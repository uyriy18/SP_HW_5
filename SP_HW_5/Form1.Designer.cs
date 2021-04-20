
namespace SP_HW_5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exlamed_ckbx = new System.Windows.Forms.CheckBox();
            this.Interrogative_ckbx = new System.Windows.Forms.CheckBox();
            this.Symbols_ckbx = new System.Windows.Forms.CheckBox();
            this.Words_ckbx = new System.Windows.Forms.CheckBox();
            this.Sentences_ckbx = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exlamed_ckbx);
            this.panel1.Controls.Add(this.Interrogative_ckbx);
            this.panel1.Controls.Add(this.Symbols_ckbx);
            this.panel1.Controls.Add(this.Words_ckbx);
            this.panel1.Controls.Add(this.Sentences_ckbx);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 412);
            this.panel1.TabIndex = 2;
            // 
            // exlamed_ckbx
            // 
            this.exlamed_ckbx.AutoSize = true;
            this.exlamed_ckbx.Checked = true;
            this.exlamed_ckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exlamed_ckbx.Location = new System.Drawing.Point(584, 105);
            this.exlamed_ckbx.Name = "exlamed_ckbx";
            this.exlamed_ckbx.Size = new System.Drawing.Size(162, 17);
            this.exlamed_ckbx.TabIndex = 5;
            this.exlamed_ckbx.Text = "Number of Exlaim Sentences";
            this.exlamed_ckbx.UseVisualStyleBackColor = true;
            // 
            // Interrogative_ckbx
            // 
            this.Interrogative_ckbx.AutoSize = true;
            this.Interrogative_ckbx.Checked = true;
            this.Interrogative_ckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Interrogative_ckbx.Location = new System.Drawing.Point(584, 82);
            this.Interrogative_ckbx.Name = "Interrogative_ckbx";
            this.Interrogative_ckbx.Size = new System.Drawing.Size(197, 17);
            this.Interrogative_ckbx.TabIndex = 4;
            this.Interrogative_ckbx.Text = "Number of Interrogvative Sentences";
            this.Interrogative_ckbx.UseVisualStyleBackColor = true;
            // 
            // Symbols_ckbx
            // 
            this.Symbols_ckbx.AutoSize = true;
            this.Symbols_ckbx.Checked = true;
            this.Symbols_ckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Symbols_ckbx.Location = new System.Drawing.Point(584, 59);
            this.Symbols_ckbx.Name = "Symbols_ckbx";
            this.Symbols_ckbx.Size = new System.Drawing.Size(117, 17);
            this.Symbols_ckbx.TabIndex = 3;
            this.Symbols_ckbx.Text = "Number of Symbols";
            this.Symbols_ckbx.UseVisualStyleBackColor = true;
            // 
            // Words_ckbx
            // 
            this.Words_ckbx.AutoSize = true;
            this.Words_ckbx.Checked = true;
            this.Words_ckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Words_ckbx.Location = new System.Drawing.Point(585, 36);
            this.Words_ckbx.Name = "Words_ckbx";
            this.Words_ckbx.Size = new System.Drawing.Size(109, 17);
            this.Words_ckbx.TabIndex = 2;
            this.Words_ckbx.Text = "Number of Words";
            this.Words_ckbx.UseVisualStyleBackColor = true;
            // 
            // Sentences_ckbx
            // 
            this.Sentences_ckbx.AutoSize = true;
            this.Sentences_ckbx.Checked = true;
            this.Sentences_ckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sentences_ckbx.Location = new System.Drawing.Point(585, 13);
            this.Sentences_ckbx.Name = "Sentences_ckbx";
            this.Sentences_ckbx.Size = new System.Drawing.Size(129, 17);
            this.Sentences_ckbx.TabIndex = 1;
            this.Sentences_ckbx.Text = "Number of Sentences";
            this.Sentences_ckbx.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(578, 412);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(12, 418);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 3;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "On the Screen",
            "In the File"});
            this.comboBox1.Location = new System.Drawing.Point(93, 420);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(220, 418);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(75, 23);
            this.Stop_btn.TabIndex = 4;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox Interrogative_ckbx;
        private System.Windows.Forms.CheckBox Symbols_ckbx;
        private System.Windows.Forms.CheckBox Words_ckbx;
        private System.Windows.Forms.CheckBox Sentences_ckbx;
        private System.Windows.Forms.CheckBox exlamed_ckbx;
        private System.Windows.Forms.Button Stop_btn;
    }
}

