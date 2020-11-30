using System;
using System.Collections.Generic;
using System.Text;

namespace StickyNotes.Models
{
    public class NoteContentElement
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsCheckBox { get; set; }
        public bool IsChecked { get; set; }
    }
}
