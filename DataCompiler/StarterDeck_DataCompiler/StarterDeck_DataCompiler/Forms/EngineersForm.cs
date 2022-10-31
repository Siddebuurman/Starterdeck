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
            InitializeCollumns();
        }
        public EngineersForm(MainForm mainForm, List<Engineer> engineers)
        {
            main = mainForm;
            InitializeComponent();
            InitializeCollumns();
            foreach (var engineer in engineers)
            {
                var index = EngineersDataGrid.Rows.Add();
                EngineersDataGrid.Rows[index].Cells[0].Value = engineer.type;
                EngineersDataGrid.Rows[index].Cells[1].Value = engineer.major;
                EngineersDataGrid.Rows[index].Cells[2].Value = engineer.cost;
            }
        }

        private void InitializeCollumns()
        {
            EngineersDataGrid.DataSource = null;
            List<DataGridViewComboBoxColumn> items = new();
            foreach (dynamic column in EngineersDataGrid.Columns)
                if (column.HeaderText != "Cost")
                    items.Add(column as DataGridViewComboBoxColumn);

            foreach (var column in items)
            {
                string header = column.HeaderText;

                if (header == "Type")
                {
                    List<string> elements = new();
                    foreach (string type in TypeData.engineerTypes)
                        elements.Add(type);
                    column.DataSource = elements;
                }
                if (header == "Major")
                {
                    List<string> elements = new();
                    foreach (string type in TypeData.majorTypes)
                        elements.Add(type);
                    column.DataSource = elements;
                }
            }
        }

        private void Engineers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //only continue if the user presses the X button, so the entered data is saved. if windows orders it to close, the data is not saved
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            List<Engineer> engineers = new();
            foreach (DataGridViewRow row in EngineersDataGrid.Rows)
                if (!row.IsNewRow)
                {
                    List<string> values = new();
                    foreach (object cell in row.Cells)
                    {
                        if (cell is DataGridViewComboBoxCell comboCell)
                            values.Add(comboCell.Value?.ToString() ?? "Undefined");
                        if (cell is DataGridViewTextBoxCell textCell)
                            values.Add(textCell.EditedFormattedValue?.ToString() ?? "0");
                    }


                    if (!int.TryParse(values[2], out int cost))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Cost must be a number", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    engineers.Add(new() { type = values[0], major = values[1], cost = cost });
                }


            main.SubmitData(engineers);
        }
    }
}
