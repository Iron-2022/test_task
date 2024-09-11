namespace WindowsFormsApp3
{
    partial class person
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.role_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(160, 34);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(155, 38);
            this.name_tb.TabIndex = 3;
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(160, 78);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(155, 38);
            this.login_tb.TabIndex = 4;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(160, 122);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(155, 38);
            this.password_tb.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Роль";
            // 
            // role_cb
            // 
            this.role_cb.FormattingEnabled = true;
            this.role_cb.Location = new System.Drawing.Point(160, 166);
            this.role_cb.Name = "role_cb";
            this.role_cb.Size = new System.Drawing.Size(155, 39);
            this.role_cb.TabIndex = 8;
            // 
            // person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 355);
            this.Controls.Add(this.role_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "person";
            this.Text = "Персона";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.person_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.person_FormClosed);
            this.Load += new System.EventHandler(this.person_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox role_cb;
    }
}