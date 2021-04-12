using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using NotesApp.Models;

namespace NotesApp.ViewModels
{
    public class ToDoListViewModel
    {
        public ObservableCollection<ToDo> ToDoItems { get; set; } = new ObservableCollection<ToDo>();

        public string NewToDoInputValue { get; set; }

    }
}
