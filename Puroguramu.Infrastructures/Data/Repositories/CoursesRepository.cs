using Microsoft.EntityFrameworkCore;
using Puroguramu.Domains.Models;
using Puroguramu.Domains.Repositories;

namespace Puroguramu.Infrastructures.Data.Repositories;

public class CoursesRepository : ICourseRepository
{
    private readonly PuroguramuDbContext _dbContext;

    private readonly EntitiesModelMapper _mapper = new();

    private readonly ILanguageRepository _languageRepository;

    public CoursesRepository(PuroguramuDbContext dbContext, ILanguageRepository languageRepository)
    {
        _dbContext = dbContext;
        _languageRepository = languageRepository;
    }

    public async Task<string?> GetCourseId(Course course)
    {
        var languageId = await _languageRepository.FindLanguageIdAsync(course.Language);
        if (languageId == null)
        {
            throw new NotImplementedException();
        }

        var courseDto = _mapper.CourseToCourseDto(course, languageId);
        return await _dbContext.Courses
            .Where(c => c.LanguageId.Equals(languageId) && c.Title.Equals(courseDto.Title))
            .Select(c => c.Id)
            .FirstOrDefaultAsync();
    }
}
