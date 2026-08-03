create or alter proc RecipeChangeStatus
(
    @RecipeID int,
    @RecipeStatus varchar(20)
)
as
begin
    set nocount on;

    if @RecipeStatus = 'Draft'
    begin
        update Recipe
        set DraftDate = getdate(),
            PublishedDate = null,
            ArchivedDate = null
        where RecipeID = @RecipeID;
    end
    else if @RecipeStatus = 'Published'
    begin
        update Recipe
        set PublishedDate = getdate(),
            ArchivedDate = null
        where RecipeID = @RecipeID;
    end
    else if @RecipeStatus = 'Archived'
    begin
        update Recipe
        set ArchivedDate = getdate()
        where RecipeID = @RecipeID;
    end
end;
go