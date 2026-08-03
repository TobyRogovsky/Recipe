create or alter proc dbo.InstructionUpdate
(
    @InstructionID int output,
    @RecipeID int,
    @Instructions varchar(500),
    @InstructionSequence int
)
as
begin
    select @InstructionID = isnull(@InstructionID, 0)

    if @InstructionID = 0
    begin
        insert Instruction
        (
            RecipeID,
            Instructions,
            InstructionSequence
        )
        values
        (
            @RecipeID,
            @Instructions,
            @InstructionSequence
        )

        select @InstructionID = scope_identity()
    end
    else
    begin
        update Instruction
        set
            Instructions = @Instructions,
            InstructionSequence = @InstructionSequence
        where InstructionID = @InstructionID
    end
end
go