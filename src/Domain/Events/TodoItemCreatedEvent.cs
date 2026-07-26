namespace CleanArchitecture.Domain.Events;

public class TodoItemCreatedEvent(TodoItem item) : DomainEvent
{
    public TodoItem Item { get; } = item;
}
