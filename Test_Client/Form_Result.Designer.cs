namespace Test_Client
{
    partial class Form_Result
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TestName = new System.Windows.Forms.TextBox();
            this.textBox_Mark = new System.Windows.Forms.TextBox();
            this.textBox_Qty = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Qty);
            this.groupBox1.Controls.Add(this.textBox_Mark);
            this.groupBox1.Controls.Add(this.textBox_TestName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(225, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TestName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qty of current answers";
            // 
            // textBox_TestName
            // 
            this.textBox_TestName.Location = new System.Drawing.Point(140, 48);
            this.textBox_TestName.Name = "textBox_TestName";
            this.textBox_TestName.Size = new System.Drawing.Size(172, 20);
            this.textBox_TestName.TabIndex = 3;
            // 
            // textBox_Mark
            // 
            this.textBox_Mark.Location = new System.Drawing.Point(140, 91);
            this.textBox_Mark.Name = "textBox_Mark";
            this.textBox_Mark.Size = new System.Drawing.Size(52, 20);
            this.textBox_Mark.TabIndex = 4;
            // 
            // textBox_Qty
            // 
            this.textBox_Qty.Location = new System.Drawing.Point(140, 135);
            this.textBox_Qty.Name = "textBox_Qty";
            this.textBox_Qty.Size = new System.Drawing.Size(52, 20);
            this.textBox_Qty.TabIndex = 5;
            // 
            // Form_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Result";
            this.Text = "Form_Result";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Qty;
        private System.Windows.Forms.TextBox textBox_Mark;
        private System.Windows.Forms.TextBox textBox_TestName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}