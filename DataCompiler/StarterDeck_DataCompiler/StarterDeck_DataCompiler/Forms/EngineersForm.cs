using StarterDeck_DataCompiler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarterDeck_DataCompiler
{
    public partial class EngineersForm : Form
    {
        private MainForm main;
        public EngineersForm(MainForm mainForm)
        {
            main = mainForm;
            InitializeComponent();

            foreach (DataGridViewComboBoxColumn column in EngineersDataGrid.Columns)
            {
                string header = column.HeaderText;

                if(header == "Type")
                {
                    List<string> items = new();
                    foreach (string type in TypeData.engineerTypes)
                        items.Add(type);
                    column.DataSource = items;
                }
                if(header == "Major")
                {
                    List<string> items = new();
                    foreach (string type in TypeData.majorTypes)
                        items.Add(type);
                    column.DataSource = items;
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
