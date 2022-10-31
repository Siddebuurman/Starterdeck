using StarterDeck_DataCompiler.Models;

namespace StarterDeck_DataCompiler
{
    public partial class MainForm : Form
    {
        public DataCollection data = new();

        public MainForm()
        {
            InitializeComponent();
        }

        public void EngineersButton_OnClick(object? o, EventArgs e)
        {
            var engineersForm = new Engineers(this);
            Hide();
            engineersForm.ShowDialog();
        }
    }
}