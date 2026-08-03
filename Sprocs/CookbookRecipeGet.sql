create or alter procedure dbo.CookbookRecipeGet
(
    @CookbookID int
)
as
begin
    select
        cbr.CookbookRecipeID,
        cbr.CookbookID,
        cbr.RecipeID,
        cbr.RecipeSequence
    from CookbookRecipe cbr
    where cbr.CookbookID = @CookbookID
    order by RecipeSequence;
end
go

