create or alter proc dbo.IngredientUpdate
    @IngredientID int output,
    @IngredientName varchar(30)
as
begin

    if isnull(@IngredientID, 0) = 0
    begin
        insert into Ingredient
        (
            IngredientName
        )
        values
        (
            @IngredientName
        )

        set @IngredientID = scope_identity()
    end
    else
    begin
        update Ingredient
        set IngredientName = @IngredientName
        where IngredientID = @IngredientID
    end

end
go