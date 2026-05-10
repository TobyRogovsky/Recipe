create or alter procedure dbo.UserGet(@UserID int = 0, @All bit = 0, @UserName varchar(21) = '')
as
begin
	select @UserName = nullif (@UserName, '')
	select u.UserID, u.FirstName, u.LastName, u.UserName
	from Users u 
	where u.UserID = @UserID
	or @All = 1
	or u.UserName like '%' + @UserName + '%'
end
go

exec UserGet
exec UserGet @All = 1
exec UserGet @username = 'b'