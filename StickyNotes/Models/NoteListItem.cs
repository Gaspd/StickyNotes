using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StickyNotes.Models
{
    public class NoteListItem
    {
        public int Id { get; set; }
        public ObservableCollection<NoteContentElement> Contents { get; set; }
        public IBrush Background { get; set; }
    }
}
