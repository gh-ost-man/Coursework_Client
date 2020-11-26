namespace Test_Client
{
    partial class Form_ShowTests
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_PassTest = new System.Windows.Forms.Button();
            this.btn_LoadTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(298, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_PassTest
            // 
            this.btn_PassTest.Location = new System.Drawing.Point(12, 290);
            this.btn_PassTest.Name = "btn_PassTest";
            this.btn_PassTest.Size = new System.Drawing.Size(96, 23);
            this.btn_PassTest.TabIndex = 1;
            this.btn_PassTest.Text = "To pass a test";
            this.btn_PassTest.UseVisualStyleBackColor = true;
            // 
            // btn_LoadTest
            // 
            this.btn_LoadTest.Location = new System.Drawing.Point(236, 290);
            this.btn_LoadTest.Name = "btn_LoadTest";
            this.btn_LoadTest.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadTest.TabIndex = 2;
            this.btn_LoadTest.Text = "Load Tests";
            this.btn_LoadTest.UseVisualStyleBackColor = true;
            this.btn_LoadTest.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // Form_ShowTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 369);
            this.Controls.Add(this.btn_LoadTest);
            this.Controls.Add(this.btn_PassTest);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_ShowTests";
            this.Text = "Form_ShowTests";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_PassTest;
        private System.Windows.Forms.Button btn_LoadTest;
    }
}