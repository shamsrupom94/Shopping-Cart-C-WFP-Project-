namespace MainFrame
{
    partial class Shopping_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shopping_List));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Final_ListGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.finalTotalLabel = new System.Windows.Forms.Label();
            this.totalVatLabel = new System.Windows.Forms.Label();
            this.regualTotalLabel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CF_name = new System.Windows.Forms.Label();
            this.CLname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Final_ListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Final_ListGridView
            // 
            this.Final_ListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Final_ListGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Final_ListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Final_ListGridView.Location = new System.Drawing.Point(12, 87);
            this.Final_ListGridView.Name = "Final_ListGridView";
            this.Final_ListGridView.Size = new System.Drawing.Size(622, 291);
            this.Final_ListGridView.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date :";
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.SystemColors.Window;
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButton.Location = new System.Drawing.Point(508, 480);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(126, 37);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Text = "     Save and Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // finalTotalLabel
            // 
            this.finalTotalLabel.AutoSize = true;
            this.finalTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalTotalLabel.Location = new System.Drawing.Point(567, 441);
            this.finalTotalLabel.Name = "finalTotalLabel";
            this.finalTotalLabel.Size = new System.Drawing.Size(31, 13);
            this.finalTotalLabel.TabIndex = 59;
            this.finalTotalLabel.Text = "......";
            // 
            // totalVatLabel
            // 
            this.totalVatLabel.AutoSize = true;
            this.totalVatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVatLabel.Location = new System.Drawing.Point(567, 408);
            this.totalVatLabel.Name = "totalVatLabel";
            this.totalVatLabel.Size = new System.Drawing.Size(31, 13);
            this.totalVatLabel.TabIndex = 58;
            this.totalVatLabel.Text = "......";
            // 
            // regualTotalLabel
            // 
            this.regualTotalLabel.AutoSize = true;
            this.regualTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regualTotalLabel.Location = new System.Drawing.Point(567, 390);
            this.regualTotalLabel.Name = "regualTotalLabel";
            this.regualTotalLabel.Size = new System.Drawing.Size(31, 13);
            this.regualTotalLabel.TabIndex = 57;
            this.regualTotalLabel.Text = "......";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(617, 438);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 16);
            this.label29.TabIndex = 56;
            this.label29.Text = "$";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(617, 408);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 55;
            this.label28.Text = "$";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(617, 390);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 13);
            this.label27.TabIndex = 54;
            this.label27.Text = "$";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(418, 438);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 16);
            this.label18.TabIndex = 53;
            this.label18.Text = "FInal Total :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(448, 408);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "VAT(0%)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(464, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Total :";
            // 
            // CF_name
            // 
            this.CF_name.AutoSize = true;
            this.CF_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CF_name.Location = new System.Drawing.Point(116, 48);
            this.CF_name.Name = "CF_name";
            this.CF_name.Size = new System.Drawing.Size(47, 16);
            this.CF_name.TabIndex = 60;
            this.CF_name.Text = "Custo";
            // 
            // CLname
            // 
            this.CLname.AutoSize = true;
            this.CLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLname.Location = new System.Drawing.Point(179, 48);
            this.CLname.Name = "CLname";
            this.CLname.Size = new System.Drawing.Size(126, 16);
            this.CLname.TabIndex = 61;
            this.CLname.Text = "Customer Name :";
            // 
            // Shopping_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(648, 529);
            this.Controls.Add(this.CLname);
            this.Controls.Add(this.CF_name);
            this.Controls.Add(this.finalTotalLabel);
            this.Controls.Add(this.totalVatLabel);
            this.Controls.Add(this.regualTotalLabel);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Final_ListGridView);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Shopping_List";
            this.Text = "Shopping List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shopping_List_FormClosing);
            this.Load += new System.EventHandler(this.Shopping_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Final_ListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView Final_ListGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label finalTotalLabel;
        private System.Windows.Forms.Label totalVatLabel;
        private System.Windows.Forms.Label regualTotalLabel;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label CF_name;
        private System.Windows.Forms.Label CLname;
    }
}