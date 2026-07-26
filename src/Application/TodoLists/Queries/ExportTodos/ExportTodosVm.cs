namespace CleanArchitecture.Application.TodoLists.Queries.ExportTodos;

public class ExportTodosVm(string fileName, string contentType, byte[] content)
{
    public required string FileName { get; set; } = fileName;

    public required string ContentType { get; set; } = contentType;

    public required byte[] Content { get; set; } = content;
}
