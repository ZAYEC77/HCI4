using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI4
{
    public partial class Form1 : Form
    {
        protected List<Віка> windows = new List<Віка>();
        protected Віка Selected
        {
            get { return ActiveMdiChild as Віка; }
        }

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            UpdateStatusBar();
            MdiChildActivate += new EventHandler(changeActiveChild);
        }
        
        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewWindow();
        }

        private void AddNewWindow()
        {
            Віка f = new Віка();
            f.MdiParent = this;
            f.Show();
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            AddNewWindow();
            Selected.OpenFile();
        }

        public void UpdateStatusBar()
        {
            String line = "";
            String column = "";
            String save = "";
            if (this.Selected != null)
            {
                save = Selected.IsSaved() ? "Save" : "Unsave";
                line = "Line " + Selected.GetCurrentLine();
                column = "Column " + Selected.GetCurrentColumn();
            }
            toolStripStatusLine.Text = line;
            toolStripStatusColumn.Text = column;
            toolStripStatusSave.Text = save;
        }

        protected void changeActiveChild(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            if (Selected != null)
                Selected.SaveFile();
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void горизонтальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void вертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selected.SetFont();
        }

        private void колірToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selected.SetColor();
        }

        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selected.Copy();
        }

        private void вирізатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selected.Cut();
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selected.Paste();
        }
    }
}
