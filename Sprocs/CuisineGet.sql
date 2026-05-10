create or alter procedure dbo.CuisineGet (@CuisineID int = 0, @All bit = 0, @CuisineName varchar (20) = '')
as
begin
	select @CuisineName = nullif (@CuisineName, '')
	select c.CuisineID, c.CuisineName
	from Cuisine c 
	where c.CuisineID = @CuisineID
	or @All = 1
	or c.CuisineName like '%' + @CuisineName + '%'
end
go

exec CuisineGet
exec CuisineGet @all = 1
exec CuisineGet @cuisinename = 'g'