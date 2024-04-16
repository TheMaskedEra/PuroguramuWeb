using Microsoft.EntityFrameworkCore;
using Puroguramu.Domains.Models;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.Infrastructures.Data.Repositories;

public class LessonsRepository : ILessonRepository
{
    private readonly PuroguramuDbContext _dbContext;

    private readonly EntitiesModelMapper _mapper = new ();

    public LessonsRepository(PuroguramuDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public int GetTotalNumber() => _dbContext.Lessons.Count();

    public async Task<int> GetTotalNumberAsync()
    {
        int totalNumber;

        await using (_dbContext)
        {
            totalNumber = await _dbContext.Lessons.CountAsync();
        }

        return totalNumber;
    }

    public void GetAllFromCourse(Course course) => throw new NotImplementedException();

    public void Insert(Lesson lesson) => throw new NotImplementedException();

    public void Update(Lesson lesson) => throw new NotImplementedException();

    public void Delete(Lesson lesson) => throw new NotImplementedException();
}
