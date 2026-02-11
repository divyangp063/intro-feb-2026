using Microsoft.AspNetCore.Mvc;

namespace TodoList.Api.Controllers;

public class TodosController : ControllerBase
{
    // When they do a get request / todos
    [HttpGet("/todos")]
    public async Task<ActionResult> GetAllTodos()
    {
        return Ok(new List<string> { "Clean the garage", "Take out the trash" });
    }

    // GET /todos/{id}

    // POST /

    // PUT /todos/{id}/person
}
