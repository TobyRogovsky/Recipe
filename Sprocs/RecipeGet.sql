create or alter proc RecipeGet
(
    @RecipeID int = 0,
    @All bit = 0,
    @RecipeName varchar(100) = ''
)
as
begin
    set nocount on;

    if @RecipeID > 0
    begin
        select RecipeID,RecipeName,Calories,DraftDate,PublishedDate,ArchivedDate, CuisineID, UserID, RecipeStatus
        from Recipe
        where RecipeID = @RecipeID;
    end
    else if @All = 1 or @RecipeName <> ''
    begin
        select r.RecipeID,r.RecipeName,r.RecipeStatus as Status,u.UserName as [User],r.Calories,count(ri.RecipeIngredientID) as NumIngredients
        from Recipe r
        join Users u
        on u.UserID = r.UserID
        left join RecipeIngredient ri
        on ri.RecipeID = r.RecipeID
        where @RecipeName = '' or r.RecipeName like '%' + @RecipeName + '%'
        group by r.RecipeID,r.RecipeName, r.RecipeStatus,u.UserName,r.Calories
        order by
            case r.RecipeStatus
                when 'Published' then 1
                when 'Draft' then 2
                when 'Archived' then 3
                else 4
            end,
            r.RecipeName;
    end
end;
go