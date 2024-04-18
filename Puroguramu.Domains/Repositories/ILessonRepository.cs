using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface ILessonRepository
{
    Task<int> GetTotalNumberAsync();

    Task<SortedList<int, Lesson>> GetAllFromCourse(Course course);

    void Insert(Lesson lesson);

    void Update(Lesson lesson);

    void Delete(Lesson lesson);
}
