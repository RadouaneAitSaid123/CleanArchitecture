namespace CleanArchitecture.Domain.Events;

public class TodoItemCompletedEvent(TodoItem item) : DomainEvent
{
    public TodoItem Item { get; } = item;
}
