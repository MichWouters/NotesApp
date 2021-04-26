using System;

namespace NotesApp.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public string Image { get; set; }

        public virtual void CanBeOverridden()
        {
        }
    }
}