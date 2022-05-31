
namespace DubberTestInterface
{
    partial class Lottery
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lottoNum1Label = new System.Windows.Forms.Label();
            this.lottoNum2Label = new System.Windows.Forms.Label();
            this.lottoNum3Label = new System.Windows.Forms.Label();
            this.lottoNum4Label = new System.Windows.Forms.Label();
            this.lottoNum5Label = new System.Windows.Forms.Label();
            this.lottoNum6Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Lime;
            this.btnGenerate.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(235, 328);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(438, 64);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lottoNum1Label
            // 
            this.lottoNum1Label.AutoSize = true;
            this.lottoNum1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoNum1Label.ForeColor = System.Drawing.Color.Black;
            this.lottoNum1Label.Location = new System.Drawing.Point(28, 137);
            this.lottoNum1Label.Name = "lottoNum1Label";
            this.lottoNum1Label.Size = new System.Drawing.Size(93, 32);
            this.lottoNum1Label.TabIndex = 1;
            this.lottoNum1Label.Text = "label1";
            // 
            // lottoNum2Label
            // 
            this.lottoNum2Label.AutoSize = true;
            this.lottoNum2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoNum2Label.Location = new System.Drawing.Point(166, 137);
            this.lottoNum2Label.Name = "lottoNum2Label";
            this.lottoNum2Label.Size = new System.Drawing.Size(93, 32);
            this.lottoNum2Label.TabIndex = 2;
            this.lottoNum2Label.Text = "label2";
            // 
            // lottoNum3Label
            // 
            this.lottoNum3Label.AutoSize = true;
            this.lottoNum3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoNum3Label.Location = new System.Drawing.Point(292, 137);
            this.lottoNum3Label.Name = "lottoNum3Label";
            this.lottoNum3Label.Size = new System.Drawing.Size(93, 32);
            this.lottoNum3Label.TabIndex = 3;
            this.lottoNum3Label.Text = "label3";
            // 
            // lottoNum4Label
            // 
            this.lottoNum4Label.AutoSize = true;
            this.lottoNum4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoNum4Label.Location = new System.Drawing.Point(425, 137);
            this.lottoNum4Label.Name = "lottoNum4Label";
            this.lottoNum4Label.Size = new System.Drawing.Size(93, 32);
            this.lottoNum4Label.TabIndex = 4;
            this.lottoNum4Label.Text = "label4";
            // 
            // lottoNum5Label
            // 
            this.lottoNum5Label.AutoSize = true;
            this.lottoNum5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoNum5Label.Location = new System.Drawing.Point(568, 137);
            this.lottoNum5Label.Name = "lottoNum5Label";
            this.lottoNum5Label.Size = new System.Drawing.Size(93, 32);
            this.lottoNum5Label.TabIndex = 5;
            this.lottoNum5Label.Text = "label5";
            // 
            // lottoNum6Label
            // 
            this.lottoNum6Label.AutoSize = true;
            this.lottoNum6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoNum6Label.Location = new System.Drawing.Point(705, 137);
            this.lottoNum6Label.Name = "lottoNum6Label";
            this.lottoNum6Label.Size = new System.Drawing.Size(93, 32);
            this.lottoNum6Label.TabIndex = 6;
            this.lottoNum6Label.Text = "label6";
            // 
            // Lottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.lottoNum6Label);
            this.Controls.Add(this.lottoNum5Label);
            this.Controls.Add(this.lottoNum4Label);
            this.Controls.Add(this.lottoNum3Label);
            this.Controls.Add(this.lottoNum2Label);
            this.Controls.Add(this.lottoNum1Label);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Lottery";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lottoNum1Label;
        private System.Windows.Forms.Label lottoNum2Label;
        private System.Windows.Forms.Label lottoNum3Label;
        private System.Windows.Forms.Label lottoNum4Label;
        private System.Windows.Forms.Label lottoNum5Label;
        private System.Windows.Forms.Label lottoNum6Label;
    }
}

