using Puroguramu.Domains.Models;

namespace Puroguramu.Domains.Repositories;

public interface ICourseRepository
{
    public Task<string?> GetCourseId(Course course);
}
