using Puroguramu.Domains.Models;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data;

public class EntitiesModelMapper
{
    public Users UserToUserDto(AppUser user, string groupId)
        =>
            new()
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            GroupId = groupId,
            RegistrationNumber = user.Matricule,
        };

    public AppUser UserDtoToUser(Users user, string groupName)
        =>
            new(
                user.RegistrationNumber,
                user.LastName,
                user.FirstName,
                user.Email,
                groupName);

    public Course CourseDtoToCourse()
        => throw new NotImplementedException();

    public Courses CourseToCourseDto()
        => throw new NotImplementedException();

    public Lesson LessonDtoToLesson(Lessons lesson) //TODO Faire les liens avec les exercises
        =>
            new(lesson.Title)
            {
                Description = lesson.Description,
                IsVisible = lesson.IsVisible,
            };

    public Lessons LessonToLessonDto(Lesson lesson) //TODO Faire les liens avec les exercises et ordre
        =>
            new()
            {
                Title = lesson.Title,
                Description = lesson.Description,
                IsVisible = lesson.IsVisible,
            };

    public Exercises ExerciseToExerciseDto(Exercise exercise)
        => throw new NotImplementedException();

    public Exercise ExerciseDtoToExercise(Exercises exercise)
        => throw new NotImplementedException();
}
