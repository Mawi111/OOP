namespace Zákldy_OOP_Forms_3
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
            this.frnuNUD = new System.Windows.Forms.NumericUpDown();
            this.senuNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusBTN = new System.Windows.Forms.Button();
            this.minusBTN = new System.Windows.Forms.Button();
            this.multyBTN = new System.Windows.Forms.Button();
            this.divisBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frnuNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senuNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // frnuNUD
            // 
            this.frnuNUD.Location = new System.Drawing.Point(314, 154);
            this.frnuNUD.Name = "frnuNUD";
            this.frnuNUD.Size = new System.Drawing.Size(120, 23);
            this.frnuNUD.TabIndex = 0;
            // 
            // senuNUD
            // 
            this.senuNUD.Location = new System.Drawing.Point(314, 183);
            this.senuNUD.Name = "senuNUD";
            this.senuNUD.Size = new System.Drawing.Size(120, 23);
            this.senuNUD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "První čislo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Druhé čislo";
            // 
            // plusBTN
            // 
            this.plusBTN.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plusBTN.Location = new System.Drawing.Point(197, 244);
            this.plusBTN.Name = "plusBTN";
            this.plusBTN.Size = new System.Drawing.Size(75, 31);
            this.plusBTN.TabIndex = 4;
            this.plusBTN.Text = "+";
            this.plusBTN.UseVisualStyleBackColor = true;
            this.plusBTN.Click += new System.EventHandler(this.plusBTN_Click);
            // 
            // minusBTN
            // 
            this.minusBTN.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minusBTN.Location = new System.Drawing.Point(278, 244);
            this.minusBTN.Name = "minusBTN";
            this.minusBTN.Size = new System.Drawing.Size(75, 31);
            this.minusBTN.TabIndex = 5;
            this.minusBTN.Text = "-";
            this.minusBTN.UseVisualStyleBackColor = true;
            this.minusBTN.Click += new System.EventHandler(this.minusBTN_Click);
            // 
            // multyBTN
            // 
            this.multyBTN.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multyBTN.Location = new System.Drawing.Point(359, 244);
            this.multyBTN.Name = "multyBTN";
            this.multyBTN.Size = new System.Drawing.Size(75, 31);
            this.multyBTN.TabIndex = 6;
            this.multyBTN.Text = "*";
            this.multyBTN.UseVisualStyleBackColor = true;
            this.multyBTN.Click += new System.EventHandler(this.multyBTN_Click);
            // 
            // divisBTN
            // 
            this.divisBTN.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divisBTN.Location = new System.Drawing.Point(440, 244);
            this.divisBTN.Name = "divisBTN";
            this.divisBTN.Size = new System.Drawing.Size(75, 31);
            this.divisBTN.TabIndex = 7;
            this.divisBTN.Text = "/";
            this.divisBTN.UseVisualStyleBackColor = true;
            this.divisBTN.Click += new System.EventHandler(this.divisBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.divisBTN);
            this.Controls.Add(this.multyBTN);
            this.Controls.Add(this.minusBTN);
            this.Controls.Add(this.plusBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senuNUD);
            this.Controls.Add(this.frnuNUD);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.frnuNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senuNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown frnuNUD;
        private NumericUpDown senuNUD;
        private Label label1;
        private Label label2;
        private Button plusBTN;
        private Button minusBTN;
        private Button multyBTN;
        private Button divisBTN;
    }
}