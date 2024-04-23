using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface ILessonRepository
{
    Task<int> GetTotalNumberAsync();

    Task<SortedList<int, Lesson>> GetAllFromCourseAsync(Course course);

    Task InsertAsync(Course course, Lesson lesson);

    Task UpdateAsync(Course course, Lesson lesson);

    Task DeleteAsync(Course course, Lesson lesson);

    Task ChangeLessonOrdersAsync(Lesson lesson, Lesson lessonBefore, Lesson lessonAfter);
}
