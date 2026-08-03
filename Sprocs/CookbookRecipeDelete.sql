create or alter procedure dbo.CookbookRecipeDelete
(
    @CookbookRecipeID int
)
as
begin
    delete CookbookRecipe
    where CookbookRecipeID = @CookbookRecipeID;
end
go