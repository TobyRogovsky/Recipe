create or alter proc dbo.CourseDelete
(
    @CourseID int
)
as
begin
    delete Course
    where CourseID = @CourseID
end
go