create or alter procedure dbo.UserDelete
(
    @UserID int
)
as
begin
    set nocount on;
    begin try
        begin transaction;
        delete Users
        where UserID = @UserID;
        commit transaction;
    end try
    begin catch
        if @@trancount > 0
            rollback transaction;
        throw;
    end catch
end