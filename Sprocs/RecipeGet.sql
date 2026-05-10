create or alter procedure dbo.RecipeGet (@RecipeID int = 0, @All bit = 0, @RecipeName varchar (50) = '')
as 
begin
	select @RecipeName = nullif (@RecipeName, '')
	select r.RecipeID, r.RecipeName, r.RecipeStatus, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.Calories, r.CuisineID, r.UserID
	from Recipe r 
	where r.RecipeID = @RecipeID
	or @All = 1
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	end
	go


	exec RecipeGet

	exec RecipeGet @all = 1

	exec RecipeGet @recipename = 'a'

	exec RecipeGet @recipeName = 'v'


