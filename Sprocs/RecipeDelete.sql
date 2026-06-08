create or alter procedure dbo.RecipeDelete(
@RecipeID int)
as
begin
begin try
	begin tran

	delete RecipeIngredient where RecipeID = @RecipeID
	delete Instruction where RecipeID = @RecipeID

	delete Recipe where RecipeID = @RecipeID

	commit
end try
begin catch
	rollback;
	throw
end catch
end
go