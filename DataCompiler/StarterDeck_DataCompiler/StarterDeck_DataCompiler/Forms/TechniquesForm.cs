using StarterDeck_DataCompiler.Models;
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
    /*
     TRAITS:
        MUST HAVE:
            traits zijn integers
            traits zijn voor elke category anders
        COULD HAVE:
            meerdere traits kunnen toevoegen per categorie
            namen van traits per categorie kunnen veranderen
     */


    public partial class TechniquesForm : Form
    {
        private MainForm main;
        public TechniquesForm(MainForm main)
        {
            this.main = main;
            InitializeComponent();

            TechniquesGridView.CellValueChanged += TechniquesGridView_CellValueChanged;

            var grid = TechniquesGridView;

            foreach(DataGridViewRow row in grid.Rows)
            {
                if(row.Index == 0)
                {
                    DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)TechniquesGridView.Columns[0];
                    column.DataSource = TypeData.categoryTypes;
                }
            }
        }

        private void TechniquesGridView_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;
    
            string? selectedCategory = (string)TechniquesGridView.Rows[0].Cells[0].Value;
            foreach (var trait in TypeData.traits.Where(x => x.boundCategory == selectedCategory))
            {

            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TechniquesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Technique> techniques = new List<Technique>();
            main.SubmitData(techniques);
        }
    }
}
