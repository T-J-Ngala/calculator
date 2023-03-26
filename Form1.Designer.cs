namespace calculator
{
    partial class Form1
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
            this.Op1 = new System.Windows.Forms.TextBox();
            this.Op2 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operand2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Op1
            // 
            this.Op1.Location = new System.Drawing.Point(111, 26);
            this.Op1.Name = "Op1";
            this.Op1.Size = new System.Drawing.Size(157, 20);
            this.Op1.TabIndex = 2;
            this.Op1.TextChanged += new System.EventHandler(this.Op1_TextChanged);
            // 
            // Op2
            // 
            this.Op2.Location = new System.Drawing.Point(111, 77);
            this.Op2.Name = "Op2";
            this.Op2.Size = new System.Drawing.Size(157, 20);
            this.Op2.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(434, 22);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 68);
            this.Add.TabIndex = 4;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(434, 124);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 71);
            this.Sub.TabIndex = 5;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(554, 23);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(75, 67);
            this.Mul.TabIndex = 6;
            this.Mul.Text = "x";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.button1_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(554, 124);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 71);
            this.Div.TabIndex = 7;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Location = new System.Drawing.Point(25, 233);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(42, 13);
            this.Results.TabIndex = 8;
            this.Results.Text = "Results";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(132, 233);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(17, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "lbl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Op2);
            this.Controls.Add(this.Op1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Op1;
        private System.Windows.Forms.TextBox Op2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Label lblResult;
    }
}

