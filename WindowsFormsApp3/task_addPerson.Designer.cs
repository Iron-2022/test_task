namespace WindowsFormsApp3
{
    partial class task_addPerson
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
            this.person_cb = new System.Windows.Forms.ComboBox();
            this.project_cb = new System.Windows.Forms.ComboBox();
            this.task_cb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Персона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Задача";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Проект";
            // 
            // person_cb
            // 
            this.person_cb.FormattingEnabled = true;
            this.person_cb.Location = new System.Drawing.Point(174, 18);
            this.person_cb.Name = "person_cb";
            this.person_cb.Size = new System.Drawing.Size(234, 39);
            this.person_cb.TabIndex = 3;
            // 
            // project_cb
            // 
            this.project_cb.FormattingEnabled = true;
            this.project_cb.Location = new System.Drawing.Point(174, 70);
            this.project_cb.Name = "project_cb";
            this.project_cb.Size = new System.Drawing.Size(234, 39);
            this.project_cb.TabIndex = 4;
            this.project_cb.Click += new System.EventHandler(this.project_cb_Click);
            // 
            // task_cb
            // 
            this.task_cb.FormattingEnabled = true;
            this.task_cb.Location = new System.Drawing.Point(174, 125);
            this.task_cb.Name = "task_cb";
            this.task_cb.Size = new System.Drawing.Size(234, 39);
            this.task_cb.TabIndex = 5;
            this.task_cb.Click += new System.EventHandler(this.task_cb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Назначить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // task_addPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.task_cb);
            this.Controls.Add(this.project_cb);
            this.Controls.Add(this.person_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "task_addPerson";
            this.Text = "Назначить задачу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.task_addPerson_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.task_addPerson_FormClosed);
            this.Load += new System.EventHandler(this.task_addPerson_Load);
            this.Shown += new System.EventHandler(this.task_addPerson_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox person_cb;
        private System.Windows.Forms.ComboBox project_cb;
        private System.Windows.Forms.ComboBox task_cb;
        private System.Windows.Forms.Button button1;
    }
}