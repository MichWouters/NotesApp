using Microsoft.EntityFrameworkCore;
using NotesApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotesApp.Repositories
{
    public class NoteRepository : INoteRepository
    {
        public async Task<Note> GetNote(int id)
        {
            using (var dbContext = new NotesContext())
            {
                Note note = await dbContext.Notes.FindAsync(id);

                return note;
            }
        }

        public async Task SaveNote(Note note)
        {
            using (var dbContext = new NotesContext())
            {
                // Check if item is new or an existing note has to be updated
                if (note.Id == 0)
                {
                    // Item is new. Add new item
                    await dbContext.Notes.AddAsync(note);
                }
                else
                {
                    // Update existing note
                    dbContext.Notes.Update(note);
                }

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteNote(Note note)
        {
            using (var dbContext = new NotesContext())
            {
                dbContext.Remove(note);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            using (var dbContext = new NotesContext())
            {
                var result = await dbContext.Notes.ToListAsync();
                return result;
            }
        }
    }
}