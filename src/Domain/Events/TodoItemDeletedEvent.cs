namespace CleanArchitecture.Domain.Events;

public class TodoItemDeletedEvent(TodoItem item) : DomainEvent
{
    public TodoItem Item { get; } = item;
}
