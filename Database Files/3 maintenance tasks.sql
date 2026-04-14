--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

-- Delete Instruction rows linked to user's recipes
BEGIN TRANSACTION;

DECLARE @UserName sysname = 'SDavis';

DELETE i
FROM Instruction i
JOIN Recipe r ON i.RecipeID = r.RecipeID
JOIN Users u ON r.UserID = u.UserID
WHERE u.UserName = @UserName;

DELETE rmc
FROM RecipeMealCourse rmc
JOIN Recipe r ON rmc.RecipeID = r.RecipeID
JOIN Users u ON r.UserID = u.UserID
WHERE u.UserName = @UserName;

DELETE ri
FROM RecipeIngredient ri
JOIN Recipe r ON ri.RecipeID = r.RecipeID
JOIN Users u ON r.UserID = u.UserID
WHERE u.UserName = @UserName;

DELETE cbr
FROM CookBookRecipe cbr
JOIN Recipe r ON cbr.RecipeID = r.RecipeID
JOIN Users u ON r.UserID = u.UserID
WHERE u.UserName = @UserName;

DELETE cbr
FROM CookBookRecipe cbr
JOIN CookBook cb ON cbr.CookBookID = cb.CookBookID
JOIN Users u ON cb.UserID = u.UserID
WHERE u.UserName = @UserName;

DELETE mc
FROM MealCourse mc
JOIN Meal m ON mc.MealID = m.MealID
JOIN Users u ON m.UserID = u.UserID
WHERE u.UserName = @UserName;

DELETE r
FROM Recipe r
JOIN Users u ON r.UserID = u.UserID
WHERE u.UserName = @UserName;

DELETE m
FROM Meal m
JOIN Users u ON m.UserID = u.UserID
WHERE u.UserName = @UserName;

DELETE cb
FROM CookBook cb
JOIN Users u ON cb.UserID = u.UserID
WHERE u.UserName = @UserName;

DELETE u
FROM Users u
WHERE u.UserName = @UserName;

COMMIT TRANSACTION;
--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
DECLARE @OriginalRecipeID INT = 1;
DECLARE @NewRecipeID INT;

INSERT INTO Recipe (CuisineID, UserID, RecipeName, Calories, DraftDate, PublishedDate, ArchivedDate)
OUTPUT inserted.RecipeID INTO @NewRecipeID
SELECT 
    CuisineID,
    UserID,
    RecipeName + ' - clone',
    Calories,
    GETDATE(),
    NULL,
    NULL
FROM Recipe
WHERE RecipeID = @OriginalRecipeID;

INSERT INTO RecipeIngredient (RecipeID, IngredientID, Amount, MeasurementID, IngredientSequence)
SELECT 
    @NewRecipeID,
    IngredientID,
    Amount,
    MeasurementID,
    IngredientSequence
FROM RecipeIngredient
WHERE RecipeID = @OriginalRecipeID;

INSERT INTO Instruction (RecipeID, Instructions, InstructionSequence)
SELECT 
    @NewRecipeID,
    Instructions,
    InstructionSequence
FROM Instruction
WHERE RecipeID = @OriginalRecipeID;

SELECT * FROM Recipe WHERE RecipeID = @NewRecipeID;
/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
INSERT dbo.CookBook (UserID, CookBookName, Price, DateCookBookCreated)
SELECT
    u.UserID,
    'Recipes by ' + u.FirstName + ' ' + u.LastName,
    COUNT(*) * 1.33,
    GETDATE()
FROM dbo.Users u
JOIN dbo.Recipe r ON r.UserID = u.UserID
WHERE u.UserName = 'ETaylor'
GROUP BY u.UserID, u.FirstName, u.LastName

INSERT dbo.CookBookRecipe (CookBookID, RecipeID, RecipeSequence)
SELECT
    cb.CookBookID,
    r.RecipeID,
    ROW_NUMBER() OVER (ORDER BY r.RecipeName) AS RecipeSequence
FROM dbo.CookBook cb
JOIN dbo.Users u
    ON cb.UserID = u.UserID
JOIN dbo.Recipe r
    ON r.UserID = u.UserID
WHERE u.UserName = 'ETaylor'
  AND cb.CookBookName = 'Recipes by ' + u.FirstName + ' ' + u.LastName
  AND cb.Price = (
      SELECT COUNT(*) * 1.33
      FROM dbo.Recipe
      WHERE UserID = u.UserID
  )
ORDER BY RecipeSequence



/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
UPDATE r
SET r.Calories = r.Calories
    + (CASE m.MeasurementType
           WHEN 'Teaspoon' THEN -1
           WHEN 'Cup' THEN 15
      END * ri.Amount)
FROM dbo.Recipe r
JOIN dbo.RecipeIngredient ri
    ON r.RecipeID = ri.RecipeID
JOIN dbo.Ingredient i
    ON ri.IngredientID = i.IngredientID
JOIN dbo.Measurement m
    ON ri.MeasurementID = m.MeasurementID
WHERE i.IngredientName = 'Sugar'
  
/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;WITH AvgPublishTime AS (
    SELECT
        AvgHoursToPublish = AVG(CAST(DATEDIFF(HOUR, DraftDate, PublishedDate) AS decimal(10,2)))
    FROM dbo.Recipe
)
SELECT
    UserFirstName = u.FirstName,
    UserLastName = u.LastName,
    EmailAddress = LOWER(LEFT(u.FirstName, 1) + u.LastName) + '@heartyhearth.com',
    Alert =
        'Your recipe ' + r.RecipeName + ' is sitting in draft for '
        + CAST(DATEDIFF(HOUR, r.DraftDate, GETDATE()) AS varchar(20)) + ' hours.' + CHAR(13) + CHAR(10)
        + 'That is '
        + CAST(DATEDIFF(HOUR, r.DraftDate, GETDATE()) - a.AvgHoursToPublish AS varchar(20))
        + ' hours more than the average '
        + CAST(a.AvgHoursToPublish AS varchar(20))
        + ' hours all other recipes took to be published.'
FROM dbo.Recipe r
JOIN dbo.Users u ON r.UserID = u.UserID
CROSS JOIN AvgPublishTime a
WHERE r.DraftDate IS NOT NULL
  AND r.PublishedDate IS NULL
  AND DATEDIFF(HOUR, r.DraftDate, GETDATE()) > a.AvgHoursToPublish
ORDER BY u.LastName, u.FirstName, r.RecipeName;

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and receive a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
SELECT
    [Email Body] = CONCAT(
        'Order cookbooks from HeartyHearth.com! We have ',
        COUNT(*),
        ' books for sale, average price is ',
        FORMAT(AVG(Price), 'N2'),
        '. You can order them all and receive a 25% discount, for a total of ',
        FORMAT(SUM(Price) * 0.75, 'N2'),
        '.' + CHAR(13) + CHAR(10),
        'Click <a href="www.heartyhearth.com/order/',
        NEWID(),
        '">here</a> to order.'
    )
FROM dbo.CookBook;
