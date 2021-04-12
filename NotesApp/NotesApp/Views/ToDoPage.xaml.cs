using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoPage : ContentPage
    {
        public ToDoPage()
        {
            InitializeComponent();
        }

        private void myToDos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private async void AddToDoClicked(object sender, EventArgs e)
        {
            // "nameof" gebruiken om te vermijden dat letterlijk naar klassen verwezen wordt
            await Shell.Current.GoToAsync(nameof(ToDoEntryPage));
        }
    }
}