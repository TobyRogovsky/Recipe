create or alter proc dbo.MeasurementGet(@All bit = 0)
as
begin
    select
        MeasurementID,
        MeasurementType
    from Measurement
    order by MeasurementType
end
go

