using System.Globalization;
using FYP.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace FYP.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
