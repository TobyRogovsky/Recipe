create or alter proc dbo.InstructionGet
(
    @All bit = 0,
    @RecipeID int = 0
)
as
begin
    select
        InstructionID,
        RecipeID,
        Instructions,
        InstructionSequence
    from Instruction
    where @All = 1 or RecipeID = @RecipeID
    order by InstructionSequence
end
go
