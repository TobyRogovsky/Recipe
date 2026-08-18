create or alter proc dbo.CuisineUpdate
(
    @Message varchar(500) = '' output,
    @CuisineID int output,
    @CuisineName varchar(20)
)
as
begin
    declare @return int = 0
    select @CuisineID = isnull(@CuisineID, 0)

    if @CuisineID = 0
    begin
        insert Cuisine
        (CuisineName)
        values(@CuisineName)
        select @CuisineID = scope_identity()
    end
    else
    begin
        update Cuisine
        set CuisineName = @CuisineName
        where CuisineID = @CuisineID
    end

    return @return
end
go