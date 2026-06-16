create or alter function dbo.MealCalories(@MealID int)
returns int
as 
begin
	declare @value int = 0

	   select @value = sum(r.Calories)
    from Meal m
    join MealCourse mc
        on mc.MealID = m.MealID
    join RecipeMealCourse rmc
        on rmc.MealCourseID = mc.MealCourseID
    join Recipe r
        on r.RecipeID = rmc.RecipeID
    where m.MealID = @MealID

	return @value
end
go