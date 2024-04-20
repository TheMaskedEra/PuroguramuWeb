using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface ILessonRepository
{
    Task<int> GetTotalNumberAsync();

    Task<SortedList<int, Lesson>> GetAllFromCourseAsync(Course course);

    Task InsertAsync(Lesson lesson);

    Task UpdateAsync(Lesson lesson);

    Task DeleteAsync(Lesson lesson);
}
