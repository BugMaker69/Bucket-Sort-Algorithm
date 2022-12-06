namespace BucketSortAlgo
{
    partial class BucketAlg
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
            this.EnteredData = new System.Windows.Forms.TextBox();
            this.AddData = new System.Windows.Forms.Button();
            this.DeleteData = new System.Windows.Forms.Button();
            this.ClearData = new System.Windows.Forms.Button();
            this.SortData = new System.Windows.Forms.Button();
            this.ListData = new System.Windows.Forms.ListBox();
            this.OutPut = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EnteredData
            // 
            this.EnteredData.Location = new System.Drawing.Point(12, 21);
            this.EnteredData.Name = "EnteredData";
            this.EnteredData.Size = new System.Drawing.Size(100, 20);
            this.EnteredData.TabIndex = 0;
            // 
            // AddData
            // 
            this.AddData.Location = new System.Drawing.Point(12, 62);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(75, 23);
            this.AddData.TabIndex = 1;
            this.AddData.Text = "Add";
            this.AddData.UseCompatibleTextRendering = true;
            this.AddData.UseVisualStyleBackColor = true;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // DeleteData
            // 
            this.DeleteData.Location = new System.Drawing.Point(12, 196);
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.Size = new System.Drawing.Size(75, 23);
            this.DeleteData.TabIndex = 2;
            this.DeleteData.Text = "Delete";
            this.DeleteData.UseVisualStyleBackColor = true;
            this.DeleteData.Click += new System.EventHandler(this.DeleteData_Click);
            // 
            // ClearData
            // 
            this.ClearData.Location = new System.Drawing.Point(12, 238);
            this.ClearData.Name = "ClearData";
            this.ClearData.Size = new System.Drawing.Size(75, 23);
            this.ClearData.TabIndex = 3;
            this.ClearData.Text = "Clear";
            this.ClearData.UseVisualStyleBackColor = true;
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // SortData
            // 
            this.SortData.Location = new System.Drawing.Point(12, 107);
            this.SortData.Name = "SortData";
            this.SortData.Size = new System.Drawing.Size(75, 23);
            this.SortData.TabIndex = 4;
            this.SortData.Text = "Sort";
            this.SortData.UseVisualStyleBackColor = true;
            this.SortData.Click += new System.EventHandler(this.SortData_Click);
            // 
            // ListData
            // 
            this.ListData.AllowDrop = true;
            this.ListData.FormattingEnabled = true;
            this.ListData.HorizontalScrollbar = true;
            this.ListData.Location = new System.Drawing.Point(164, 21);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(132, 147);
            this.ListData.TabIndex = 5;
            // 
            // OutPut
            // 
            this.OutPut.FormattingEnabled = true;
            this.OutPut.Location = new System.Drawing.Point(164, 196);
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(132, 147);
            this.OutPut.TabIndex = 6;
            // 
            // BucketAlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 382);
            this.Controls.Add(this.OutPut);
            this.Controls.Add(this.ListData);
            this.Controls.Add(this.SortData);
            this.Controls.Add(this.ClearData);
            this.Controls.Add(this.DeleteData);
            this.Controls.Add(this.AddData);
            this.Controls.Add(this.EnteredData);
            this.Name = "BucketAlg";
            this.Text = "Bucket Sort Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnteredData;
        private System.Windows.Forms.Button AddData;
        private System.Windows.Forms.Button DeleteData;
        private System.Windows.Forms.Button ClearData;
        private System.Windows.Forms.Button SortData;
        private System.Windows.Forms.ListBox ListData;
        private System.Windows.Forms.ListBox OutPut;
    }
}

