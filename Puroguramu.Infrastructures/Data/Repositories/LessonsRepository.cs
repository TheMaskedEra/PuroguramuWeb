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

    public async Task<int> GetTotalNumberAsync() => await _dbContext.Lessons.CountAsync();

    public void GetAllFromCourse(Course course) => throw new NotImplementedException();

    public void Insert(Lesson lesson) => throw new NotImplementedException();

    public void Update(Lesson lesson) => throw new NotImplementedException();

    public void Delete(Lesson lesson) => throw new NotImplementedException();
}
