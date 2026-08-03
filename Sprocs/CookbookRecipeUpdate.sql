create or alter procedure dbo.CookbookRecipeUpdate
(
    @CookbookRecipeID int output,
    @CookbookID int,
    @RecipeID int,
    @RecipeSequence int
)
as
begin
    if @CookbookRecipeID = 0
    begin
        insert into CookbookRecipe
        (
            CookbookID,
            RecipeID,
            RecipeSequence
        )
        values
        (
            @CookbookID,
            @RecipeID,
            @RecipeSequence
        );

        select @CookbookRecipeID = scope_identity();
    end
    else
    begin
        update CookbookRecipe
        set
            CookbookID = @CookbookID,
            RecipeID = @RecipeID,
            RecipeSequence = @RecipeSequence
        where CookbookRecipeID = @CookbookRecipeID;
    end
end
go