create or alter proc dbo.MeasurementUpdate
    @MeasurementID int output,
    @MeasurementType varchar(12)
as
begin
    if isnull(@MeasurementID, 0) = 0
    begin
        insert into Measurement
        (
            MeasurementType
        )
        values
        (
            @MeasurementType
        )

        set @MeasurementID = scope_identity()
    end
    else
    begin
        update Measurement
        set MeasurementType = @MeasurementType
        where MeasurementID = @MeasurementID
    end

end
go
