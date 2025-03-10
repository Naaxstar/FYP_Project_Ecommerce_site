﻿using FYP.Application.Common.Mappings;
using FYP.Domain.Entities;

namespace FYP.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
