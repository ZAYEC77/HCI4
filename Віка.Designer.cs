namespace HCI4
{
    partial class Віка
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
            this.richTextBox = new HCI4.MyRichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.новийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиТутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.копіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колірToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.закритиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.тудаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.друкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(284, 262);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox_MouseClick);
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийToolStripMenuItem,
            this.відкритиТутToolStripMenuItem,
            this.toolStripSeparator1,
            this.копіюватиToolStripMenuItem,
            this.вирізатиToolStripMenuItem,
            this.вставитиToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.колірToolStripMenuItem,
            this.toolStripSeparator2,
            this.закритиToolStripMenuItem1,
            this.тудаToolStripMenuItem,
            this.сюдаToolStripMenuItem,
            this.друкToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 258);
            // 
            // новийToolStripMenuItem
            // 
            this.новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            this.новийToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.новийToolStripMenuItem.Text = "Новий";
            this.новийToolStripMenuItem.Click += new System.EventHandler(this.новийToolStripMenuItem_Click);
            // 
            // відкритиТутToolStripMenuItem
            // 
            this.відкритиТутToolStripMenuItem.Name = "відкритиТутToolStripMenuItem";
            this.відкритиТутToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.відкритиТутToolStripMenuItem.Text = "Відкрити тут";
            this.відкритиТутToolStripMenuItem.Click += new System.EventHandler(this.відкритиТутToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // копіюватиToolStripMenuItem
            // 
            this.копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            this.копіюватиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.копіюватиToolStripMenuItem.Text = "Копіювати";
            this.копіюватиToolStripMenuItem.Click += new System.EventHandler(this.копіюватиToolStripMenuItem_Click);
            // 
            // вирізатиToolStripMenuItem
            // 
            this.вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            this.вирізатиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.вирізатиToolStripMenuItem.Text = "Вирізати";
            this.вирізатиToolStripMenuItem.Click += new System.EventHandler(this.вирізатиToolStripMenuItem_Click);
            // 
            // вставитиToolStripMenuItem
            // 
            this.вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            this.вставитиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.вставитиToolStripMenuItem.Text = "Вставити";
            this.вставитиToolStripMenuItem.Click += new System.EventHandler(this.вставитиToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // колірToolStripMenuItem
            // 
            this.колірToolStripMenuItem.Name = "колірToolStripMenuItem";
            this.колірToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.колірToolStripMenuItem.Text = "Колір";
            this.колірToolStripMenuItem.Click += new System.EventHandler(this.колірToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // закритиToolStripMenuItem1
            // 
            this.закритиToolStripMenuItem1.Name = "закритиToolStripMenuItem1";
            this.закритиToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.закритиToolStripMenuItem1.Text = "Закрити";
            this.закритиToolStripMenuItem1.Click += new System.EventHandler(this.закритиToolStripMenuItem1_Click);
            // 
            // тудаToolStripMenuItem
            // 
            this.тудаToolStripMenuItem.Name = "тудаToolStripMenuItem";
            this.тудаToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.тудаToolStripMenuItem.Text = "<- Туди";
            this.тудаToolStripMenuItem.Click += new System.EventHandler(this.тудаToolStripMenuItem_Click);
            // 
            // сюдаToolStripMenuItem
            // 
            this.сюдаToolStripMenuItem.Name = "сюдаToolStripMenuItem";
            this.сюдаToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.сюдаToolStripMenuItem.Text = "Сюди ->";
            this.сюдаToolStripMenuItem.Click += new System.EventHandler(this.сюдаToolStripMenuItem_Click);
            // 
            // друкToolStripMenuItem
            // 
            this.друкToolStripMenuItem.Name = "друкToolStripMenuItem";
            this.друкToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.друкToolStripMenuItem.Text = "Друк";
            this.друкToolStripMenuItem.Click += new System.EventHandler(this.друкToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "My format|*.mrf";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "My format|*.mrf";
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Віка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richTextBox);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Віка";
            this.Text = "Новий документ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Віка_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Віка_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyRichTextBox richTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новийToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem відкритиТутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem колірToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem закритиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тудаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem друкToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}