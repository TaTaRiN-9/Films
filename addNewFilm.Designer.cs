namespace Films
{
    partial class addNewFilm
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
            this.addFilm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNameFilm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCreationYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.choiceStyle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.choiceDirectors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addFilm
            // 
            this.addFilm.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFilm.Location = new System.Drawing.Point(112, 285);
            this.addFilm.Name = "addFilm";
            this.addFilm.Size = new System.Drawing.Size(175, 34);
            this.addFilm.TabIndex = 0;
            this.addFilm.Text = "Добавить фильм";
            this.addFilm.UseVisualStyleBackColor = true;
            this.addFilm.Click += new System.EventHandler(this.addFilm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добавление нового фильма";
            // 
            // textNameFilm
            // 
            this.textNameFilm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameFilm.Location = new System.Drawing.Point(127, 69);
            this.textNameFilm.Name = "textNameFilm";
            this.textNameFilm.Size = new System.Drawing.Size(228, 26);
            this.textNameFilm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год создания";
            // 
            // textCreationYear
            // 
            this.textCreationYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCreationYear.Location = new System.Drawing.Point(127, 122);
            this.textCreationYear.Name = "textCreationYear";
            this.textCreationYear.Size = new System.Drawing.Size(228, 26);
            this.textCreationYear.TabIndex = 5;
            this.textCreationYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCreationYear_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Жанр";
            // 
            // choiceStyle
            // 
            this.choiceStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choiceStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceStyle.FormattingEnabled = true;
            this.choiceStyle.Location = new System.Drawing.Point(127, 175);
            this.choiceStyle.Name = "choiceStyle";
            this.choiceStyle.Size = new System.Drawing.Size(186, 26);
            this.choiceStyle.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Режиссёр";
            // 
            // choiceDirectors
            // 
            this.choiceDirectors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choiceDirectors.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceDirectors.FormattingEnabled = true;
            this.choiceDirectors.Location = new System.Drawing.Point(127, 226);
            this.choiceDirectors.Name = "choiceDirectors";
            this.choiceDirectors.Size = new System.Drawing.Size(186, 26);
            this.choiceDirectors.TabIndex = 9;
            // 
            // addNewFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.choiceDirectors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.choiceStyle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCreationYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNameFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addNewFilm";
            this.Text = "addNewFilm";
            this.Load += new System.EventHandler(this.addNewFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNameFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCreationYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox choiceStyle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox choiceDirectors;
    }
}