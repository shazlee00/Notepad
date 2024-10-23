namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        string _filePath;

        public Form1()
        {
            InitializeComponent();

            _filePath = null;

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (_filePath == null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }
            }
            else
            {
                richTextBox1.SaveFile(_filePath);

            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.ShowDialog();
                _filePath = openFileDialog1.FileName;
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);

                _filePath = null;

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (MessageBox.Show("Do you want to save changes?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
                else
                {
                    _filePath = null;
                    richTextBox1.Text = "";
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText != "")
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }
                else
                {
                    richTextBox1.Font = fontDialog1.Font;
                }




            }


        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                if (richTextBox1.SelectedText != "")
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.ForeColor = colorDialog1.Color;
                }
            }
        }

        private void backgroudColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText != "")
                {
                    richTextBox1.SelectionBackColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.BackColor = colorDialog1.Color;
                }
            }
        }
    }
}
