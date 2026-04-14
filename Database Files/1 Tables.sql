
DROP TABLE if EXISTS Instruction

DROP TABLE if EXISTS CookBookRecipe
DROP TABLE if EXISTS MealRecipe
DROP TABLE if EXISTS RecipeCourse
DROP TABLE if EXISTS RecipeIngredient
DROP TABLE if EXISTS IngredientMeasurement
DROP TABLE if EXISTS RecipeMealCourse
drop TABLE if EXISTS Recipe
DROP TABLE if EXISTS Measurement
DROP TABLE if EXISTS MealCourse
drop TABLE if EXISTS Ingredient
drop TABLE if EXISTS Cuisine
drop TABLE if EXISTS Meal
drop TABLE if EXISTS course
drop TABLE if EXISTS CookBook
DROP TABLE if EXISTS Users
go 
CREATE table dbo.Users(
    UserID int not null IDENTITY PRIMARY key,
    FirstName varchar (20) not null 
        CONSTRAINT ck_user_first_name_cannot_be_blank check (FirstName <> ''),
    LastName VARCHAR (20) not NULL
        CONSTRAINT ck_user_last_name_cannot_be_blank CHECK (LastName <> ''),
    UserName VARCHAR (21) not NULL
        CONSTRAINT ck_user_name_cannot_be_blank CHECK (UserName <> '')
        constraint u_user_username UNIQUE
)
go
CREATE TABLE dbo.Cuisine(
    CuisineID int not null IDENTITY PRIMARY KEY,
    CuisineName VARCHAR (20) not null
        CONSTRAINT ck_cuisine_name_cannot_be_blank CHECK (CuisineName <> '')
        constraint u_cuisine_CuisineName UNIQUE
)
go
create Table dbo.Recipe(
    RecipeID int not null IDENTITY PRIMARY key,
    CuisineID int not null
        CONSTRAINT f_cuisine_recipes FOREIGN key REFERENCES Cuisine(CuisineID),
       UserID int not null 
        CONSTRAINT f_User_recipe REFERENCES Users(UserID),
    RecipeName VARCHAR(50) 
        CONSTRAINT ck_recipe_name_cannot_be_blank CHECK (RecipeName <> '') 
        CONSTRAINT u_recipe_name UNIQUE,
    Calories int not null
constraint ck_calories_must_be_greater_than_zero check (Calories > 0), 
DraftDate DATE NOT NULL
    CONSTRAINT ck_draft_date_must_be_between_2025_10_27_and_today
        CHECK (DraftDate BETWEEN '2025-10-27' AND GETDATE()),
PublishedDate DATE NULL
    CONSTRAINT ck_published_date_must_be_before_current_date
        CHECK (PublishedDate IS NULL OR PublishedDate < GETDATE()),
ArchivedDate DATE NULL
    CONSTRAINT ck_archived_date_must_be_before_current_date
        CHECK (ArchivedDate IS NULL OR ArchivedDate < GETDATE()),
RecipeStatus AS 
    CASE 
        WHEN ArchivedDate IS NOT NULL THEN 'Archived'
        WHEN PublishedDate IS NOT NULL THEN 'Published'
        WHEN DraftDate IS NOT NULL THEN 'Draft'
    END,
RecipePicture AS ('Recipe_' + REPLACE(RecipeName, ' ', '_') + '.jpg'),
CONSTRAINT ck_draft_date_must_be_before_published_date
    CHECK (DraftDate < PublishedDate),
CONSTRAINT ck_published_date_must_be_before_archived_date
    CHECK (PublishedDate < ArchivedDate),
CONSTRAINT ck_draft_date_must_be_before_archived_date
    CHECK (DraftDate < ArchivedDate)
)
go
CREATE TABLE dbo.Measurement(
    MeasurementID int not null IDENTITY PRIMARY KEY,
    MeasurementType VARCHAR (12) not null  
        CONSTRAINT ck_measurement_type_cannot_be_blank CHECK (MeasurementType <> '')
        constraint u_measurement_MeasurementType UNIQUE
    )
GO
CREATE TABLE dbo.Ingredient(
    IngredientID int not null IDENTITY PRIMARY key,
    IngredientName VARCHAR (30) not null,
        CONSTRAINT ck_ingredient_name_cannot_be_blank CHECK (IngredientName <> ''), 
        CONSTRAINT u_ingredient_IngredientName UNIQUE (IngredientName),
    IngredientPicture as ('Ingredient_' + IngredientName +'.jpg')
)
GO
CREATE TABLE dbo.Meal (
    MealID int not null IDENTITY PRIMARY key,
    MealName VARCHAR (50)not null 
        CONSTRAINT ck_meal_name_cannot_be_blank CHECK (MealName <>'')
        CONSTRAINT u_meal_MealName UNIQUE,
    UserID int not null 
        CONSTRAINT f_Users_ID REFERENCES Users(UserID),
    MealStatus bit not null default 0,
    DateMealCreated DATE not NULL constraint ck_date_meal_created_must_be_between_2025_10_27_and_today CHECK (DateMealCreated between '2025-10-27' and getdate()),
    MealPicture as ('Meal_'+ MealName+'.jpg')
)
GO
CREATE table dbo.Course(
    CourseID int not null IDENTITY PRIMARY KEY,
    CourseName VARCHAR (20) not null 
        CONSTRAINT u_Course_CourseName UNIQUE
        CONSTRAINT ck_course_name_cannot_be_blank CHECK(CourseName <> ''),
    CourseSequence int not NULL
    constraint ck_course_sequence_must_be_greater_than_0 check(CourseSequence > 0)   
)
go
CREATE TABLE dbo.CookBook(
    CookBookID int not null IDENTITY PRIMARY key,
    CookBookName VARCHAR (50) not null
        CONSTRAINT ck_cook_book_name_cannot_be_blank CHECK (CookBookName <> '')
        CONSTRAINT u_CookBook_CookBookName UNIQUE,
    Price DECIMAL(5,2) not NULL
        constraint ck_price_must_be_greater_than_0 check (price > 0),
    UserID int not null 
        CONSTRAINT f_User_UserID REFERENCES Users(UserID),
    CookBookStatus bit DEFAULT 0,
    DateCookBookCreated DATE not NULL,
        constraint ck_cook_book_must_be_created_between2025_10_27_and_today CHECK (DateCookBookCreated BETWEEN '2025-10-27' AND GETDATE()),
CookBookPicture AS ('CookBook_' + REPLACE(CookBookName, ' ', '_') + '.jpg')
)
go
CREATE TABLE dbo.RecipeIngredient(
    RecipeIngredientID int not null IDENTITY PRIMARY key,
    RecipeID int not null 
        CONSTRAINT f_recipe_ID FOREIGN key REFERENCES Recipe(RecipeID),
    IngredientID int not null 
        CONSTRAINT f_Ingredient_IngredientID FOREIGN KEY REFERENCES Ingredient (IngredientID),
    MeasurementID int not null 
        constraint f_Measurement_ID FOREIGN key REFERENCES Measurement(MeasurementID),
    Amount DECIMAL (4,2) not NULL,
    IngredientSequence int not null 
        constraint ck_ingredient_sequence_is_greater_than_0 CHECK (IngredientSequence > 0),
    CONSTRAINT u_recipe_and_ingredient_must_be UNIQUE (RecipeID, IngredientID)
)
GO
create TABLE dbo.MealCourse (
    MealCourseID int not null IDENTITY PRIMARY key,
    MealID int not null 
        CONSTRAINT f_mealID FOREIGN key REFERENCES meal (MealID),
    CourseID int not null
        constraint f_courseID FOREIGN key REFERENCES course(CourseID),
    constraint u_meal_ID_and_course_ID_must_be unique (MealID, CourseID)
)
GO
CREATE TABLE dbo.RecipeMealCourse(
     RecipeMealCourseID int not null IDENTITY PRIMARY key,
    MealCourseID int not null CONSTRAINT f_meal_course_ID FOREIGN KEY REFERENCES mealcourse(MealCourseID),
    RecipeID int not null CONSTRAINT f_recipe_meal_course_recipe FOREIGN key REFERENCES recipe(RecipeId),
    DishType bit DEFAULT 0,
    constraint u_meal_course_ID_and_Recipe_ID_must_be unique (MealCourseID, RecipeID)
)
GO
CREATE TABLE dbo.CookBookRecipe(
   CookBookRecipeID int not null IDENTITY PRIMARY key,
    CookBookID int not null 
        constraint f_cookbook_ID FOREIGN key REFERENCES cookbook(CookBookID),
    RecipeID int not null 
        constraint f_recipe FOREIGN key REFERENCES recipe(RecipeID),
    RecipeSequence int not null
        CONSTRAINT ck_recipe_sequence_is_greater_than_0 check(RecipeSequence > 0),
    CONSTRAINT u_cook_book_ID_and_recipe_name_must_be UNIQUE (CookBookID, RecipeID)
)
GO
create TABLE dbo.Instruction (
    InstructionID int not null IDENTITY PRIMARY key,
    RecipeID int not null CONSTRAINT f_Instruction_RecipeID FOREIGN key REFERENCES recipe(RecipeID),
    Instructions VARCHAR (500) not NULL
        constraint ck_instructions_cannot_be_blank check (instructions <> ''),
    InstructionSequence int not null
        constraint ck_instruction_sequence_must_be_greater_than_0 check(InstructionSequence > 0)

)





