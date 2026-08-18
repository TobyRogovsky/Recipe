create or alter proc dbo.CuisineDelete
(
    @CuisineID int
)
as
begin

    delete CookbookRecipe
    where RecipeID in
    (
        select RecipeID
        from Recipe
        where CuisineID = @CuisineID
    )

    delete RecipeMealCourse
    where RecipeID in
    (
        select RecipeID
        from Recipe
        where CuisineID = @CuisineID
    )

    delete Instruction
    where RecipeID in
    (
        select RecipeID
        from Recipe
        where CuisineID = @CuisineID
    )

    delete RecipeIngredient
    where RecipeID in
    (
        select RecipeID
        from Recipe
        where CuisineID = @CuisineID
    )

    delete Recipe
    where CuisineID = @CuisineID

    delete Cuisine
    where CuisineID = @CuisineID

end
go