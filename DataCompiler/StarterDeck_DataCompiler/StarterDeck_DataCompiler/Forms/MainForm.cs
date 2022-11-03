using StarterDeck_DataCompiler.Forms;
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
            EngineersForm engineersForm;
            if (data.engineers.Count != 0)
                engineersForm = new EngineersForm(this, data.engineers);
            else
                engineersForm = new(this);

            Hide();
            engineersForm.ShowDialog();
        }

        private void EngineerTypesButton_Click(object sender, EventArgs e)
        {
            EngineerTypeForm engineerTypeForm = new();
            Hide();
            engineerTypeForm.ShowDialog();
            Show();
        }

        public void SubmitData(List<Engineer> engineers)
        {
            foreach (var engineer in engineers)
                if (!data.engineers.Any(x => x.IsSame(engineer)))
                {
                    data.engineers.Add(engineer);
                    engineer.ID = engineers.IndexOf(engineer);
                }
            Show();
        }
        public void SubmitData(List<Technique> techniques)
        {
            Show();
        }
        public void SubmitData(List<Scenario> scenarios)
        {
            Show();
        }

        private void LoadExistingButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.AddExtension = true;
            OpenFileDialog.DefaultExt = "ingeniousdata";
            OpenFileDialog.Filter = "Ingenious Data Files (*.ingeniousdata)|*.ingeniousdata";
            OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                data.Load(OpenFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("No data was loaded", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveAsNewButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.AddExtension = true;
            SaveFileDialog.DefaultExt = "ingeniousdata";
            SaveFileDialog.Filter = "Ingenious Data Files (*.ingeniousdata)|*.ingeniousdata";
            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var result = SaveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                data.Save(SaveFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("No data was loaded", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TechniquesButton_Click(object sender, EventArgs e)
        {
            var form = new TechniquesForm(this);
            Hide();
            form.ShowDialog();
        }

        private void CategoryTypesButton_Click(object sender, EventArgs e)
        {
            Hide();
            new CategoryForm().ShowDialog();
            Show();
        }
    }
}