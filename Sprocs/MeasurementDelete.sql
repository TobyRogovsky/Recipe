create or alter proc dbo.MeasurementDelete
(
    @MeasurementID int
)
as
begin

    delete RecipeIngredient
    where MeasurementID = @MeasurementID

    delete Measurement
    where MeasurementID = @MeasurementID

end
go