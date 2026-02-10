using MuddiestMoment.Api.Student.Endpoints;

namespace MuddiestMoment.Api.Student;

public static class ApiExtensions
{
    extension(IEndpointRouteBuilder endpoints)
    {
        // POST /student/moments
        // GET /student/moments
        public IEndpointRouteBuilder MapStudentEndpoints()
        {
            var group = endpoints.MapGroup("/student/moments");
            // If any http post methods come in for student/moments, run this function
            group.MapPost("", StudentAddsMoment.AddMoment);

            return group;
        }
    }
}
