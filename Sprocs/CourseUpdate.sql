create or alter proc dbo.CourseUpdate
(
    @Message varchar(500) = '' output,
    @CourseID int output,
    @CourseName varchar(20),
    @CourseSequence int = null
)
as
begin
    declare @return int = 0
    select @CourseID = isnull(@CourseID, 0)

    if @CourseID = 0
    begin
        insert Course
        (CourseName,CourseSequence)
        values
        (@CourseName,isnull(@CourseSequence, 1))

        select @CourseID = scope_identity()
    end
    else
    begin
        update Course
        set CourseName = @CourseName, CourseSequence = isnull(@CourseSequence, CourseSequence)
        where CourseID = @CourseID
    end
    return @return
end
go