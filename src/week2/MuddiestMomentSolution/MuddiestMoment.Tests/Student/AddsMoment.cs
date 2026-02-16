
using Alba;
using MuddiestMoment.Api.Student.Endpoints;

namespace MuddiestMoment.Tests.Student;

public class AddsMoment
{
    [Fact]
    public async Task CanAddAMoment()
    {
        var host = await AlbaHost.For<Program>();

        // Scenario 
        // Start up the API
        // Make a post request with some data to /student/moments
        // The status code should be a 200
        // We should also get some stuff back
        // Part 2 later

        var itemToSend = new StudentMomentCreateModel 
        { 
            Title = "Containers", 
            Description = "Tell me about volumes" 
        };
        var response = await host.Scenario(api =>
        {
            api.Post.Json(itemToSend).ToUrl("/student/moments");
            api.StatusCodeShouldBeOk();
        });
    }
}

// dotnet run - start the api
// dotnet test - run my system tests