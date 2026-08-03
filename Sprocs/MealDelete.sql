create or alter proc dbo.MealDelete
(
    @MealID int
)
as
begin
    delete Meal
    where MealID = @MealID
end
go