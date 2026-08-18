create or alter proc dbo.IngredientDelete
(
    @IngredientID int
)
as
begin
    delete RecipeIngredient
    where IngredientID = @IngredientID

    delete Ingredient
    where IngredientID = @IngredientID
end
go