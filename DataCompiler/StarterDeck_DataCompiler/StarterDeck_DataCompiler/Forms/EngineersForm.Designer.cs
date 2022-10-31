namespace StarterDeck_DataCompiler
{
    partial class EngineersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EngineersDataGrid = new System.Windows.Forms.DataGridView();
            this.EngineerType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EngineerMajor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EngineersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineerBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EngineersDataGrid
            // 
            this.EngineersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EngineersDataGrid.AutoGenerateColumns = false;
            this.EngineersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EngineersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EngineerType,
            this.EngineerMajor,
            this.Cost});
            this.EngineersDataGrid.DataSource = this.engineerBindingSource;
            this.EngineersDataGrid.Location = new System.Drawing.Point(3, 3);
            this.EngineersDataGrid.Name = "EngineersDataGrid";
            this.EngineersDataGrid.RowTemplate.Height = 25;
            this.EngineersDataGrid.Size = new System.Drawing.Size(770, 390);
            this.EngineersDataGrid.TabIndex = 0;
            // 
            // EngineerType
            // 
            this.EngineerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EngineerType.HeaderText = "Type";
            this.EngineerType.Name = "EngineerType";
            this.EngineerType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EngineerType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EngineerType.ToolTipText = "The specific type of the engineer";
            // 
            // EngineerMajor
            // 
            this.EngineerMajor.HeaderText = "Major";
            this.EngineerMajor.MaxDropDownItems = 100;
            this.EngineerMajor.Name = "EngineerMajor";
            this.EngineerMajor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EngineerMajor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EngineerMajor.ToolTipText = "How skilled the engineer is";
            this.EngineerMajor.Width = 120;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cost.ToolTipText = "The cost of this Engineer";
            this.Cost.Width = 120;
            // 
            // engineerBindingSource
            // 
            this.engineerBindingSource.DataSource = typeof(StarterDeck_DataCompiler.Models.Engineer);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SubmitButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.EngineersDataGrid);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(3, 399);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(770, 24);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // EngineersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EngineersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Engineers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Engineers_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.EngineersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineerBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView EngineersDataGrid;
        private BindingSource engineerBindingSource;
        private DataGridViewComboBoxColumn EngineerType;
        private DataGridViewComboBoxColumn EngineerMajor;
        private DataGridViewTextBoxColumn Cost;
        private TableLayoutPanel tableLayoutPanel1;
        private Button SubmitButton;
    }
}