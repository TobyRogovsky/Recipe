create or alter proc dbo.UserUpdate
    @UserID int output,
    @FirstName varchar(20),
    @LastName varchar(20),
    @UserName varchar(21)
as
begin

    if isnull(@UserID, 0) = 0
    begin
        insert into Users
        (
            FirstName,LastName,UserName
        )
        values
        (
            @FirstName,@LastName,@UserName
        )
        set @UserID = scope_identity()
    end
    else
    begin
        update Users
        set FirstName = @FirstName, LastName = @LastName, UserName = @UserName
        where UserID = @UserID
    end
end
go