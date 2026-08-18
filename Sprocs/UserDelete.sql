create or alter procedure dbo.UserDelete
(
    @UserID int
)
as
begin
    set nocount on

    begin try
        begin transaction

        delete CookbookRecipe
        where CookbookID in
        ( select CookbookID
            from Cookbook
            where UserID = @UserID
        )

        delete CookbookRecipe
        where RecipeID in
        (select RecipeID
            from Recipe
            where UserID = @UserID
        )

        delete RecipeMealCourse
        where RecipeID in
        (select RecipeID
            from Recipe
            where UserID = @UserID
        )

        delete RecipeMealCourse
        where MealCourseID in
        (select mc.MealCourseID
            from MealCourse mc
            join Meal m
            on mc.MealID = m.MealID
            where m.UserID = @UserID
        )

        delete Instruction
        where RecipeID in
        (select RecipeID
            from Recipe
            where UserID = @UserID
        )

        delete RecipeIngredient
        where RecipeID in
        (select RecipeID
            from Recipe
            where UserID = @UserID
        )

        delete MealCourse
        where MealID in
        (select MealID
            from Meal
            where UserID = @UserID
        )

        delete Cookbook
        where UserID = @UserID
        delete Meal
        where UserID = @UserID
        delete Recipe
        where UserID = @UserID
        delete Users
        where UserID = @UserID
        commit transaction
    end try
    begin catch
        if @@trancount > 0
            rollback transaction

        throw
    end catch
end
go