using StickyNotes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StickyNotes.ViewModels
{
    public class NoteListViewModel : ViewModelBase
    {
        public NoteListViewModel()
        {
            Items = new ObservableCollection<NoteListItem>();
        }
        public ObservableCollection<NoteListItem> Items {get;}
    }
}
