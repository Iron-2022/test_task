namespace WindowsFormsApp3
{
    partial class Form2
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
            this.create_person_bt = new System.Windows.Forms.Button();
            this.create_project_bt = new System.Windows.Forms.Button();
            this.budget2 = new System.Windows.Forms.Button();
            this.budget1 = new System.Windows.Forms.Button();
            this.create_task_bt = new System.Windows.Forms.Button();
            this.assign_task_bt = new System.Windows.Forms.Button();
            this.create_role_bt = new System.Windows.Forms.Button();
            this.given_p = new System.Windows.Forms.Panel();
            this.passed_p = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // create_person_bt
            // 
            this.create_person_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_person_bt.Location = new System.Drawing.Point(13, 13);
            this.create_person_bt.Name = "create_person_bt";
            this.create_person_bt.Size = new System.Drawing.Size(93, 84);
            this.create_person_bt.TabIndex = 0;
            this.create_person_bt.Text = "создать персону";
            this.create_person_bt.UseVisualStyleBackColor = true;
            this.create_person_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // create_project_bt
            // 
            this.create_project_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_project_bt.Location = new System.Drawing.Point(112, 13);
            this.create_project_bt.Name = "create_project_bt";
            this.create_project_bt.Size = new System.Drawing.Size(93, 84);
            this.create_project_bt.TabIndex = 1;
            this.create_project_bt.Text = "создать проект";
            this.create_project_bt.UseVisualStyleBackColor = true;
            this.create_project_bt.Click += new System.EventHandler(this.button2_Click);
            // 
            // budget2
            // 
            this.budget2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budget2.BackColor = System.Drawing.Color.Red;
            this.budget2.Location = new System.Drawing.Point(112, 193);
            this.budget2.Name = "budget2";
            this.budget2.Size = new System.Drawing.Size(93, 84);
            this.budget2.TabIndex = 2;
            this.budget2.Text = "создать приход";
            this.budget2.UseVisualStyleBackColor = false;
            // 
            // budget1
            // 
            this.budget1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budget1.BackColor = System.Drawing.Color.Red;
            this.budget1.Location = new System.Drawing.Point(112, 103);
            this.budget1.Name = "budget1";
            this.budget1.Size = new System.Drawing.Size(93, 84);
            this.budget1.TabIndex = 3;
            this.budget1.Text = "создать уход";
            this.budget1.UseVisualStyleBackColor = false;
            // 
            // create_task_bt
            // 
            this.create_task_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_task_bt.Location = new System.Drawing.Point(211, 13);
            this.create_task_bt.Name = "create_task_bt";
            this.create_task_bt.Size = new System.Drawing.Size(93, 84);
            this.create_task_bt.TabIndex = 4;
            this.create_task_bt.Text = "создать задачу";
            this.create_task_bt.UseVisualStyleBackColor = true;
            this.create_task_bt.Click += new System.EventHandler(this.button5_Click);
            // 
            // assign_task_bt
            // 
            this.assign_task_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assign_task_bt.Location = new System.Drawing.Point(211, 103);
            this.assign_task_bt.Name = "assign_task_bt";
            this.assign_task_bt.Size = new System.Drawing.Size(93, 84);
            this.assign_task_bt.TabIndex = 5;
            this.assign_task_bt.Text = "назначить задачу";
            this.assign_task_bt.UseVisualStyleBackColor = true;
            this.assign_task_bt.Click += new System.EventHandler(this.button6_Click);
            // 
            // create_role_bt
            // 
            this.create_role_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_role_bt.Location = new System.Drawing.Point(13, 103);
            this.create_role_bt.Name = "create_role_bt";
            this.create_role_bt.Size = new System.Drawing.Size(93, 84);
            this.create_role_bt.TabIndex = 7;
            this.create_role_bt.Text = "Создать роли доступа";
            this.create_role_bt.UseVisualStyleBackColor = true;
            this.create_role_bt.Click += new System.EventHandler(this.button7_Click);
            // 
            // given_p
            // 
            this.given_p.Location = new System.Drawing.Point(310, 13);
            this.given_p.Name = "given_p";
            this.given_p.Size = new System.Drawing.Size(223, 425);
            this.given_p.TabIndex = 8;
            // 
            // passed_p
            // 
            this.passed_p.Location = new System.Drawing.Point(565, 13);
            this.passed_p.Name = "passed_p";
            this.passed_p.Size = new System.Drawing.Size(223, 425);
            this.passed_p.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passed_p);
            this.Controls.Add(this.given_p);
            this.Controls.Add(this.create_role_bt);
            this.Controls.Add(this.assign_task_bt);
            this.Controls.Add(this.create_task_bt);
            this.Controls.Add(this.budget1);
            this.Controls.Add(this.budget2);
            this.Controls.Add(this.create_project_bt);
            this.Controls.Add(this.create_person_bt);
            this.Name = "Form2";
            this.Text = "меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_person_bt;
        private System.Windows.Forms.Button create_project_bt;
        private System.Windows.Forms.Button budget2;
        private System.Windows.Forms.Button budget1;
        private System.Windows.Forms.Button create_task_bt;
        private System.Windows.Forms.Button assign_task_bt;
        private System.Windows.Forms.Button create_role_bt;
        private System.Windows.Forms.Panel given_p;
        private System.Windows.Forms.Panel passed_p;
    }
}