namespace StarterDeck_DataCompiler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TechniquesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveAsNewButton = new System.Windows.Forms.Button();
            this.LoadExistingButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.EngineerTypesButton = new System.Windows.Forms.Button();
            this.CategoryTypesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "General";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Scenarios";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TechniquesButton
            // 
            this.TechniquesButton.Location = new System.Drawing.Point(12, 41);
            this.TechniquesButton.Name = "TechniquesButton";
            this.TechniquesButton.Size = new System.Drawing.Size(75, 23);
            this.TechniquesButton.TabIndex = 5;
            this.TechniquesButton.Text = "Techniques";
            this.TechniquesButton.UseVisualStyleBackColor = true;
            this.TechniquesButton.Click += new System.EventHandler(this.TechniquesButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Engineers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EngineersButton_OnClick);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "Open Data File";
            // 
            // SaveAsNewButton
            // 
            this.SaveAsNewButton.Location = new System.Drawing.Point(402, 12);
            this.SaveAsNewButton.Name = "SaveAsNewButton";
            this.SaveAsNewButton.Size = new System.Drawing.Size(95, 23);
            this.SaveAsNewButton.TabIndex = 8;
            this.SaveAsNewButton.Text = "Save as new";
            this.SaveAsNewButton.UseVisualStyleBackColor = true;
            this.SaveAsNewButton.Click += new System.EventHandler(this.SaveAsNewButton_Click);
            // 
            // LoadExistingButton
            // 
            this.LoadExistingButton.Location = new System.Drawing.Point(402, 41);
            this.LoadExistingButton.Name = "LoadExistingButton";
            this.LoadExistingButton.Size = new System.Drawing.Size(95, 23);
            this.LoadExistingButton.TabIndex = 9;
            this.LoadExistingButton.Text = "Load Existing";
            this.LoadExistingButton.UseVisualStyleBackColor = true;
            this.LoadExistingButton.Click += new System.EventHandler(this.LoadExistingButton_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileName = "Select Save Location";
            this.SaveFileDialog.Title = "Save-File Location";
            // 
            // EngineerTypesButton
            // 
            this.EngineerTypesButton.Location = new System.Drawing.Point(163, 12);
            this.EngineerTypesButton.Name = "EngineerTypesButton";
            this.EngineerTypesButton.Size = new System.Drawing.Size(108, 23);
            this.EngineerTypesButton.TabIndex = 10;
            this.EngineerTypesButton.Text = "Engineers Types";
            this.EngineerTypesButton.UseVisualStyleBackColor = true;
            this.EngineerTypesButton.Click += new System.EventHandler(this.EngineerTypesButton_Click);
            // 
            // CategoryTypesButton
            // 
            this.CategoryTypesButton.Location = new System.Drawing.Point(163, 41);
            this.CategoryTypesButton.Name = "CategoryTypesButton";
            this.CategoryTypesButton.Size = new System.Drawing.Size(108, 23);
            this.CategoryTypesButton.TabIndex = 11;
            this.CategoryTypesButton.Text = "Category Types";
            this.CategoryTypesButton.UseVisualStyleBackColor = true;
            this.CategoryTypesButton.Click += new System.EventHandler(this.CategoryTypesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 213);
            this.Controls.Add(this.CategoryTypesButton);
            this.Controls.Add(this.EngineerTypesButton);
            this.Controls.Add(this.LoadExistingButton);
            this.Controls.Add(this.SaveAsNewButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TechniquesButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Compiler - Main";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button4;
        private Button button3;
        private Button TechniquesButton;
        private Button button1;
        internal ErrorProvider ErrorProvider;
        private Button LoadExistingButton;
        private Button SaveAsNewButton;
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
        private Button EngineerTypesButton;
        private Button CategoryTypesButton;
    }
}