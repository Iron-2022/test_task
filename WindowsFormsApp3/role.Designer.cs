namespace WindowsFormsApp3
{
    partial class role
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(298, 36);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Создавать персоны";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(295, 36);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Создавать проекты";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 139);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(277, 36);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Создавать задачи";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 181);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(277, 36);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Назначать задачи";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(148, 6);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(162, 38);
            this.name_tb.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(12, 223);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(342, 36);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Управление бюджетом";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 331);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "role";
            this.Text = "Создание роли";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.role_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.role_FormClosed);
            this.Load += new System.EventHandler(this.role_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}