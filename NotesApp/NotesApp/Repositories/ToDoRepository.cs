using Microsoft.EntityFrameworkCore;
using NotesApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotesApp.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        public async Task<ToDo> GetTodo(int id)
        {
            using (var dbContext = new NotesContext())
            {
                var toDo = await dbContext.ToDos.FindAsync(id);
                return toDo;
            }
        }

        public async Task SaveTodo(ToDo toDo)
        {
            using (var dbContext = new NotesContext())
            {
                if (toDo.Id == 0)
                {
                    await dbContext.ToDos.AddAsync(toDo);
                }
                else
                {
                    dbContext.ToDos.Update(toDo);
                }

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteTodo(ToDo toDo)
        {
            using (var dbContext = new NotesContext())
            {
                dbContext.Remove(toDo);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ToDo>> GetAllToDos()
        {
            using (var dbContext = new NotesContext())
            {
                return await dbContext.ToDos.ToListAsync();
            }
        }
    }
}