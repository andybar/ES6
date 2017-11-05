namespace WFA
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxAnswers = new System.Windows.Forms.ComboBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxAnswers = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonReload = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.JustificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAnswers
            // 
            this.comboBoxAnswers.FormattingEnabled = true;
            this.comboBoxAnswers.Location = new System.Drawing.Point(12, 155);
            this.comboBoxAnswers.Name = "comboBoxAnswers";
            this.comboBoxAnswers.Size = new System.Drawing.Size(88, 21);
            this.comboBoxAnswers.TabIndex = 0;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 139);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(35, 13);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "label1";
            // 
            // textBoxAnswers
            // 
            this.textBoxAnswers.Location = new System.Drawing.Point(12, 155);
            this.textBoxAnswers.Name = "textBoxAnswers";
            this.textBoxAnswers.Size = new System.Drawing.Size(88, 20);
            this.textBoxAnswers.TabIndex = 2;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(106, 154);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 22);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(53, 182);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 23);
            this.buttonReload.TabIndex = 4;
            this.buttonReload.Text = "Повторить";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(26, 163);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JustificationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(190, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // JustificationToolStripMenuItem
            // 
            this.JustificationToolStripMenuItem.Name = "JustificationToolStripMenuItem";
            this.JustificationToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.JustificationToolStripMenuItem.Text = "Лог Вывода";
            this.JustificationToolStripMenuItem.Click += new System.EventHandler(this.JustificationToolStripMenuItem_Click_1);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 211);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxAnswers);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.comboBoxAnswers);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form";
            this.Text = "Carbinder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAnswers;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxAnswers;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem JustificationToolStripMenuItem;
    }
}

