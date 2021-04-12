using NotesApp.Models;
using NotesApp.Repositories;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotesApp.ViewModels
{
    public class ToDoListViewModel
    {
        private readonly IToDoRepository _repo;

        public ObservableCollection<ToDo> ToDoItems { get; set; }

        public string NewToDoInputValue { get; set; }

        public ICommand AddToDoCommand => new Command(AddToDoItem);

        public ToDoListViewModel()
        {
            _repo = new ToDoRepository();
        }

        private async void AddToDoItem()
        {
            var todo = new ToDo()
            {
                Text = NewToDoInputValue
            };

            await _repo.SaveTodoAsync(todo);
        }
    }
}