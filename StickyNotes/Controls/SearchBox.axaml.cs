using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StickyNotes.Controls
{
    public class SearchBox : UserControl
    {
        public SearchBox()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
