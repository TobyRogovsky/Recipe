USE HeartyHearthDB
go
DELETE RecipeMealCourse
GO
DELETE CookBookRecipe
GO
DELETE RecipeIngredient
GO
DELETE Instruction
GO
DELETE MealCourse
GO
DELETE Meal
GO
DELETE Course
GO
DELETE CookBook
GO
DELETE Recipe
GO
DELETE Ingredient
GO
DELETE Measurement
GO
DELETE Cuisine
GO
DELETE Users
GO
INSERT Users(FirstName, LastName, UserName)
SELECT 'Jane', 'Doe', 'JDoe'
union all SELECT'John', 'Smith', 'JSmith'
union all SELECT'Emily', 'Clark', 'EClark'
union all SELECT'Michael', 'Brown', 'MBrown'
union all SELECT'Sarah', 'Davis', 'SDavis'
union all SELECT'Daniel', 'White', 'DWhite'
union all SELECT'Olivia', 'Johnson', 'OJohnson'
union all SELECT'Ethan', 'Taylor', 'ETaylor'
union all SELECT'Ava', 'Wilson', 'AWilson'
union all SELECT'Liam', 'Anderson', 'LAnderson'
union all SELECT'Sophia', 'Martinez', 'SMartinez' 
go
INSERT Cuisine(CuisineName)
SELECT 'American'
union select 'French'
union select 'English'
union select 'Indian'
union select 'Greek'
union select 'Mexican'
union select 'Chinese'
go 
; with x AS (
  SELECT CuisineName = 'American', UserName = 'JSmith', RecipeName = 'Chocolate Chip Cookies', Calories = 300, DraftDate = '05-25-2000', PublishedDate = '08-10-2000',ArchivedDate = '01-01-2015'
UNION ALL SELECT 'French', 'LAnderson', 'Apple Yogurt Smoothie', 150, '03-14-2001', NULL, NULL
UNION ALL SELECT 'English', 'OJohnson', 'Cheese Bread', 200, '02-10-2002', '04-15-2002', '09-01-2002'
UNION ALL SELECT 'American', 'SDavis', 'Butter Muffins', 250, '07-09-2003', '09-01-2003', NULL
UNION ALL SELECT 'Indian', 'ETaylor', 'Spiced Chickpea Curry', 175, '01-20-2004', NULL, NULL
UNION ALL SELECT 'Mexican', 'SMartinez', 'Cheese & Bean Enchiladas', 280, '04-12-2005', '06-10-2005', '11-15-2005'
UNION ALL SELECT 'Chinese', 'DWhite', 'Vegetable Fried Rice', 100, '08-03-2006', '09-22-2006', NULL
)
insert Recipe (CuisineID, UserID, RecipeName, Calories, DraftDate, PublishedDate, ArchivedDate)
SELECT c.CuisineID, u.UserID, x.RecipeName, x.Calories, x.DraftDate, x.PublishedDate, x.archiveddate
from x 
JOIN Cuisine c 
on c.CuisineName = x.CuisineName
JOIN Users u 
on u.UserName = x.UserName
GO
insert Measurement (MeasurementType)
select 'Cup'
union select 'Tsp'
union select 'Tbsp'
union select 'Oz'
union select 'cloves'
union SELECT 'pinch'
union select 'stick'
union SELECT 'club'
union select 'unspecified'
go
INSERT Ingredient (IngredientName)
select 'Sugar'
union select 'Oil'
union select 'Eggs'
union select 'Flour'
union select 'Vanilla sugar'
union select 'Baking powder'
union select 'Baking soda'
union select 'Chocolate chips'
union select 'Granny Smith apples'
union select 'Vanilla yogurt'
union select 'Orange juice'
union select 'Honey'
union select 'Ice cubes'
union select 'Bread'
union select 'Butter'
union select 'Shredded cheese'
union select 'Garlic'
union select 'Black pepper'
union select 'Salt'
union select 'Vanilla pudding mix'
union select 'Whipped cream cheese'
union select 'Sour cream cheese'
union select 'Vegetable oil'
union select 'Onion'
union select 'Curry powder'
union select 'Chickpeas'
union select 'Diced tomatoes'
union select 'Water'
union select 'corn tortillas'
union select 'black beans'
union select 'Enchilada sauce'
union select 'olive oil'
union select 'Cooked rice'
union select 'Mixed vegetables'
union select 'Soy sauce'
union select 'Scallions'


GO
;with x as (
    SELECT MealName = 'Breakfast bash', UserName = 'EClark', MealStatus = 1, DateMealCreated = '10-27-2025'
    union all SELECT 'Lunch Delight', 'ETaylor', 1, '11-24-2025'
    union all SELECT 'Dinner Feast', 'AWilson', 0, '10-29-2025'
    union all SELECT 'Midday Munch', 'MBrown', 0, '11-15-2025'
)
insert Meal(MealName, UserID, MealStatus, DateMealCreated)
SELECT x.MealName, u.UserID, x.MealStatus, x.DateMealCreated
from x 
join Users u 
on x.UserName = u.UserName
go 
INSERT Course (CourseName, CourseSequence)
select 'Appetizer', 1
union select 'Main Course', 2
union select 'Dessert', 3
go 
;with x as (
    SELECT CookBookName = 'Treats for two', Price = 30, UserName = 'ETaylor', CookBookStatus = 0, DateCookBookCreated = '10-28-2025'
union all select 'Family Feast Favorites', 45, 'SMartinez', 1, '11-01-2025'
union all select 'Baking Bliss', 40, 'OJohnson', 0, '10-29-2025'
union all select 'Quick Comforts', 25, 'AWilson', 1, '11-02-2025'
)
insert CookBook (CookBookName, Price,  UserID, CookBookStatus, DateCookBookCreated)
SELECT x.CookBookName, x.Price, u.UserID, x.CookBookStatus, x.DateCookBookCreated
from x 
join Users u 
on x.UserName = u.UserName
go 
;with x as (
    select RecipeName = 'Chocolate Chip Cookies',  IngredientName = 'Sugar', Amount = 1, MeasurementName = 'Cup', IngredientSequence = 1
   union all select 'Chocolate Chip Cookies', 'oil', 1.5, 'Cup', 2
   union all select 'Chocolate Chip Cookies', 'eggs', 3, 'Unspecified', 3
   union all select 'Chocolate Chip Cookies', 'flour', 2, 'cup', 4
   union all select 'Chocolate Chip Cookies', 'vanilla sugar', 1, 'tsp', 5
   union all select 'Chocolate Chip Cookies', 'baking powder', 2, 'tsp', 6
   union all select 'Chocolate Chip Cookies', 'baking soda', 1.5, 'tsp', 7
   union all select 'Chocolate Chip Cookies', 'chocolate chips', 1, 'cup', 8
   union all select 'Apple Yogurt Smoothie', 'Granny Smith Apples', 3,'unspecified', 1
   union all select 'Apple Yogurt Smoothie', 'vanilla yogurt', 2, 'cups', 2
   union all select 'Apple Yogurt Smoothie', 'sugar', 2, 'tsp', 3
   union all select 'Apple Yogurt Smoothie', 'orange juice', 0.5, 'cup', 4
   union all select 'Apple Yogurt Smoothie', 'honey', 2, 'tbsp', 5
   union all select 'Apple Yogurt Smoothie', 'ice cubes', 5, 'unspecified', 6
   union all select 'Cheese Bread', 'bread', 1, 'club',1
   union all select 'Cheese Bread', 'butter', 4, 'oz',2
   union all select 'Cheese Bread', 'shredded cheese', 8, 'oz',3
   union all select 'Cheese Bread', 'garlic (crushed)', 2, 'cloves',4
   union all select 'Cheese Bread', 'black pepper', 0.25, 'tsp',5
   union all select 'Cheese Bread', 'salt', 1, 'pinch',6
   union all select 'Butter Muffins', 'butter', 1, 'stick', 1
   union all select 'Butter Muffins', 'sugar', 3, 'cups', 2
   union all select 'Butter Muffins', 'vanilla pudding', 2, 'tbsp', 3
   union all select 'Butter Muffins', 'eggs', 4, 'unsepcified', 4
   union all select 'Butter Muffins', 'whipped cream cheese', 8, 'oz', 5
   union all select 'Butter Muffins', 'sour cream cheese', 8, 'oz', 6
   union all select 'Butter Muffins', 'flour', 1, 'cup', 7
   union all select 'Butter Muffins', 'baking powder', 2, 'tsp', 8
   union all select 'Spiced Chickpea Curry', 'vegetable oil', 2, 'tbsp' ,1
   union all select 'Spiced Chickpea Curry', 'onion', 1, 'large', 2
   union all select 'Spiced Chickpea Curry', 'garlic', 3, 'cloves', 3
   union all select 'Spiced Chickpea Curry', 'curry powder', 1, 'tbsp', 4
   union all select 'Spiced Chickpea Curry', 'chickpeas', 30, 'oz', 5
   union all select 'Spiced Chickpea Curry', 'diced tomatoes', 14, 'oz', 6
   union all select 'Spiced Chickpea Curry', 'water', 1, 'cup', 7
   union all select 'Spiced Chickpea Curry', 'salt', 1, 'tsp', 8
   union all select 'Spiced Chickpea Curry', 'black pepper', 0.25, 'tsp', 9
   union all select 'Cheese & Bean Enchiladas', 'corn tortillas', 8, 'unspecified', 1
   union all select 'Cheese & Bean Enchiladas', 'black beans', 15, 'oz', 2
   union all select 'Cheese & Bean Enchiladas', 'shredded cheese', 1.5, 'cups', 3
   union all select 'Cheese & Bean Enchiladas', 'enchilada sauce', 10, 'oz', 4
   union all select 'Cheese & Bean Enchiladas', 'diced onion', 0.5, 'cup', 5
   union all select 'Cheese & Bean Enchiladas', 'olive oil', 1, 'tbsp', 6
   union all select 'Cheese & Bean Enchiladas', 'salt', 1, 'pinch', 7
   union all select 'Cheese & Bean Enchiladas', 'pepper', 1, 'pinch', 8
   union all select 'Vegetable Fried Rice', 'vegetable oil', 2, 'tbsp', 1
   union all select 'Vegetable Fried Rice', 'eggs', 2, 'unspecified', 2
   union all select 'Vegetable Fried Rice', 'cooked rice', 3, 'cups', 3
   union all select 'Vegetable Fried Rice', 'mixed vegetables', 1, 'cup', 4
   union all select 'Vegetable Fried Rice', 'soy sauce', 2, 'tbsp', 5
   union all select 'Vegetable Fried Rice', 'salt', 1, 'tsp', 6
   union all select 'Vegetable Fried Rice', 'black pepper', 0.25, 'tsp', 7
   union all select 'Vegetable Fried Rice', 'scallions', 2, 'unspecified', 8
   union all select 'Vegetable Fried Rice', 'onion', 0.5, 'unspecified', 9
)
insert RecipeIngredient (RecipeID, IngredientID, Amount, MeasurementID, IngredientSequence)
select r.RecipeID, i.IngredientID, x.Amount, m.MeasurementID, x.IngredientSequence
from x 
join Recipe r 
on x.RecipeName = r.RecipeName
join Ingredient i 
on x.IngredientName = i.IngredientName
join Measurement m 
on m.MeasurementType = x.MeasurementName
GO
;with x as (
    select MealName =  'Breakfast Bash', CourseName = 'Appetizer'
    union all select 'Breakfast Bash', 'Main Course'
    union all select 'Lunch Delight', 'Main Course'
    union all select 'Dinner Feast', 'Main Course'
    union all select 'Dinner Feast', 'Side Dish'
    union all select 'Dinner Feast', 'Dessert'
    union all select 'Midday Munch', 'Main Dish'
    union all select 'Midday Munch', 'Dessert'
)
insert MealCourse (MealID, CourseID)
select m.mealID, c.courseID
from x 
join Meal M
on m.MealName = x.MealName
join Course c 
on c.CourseName = x.CourseName
go 

;with x as(
    select RecipeName = 'Chocolate Chip Cookies', MealName = 'Dinner Feast', DishType = 0, CourseName = 'Dessert'
union all select 'Apple Yogurt Smoothie', 'Breakfast Bash', 0, 'Appetizer'
union all select 'Cheese Bread', 'Breakfast Bash', 1, 'Main Course'
union all select 'Butter Muffins', 'Breakfast Bash', 0, 'Main Course'
union all select 'Spiced Chickpea Curry', 'Dinner Feast', 1, 'Main Course'
union all select 'Cheese & Bean Enchiladas', 'Lunch Delight', 1, 'Main Course'
union all select 'Vegetable Fried Rice', 'Dinner Feast', 0, 'Appetizer'
union all select 'Vegetable Fried Rice', 'Midday Munch', 0, 'Appetizer'
) 
insert RecipeMealCourse (MealCourseID, RecipeID, DishType)
select mc.MealCourseID, r.RecipeID, x.DishType
from x 
join Meal m
on m.MealName = x.MealName
join MealCourse mc 
on mc.MealID = m.MealID 
join Course c 
on c.CourseName = x.CourseName
join Recipe r 
on r.RecipeName = x.RecipeName
go 
;with x as (
    SELECT CookBookName = 'Treats for Two', RecipeName = 'Apple Yogurt Smoothie', RecipeSequence = 1
    union all select 'Treats for Two', 'Cheese Bread', 2
    union all select 'Quick Comforts', 'Chocolate Chip Cookies', 1
    union all select 'Quick Comforts', 'Vegetable Rice', 2
    union all select 'Family Feast Favorites', 'Vegetable Rice', 1
    union all select 'Family Feast Favorites', 'Spiced Chickpea Curry', 2
    union all select 'Baking Bliss', 'Chocolate Chip Cookies', 1
    union all select 'Baking Bliss', 'Cheese Bread', 2
)
INSERT CookBookRecipe (CookBookID, RecipeID, RecipeSequence)
select c.CookBookID, r.RecipeID, x.RecipeSequence
from x 
join CookBook c 
on x.CookBookName = c.CookBookName
join Recipe r 
on r.RecipeName = x.RecipeName
go 
;with x as (
    select RecipeName = 'Chocolate Chip Cookies', Instructions = 'First combine sugar, oil and eggs in a bowl', InstructionSequence = 1
    union all select 'Chocolate Chip Cookies', 'mix well', 2
    union all select 'Chocolate Chip Cookies', 'add flour, vanilla sugar, baking powder and baking soda', 3
    union all select 'Chocolate Chip Cookies', 'beat for 5 minutes', 4
    union all select 'Chocolate Chip Cookies', 'add chocolate chips', 5
    union all select 'Chocolate Chip Cookies', 'freeze for 1-2 hours', 6
    union all select 'Chocolate Chip Cookies', 'roll into balls and place spread out on a cookie sheet', 7
    union all select 'Chocolate Chip Cookies', 'bake on 350 for 10 min', 8
    union all select 'Apple Yogurt Smoothie', 'peel the apples and dice', 1
    union all select 'Apple Yogurt Smoothie', 'combine all ingredients in bowl except for apples and ice cubes', 2
    union all select 'Apple Yogurt Smoothie', 'mix until smooth', 3
    union all select 'Apple Yogurt Smoothie', 'add apples and ice cubes', 4
    union all select 'Apple Yogurt Smoothie', 'pour into glasses', 5
    union all select 'Cheese Bread', 'slit bread every 3/4 inch', 1
    union all select 'Cheese Bread', 'combine all ingredients in bowl', 2
    union all select 'Cheese Bread', 'fill slits with cheese mixture', 3
    union all select 'Cheese Bread', 'wrap bread in foil and bake for 30 minutes', 4
    union all select 'Butter Muffins', 'cream butter with sugars', 1
    union all select 'Butter Muffins', 'add eggs and mix well', 2
    union all select 'Butter Muffins', 'slowly add rest of ingredients and mix well', 3
    union all select 'Butter Muffins', 'fill muffin pans 3/4 full and bake for 30 minutes', 4
    union all select 'Spiced Chickpea Curry', 'heat oil in a large skillet or pot over medium heat', 1
    union all select 'Spiced Chickpea Curry', 'add chopped onion and cook for about 5 minutes until soft and lightly golden', 2
    union all select 'Spiced Chickpea Curry', 'stir in garlic and curry powder and cook for 1 minute until fragrant', 3
    union all select 'Spiced Chickpea Curry', 'mix in diced tomatoes and chickpeas and stir well to coat with spices', 4
    union all select 'Spiced Chickpea Curry', 'pour in water, salt, and black pepper', 5
    union all select 'Spiced Chickpea Curry', 'bring to a gentle boil then reduce heat and simmer uncovered for 10–15 minutes', 6
    union all select 'Spiced Chickpea Curry', 'taste and adjust seasoning if needed', 7
    union all select 'Spiced Chickpea Curry', 'serve hot over white or brown rice', 8
    union all select 'Cheese & Bean Enchiladas', 'preheat oven to 375°F (190°C) and lightly grease a baking dish with olive oil', 1
    union all select 'Cheese & Bean Enchiladas', 'combine beans, half of the shredded cheese, diced onion, salt, and pepper in a bowl and mix well', 2
    union all select 'Cheese & Bean Enchiladas', 'spoon a few tablespoons of the bean mixture onto each tortilla and roll up tightly', 3
    union all select 'Cheese & Bean Enchiladas', 'place rolled tortillas seam-side down in the baking dish', 4
    union all select 'Cheese & Bean Enchiladas', 'pour enchilada sauce evenly over the rolled tortillas', 5
    union all select 'Cheese & Bean Enchiladas', 'sprinkle remaining cheese on top', 6
    union all select 'Cheese & Bean Enchiladas', 'cover with foil and bake for 20 minutes', 7
    union all select 'Cheese & Bean Enchiladas', 'uncover and bake for an additional 5 minutes until cheese is bubbly and lightly golden', 8
    union all select 'Cheese & Bean Enchiladas', 'remove from oven, let cool slightly, and serve warm', 9
    union all select 'Vegetable Fried Rice', 'heat oil in a large pan or wok over medium-high heat', 1
    union all select 'Vegetable Fried Rice', 'add eggs and scramble lightly then push to one side', 2
    union all select 'Vegetable Fried Rice', 'add mixed vegetables and cook for 2–3 minutes until just tender', 3
    union all select 'Vegetable Fried Rice', 'stir in cooked rice breaking up any clumps', 4
    union all select 'Vegetable Fried Rice', 'add soy sauce salt and pepper then stir well', 5
    union all select 'Vegetable Fried Rice', 'cook another 3–4 minutes until heated through', 6
    union all select 'Vegetable Fried Rice', 'mix everything evenly and garnish with scallions or chopped onions if desired', 7
    union all select 'Vegetable Fried Rice', 'serve hot', 8
)
insert Instruction (RecipeID, Instructions, InstructionSequence)
SELECT r.RecipeID, x.instructions, x.InstructionSequence
from x 
join Recipe r 
on r.RecipeName = x.RecipeName
go 