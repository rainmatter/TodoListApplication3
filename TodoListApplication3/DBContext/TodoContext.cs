using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TodoListApplication3.Models;

namespace TodoListApplication3.DBContext
{
    public class TodoContext :DbContext
    {
        public DbSet<TodoList> TodoLists { get; set; }
    }
}