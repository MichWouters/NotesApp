using System.Collections.Generic;
using System.Threading.Tasks;
using NotesApp.Models;

namespace NotesApp.Repositories
{
    public interface IToDoRepository
    {
        Task<ToDo> GetTodoAsync(int id);
        Task SaveTodoAsync(ToDo toDo);
        Task DeleteTodoAsync(ToDo toDo);
        Task<IEnumerable<ToDo>> GetAllToDosAsync();
    }
}