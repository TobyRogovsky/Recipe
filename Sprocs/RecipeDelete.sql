create or alter procedure dbo.RecipeDelete(
@RecipeID int,
@Message varchar (500) = '' output)
as
begin
	declare @return int = 0
	if exists (select * from recipe r where r.recipeID = @RecipeID and
				(
				r.PublishedDate is not null
				and
					(
					    r.ArchivedDate is null
					    or r.ArchivedDate >= dateadd(day,-30,getdate())
					)
				)
			 )
begin
	 select @return = 1,
               @Message = 'Recipe can only be deleted if it is drafted or archived for over 30 days.'
        goto finished
	end
begin try
	begin tran
	
        delete RecipeIngredient where RecipeID = @RecipeID
        delete Instruction where RecipeID = @RecipeID
        delete RecipeMealCourse where RecipeID = @RecipeID
        delete CookBookRecipe where RecipeID = @RecipeID
        delete Recipe where RecipeID = @RecipeID

	commit
end try
begin catch
	rollback;
	throw
end catch
finished: 
return @return
end
go