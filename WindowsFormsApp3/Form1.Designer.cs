namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login_l = new System.Windows.Forms.Label();
            this.password_l = new System.Windows.Forms.Label();
            this.avtoriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(233)))), ((int)(((byte)(105)))));
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.SystemColors.InfoText;
            this.login.Location = new System.Drawing.Point(12, 48);
            this.login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login.Name = "login";
            this.login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login.Size = new System.Drawing.Size(350, 42);
            this.login.TabIndex = 0;
            this.login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(233)))), ((int)(((byte)(105)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.SystemColors.InfoText;
            this.password.Location = new System.Drawing.Point(12, 141);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password.Size = new System.Drawing.Size(350, 42);
            this.password.TabIndex = 1;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // login_l
            // 
            this.login_l.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_l.AutoSize = true;
            this.login_l.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_l.Location = new System.Drawing.Point(12, 14);
            this.login_l.Name = "login_l";
            this.login_l.Size = new System.Drawing.Size(88, 33);
            this.login_l.TabIndex = 2;
            this.login_l.Text = "Логин";
            // 
            // password_l
            // 
            this.password_l.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_l.AutoSize = true;
            this.password_l.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_l.Location = new System.Drawing.Point(12, 107);
            this.password_l.Name = "password_l";
            this.password_l.Size = new System.Drawing.Size(101, 33);
            this.password_l.TabIndex = 3;
            this.password_l.Text = "Пароль";
            // 
            // avtoriz
            // 
            this.avtoriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avtoriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.avtoriz.Cursor = System.Windows.Forms.Cursors.Default;
            this.avtoriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avtoriz.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avtoriz.Location = new System.Drawing.Point(12, 206);
            this.avtoriz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.avtoriz.Name = "avtoriz";
            this.avtoriz.Size = new System.Drawing.Size(349, 65);
            this.avtoriz.TabIndex = 4;
            this.avtoriz.Text = "Авторизация";
            this.avtoriz.UseMnemonic = false;
            this.avtoriz.UseVisualStyleBackColor = false;
            this.avtoriz.Click += new System.EventHandler(this.avtoriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(376, 284);
            this.Controls.Add(this.avtoriz);
            this.Controls.Add(this.password_l);
            this.Controls.Add(this.login_l);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label login_l;
        private System.Windows.Forms.Label password_l;
        private System.Windows.Forms.Button avtoriz;
    }
}

