using NotesApp.Models;
using NotesApp.Repositories;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotesApp.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class NoteEntryPage : ContentPage
    {
        private readonly INoteRepository _noteRepository;

        public int ItemId
        {
            set => LoadNote(value);
        }

        public NoteEntryPage()
        {
            InitializeComponent();
            _noteRepository = new NoteRepository();
            BindingContext = new Note();
        }

        private async Task LoadNote(int id)
        {
            BindingContext = await _noteRepository.GetNote(id);
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (BindingContext is Note note)
            {
                note.Date = DateTime.Now;
                await SaveNote(note);
            }

            // Navigate backwards -> Go back to previous screen
            await Shell.Current.GoToAsync("..");
        }

        private async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = BindingContext as Note;
            await DeleteNote(note);

            // Navigate backwards -> Go back to previous screen
            await Shell.Current.GoToAsync("..");
        }

        public async Task SaveNote(Note note)
        {
            await _noteRepository.SaveNote(note);
        }

        private async Task DeleteNote(Note note)
        {
            await _noteRepository.DeleteNote(note);
        }
    }
}