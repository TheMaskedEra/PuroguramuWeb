using Puroguramu.Domains.Models;
using Puroguramu.Infrastructures.Data.Entities;

namespace Puroguramu.Infrastructures.Data;

public class EntitiesModelMapper
{
    public Users UserToEFUser(AppUser user, string groupId) => new()
    {
        FirstName = user.FirstName,
        LastName = user.LastName,
        Email = user.Email,
        GroupId = groupId,
        RegistrationNumber = user.Matricule,
    };

    public AppUser EFUserToUser(Users user, string groupName) =>
        new(user.RegistrationNumber,
            user.LastName,
            user.FirstName,
            user.Email,
            groupName);

    public Course EFCourseToCourse() => throw new NotImplementedException();

    public Courses CourseToEFCourse() => throw new NotImplementedException();

    public Lesson EFLessonToLesson() => throw new NotImplementedException();

    public Lessons LessonToEFLesson() => throw new NotImplementedException();

    public Exercises ExerciseToEFExercise(Exercise exercise) => throw new NotImplementedException();

    public Exercise EFExerciseToExercise(Exercises exercise) => throw new NotImplementedException();
}
