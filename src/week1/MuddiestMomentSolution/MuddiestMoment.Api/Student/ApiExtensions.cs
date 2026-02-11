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
            // 1 hypocritical thing
            // 2 BS "slimed" - 
            var group = endpoints.MapGroup("/student/moments");
            // If any http post methods come in for student/moments, run this function
            group.MapPost("", StudentAddsMoment.AddMoment);
            group.MapGet("", StudentGetsListOfSavedMoments.GetAllMomentsForStudent);
            // DELETE /student/moments/142394823
            group.MapDelete("/{id:guid}", StudentMarksMomentAnswered.MarkQuestionAnswered);

            // TODO /student/answered-questions
            var answer_group = endpoints.MapGroup("/student/answered-questions");
            answer_group.MapGet("", StudentGetsListOfAnsweredQuestions.GetAnswerdQuestionsForStudent);

            return group;
        }
    }
}
