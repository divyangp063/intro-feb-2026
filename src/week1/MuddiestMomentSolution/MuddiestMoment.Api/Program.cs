// [X] Use Top Level Statements
using Marten;
using MuddiestMoment.Api.Student;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("db-mm") ?? throw new Exception("No Connection String");
// appsettings.json -> "ConnectionString" : { "db-mm": "..." }
// See if there is an Environment Variable on the machine we are running on called "ASPNETCORE_ENVIRONMENT"
// If it is there, look for an appsettings.ENVIRONMENT.json and that value
// Looks at environment variables -
//  ConnectionString__tacos


builder.Services.AddMarten(config =>
{
    config.Connection(connectionString);
}).UseLightweightSessions();
builder.AddServiceDefaults();

// Add the services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Above this is configuration of services (things that own some state and the process around it) that we need in our application
builder.Services.AddValidation(); // Opting in to services to handle some stuff for us
var app = builder.Build();

// Everything here is setting up how we actually handle incmoing request and write responses

app.MapOpenApi();
// Add the code that allows us to handle POST to /student/moments

app.MapStudentEndpoints(); // More explicit - means more "intention revealing"

app.MapDefaultEndpoints();
// This api is not up and running (litening for requests until we hit the next line)
app.Run();

