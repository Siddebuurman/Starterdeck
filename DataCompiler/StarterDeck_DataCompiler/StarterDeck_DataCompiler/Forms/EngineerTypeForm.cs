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
    public partial class EngineerTypeForm : Form
    {
        public EngineerTypeForm()
        {
            InitializeComponent();
        }

        private void EngineerTypeForm_Load(object sender, EventArgs e)
        {
            foreach (string type in TypeData.engineerTypes)
                EnginnerTypeGridView.Rows.Add(type);
        }

        private void EngineerTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> types = new();

            foreach (DataGridViewRow row in EnginnerTypeGridView.Rows)
            {
                if (!string.IsNullOrWhiteSpace((string)row.Cells[0].EditedFormattedValue))
                    types.Add(row.Cells[0].EditedFormattedValue.ToString());
            }

            TypeData.engineerTypes.Clear();
            foreach(string type in types)
            {
                TypeData.engineerTypes.Add(type);
            }
        }
    }
}
