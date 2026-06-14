create or alter proc dbo.RecipeUpdate(
	@Message varchar(500) = '' output,
	@RecipeID int  output,
	@CuisineID int,
	@UserID int,
	@RecipeName varchar(50),
	@Calories int,
	@DraftDate date	

)
as 
begin
	declare @return int = 0

	select @RecipeID = isnull(@RecipeID, 0)

	if @recipeID = 0
	begin
		insert recipe(CuisineID, UserID, RecipeName, Calories, DraftDate)
		values (@CuisineID, @UserID, @RecipeName, @Calories, @DraftDate) 

		select @RecipeID = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set
		CuisineID = @CuisineID, 
		UserID = @UserID, 
		RecipeName = @RecipeName, 
		Calories = @Calories, 
		DraftDate = @DraftDate
		where RecipeID = @RecipeID
	end
return @return
end
go

		 