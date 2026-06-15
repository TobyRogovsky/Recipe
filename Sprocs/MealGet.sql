create or alter proc dbo.MealGet(
@MealID int = 0,
@All bit = 0,
@MealName varchar (100) = ''
)
as
begin
	select m.MealID, m.MealName, TotalCalories = dbo.MealCalories(m.MealID)
	from Meal m 
	where m.MealID = @MealID
	or @All = 1
	or m.MealName like '%' + @MealName + '%'
	order by m.MealName
end
go