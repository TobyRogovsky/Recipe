create or alter proc dbo.RecipeIngredientUpdate
(
    @RecipeIngredientID int output,
    @RecipeID int,
    @IngredientID int,
    @MeasurementID int,
    @Amount decimal(10, 2),
    @IngredientSequence int
)
as
begin
    select @RecipeIngredientID =
        isnull(@RecipeIngredientID, 0)

    if @RecipeIngredientID = 0
    begin
        insert RecipeIngredient
        (
            RecipeID,
            IngredientID,
            MeasurementID,
            Amount,
            IngredientSequence
        )
        values
        (
            @RecipeID,
            @IngredientID,
            @MeasurementID,
            @Amount,
            @IngredientSequence
        )

        select @RecipeIngredientID = scope_identity()
    end
    else
    begin
        update RecipeIngredient
        set
            IngredientID = @IngredientID,
            MeasurementID = @MeasurementID,
            Amount = @Amount,
            IngredientSequence = @IngredientSequence
        where RecipeIngredientID = @RecipeIngredientID
    end
end
go