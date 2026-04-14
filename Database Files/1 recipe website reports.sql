use HeartyHearthDB
go 
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
SELECT 'Recipes' AS ItemName, COUNT(*) AS ItemCount
FROM Recipe
UNION ALL
SELECT 'Meals', COUNT(*)
FROM Meal
UNION ALL
SELECT 'CookBooks', COUNT(*)
FROM CookBook
ORDER BY ItemName



/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. Archived recipes should appear gray on the website.
	In order for the recipe name to be gray on the website, surround the archived recipe names with: <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
SELECT DisplayRecipeName =
        CASE WHEN r.ArchivedDate IS NOT NULL 
        THEN '<span style="color:gray">' + r.RecipeName + '</span>'
        ELSE r.RecipeName
        END,
    PublishedDate = ISNULL(CONVERT(varchar(10), r.PublishedDate, 101), ''),
    ArchivedDate  = ISNULL(CONVERT(varchar(10), r.ArchivedDate, 101), ''),
    u.UserName, r.Calories, IngredientCount = COUNT(ri.ingredientID), r.RecipeStatus 
from Recipe r 
join Users u 
on u.userID = r.userID
join RecipeIngredient ri 
on ri.recipeID = r.RecipeID 
WHERE r.RecipeStatus <> 'Draft'
group by r.RecipeName, r.PublishedDate, r.archivedDate, u.username, r.calories, r.RecipeStatus
order by r.RecipeStatus DESC,
 r.RecipeName
go 


/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
--a
SELECT r.RecipeName, r.Calories, NumOfIngredients = COUNT(distinct ri.RecipeIngredientID), NumOfSteps = COUNT(distinct i.InstructionID)
from Recipe r 
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
join Instruction i 
on i.RecipeID = r.RecipeID
where r.RecipeName = 'Chocolate Chip Cookies'
group by r.RecipeName, r.Calories
--b 
SELECT Ingredient = CONCAT(ri.Amount, ' ', m.MeasurementType, ' ', i.IngredientName)
from Recipe r  
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
join Ingredient i 
on i.IngredientID = ri.IngredientID
join Measurement m 
on m.MeasurementID = ri.MeasurementID
WHERE r.RecipeName = 'Chocolate Chip Cookies'
order by ri.IngredientSequence
--c 
SELECT  i.Instructions
from Recipe r 
join Instruction i 
on i.RecipeID = r.RecipeID
WHERE r.RecipeName = 'Chocolate Chip Cookies'
ORDER by i.InstructionSequence

/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
SELECT m.MealName, u.UserName, Calories = SUM(r.Calories), Courses = COUNT(distinct c.CourseName), Recipes = COUNT(distinct r.RecipeName)
from Recipe r 
join RecipeMealCourse rmc 
on r.RecipeID = rmc.RecipeID
join MealCourse mc 
on mc.MealCourseID = rmc.MealCourseID
join Meal m 
on m.MealID = mc.MealID
join Course c 
on c.CourseID = mc.CourseID
join Users u 
on m.UserID = u.UserID
where m.MealStatus = 1
GROUP by m.MealName, u.UserName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
--a
SELECT m.MealName, u.username, m.DateMealCreated
from Meal m 
join Users u 
on m.UserID = u.UserID
where m.MealName = 'Dinner Feast'
--b 
SELECT 
    Meal =
        CASE 
            WHEN c.CourseName = 'Main Course' AND rmc.DishType = 1 THEN 
                CONCAT('<b>', c.CourseName, ': Main dish - ', r.RecipeName, '</b>')
            WHEN c.CourseName = 'Main Course' AND rmc.DishType <> 1 THEN 
                CONCAT(c.CourseName, ': Side dish - ', r.RecipeName)
            ELSE 
                CONCAT(c.CourseName, ': ', r.RecipeName)
        END
FROM Recipe r
JOIN RecipeMealCourse rmc ON r.RecipeID = rmc.RecipeID
JOIN MealCourse mc ON mc.MealCourseID = rmc.MealCourseID
JOIN Meal m ON m.MealID = mc.MealID
JOIN Course c ON c.CourseID = mc.CourseID
WHERE m.MealName = 'Dinner Feast';


/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select cb.CookBookName, u.UserName, NumOfRecipes = COUNT(*)
from CookBook cb
join Users u 
on cb.UserID = u.UserID
where cb.CookBookStatus = 1
GROUP by cb.CookBookName, u.UserName
ORDER by cb.CookBookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
--a 
SELECT cb.CookBookName, u.UserName, cb.DateCookBookCreated, cb.Price, NumOfRecipes = COUNT(*)
from CookBook cb 
join Users u 
on cb.UserID = u.UserID
where cb.CookBookName = 'Treats for two'
GROUP by cb.CookBookName, u.UserName, cb.DateCookBookCreated, cb.Price
--b 
SELECT r.RecipeName, c.CuisineName, IngredientNum = COUNT(distinct i.IngredientID), NumOfSteps = COUNT(distinct ins.InstructionID)
from Recipe r 
join Cuisine c 
on r.CuisineID = c.CuisineID
join RecipeIngredient ri
on r.RecipeID = ri.RecipeID
join Ingredient i 
on i.IngredientID = ri.IngredientID
join Instruction ins 
on r.RecipeID = ins.RecipeID
join CookBookRecipe cbr 
on cbr.RecipeID = r.RecipeID
join CookBook cb 
on cb.CookBookID = cbr.CookBookID
where cb.CookBookName = 'Family Feast Favorites'
GROUP by r.RecipeName, c.CuisineName





/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
--a
SELECT DISTINCT
    ReversedRecipe = CONCAT(
        UPPER(SUBSTRING(REVERSE(r.RecipeName), 1, 1)),
        LOWER(SUBSTRING(REVERSE(r.RecipeName), 2, LEN(r.RecipeName)))
    ),
    NewPicture = REPLACE(
        CONCAT(
            'Recipe_',
            UPPER(SUBSTRING(REVERSE(r.RecipeName), 1, 1)),
            LOWER(SUBSTRING(REVERSE(r.RecipeName), 2, LEN(r.RecipeName))),
            '.jpg'
        ),
        ' ',
        '_'
    )
FROM Recipe r
JOIN CookBookRecipe cr ON r.RecipeID = cr.RecipeID
GROUP BY r.RecipeName
--b 
;WITH x AS (
    SELECT 
        RecipeID, 
        MAX(InstructionSequence) AS MaxInstructionSequence
    FROM Instruction
    GROUP BY RecipeID
)
SELECT 
    i.RecipeID, 
    i.Instructions
FROM Instruction i
JOIN x ON i.RecipeID = x.RecipeID AND i.InstructionSequence = x.MaxInstructionSequence


/*
For site administration page:
5 seperate reports
*/
   --a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    SELECT 
    u.UserName, 
    RecipeStatus = ISNULL(r.RecipeStatus, ''), 
    NumOfRecipes = COUNT(r.RecipeId)
FROM Users u
LEFT JOIN Recipe r
    ON r.UserId = u.UserId
GROUP BY u.UserName, r.RecipeStatus
ORDER BY u.UserName, RecipeStatus
   --b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
   SELECT 
    u.Username, 
    NumOfRecipes = COUNT(r.RecipeId), 
    AvgDaysToPublish = AVG(DATEDIFF(day, r.DraftDate, r.PublishedDate))
FROM Users u 
JOIN Recipe r
    ON u.UserID = r.UserId
GROUP BY u.Username
ORDER BY u.Username
   --c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        --Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
        SELECT 
    u.UserName, 
    NumOfMeals = COUNT(m.MealId), 
    Active = ISNULL(SUM(CASE WHEN m.MealStatus = 'Active' THEN 1 ELSE 0 END), 0), 
    Inactive = ISNULL(SUM(CASE WHEN m.MealStatus = 'Inactive' THEN 1 ELSE 0 END), 0)
FROM Users u
LEFT JOIN Meal m
    ON u.UserId = m.UserId
GROUP BY u.UserName
ORDER BY u.UserName
   --d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
       --Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
       SELECT 
    u.UserName, 
    NumOfCookbooks = COUNT(c.CookbookId), 
    Active = ISNULL(SUM(CASE WHEN c.CookBookStatus = 1 THEN 1 ELSE 0 END), 0), 
    Inactive = ISNULL(SUM(CASE WHEN c.CookBookStatus = 0 THEN 1 ELSE 0 END), 0)
FROM Users u
LEFT JOIN Cookbook c
    ON u.UserId = c.UserId
GROUP BY u.UserName
ORDER BY u.UserName
   --e) List of archived recipes that were never published, and how long it took for them to be archived.
SELECT 
    r.RecipeName, 
    NumOfDaysDrafted = DATEDIFF(day, r.DraftDate, r.ArchivedDate)
FROM Recipe r
WHERE r.PublishedDate IS NULL
  AND r.RecipeStatus = 'Archived'


--For user dashboard page:
   -- a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
      --  Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
   ;with x as (
    SELECT userID, UserName 
    from Users
    where UserName = 'AWilson'
   )
   SELECT Recipes = 'Recipes', NumRecipes =  COUNT(r.RecipeID)
   from x 
   join Recipe r 
   on r.UserID = x.UserID
   union all SELECT Meals = 'Meals', NumMeals = COUNT(m.mealID)
   from x 
   left join Meal m 
   on m.UserID = x.UserID
   UNION all SELECT CookBooks = 'CookBooks', NumCookBooks = COUNT(cb.CookBookID)
   from x 
   left join CookBook cb 
   on x.UserID = cb.UserID 
    
   -- b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
   SELECT 
    r.RecipeName, 
    r.RecipeStatus, 
    HoursBetweenStatuses = DATEDIFF(
        hour, 
        CASE 
            WHEN r.ArchivedDate IS NOT NULL AND r.PublishedDate IS NOT NULL THEN r.PublishedDate 
            ELSE r.DraftDate 
        END,
        ISNULL(r.ArchivedDate, r.PublishedDate)
    )
FROM Recipe r
JOIN Users u ON r.UserID = u.UserID
WHERE u.UserName = 'MBrown'
  AND r.RecipeStatus <> 'Draft'
   -- OPTIONAL CHALLENGE QUESTION
   -- c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
     --   Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 

