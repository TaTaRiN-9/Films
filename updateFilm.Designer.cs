namespace Films
{
    partial class updateFilm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNameFilm = new System.Windows.Forms.TextBox();
            this.textCreationYear = new System.Windows.Forms.TextBox();
            this.buttonDeleteFilm = new System.Windows.Forms.Button();
            this.buttonUpdateFilm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.choiceStyle = new System.Windows.Forms.ComboBox();
            this.choiceDirectors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Изменение фильма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Название";
            // 
            // textNameFilm
            // 
            this.textNameFilm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameFilm.Location = new System.Drawing.Point(131, 60);
            this.textNameFilm.Name = "textNameFilm";
            this.textNameFilm.Size = new System.Drawing.Size(228, 26);
            this.textNameFilm.TabIndex = 10;
            // 
            // textCreationYear
            // 
            this.textCreationYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCreationYear.Location = new System.Drawing.Point(131, 110);
            this.textCreationYear.Name = "textCreationYear";
            this.textCreationYear.Size = new System.Drawing.Size(228, 26);
            this.textCreationYear.TabIndex = 11;
            // 
            // buttonDeleteFilm
            // 
            this.buttonDeleteFilm.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteFilm.Location = new System.Drawing.Point(44, 253);
            this.buttonDeleteFilm.Name = "buttonDeleteFilm";
            this.buttonDeleteFilm.Size = new System.Drawing.Size(125, 34);
            this.buttonDeleteFilm.TabIndex = 18;
            this.buttonDeleteFilm.Text = "Удалить";
            this.buttonDeleteFilm.UseVisualStyleBackColor = true;
            this.buttonDeleteFilm.Click += new System.EventHandler(this.buttonDeleteFilm_Click);
            // 
            // buttonUpdateFilm
            // 
            this.buttonUpdateFilm.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateFilm.Location = new System.Drawing.Point(214, 253);
            this.buttonUpdateFilm.Name = "buttonUpdateFilm";
            this.buttonUpdateFilm.Size = new System.Drawing.Size(125, 34);
            this.buttonUpdateFilm.TabIndex = 19;
            this.buttonUpdateFilm.Text = "Изменить";
            this.buttonUpdateFilm.UseVisualStyleBackColor = true;
            this.buttonUpdateFilm.Click += new System.EventHandler(this.buttonUpdateFilm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Год создания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Жанр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Режиссёр";
            // 
            // choiceStyle
            // 
            this.choiceStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choiceStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceStyle.FormattingEnabled = true;
            this.choiceStyle.Location = new System.Drawing.Point(132, 161);
            this.choiceStyle.Name = "choiceStyle";
            this.choiceStyle.Size = new System.Drawing.Size(186, 26);
            this.choiceStyle.TabIndex = 23;
            // 
            // choiceDirectors
            // 
            this.choiceDirectors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choiceDirectors.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceDirectors.FormattingEnabled = true;
            this.choiceDirectors.Location = new System.Drawing.Point(132, 209);
            this.choiceDirectors.Name = "choiceDirectors";
            this.choiceDirectors.Size = new System.Drawing.Size(186, 26);
            this.choiceDirectors.TabIndex = 24;
            // 
            // updateFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.choiceDirectors);
            this.Controls.Add(this.choiceStyle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdateFilm);
            this.Controls.Add(this.buttonDeleteFilm);
            this.Controls.Add(this.textCreationYear);
            this.Controls.Add(this.textNameFilm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "updateFilm";
            this.Text = "updateFilm";
            this.Load += new System.EventHandler(this.updateFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNameFilm;
        private System.Windows.Forms.TextBox textCreationYear;
        private System.Windows.Forms.Button buttonDeleteFilm;
        private System.Windows.Forms.Button buttonUpdateFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox choiceStyle;
        private System.Windows.Forms.ComboBox choiceDirectors;
    }
}