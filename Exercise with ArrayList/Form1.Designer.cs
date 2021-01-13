
namespace Exercise_with_ArrayList
{
    partial class ArrayListDemo
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
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(34, 38);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(308, 342);
            this.lbResult.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(375, 47);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(235, 80);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read + Overview";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Animal:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(396, 204);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(213, 20);
            this.txtInput.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(396, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(212, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(399, 304);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(208, 41);
            this.btnEmpty.TabIndex = 5;
            this.btnEmpty.Text = "Empty All";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(399, 361);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(210, 35);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // ArrayListDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lbResult);
            this.Name = "ArrayListDemo";
            this.Text = "Array List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnSort;
    }
}

