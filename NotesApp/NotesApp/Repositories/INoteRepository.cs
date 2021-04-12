using NotesApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotesApp.Repositories
{
    public interface INoteRepository
    {
        Task<Note> GetNote(int id);

        Task SaveNote(Note note);

        Task DeleteNote(Note note);

        Task<IEnumerable<Note>> GetAllNotes();
    }
}