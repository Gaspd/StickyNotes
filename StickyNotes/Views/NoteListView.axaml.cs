using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StickyNotes.Views
{
    public class NoteListView : UserControl
    {
        public NoteListView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
