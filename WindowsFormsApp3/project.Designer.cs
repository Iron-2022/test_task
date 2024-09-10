namespace WindowsFormsApp3
{
    partial class project
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
            this.budget_tb = new System.Windows.Forms.TextBox();
            this.person_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.term_data = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Бюджет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(207, 17);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(198, 38);
            this.name_tb.TabIndex = 3;
            // 
            // budget_tb
            // 
            this.budget_tb.Location = new System.Drawing.Point(207, 64);
            this.budget_tb.Name = "budget_tb";
            this.budget_tb.Size = new System.Drawing.Size(198, 38);
            this.budget_tb.TabIndex = 4;
            // 
            // person_cb
            // 
            this.person_cb.FormattingEnabled = true;
            this.person_cb.Location = new System.Drawing.Point(207, 152);
            this.person_cb.Name = "person_cb";
            this.person_cb.Size = new System.Drawing.Size(198, 39);
            this.person_cb.TabIndex = 6;
            this.person_cb.SelectedIndexChanged += new System.EventHandler(this.person_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Исполнитель";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // term_data
            // 
            this.term_data.Location = new System.Drawing.Point(207, 109);
            this.term_data.Name = "term_data";
            this.term_data.Size = new System.Drawing.Size(200, 38);
            this.term_data.TabIndex = 9;
            // 
            // project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 351);
            this.Controls.Add(this.term_data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.person_cb);
            this.Controls.Add(this.budget_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "project";
            this.Text = "Проект";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.project_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.project_FormClosed);
            this.Load += new System.EventHandler(this.project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox budget_tb;
        private System.Windows.Forms.ComboBox person_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker term_data;
    }
}