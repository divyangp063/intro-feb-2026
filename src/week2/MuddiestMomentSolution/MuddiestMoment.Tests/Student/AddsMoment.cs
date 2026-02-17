
using Alba;
using MuddiestMoment.Api.Student.Endpoints;
using Testcontainers.PostgreSql;

namespace MuddiestMoment.Tests.Student;

public class AddsMoment
{
    [Fact]
    public async Task CanAddAMoment()
    {
        var postgreSqlContainer = new PostgreSqlBuilder("postgres:17.5").Build();
        await postgreSqlContainer.StartAsync();

        var host = await AlbaHost.For<Program>(config =>
        {
            config.UseSetting("ConnectionStrings:db-mm", postgreSqlContainer.GetConnectionString());
        });

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