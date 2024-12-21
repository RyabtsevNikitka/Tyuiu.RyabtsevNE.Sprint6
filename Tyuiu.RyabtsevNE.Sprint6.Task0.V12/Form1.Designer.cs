namespace Tyuiu.RyabtsevNE.Sprint6.Task0.V12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxTask_RNE = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            textBoxVarX_RNE = new TextBox();
            groupBoxRes_RNE = new GroupBox();
            textBoxRes_RNE = new TextBox();
            buttonDone = new Button();
            groupBoxTask_RNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxRes_RNE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_RNE
            // 
            groupBoxTask_RNE.Controls.Add(pictureBox1);
            groupBoxTask_RNE.Location = new Point(12, 12);
            groupBoxTask_RNE.Name = "groupBoxTask_RNE";
            groupBoxTask_RNE.Size = new Size(763, 100);
            groupBoxTask_RNE.TabIndex = 0;
            groupBoxTask_RNE.TabStop = false;
            groupBoxTask_RNE.Text = "условие";
            groupBoxTask_RNE.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(751, 72);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxVarX_RNE);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(18, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 298);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ввод данных";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(16, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 0;
            textBox1.Text = "переменная x";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxVarX_RNE
            // 
            textBoxVarX_RNE.Location = new Point(16, 203);
            textBoxVarX_RNE.Name = "textBoxVarX_RNE";
            textBoxVarX_RNE.Size = new Size(100, 23);
            textBoxVarX_RNE.TabIndex = 1;
            textBoxVarX_RNE.KeyPress += textBoxVarX_RNE_KeyPress;
            // 
            // groupBoxRes_RNE
            // 
            groupBoxRes_RNE.Controls.Add(textBoxRes_RNE);
            groupBoxRes_RNE.Location = new Point(496, 118);
            groupBoxRes_RNE.Name = "groupBoxRes_RNE";
            groupBoxRes_RNE.Size = new Size(273, 114);
            groupBoxRes_RNE.TabIndex = 2;
            groupBoxRes_RNE.TabStop = false;
            groupBoxRes_RNE.Text = "вывод данных";
            // 
            // textBoxRes_RNE
            // 
            textBoxRes_RNE.Location = new Point(6, 50);
            textBoxRes_RNE.Name = "textBoxRes_RNE";
            textBoxRes_RNE.Size = new Size(104, 23);
            textBoxRes_RNE.TabIndex = 3;
            textBoxRes_RNE.TextChanged += textBoxRes_RNE_TextChanged;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(668, 347);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(101, 69);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "посчитать";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxRes_RNE);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxTask_RNE);
            Name = "Form1";
            Text = "Form1";
            groupBoxTask_RNE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxRes_RNE.ResumeLayout(false);
            groupBoxRes_RNE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_RNE;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox textBoxVarX_RNE;
        private TextBox textBox1;
        private GroupBox groupBoxRes_RNE;
        private TextBox textBoxRes_RNE;
        private Button buttonDone;
    }
}
