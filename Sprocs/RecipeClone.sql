create or alter proc RecipeClone
    @RecipeID int
as
begin
    set nocount on;

    begin try
        begin transaction;

        declare @NewRecipeID int;

        insert Recipe
        (
            RecipeName,
            Calories,
            DraftDate,
            PublishedDate,
            ArchivedDate,
            CuisineID,
            UserID
        )
        select
            RecipeName + ' - clone',
            Calories,
            getdate(),
            null,
            null,
            CuisineID,
            UserID
        from Recipe
        where RecipeID = @RecipeID;

        set @NewRecipeID = scope_identity();

        insert RecipeIngredient
        (
            RecipeID,
            IngredientID,
            MeasurementID,
            Amount,
            IngredientSequence
        )
        select
            @NewRecipeID,
            IngredientID,
            MeasurementID,
            Amount,
            IngredientSequence
        from RecipeIngredient
        where RecipeID = @RecipeID;

        insert Instruction
        (
            RecipeID,
            InstructionSequence,
            Instructions
        )
        select
            @NewRecipeID,
            InstructionSequence,
            Instructions
        from Instruction
        where RecipeID = @RecipeID;

        commit transaction;

        select @NewRecipeID as RecipeID;
    end try
    begin catch
        if @@trancount > 0
            rollback transaction;

        throw;
    end catch
end

