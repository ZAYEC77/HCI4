using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace HCI4
{
    public partial class Віка : Form //
    {
        protected static string etx = ".mrf";
        protected bool save = false;
        protected String filePath = "";
        public new Form1 Parent
        {
            get { return MdiParent as Form1; }
        }
        public Віка()
        {
            InitializeComponent();
        }

        public Віка(String filePath = "")
        {
            InitializeComponent();
            LoadFile(filePath);
        }

        protected void LoadFile(String filePath)
        {
            Text = Path.GetFileName(filePath);
            try
            {
                richTextBox.LoadFile(filePath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void SetFont()
        {
            fontDialog.ShowDialog();
            richTextBox.SelectionFont = fontDialog.Font; 
        }

        public void OpenFile()
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    filePath = openFileDialog.FileName;
                    LoadFile(filePath);
                    save = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void SaveFile()
        {
            if (File.Exists(filePath))
            {
                richTextBox.SaveFile(filePath);
                Text = Path.GetFileName(filePath);
                save = true;
            }
            else
            {
                SaveFileAs();
            }
        }

        private void SaveFileAs()
        {
            saveFileDialog.FileName = filePath;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                richTextBox.SaveFile(filePath);
                Text = Path.GetFileName(filePath);
                save = true;
            }
        }
        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void NewDoc()
        {
            richTextBox.Clear();
            Text = "Новий документ";
        }

        public void ShutDown()
        {
            if (!save)
            {
                if (MessageBox.Show("Зберегти файл?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveFile();
                }
            }
        }

        private void Віка_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShutDown();
        }

        private void відкритиТутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateStatus();
            save = false;
        }

        internal bool IsSaved()
        {
            return this.save;
        }

        public int GetCurrentLine()
        {
            return richTextBox.GetLineFromCharIndex(richTextBox.SelectionStart) + 1;
        }

        protected void UpdateStatus()
        {
            Parent.UpdateStatusBar();
        }

        public int GetCurrentColumn()
        {
            return richTextBox.SelectionStart - richTextBox.GetFirstCharIndexOfCurrentLine();
        }

        private void richTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateStatus();
        }

        private void Віка_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.UpdateStatusBar();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFont();
        }

        private void колірToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColor();
        }

        public void SetColor()
        {
            colorDialog.ShowDialog();
            richTextBox.SelectionColor = colorDialog.Color;
        }

        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateStatus();
        }

        private void закритиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Redo()
        {
            if (richTextBox.CanRedo)
            {
                richTextBox.Redo();
            }
        }

        public void Undo()
        {
            if (richTextBox.CanUndo)
            {
                richTextBox.Undo();
            }
        }

        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        public void Copy()
        {
            richTextBox.Copy();
        }

        public void Paste()
        {
            richTextBox.Paste();
        }

        public void Cut()
        {
            richTextBox.Cut();
        }

        private void вирізатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void тудаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void сюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void друкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }


        public void Print()
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
				printDocument1.Print();
		}
        private int checkPrint;
        
		private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{
			checkPrint = 0;
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			
            checkPrint = richTextBox.Print(checkPrint, richTextBox.TextLength, e);

            if (checkPrint < richTextBox.TextLength)
				e.HasMorePages = true;
			else
				e.HasMorePages = false;
		}
             
    }
}
