create or alter proc dbo.MealGet(
@MealID int = 0,
@All bit = 0,
@MealName varchar (100) = ''
)
as
begin
	select m.MealID, m.MealName,TotalCalories = dbo.MealCalories(m.MealID), count(distinct rmc.RecipeMealCourseID) as NumCourses, count(rmc.RecipeMealCourseID) as NumRecipes
	from Meal m 
	join MealCourse mc
	on m.MealID = mc.MealID
	join RecipeMealCourse rmc
	on mc.MealCourseID = rmc.MealCourseID
	or @All = 1
	or m.MealName like '%' + @MealName + '%'
	group by m.MealID, m.MealName
	order by m.MealName
end
go