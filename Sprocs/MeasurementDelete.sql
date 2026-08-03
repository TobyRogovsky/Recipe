create or alter proc dbo.MeasurementDelete
(
    @MeasurementID int
)
as
begin
    delete Measurement
    where MeasurementID = @MeasurementID
end
go