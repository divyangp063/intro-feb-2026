using Marten;

namespace MuddiestMoment.Api.Student.Endpoints;

public class StudentMarksMomentAnswered
{
    // Who? Authorization
    // Which questions (that id)
    // Policy
    //  - You should only be able to do this for a question you own or created
    public static async Task<IResult> MarkQuestionAnswered(Guid id, IDocumentSession session)
    {
        // Delete that question from the databased
        // See if we can find that moment, and if we do, "flag it" as answered
        var savedMoment = await session.Query<StudentMomentEntity>()
            .Where(m => m.Id == id)
            .SingleOrDefaultAsync();
        if(savedMoment is null)
        {
            return TypedResults.Ok();
        }
        savedMoment.IsAnswered = true;
        session.Store(savedMoment);
        await session.SaveChangesAsync();
        return TypedResults.Ok();
    }
}
