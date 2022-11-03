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

namespace StarterDeck_DataCompiler.Forms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        public void InitializeDataGrid()
        {
            foreach (string cat in TypeData.categoryTypes)
            {
                CategoryGridView.Rows.Add(cat);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TypeData.categoryTypes.Clear();
            foreach(DataGridViewRow row in CategoryGridView.Rows)
            {
                string value = (string)row.Cells[0].EditedFormattedValue;
                if (string.IsNullOrWhiteSpace(value))
                    continue;

                TypeData.categoryTypes.Add(value);
            }
        }
    }
}
