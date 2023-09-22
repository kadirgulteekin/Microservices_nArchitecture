using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Shared.Dtos;

namespace FreeCourse.Services.Catalog.Services
{
    internal interface ICourseService
    {
        Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        Task<Response<NoContent>> DeletedAsync(string id);
        Task<Response<List<CourseDto>>> GetAllAsync();
        Task<Response<List<CourseDto>>> GetAllByUserId(string userId);
        Task<Response<CourseDto>> GetByIdAsync(string id);
        Task<Response<NoContent>> UpdatedAsync(CourseUpdateDto courseUpdateDto);
    }
}