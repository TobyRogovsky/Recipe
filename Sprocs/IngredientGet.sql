create or alter proc dbo.IngredientGet(@All bit = 0)
as
begin
    select
        IngredientID,
        IngredientName
    from Ingredient
    order by IngredientName
end
go