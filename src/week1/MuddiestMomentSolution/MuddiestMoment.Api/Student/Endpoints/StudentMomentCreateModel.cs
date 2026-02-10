using System.ComponentModel.DataAnnotations;

namespace MuddiestMoment.Api.Student.Endpoints;

/*
    POST https://localhost:1337/student/moments
    Content-type: application/json
    Authorization: ***** Bearer Token (Fake this for a while)

    {
        "title": "HTTP",
        "description": "A little fuzzy on the types of resources... collections, documents?"
    }
*/
public record StudentMomentCreateModel
{
    // Attributes are square brackets
    [MinLength(3), MaxLength(50)]
    public required string Title { get; set; } = string.Empty;
    [MaxLength(150)]
    public string Description { get; set; } = string.Empty;
}
    