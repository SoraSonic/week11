namespace week11
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
            this.Prime_number_label = new System.Windows.Forms.Label();
            this.Prime_number_Box = new System.Windows.Forms.TextBox();
            this.Create_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Read_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.New_Prime_number_label = new System.Windows.Forms.Label();
            this.New_Prime_number_Box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prime_number_label
            // 
            this.Prime_number_label.AutoSize = true;
            this.Prime_number_label.Location = new System.Drawing.Point(194, 131);
            this.Prime_number_label.Name = "Prime_number_label";
            this.Prime_number_label.Size = new System.Drawing.Size(71, 13);
            this.Prime_number_label.TabIndex = 0;
            this.Prime_number_label.Text = "Prime number";
            // 
            // Prime_number_Box
            // 
            this.Prime_number_Box.Location = new System.Drawing.Point(321, 128);
            this.Prime_number_Box.Name = "Prime_number_Box";
            this.Prime_number_Box.Size = new System.Drawing.Size(100, 20);
            this.Prime_number_Box.TabIndex = 1;
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(173, 246);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(75, 23);
            this.Create_button.TabIndex = 2;
            this.Create_button.Text = "Create";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(273, 246);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 3;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Read_button
            // 
            this.Read_button.Location = new System.Drawing.Point(367, 246);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(75, 23);
            this.Read_button.TabIndex = 4;
            this.Read_button.Text = "Read";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(463, 246);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 5;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // New_Prime_number_label
            // 
            this.New_Prime_number_label.AutoSize = true;
            this.New_Prime_number_label.Location = new System.Drawing.Point(194, 176);
            this.New_Prime_number_label.Name = "New_Prime_number_label";
            this.New_Prime_number_label.Size = new System.Drawing.Size(96, 13);
            this.New_Prime_number_label.TabIndex = 6;
            this.New_Prime_number_label.Text = "New Prime number";
            // 
            // New_Prime_number_Box
            // 
            this.New_Prime_number_Box.Location = new System.Drawing.Point(321, 176);
            this.New_Prime_number_Box.Name = "New_Prime_number_Box";
            this.New_Prime_number_Box.Size = new System.Drawing.Size(100, 20);
            this.New_Prime_number_Box.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.New_Prime_number_Box);
            this.Controls.Add(this.New_Prime_number_label);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.Prime_number_Box);
            this.Controls.Add(this.Prime_number_label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prime_number_label;
        private System.Windows.Forms.TextBox Prime_number_Box;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Read_button;
        