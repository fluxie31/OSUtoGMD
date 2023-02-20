namespace OSUtoGMD {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.TextBoxSelectedFile = new System.Windows.Forms.TextBox();
			this.BtnSelectFile = new System.Windows.Forms.Button();
			this.LabelLevelName = new System.Windows.Forms.Label();
			this.TextBoxLevelName = new System.Windows.Forms.TextBox();
			this.ButtonSubmit = new System.Windows.Forms.Button();
			this.FormOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.NumberNGID = new System.Windows.Forms.NumericUpDown();
			this.LabelNGID = new System.Windows.Forms.Label();
			this.FormSaveFile = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.NumberNGID)).BeginInit();
			this.SuspendLayout();
			// 
			// TextBoxSelectedFile
			// 
			this.TextBoxSelectedFile.Location = new System.Drawing.Point(12, 12);
			this.TextBoxSelectedFile.Name = "TextBoxSelectedFile";
			this.TextBoxSelectedFile.PlaceholderText = "Please select a file.";
			this.TextBoxSelectedFile.Size = new System.Drawing.Size(195, 23);
			this.TextBoxSelectedFile.TabIndex = 0;
			// 
			// BtnSelectFile
			// 
			this.BtnSelectFile.Location = new System.Drawing.Point(213, 11);
			this.BtnSelectFile.Name = "BtnSelectFile";
			this.BtnSelectFile.Size = new System.Drawing.Size(75, 24);
			this.BtnSelectFile.TabIndex = 1;
			this.BtnSelectFile.Text = "Select File";
			this.BtnSelectFile.UseVisualStyleBackColor = true;
			this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
			// 
			// LabelLevelName
			// 
			this.LabelLevelName.AutoSize = true;
			this.LabelLevelName.Location = new System.Drawing.Point(12, 38);
			this.LabelLevelName.Name = "LabelLevelName";
			this.LabelLevelName.Size = new System.Drawing.Size(151, 15);
			this.LabelLevelName.TabIndex = 2;
			this.LabelLevelName.Text = "Enter a name for your level:";
			// 
			// TextBoxLevelName
			// 
			this.TextBoxLevelName.Location = new System.Drawing.Point(12, 56);
			this.TextBoxLevelName.MaxLength = 20;
			this.TextBoxLevelName.Name = "TextBoxLevelName";
			this.TextBoxLevelName.PlaceholderText = "Unnamed 0";
			this.TextBoxLevelName.Size = new System.Drawing.Size(275, 23);
			this.TextBoxLevelName.TabIndex = 3;
			// 
			// ButtonSubmit
			// 
			this.ButtonSubmit.Location = new System.Drawing.Point(12, 114);
			this.ButtonSubmit.Name = "ButtonSubmit";
			this.ButtonSubmit.Size = new System.Drawing.Size(275, 23);
			this.ButtonSubmit.TabIndex = 6;
			this.ButtonSubmit.Text = "Process and Convert";
			this.ButtonSubmit.UseVisualStyleBackColor = true;
			this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
			// 
			// FormOpenFile
			// 
			this.FormOpenFile.FileName = "openFileDialog1";
			this.FormOpenFile.Filter = "osu! beatmaps|*.osu";
			// 
			// NumberNGID
			// 
			this.NumberNGID.Location = new System.Drawing.Point(153, 85);
			this.NumberNGID.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.NumberNGID.Name = "NumberNGID";
			this.NumberNGID.Size = new System.Drawing.Size(135, 23);
			this.NumberNGID.TabIndex = 5;
			// 
			// LabelNGID
			// 
			this.LabelNGID.AutoSize = true;
			this.LabelNGID.Location = new System.Drawing.Point(12, 87);
			this.LabelNGID.Name = "LabelNGID";
			this.LabelNGID.Size = new System.Drawing.Size(135, 15);
			this.LabelNGID.TabIndex = 7;
			this.LabelNGID.Text = "Select a Newgrounds ID:";
			// 
			// FormSaveFile
			// 
			this.FormSaveFile.Filter = "GMDShare Levels|*.gmd";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 150);
			this.Controls.Add(this.LabelNGID);
			this.Controls.Add(this.NumberNGID);
			this.Controls.Add(this.ButtonSubmit);
			this.Controls.Add(this.TextBoxLevelName);
			this.Controls.Add(this.LabelLevelName);
			this.Controls.Add(this.BtnSelectFile);
			this.Controls.Add(this.TextBoxSelectedFile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.Name = "Form1";
			this.Text = "OSUtoGMD";
			((System.ComponentModel.ISupportInitialize)(this.NumberNGID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox TextBoxSelectedFile;
		private Button BtnSelectFile;
		private Label LabelLevelName;
		private TextBox TextBoxLevelName;
		private Button ButtonSubmit;
		private OpenFileDialog FormOpenFile;
		private NumericUpDown NumberNGID;
		private Label LabelNGID;
		private SaveFileDialog FormSaveFile;
	}
}