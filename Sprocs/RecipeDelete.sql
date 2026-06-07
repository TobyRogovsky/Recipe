create or alter procedure dbo.RecipeDelete(
@RecipeID int)
as
begin
begin try
	begin tran
	delete CookBookRecipe where RecipeID = @RecipeID
	delete Recipe where RecipeID = @RecipeID
	commit
	end try
	begin catch
	rollback;
	throw
	end catch
end
go