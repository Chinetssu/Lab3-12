
namespace Lab3_12
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
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.pictureBoxRGB = new System.Windows.Forms.PictureBox();
            this.pictureBoxHSV = new System.Windows.Forms.PictureBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonHSVToRGB = new System.Windows.Forms.Button();
            this.buttonRGBToHSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHSV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(44, 12);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 22);
            this.textBoxR.TabIndex = 0;
            this.textBoxR.Text = "0";
            this.textBoxR.TextChanged += new System.EventHandler(this.RTextChanged);
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(44, 40);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(100, 22);
            this.textBoxG.TabIndex = 1;
            this.textBoxG.Text = "0";
            this.textBoxG.TextChanged += new System.EventHandler(this.gTextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(44, 68);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 2;
            this.textBoxB.Text = "0";
            this.textBoxB.TextChanged += new System.EventHandler(this.bTextChanged);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(8, 15);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(30, 17);
            this.R.TabIndex = 3;
            this.R.Text = "R =";
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Location = new System.Drawing.Point(8, 45);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(31, 17);
            this.G.TabIndex = 4;
            this.G.Text = "G =";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(8, 73);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(29, 17);
            this.B.TabIndex = 5;
            this.B.Text = "B =";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(652, 71);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(29, 17);
            this.labelV.TabIndex = 11;
            this.labelV.Text = "V =";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(652, 43);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(29, 17);
            this.labelS.TabIndex = 10;
            this.labelS.Text = "S =";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(652, 13);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(30, 17);
            this.labelH.TabIndex = 9;
            this.labelH.Text = "H =";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(688, 66);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(100, 22);
            this.textBoxV.TabIndex = 8;
            this.textBoxV.Text = "0";
            this.textBoxV.TextChanged += new System.EventHandler(this.VTextChanged);
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(688, 38);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(100, 22);
            this.textBoxS.TabIndex = 7;
            this.textBoxS.Text = "0";
            this.textBoxS.TextChanged += new System.EventHandler(this.STextChanged);
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(688, 10);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 22);
            this.textBoxH.TabIndex = 6;
            this.textBoxH.Text = "0";
            this.textBoxH.TextChanged += new System.EventHandler(this.HTextChanged);
            // 
            // pictureBoxRGB
            // 
            this.pictureBoxRGB.Location = new System.Drawing.Point(11, 133);
            this.pictureBoxRGB.Name = "pictureBoxRGB";
            this.pictureBoxRGB.Size = new System.Drawing.Size(133, 50);
            this.pictureBoxRGB.TabIndex = 12;
            this.pictureBoxRGB.TabStop = false;
            // 
            // pictureBoxHSV
            // 
            this.pictureBoxHSV.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxHSV.Location = new System.Drawing.Point(655, 133);
            this.pictureBoxHSV.Name = "pictureBoxHSV";
            this.pictureBoxHSV.Size = new System.Drawing.Size(133, 50);
            this.pictureBoxHSV.TabIndex = 13;
            this.pictureBoxHSV.TabStop = false;
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(347, 146);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(120, 37);
            this.buttonSum.TabIndex = 14;
            this.buttonSum.Text = "Сложить цвета";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonHSVToRGB
            // 
            this.buttonHSVToRGB.Location = new System.Drawing.Point(305, 146);
            this.buttonHSVToRGB.Name = "buttonHSVToRGB";
            this.buttonHSVToRGB.Size = new System.Drawing.Size(36, 37);
            this.buttonHSVToRGB.TabIndex = 15;
            this.buttonHSVToRGB.Text = "<--";
            this.buttonHSVToRGB.UseVisualStyleBackColor = true;
            this.buttonHSVToRGB.Click += new System.EventHandler(this.buttonHSVToRGB_Click);
            // 
            // buttonRGBToHSV
            // 
            this.buttonRGBToHSV.Location = new System.Drawing.Point(473, 146);
            this.buttonRGBToHSV.Name = "buttonRGBToHSV";
            this.buttonRGBToHSV.Size = new System.Drawing.Size(37, 37);
            this.buttonRGBToHSV.TabIndex = 16;
            this.buttonRGBToHSV.Text = "-->";
            this.buttonRGBToHSV.UseVisualStyleBackColor = true;
            this.buttonRGBToHSV.Click += new System.EventHandler(this.buttonRGBToHSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 213);
            this.Controls.Add(this.buttonRGBToHSV);
            this.Controls.Add(this.buttonHSVToRGB);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.pictureBoxHSV);
            this.Controls.Add(this.pictureBoxRGB);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.PictureBox pictureBoxRGB;
        private System.Windows.Forms.PictureBox pictureBoxHSV;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonHSVToRGB;
        private System.Windows.Forms.Button buttonRGBToHSV;
    }
}

