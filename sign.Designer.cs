namespace Films
{
    partial class sign
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
            this.signUpButton = new System.Windows.Forms.Button();
            this.emailUserAcc = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.ExistUser = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(186, 362);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(190, 35);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Зарегистрироваться";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailUserAcc
            // 
            this.emailUserAcc.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailUserAcc.Location = new System.Drawing.Point(223, 166);
            this.emailUserAcc.Name = "emailUserAcc";
            this.emailUserAcc.Size = new System.Drawing.Size(265, 27);
            this.emailUserAcc.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(223, 233);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(265, 27);
            this.pass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Подтвердите пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmPass
            // 
            this.confirmPass.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass.Location = new System.Drawing.Point(223, 300);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(265, 27);
            this.confirmPass.TabIndex = 6;
            // 
            // ExistUser
            // 
            this.ExistUser.AutoSize = true;
            this.ExistUser.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistUser.Location = new System.Drawing.Point(226, 427);
            this.ExistUser.Name = "ExistUser";
            this.ExistUser.Size = new System.Drawing.Size(118, 17);
            this.ExistUser.TabIndex = 7;
            this.ExistUser.TabStop = true;
            this.ExistUser.Text = "Уже есть аккаунт?";
            this.ExistUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExistUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Регистрация";
            // 
            // sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 543);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExistUser);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.emailUserAcc);
            this.Controls.Add(this.signUpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "sign";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.sign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox emailUserAcc;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.LinkLabel ExistUser;
        private System.Windows.Forms.Label label5;
    }
}