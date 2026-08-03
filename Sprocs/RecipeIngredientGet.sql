create or alter proc dbo.RecipeIngredientGet
(
    @RecipeID int
)
as
begin
    select
        ri.RecipeIngredientID,
        ri.RecipeID,
        ri.IngredientID,
        ri.MeasurementID,
        ri.Amount,
        ri.IngredientSequence
    from RecipeIngredient ri
    where ri.RecipeID = @RecipeID
    order by ri.IngredientSequence
end
go

