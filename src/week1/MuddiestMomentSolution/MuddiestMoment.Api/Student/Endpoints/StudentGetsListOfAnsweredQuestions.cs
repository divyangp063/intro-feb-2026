using Marten;
using Marten.Schema;

namespace MuddiestMoment.Api.Student.Endpoints;

public static class StudentGetsListOfAnsweredQuestions
{
    public static async Task<IResult> GetAnswerdQuestionsForStudent(IDocumentSession session)
    {
        var answered = await session.Query<StudentMomentEntity>()
            .Where(a => a.AddedBy == "fake user" && a.IsAnswered == true)
            .Select(a => new StudentMomentResponseModel
            {
                Id = a.Id,  // This needs to be the ID of the person making this request
                AddedBy = a.AddedBy,
                CreatedOn = a.CreatedOn,
                Description = a.Description,
                Title = a.Title
            })
            .ToListAsync();
        return TypedResults.Ok(answered);
    }
}
