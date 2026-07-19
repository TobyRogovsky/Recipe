create or alter procedure dbo.RecipeListGet
as
begin
    select
        r.RecipeId,
        r.RecipeName,
        r.RecipeStatus as Status,
        u.UserName as [User],
        r.Calories,
        count(ri.RecipeIngredientID) as NumIngredients
    from Recipe r
    join [Users] u
        on r.UserID = u.UserID
    left join RecipeIngredient ri
        on r.RecipeID = ri.RecipeID
    group by r.RecipeID, r.RecipeName, r.RecipeStatus, u.UserName, r.Calories
    order by
        case r.RecipeStatus
            when 'Published' then 1
            when 'Draft' then 2
            when 'Archived' then 3
            else 4
        end,
        r.RecipeName
end
go