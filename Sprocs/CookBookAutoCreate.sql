create or alter proc dbo.CookbookAutoCreate(
@UserID int = 0,
@CookbookID int = 0 output
)
as
begin

	set nocount on;

	declare @FirstName varchar (50);
	declare @LastName varchar (50);
	declare @RecipeCount int;

	select @FirstName = u.FirstName, @LastName = u.LastName
	from Users u 
	where u.userID = @UserID;

	if @FirstName is null
		begin
			;throw 50000, 'User was not found.', 1;
		end;
	
	select @RecipeCount = count(*)
	from Recipe r 
	where r.UserID = @UserID;

	if @RecipeCount = 0
	begin
		;throw 50000, 'The select user does not have any recipes.', 1;
	end

begin transaction;
begin try
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
                concat('Recipes by ', @FirstName, ' ', @LastName),
                @RecipeCount * 1.33,
                getdate()
            );

        set @CookbookID = scope_identity()

        insert CookbookRecipe
        (
            CookbookID,
            RecipeID,
            RecipeSequence
        )
        select
            @CookbookID,
            RecipeID,
            row_number() over(order by r.RecipeName)
        from Recipe r
        where r.UserID = @UserID;

        commit transaction;

    end try
    begin catch

        if @@trancount > 0
        begin
            rollback transaction;
        end;

        throw;

    end catch;
end;


select *
from recipe