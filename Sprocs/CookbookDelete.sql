create or alter proc dbo.CookbookDelete
(
    @CookbookID int
)
as
begin
    declare @return int = 0

    begin transaction

    begin try

        delete CookbookRecipe
        where CookbookID = @CookbookID

        delete Cookbook
        where CookbookID = @CookbookID

        commit transaction

    end try
    begin catch

        rollback transaction
        ;throw

    end catch

    return @return
end
go