// [X] Use Top Level Statements
using MuddiestMoment.Api.Student;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add the services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Above this is configuration of services (things that own some state and the process around it) that we need in our application
builder.Services.AddValidation(); // Opting in to services to handle some stuff for us
var app = builder.Build();

// Everything here is setting up how we actually handle incmoing request and write responses

// Add the code that allows us to handle POST to /student/moments

app.MapStudentEndpoints();

app.MapDefaultEndpoints();

app.Run();

