namespace CleanArchitecture.Application.TodoLists.Queries.ExportTodos;

public class ExportTodosVm
{
    public ExportTodosVm(string fileName, string contentType, byte[] content)
    {
        FileName = fileName;
        ContentType = contentType;
        Content = content;
    }

    public required string FileName { get; set; }

    public required string ContentType { get; set; }

    public required byte[] Content { get; set; }
}
