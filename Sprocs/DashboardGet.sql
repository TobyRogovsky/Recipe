create or alter proc dbo.DashboardGet

as
begin
	select 'Recipes' as [Type], count(*) as [Number]
	from Recipe r 

	union all select 'Meals', count(*)
	from Meal m 

	union all select 'CookBooks', count(*)
	from Cookbook cb

end
go

exec DashboardGet