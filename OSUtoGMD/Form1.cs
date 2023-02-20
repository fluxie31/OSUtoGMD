using System.Windows.Forms;

namespace OSUtoGMD {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void BtnSelectFile_Click(object sender, EventArgs e) {
			if (FormOpenFile.ShowDialog() == DialogResult.OK) {
				TextBoxSelectedFile.Text = FormOpenFile.FileName;
			}
		}

		private void ButtonSubmit_Click(object sender, EventArgs e) {
			if (TextBoxLevelName.Text.Length == 0) {
				TextBoxLevelName.Text = "Unnamed 0";
			}
			FormSaveFile.FileName = TextBoxLevelName.Text + ".gmd";
			if (FormSaveFile.ShowDialog() == DialogResult.OK) {
				Enabled = false;
			}

			string OSUFilePath = TextBoxSelectedFile.Text;
			string LevelName = TextBoxLevelName.Text;
			int SongID = (int)NumberNGID.Value;

			try {
				GMDBuilder gmdb = new GMDBuilder(OSUFilePath, LevelName, SongID);
				if (gmdb.ProcessOSUFile()) {
					File.WriteAllText(FormSaveFile.FileName, gmdb.GMDFile());
					MessageBox.Show("Success.");
					Enabled = true;
				} else {
					throw new Exception("An error occured.");
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "HOLY FUCKING BINGLE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Enabled = true;
			}
		}
	}
}