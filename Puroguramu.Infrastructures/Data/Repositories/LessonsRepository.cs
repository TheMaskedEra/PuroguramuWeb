using System.Collections;
using Microsoft.EntityFrameworkCore;
using Puroguramu.Domains.Models;
using Puroguramu.Domains.Repositories;
using Puroguramu.Infrastructures.Data.Entities;
using Lesson = Puroguramu.Domains.Models.Lesson;

namespace Puroguramu.Infrastructures.Data.Repositories;

public class LessonsRepository : ILessonRepository
{
    private readonly PuroguramuDbContext _dbContext;

    private readonly EntitiesModelMapper _mapper = new ();

    public LessonsRepository(PuroguramuDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> GetTotalNumberAsync()
        => await _dbContext.Lessons.CountAsync();

    public async Task<SortedList<int, Lesson>> GetAllFromCourseAsync(Course course) //TODO S'occuper d'exception si retourne null ?
    {
        var lessonList = new SortedList<int,Lesson>();
        var currentLessonId = await FindFirstLessonIdInCourseAsync(course);

        if (currentLessonId == null)
        {
            return lessonList;
        }

        var i = 0;

        while (currentLessonId != null)
        {
            var lesson = await FindLessonById(currentLessonId);
            if (lesson == null)
            {
                throw new NotImplementedException();
            }

            lessonList.Add(i++, lesson);

            currentLessonId = await FindNextLessonId(currentLessonId);
        }

        return lessonList;
    }

    private async Task<string?> FindFirstLessonIdInCourseAsync(Course course)
    {
        var courseId = await _dbContext.Courses
            .Where(c => c.Title.Equals(course.Title) && c.LanguageId.Equals(course.Language))
            .Select(c => c.Id)
            .FirstOrDefaultAsync();

        return await _dbContext.Lessons
            .Join(_dbContext.LessonOrders, l => l.Id, lo => lo.LessonId, (l, lo) => new { Lessons = l, LessonOrders = lo })
            .Where(t => t.LessonOrders.LessonBeforeId == null && t.Lessons.CourseId == courseId)
            .Select(t => t.Lessons.Id)
            .FirstOrDefaultAsync();
    }

    private async Task<string?> FindNextLessonId(string lessonId)
        => await _dbContext.Lessons
            .Join(_dbContext.LessonOrders, l => l.Id, lo => lo.LessonId, (l, lo) => new { Lessons = l, LessonOrders = lo })
            .Where(t => t.LessonOrders.LessonId == lessonId)
            .Select(t => t.LessonOrders.LessonAfterId)
            .FirstOrDefaultAsync();

    private async Task<Lesson?> FindLessonById(string id)
    {
        var lessonDto = await _dbContext.Lessons.Where(l => l.Id == id).FirstOrDefaultAsync();
        return lessonDto == null ? null : _mapper.LessonDtoToLesson(lessonDto);
    }

    public Task InsertAsync(Lesson lesson)
        => throw new NotImplementedException();

    public Task UpdateAsync(Lesson lesson)
        => throw new NotImplementedException();

    public Task DeleteAsync(Lesson lesson)
        => throw new NotImplementedException();
}
