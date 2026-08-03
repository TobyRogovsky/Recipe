create or alter proc dbo.CourseGet
(
    @CourseID int = 0,
    @All bit = 0
)
as
begin
    select
        CourseID,
        CourseName
    from Course
    where @All = 1
       or CourseID = @CourseID
    order by CourseName
end
go