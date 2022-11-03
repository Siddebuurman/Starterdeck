namespace StarterDeck_DataCompiler
{
    partial class TechniquesForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TechniquesGridView = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhaseSelection1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PhaseSelection2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PhaseSelection3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PhaseSelection4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechniquesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.TechniquesGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SubmitButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1232, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TechniquesGridView
            // 
            this.TechniquesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TechniquesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Name,
            this.PhaseSelection1,
            this.PhaseSelection2,
            this.PhaseSelection3,
            this.PhaseSelection4,
            this.Cost});
            this.TechniquesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TechniquesGridView.Location = new System.Drawing.Point(3, 3);
            this.TechniquesGridView.Name = "TechniquesGridView";
            this.TechniquesGridView.RowTemplate.Height = 25;
            this.TechniquesGridView.Size = new System.Drawing.Size(1226, 390);
            this.TechniquesGridView.TabIndex = 0;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.Width = 200;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.FillWeight = 200F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // PhaseSelection1
            // 
            this.PhaseSelection1.HeaderText = "Concept Development Phase";
            this.PhaseSelection1.Name = "PhaseSelection1";
            // 
            // PhaseSelection2
            // 
            this.PhaseSelection2.HeaderText = "System Design Phase";
            this.PhaseSelection2.Name = "PhaseSelection2";
            // 
            // PhaseSelection3
            // 
            this.PhaseSelection3.HeaderText = "Detail Design Phase";
            this.PhaseSelection3.Name = "PhaseSelection3";
            // 
            // PhaseSelection4
            // 
            this.PhaseSelection4.HeaderText = "Integration and Validation Phase";
            this.PhaseSelection4.Name = "PhaseSelection4";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(3, 399);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(1226, 24);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // TechniquesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Techniques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TechniquesForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TechniquesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView TechniquesGridView;
        private DataGridViewComboBoxColumn Category;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewCheckBoxColumn PhaseSelection1;
        private DataGridViewCheckBoxColumn PhaseSelection2;
        private DataGridViewCheckBoxColumn PhaseSelection3;
        private DataGridViewCheckBoxColumn PhaseSelection4;
        private DataGridViewTextBoxColumn Cost;
        private Button SubmitButton;
    }
}