using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface ILessonRepository
{
    int GetTotalNumber();

    void GetAllFromCourse(Course course);

    void Insert(Lesson lesson);

    void Update(Lesson lesson);

    void Delete(Lesson lesson);
}
