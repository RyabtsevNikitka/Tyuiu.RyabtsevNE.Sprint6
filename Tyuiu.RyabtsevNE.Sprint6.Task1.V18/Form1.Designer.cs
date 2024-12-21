namespace Tyuiu.RyabtsevNE.Sprint6.Task1.V18
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask_RNE = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxData_RNE = new GroupBox();
            textBox1_RNE = new TextBox();
            textBox2_RNE = new TextBox();
            groupBoxTask_RNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxData_RNE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_RNE
            // 
            groupBoxTask_RNE.Controls.Add(pictureBox1);
            groupBoxTask_RNE.Location = new Point(12, 12);
            groupBoxTask_RNE.Name = "groupBoxTask_RNE";
            groupBoxTask_RNE.Size = new Size(776, 119);
            groupBoxTask_RNE.TabIndex = 0;
            groupBoxTask_RNE.TabStop = false;
            groupBoxTask_RNE.Text = "условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(764, 91);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxData_RNE
            // 
            groupBoxData_RNE.Controls.Add(textBox2_RNE);
            groupBoxData_RNE.Controls.Add(textBox1_RNE);
            groupBoxData_RNE.Location = new Point(12, 153);
            groupBoxData_RNE.Name = "groupBoxData_RNE";
            groupBoxData_RNE.Size = new Size(335, 285);
            groupBoxData_RNE.TabIndex = 1;
            groupBoxData_RNE.TabStop = false;
            groupBoxData_RNE.Text = "ввод данных";
            // 
            // textBox1_RNE
            // 
            textBox1_RNE.BackColor = SystemColors.Menu;
            textBox1_RNE.BorderStyle = BorderStyle.None;
            textBox1_RNE.Location = new Point(6, 182);
            textBox1_RNE.Name = "textBox1_RNE";
            textBox1_RNE.Size = new Size(100, 16);
            textBox1_RNE.TabIndex = 0;
            textBox1_RNE.Text = "старт шага";
            // 
            // textBox2_RNE
            // 
            textBox2_RNE.Location = new Point(0, 214);
            textBox2_RNE.Name = "textBox2_RNE";
            textBox2_RNE.Size = new Size(100, 23);
            textBox2_RNE.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxData_RNE);
            Controls.Add(groupBoxTask_RNE);
            Name = "Form1";
            Text = "Form1";
            groupBoxTask_RNE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxData_RNE.ResumeLayout(false);
            groupBoxData_RNE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_RNE;
        private PictureBox pictureBox1;
        private GroupBox groupBoxData_RNE;
        private TextBox textBox2_RNE;
        private TextBox textBox1_RNE;
    }
}
