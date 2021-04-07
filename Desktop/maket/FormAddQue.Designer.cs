
namespace maket
{
    partial class FormAddQue
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
            this.labelTextQueText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCorAns = new System.Windows.Forms.TextBox();
            this.textBoxWrAns = new System.Windows.Forms.TextBox();
            this.buttonWrAns = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCorAns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTextQueText
            // 
            this.labelTextQueText.AutoSize = true;
            this.labelTextQueText.Location = new System.Drawing.Point(12, 30);
            this.labelTextQueText.Name = "labelTextQueText";
            this.labelTextQueText.Size = new System.Drawing.Size(104, 17);
            this.labelTextQueText.TabIndex = 0;
            this.labelTextQueText.Text = "Insert Question";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correct Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wrong answer:";
            // 
            // textBoxCorAns
            // 
            this.textBoxCorAns.Location = new System.Drawing.Point(154, 89);
            this.textBoxCorAns.Name = "textBoxCorAns";
            this.textBoxCorAns.Size = new System.Drawing.Size(209, 22);
            this.textBoxCorAns.TabIndex = 5;
            // 
            // textBoxWrAns
            // 
            this.textBoxWrAns.Location = new System.Drawing.Point(154, 135);
            this.textBoxWrAns.Name = "textBoxWrAns";
            this.textBoxWrAns.Size = new System.Drawing.Size(209, 22);
            this.textBoxWrAns.TabIndex = 6;
            // 
            // buttonWrAns
            // 
            this.buttonWrAns.Location = new System.Drawing.Point(379, 135);
            this.buttonWrAns.Name = "buttonWrAns";
            this.buttonWrAns.Size = new System.Drawing.Size(75, 23);
            this.buttonWrAns.TabIndex = 7;
            this.buttonWrAns.Text = "add";
            this.buttonWrAns.UseVisualStyleBackColor = true;
            this.buttonWrAns.Click += new System.EventHandler(this.buttonWrAns_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 198);
            this.dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Check result";
            // 
            // buttonCorAns
            // 
            this.buttonCorAns.Location = new System.Drawing.Point(379, 89);
            this.buttonCorAns.Name = "buttonCorAns";
            this.buttonCorAns.Size = new System.Drawing.Size(75, 23);
            this.buttonCorAns.TabIndex = 10;
            this.buttonCorAns.Text = "add";
            this.buttonCorAns.UseVisualStyleBackColor = true;
            this.buttonCorAns.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormAddQue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCorAns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonWrAns);
            this.Controls.Add(this.textBoxWrAns);
            this.Controls.Add(this.textBoxCorAns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTextQueText);
            this.Name = "FormAddQue";
            this.Text = "FormAddQue";
            this.Load += new System.EventHandler(this.FormAddQue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextQueText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCorAns;
        private System.Windows.Forms.TextBox textBoxWrAns;
        private System.Windows.Forms.Button buttonWrAns;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCorAns;
    }
}