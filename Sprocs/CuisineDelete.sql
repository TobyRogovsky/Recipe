create or alter proc dbo.CuisineDelete
(
    @CuisineID int
)
as
begin
    delete Cuisine
    where CuisineID = @CuisineID
end
go