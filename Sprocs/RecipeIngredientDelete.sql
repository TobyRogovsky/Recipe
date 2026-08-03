create or alter proc dbo.RecipeIngredientDelete
(
    @RecipeIngredientID int
)
as
begin
    delete RecipeIngredient
    where RecipeIngredientID = @RecipeIngredientID
end
go