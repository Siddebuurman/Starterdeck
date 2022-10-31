using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarterDeck_DataCompiler
{
    public partial class Engineers : Form
    {
        private MainForm main;
        public Engineers(MainForm mainForm)
        {
            main = mainForm;
            InitializeComponent();

            foreach (DataGridViewComboBoxColumn column in EngineersDataGrid.Columns)
            {
                string header = column.HeaderText;

                if(header == "Type")
                {
                    List<Models.EngineerType> types = new();
                    foreach(Models.EngineerType type in Enum.GetValues(typeof(Models.EngineerType)))
                        types.Add(type);
                    column.DataSource = types;
                }
                if(header == "Major")
                {
                    List<Models.MajorType> types = new();
                    foreach (Models.MajorType type in Enum.GetValues(typeof(Models.MajorType)))
                        types.Add(type);
                    column.DataSource = types;
                }
            }
        }

        private void Engineers_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataGridViewComboBoxColumn column in EngineersDataGrid.Columns)
            {
                string header = column.HeaderText;

                foreach (string entry in column.Items)
                {
                    
                }
            }

            main.Show();
        }
    }
}
