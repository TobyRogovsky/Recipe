create or alter function dbo.RecipeDesc(@RecipeID int)
returns varchar (200) 
as
begin

	declare @value varchar (200) = ''

	select @value = concat(r.RecipeName, ' (', c.CuisineName, ') ', 'has ', count(distinct ri.RecipeIngredientID), ' ingredients and ', count(distinct i.InstructionID), ' steps.' ) 
	from Recipe r 
	join Cuisine c 
	on r.CuisineID = c.CuisineID
	left join RecipeIngredient ri
	on r.RecipeID = ri.RecipeID
	left join Instruction i 
	on r.RecipeID = i.RecipeID
	where r.recipeID = @RecipeID
	group by r.RecipeName, c.CuisineName	

	return @value

end
go

