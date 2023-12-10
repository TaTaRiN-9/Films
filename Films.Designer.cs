namespace Films
{
    partial class Films
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsTable = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonUpdateFilm = new System.Windows.Forms.Button();
            this.addNewFilm = new System.Windows.Forms.Button();
            this.filmsData = new System.Windows.Forms.DataGridView();
            this.panelFilm = new System.Windows.Forms.Panel();
            this.lineSearch = new System.Windows.Forms.TextBox();
            this.buttonDeleteSearch = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelFilms = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.filmsTable.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsData)).BeginInit();
            this.panelFilm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // filmsTable
            // 
            this.filmsTable.AccessibleName = "Актеры";
            this.filmsTable.Controls.Add(this.tabPage1);
            this.filmsTable.Controls.Add(this.tabPage2);
            this.filmsTable.Location = new System.Drawing.Point(0, 27);
            this.filmsTable.Name = "filmsTable";
            this.filmsTable.SelectedIndex = 0;
            this.filmsTable.Size = new System.Drawing.Size(734, 489);
            this.filmsTable.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonUpdateFilm);
            this.tabPage1.Controls.Add(this.addNewFilm);
            this.tabPage1.Controls.Add(this.filmsData);
            this.tabPage1.Controls.Add(this.panelFilm);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фильмы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateFilm
            // 
            this.buttonUpdateFilm.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateFilm.Location = new System.Drawing.Point(518, 56);
            this.buttonUpdateFilm.Name = "buttonUpdateFilm";
            this.buttonUpdateFilm.Size = new System.Drawing.Size(181, 29);
            this.buttonUpdateFilm.TabIndex = 6;
            this.buttonUpdateFilm.Text = "Внести изменения";
            this.buttonUpdateFilm.UseVisualStyleBackColor = true;
            this.buttonUpdateFilm.Click += new System.EventHandler(this.buttonUpdateFilm_Click);
            // 
            // addNewFilm
            // 
            this.addNewFilm.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewFilm.Location = new System.Drawing.Point(37, 56);
            this.addNewFilm.Name = "addNewFilm";
            this.addNewFilm.Size = new System.Drawing.Size(181, 29);
            this.addNewFilm.TabIndex = 5;
            this.addNewFilm.Text = "Добавить фильм";
            this.addNewFilm.UseVisualStyleBackColor = true;
            this.addNewFilm.Click += new System.EventHandler(this.addNewFilmClick);
            // 
            // filmsData
            // 
            this.filmsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsData.Location = new System.Drawing.Point(0, 91);
            this.filmsData.Name = "filmsData";
            this.filmsData.RowTemplate.Height = 24;
            this.filmsData.Size = new System.Drawing.Size(726, 372);
            this.filmsData.TabIndex = 2;
            // 
            // panelFilm
            // 
            this.panelFilm.BackColor = System.Drawing.Color.DarkGray;
            this.panelFilm.Controls.Add(this.lineSearch);
            this.panelFilm.Controls.Add(this.buttonDeleteSearch);
            this.panelFilm.Controls.Add(this.buttonUpdate);
            this.panelFilm.Controls.Add(this.labelFilms);
            this.panelFilm.Location = new System.Drawing.Point(0, 0);
            this.panelFilm.Name = "panelFilm";
            this.panelFilm.Size = new System.Drawing.Size(726, 50);
            this.panelFilm.TabIndex = 1;
            // 
            // lineSearch
            // 
            this.lineSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineSearch.Location = new System.Drawing.Point(188, 13);
            this.lineSearch.Name = "lineSearch";
            this.lineSearch.Size = new System.Drawing.Size(222, 26);
            this.lineSearch.TabIndex = 4;
            // 
            // buttonDeleteSearch
            // 
            this.buttonDeleteSearch.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSearch.Location = new System.Drawing.Point(416, 10);
            this.buttonDeleteSearch.Name = "buttonDeleteSearch";
            this.buttonDeleteSearch.Size = new System.Drawing.Size(89, 29);
            this.buttonDeleteSearch.TabIndex = 3;
            this.buttonDeleteSearch.Text = "Стереть";
            this.buttonDeleteSearch.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(598, 10);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(101, 29);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelFilms
            // 
            this.labelFilms.AutoSize = true;
            this.labelFilms.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilms.Location = new System.Drawing.Point(33, 14);
            this.labelFilms.Name = "labelFilms";
            this.labelFilms.Size = new System.Drawing.Size(85, 23);
            this.labelFilms.TabIndex = 0;
            this.labelFilms.Text = "Фильмы";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Режиссёры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 50);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Стереть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(188, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Режиссеры";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(598, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Films
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 521);
            this.Controls.Add(this.filmsTable);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Films";
            this.Text = "Films";
            this.Load += new System.EventHandler(this.Films_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.filmsTable.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmsData)).EndInit();
            this.panelFilm.ResumeLayout(false);
            this.panelFilm.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl filmsTable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelFilm;
        private System.Windows.Forms.Label labelFilms;
        private System.Windows.Forms.TextBox lineSearch;
        private System.Windows.Forms.Button buttonDeleteSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView filmsData;
        private System.Windows.Forms.Button addNewFilm;
        private System.Windows.Forms.Button buttonUpdateFilm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}