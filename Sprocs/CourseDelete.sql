create or alter proc dbo.CourseDelete
(
    @CourseID int
)
as
begin

    delete RecipeMealCourse
    where MealCourseID in
    (
        select MealCourseID
        from MealCourse
        where CourseID = @CourseID
    )

    delete MealCourse
    where CourseID = @CourseID

    delete Course
    where CourseID = @CourseID

end
go