create or alter proc dbo.InstructionDelete
(
    @InstructionID int
)
as
begin
    delete Instruction
    where InstructionID = @InstructionID
end
go