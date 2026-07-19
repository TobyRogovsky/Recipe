create or alter proc dbo.CookbookGet(
@cookbookID int = 0,
@All bit = 0
)
as
begin
	select c.cookbookid, c.cookbookname, c.Price, c.userID, u.Username, count(cr.recipeID) as NumRecipes
	from CookBook c 
	join users u
	on u.userID = c.UserID
	left join CookbookRecipe cr
	on c.cookbookid = cr.cookbookid
	where c.cookbookID = @cookbookID
	or @all = 1
	group by c.cookbookID, c.cookbookname, c.price, c.userID ,u.username
	order by c.cookbookname


end
go



exec CookbookGet @all = 1

select DB_NAME() as CurrentDatabase;

select
    p.name
from sys.parameters p
where p.object_id = object_id('dbo.CookbookGet');