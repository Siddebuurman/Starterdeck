namespace StarterDeck_DataCompiler.Forms
{
    partial class EngineerTypeForm
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
            this.EnginnerTypeGridView = new System.Windows.Forms.DataGridView();
            this.EngineerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.EnginnerTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EnginnerTypeGridView
            // 
            this.EnginnerTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnginnerTypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EngineerType});
            this.EnginnerTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnginnerTypeGridView.Location = new System.Drawing.Point(0, 0);
            this.EnginnerTypeGridView.Name = "EnginnerTypeGridView";
            this.EnginnerTypeGridView.RowTemplate.Height = 25;
            this.EnginnerTypeGridView.Size = new System.Drawing.Size(448, 532);
            this.EnginnerTypeGridView.TabIndex = 0;
            // 
            // EngineerType
            // 
            this.EngineerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EngineerType.HeaderText = "Engineer Type";
            this.EngineerType.Name = "EngineerType";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(429, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 532);
            this.vScrollBar1.TabIndex = 1;
            // 
            // EngineerTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 532);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.EnginnerTypeGridView);
            this.Name = "EngineerTypeForm";
            this.Text = "EngineerTypeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EngineerTypeForm_FormClosing);
            this.Load += new System.EventHandler(this.EngineerTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnginnerTypeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView EnginnerTypeGridView;
        private VScrollBar vScrollBar1;
        private DataGridViewTextBoxColumn EngineerType;
    }
}