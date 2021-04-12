using System.Collections.Generic;
using System.Threading.Tasks;
using NotesApp.Models;

namespace NotesApp.Repositories
{
    public interface IToDoRepository
    {
        Task<ToDo> GetTodo(int id);
        Task SaveTodo(ToDo toDo);
        Task DeleteTodo(ToDo toDo);
        Task<IEnumerable<ToDo>> GetAllToDos();
    }
}