namespace StarterDeck_DataCompiler
{
    partial class Engineers
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
            this.engineerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EngineerType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EngineerMajor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EngineersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EngineersDataGrid
            // 
            this.EngineersDataGrid.AutoGenerateColumns = false;
            this.EngineersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EngineersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EngineerType,
            this.EngineerMajor});
            this.EngineersDataGrid.DataSource = this.engineerBindingSource;
            this.EngineersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EngineersDataGrid.Location = new System.Drawing.Point(0, 0);
            this.EngineersDataGrid.Name = "EngineersDataGrid";
            this.EngineersDataGrid.RowTemplate.Height = 25;
            this.EngineersDataGrid.Size = new System.Drawing.Size(800, 450);
            this.EngineersDataGrid.TabIndex = 0;
            // 
            // engineerBindingSource
            // 
            this.engineerBindingSource.DataSource = typeof(StarterDeck_DataCompiler.Models.Engineer);
            // 
            // EngineerType
            // 
            this.EngineerType.HeaderText = "Type";
            this.EngineerType.Name = "EngineerType";
            this.EngineerType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EngineerType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EngineerType.ToolTipText = "The specific type of the engineer";
            // 
            // EngineerMajor
            // 
            this.EngineerMajor.HeaderText = "Major";
            this.EngineerMajor.Name = "EngineerMajor";
            this.EngineerMajor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EngineerMajor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EngineerMajor.ToolTipText = "How skilled the engineer is";
            // 
            // Engineers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EngineersDataGrid);
            this.Name = "Engineers";
            this.Text = "Engineers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Engineers_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.EngineersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView EngineersDataGrid;
        private BindingSource engineerBindingSource;
        private DataGridViewComboBoxColumn EngineerType;
        private DataGridViewComboBoxColumn EngineerMajor;
    }
}