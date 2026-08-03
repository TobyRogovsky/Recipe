create or alter proc dbo.IngredientDelete
(
    @IngredientID int
)
as
begin
    delete Ingredient
    where IngredientID = @IngredientID
end
go