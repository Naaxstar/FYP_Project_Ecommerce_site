using FYP.Application.TodoLists.Queries.ExportTodos;

namespace FYP.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
