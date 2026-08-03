create or alter proc dbo.CookbookUpdate
(
    @Message varchar(500) = '' output,
    @CookbookID int output,
    @UserID int,
    @CookbookName varchar(100),
    @Price decimal(10, 2),
    @DateCookBookCreated date
)
as
begin
    declare @return int = 0

    select @CookbookID = isnull(@CookbookID, 0)

    if @CookbookID = 0
    begin
        insert Cookbook
        (
            UserID,
            CookbookName,
            Price,
            DateCookBookCreated
        )
        values
        (
            @UserID,
            @CookbookName,
            @Price,
            @DateCookBookCreated
        )

        select @CookbookID = scope_identity()
    end
    else
    begin
        update Cookbook
        set
            UserID = @UserID,
            CookbookName = @CookbookName,
            Price = @Price,
            DateCookBookCreated = @DateCookBookCreated
        where CookbookID = @CookbookID
    end

    return @return
end
go