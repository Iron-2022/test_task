namespace WindowsFormsApp3
{
    partial class task
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
            this.description_tb = new System.Windows.Forms.TextBox();
            this.hour_data = new System.Windows.Forms.DateTimePicker();
            this.project_cb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Описание задачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Расчасовка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Проект";
            // 
            // description_tb
            // 
            this.description_tb.Location = new System.Drawing.Point(281, 25);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(512, 153);
            this.description_tb.TabIndex = 3;
            // 
            // hour_data
            // 
            this.hour_data.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hour_data.Location = new System.Drawing.Point(281, 202);
            this.hour_data.Name = "hour_data";
            this.hour_data.Size = new System.Drawing.Size(200, 38);
            this.hour_data.TabIndex = 4;
            this.hour_data.Value = new System.DateTime(2024, 9, 11, 0, 40, 0, 0);
            // 
            // project_cb
            // 
            this.project_cb.FormattingEnabled = true;
            this.project_cb.Location = new System.Drawing.Point(281, 252);
            this.project_cb.Name = "project_cb";
            this.project_cb.Size = new System.Drawing.Size(200, 39);
            this.project_cb.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(449, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.project_cb);
            this.Controls.Add(this.hour_data);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "task";
            this.Text = "Создать задачу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.task_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.task_FormClosed);
            this.Load += new System.EventHandler(this.task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.DateTimePicker hour_data;
        private System.Windows.Forms.ComboBox project_cb;
        private System.Windows.Forms.Button button1;
    }
}