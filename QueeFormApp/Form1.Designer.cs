namespace QueeFormApp
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
            this.nqueeGroupBox = new System.Windows.Forms.GroupBox();
            this.dequeeGroupBox = new System.Windows.Forms.GroupBox();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.inputNameTextBox = new System.Windows.Forms.TextBox();
            this.inputComplainTextBox = new System.Windows.Forms.TextBox();
            this.outputNameTextBox = new System.Windows.Forms.TextBox();
            this.outputSerialTextBox = new System.Windows.Forms.TextBox();
            this.outputComplainTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.enqueeButton = new System.Windows.Forms.Button();
            this.dequeeButton = new System.Windows.Forms.Button();
            this.nqueeGroupBox.SuspendLayout();
            this.dequeeGroupBox.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nqueeGroupBox
            // 
            this.nqueeGroupBox.Controls.Add(this.enqueeButton);
            this.nqueeGroupBox.Controls.Add(this.label2);
            this.nqueeGroupBox.Controls.Add(this.label1);
            this.nqueeGroupBox.Controls.Add(this.inputComplainTextBox);
            this.nqueeGroupBox.Controls.Add(this.inputNameTextBox);
            this.nqueeGroupBox.Location = new System.Drawing.Point(4, 13);
            this.nqueeGroupBox.Name = "nqueeGroupBox";
            this.nqueeGroupBox.Size = new System.Drawing.Size(409, 124);
            this.nqueeGroupBox.TabIndex = 0;
            this.nqueeGroupBox.TabStop = false;
            this.nqueeGroupBox.Text = "Enquee Customer";
            // 
            // dequeeGroupBox
            // 
            this.dequeeGroupBox.Controls.Add(this.dequeeButton);
            this.dequeeGroupBox.Controls.Add(this.label5);
            this.dequeeGroupBox.Controls.Add(this.label4);
            this.dequeeGroupBox.Controls.Add(this.label3);
            this.dequeeGroupBox.Controls.Add(this.outputComplainTextBox);
            this.dequeeGroupBox.Controls.Add(this.outputSerialTextBox);
            this.dequeeGroupBox.Controls.Add(this.outputNameTextBox);
            this.dequeeGroupBox.Location = new System.Drawing.Point(419, 12);
            this.dequeeGroupBox.Name = "dequeeGroupBox";
            this.dequeeGroupBox.Size = new System.Drawing.Size(432, 124);
            this.dequeeGroupBox.TabIndex = 1;
            this.dequeeGroupBox.TabStop = false;
            this.dequeeGroupBox.Text = "Dequee Customer";
            // 
            // listGroupBox
            // 
            this.listGroupBox.Controls.Add(this.customerListView);
            this.listGroupBox.Location = new System.Drawing.Point(69, 224);
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.Size = new System.Drawing.Size(782, 124);
            this.listGroupBox.TabIndex = 1;
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Text = "Waiting Quee";
            // 
            // inputNameTextBox
            // 
            this.inputNameTextBox.Location = new System.Drawing.Point(62, 17);
            this.inputNameTextBox.Name = "inputNameTextBox";
            this.inputNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.inputNameTextBox.TabIndex = 0;
            // 
            // inputComplainTextBox
            // 
            this.inputComplainTextBox.Location = new System.Drawing.Point(62, 51);
            this.inputComplainTextBox.Name = "inputComplainTextBox";
            this.inputComplainTextBox.Size = new System.Drawing.Size(341, 20);
            this.inputComplainTextBox.TabIndex = 1;
            // 
            // outputNameTextBox
            // 
            this.outputNameTextBox.Location = new System.Drawing.Point(62, 59);
            this.outputNameTextBox.Name = "outputNameTextBox";
            this.outputNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputNameTextBox.TabIndex = 1;
            // 
            // outputSerialTextBox
            // 
            this.outputSerialTextBox.Location = new System.Drawing.Point(62, 29);
            this.outputSerialTextBox.Name = "outputSerialTextBox";
            this.outputSerialTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputSerialTextBox.TabIndex = 2;
            // 
            // outputComplainTextBox
            // 
            this.outputComplainTextBox.Location = new System.Drawing.Point(62, 86);
            this.outputComplainTextBox.Name = "outputComplainTextBox";
            this.outputComplainTextBox.Size = new System.Drawing.Size(364, 20);
            this.outputComplainTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Complain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serial No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // customerListView
            // 
            this.customerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.customerListView.Location = new System.Drawing.Point(6, 21);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(770, 97);
            this.customerListView.TabIndex = 0;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            this.columnHeader3.Width = 500;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Complain";
            // 
            // enqueeButton
            // 
            this.enqueeButton.Location = new System.Drawing.Point(11, 83);
            this.enqueeButton.Name = "enqueeButton";
            this.enqueeButton.Size = new System.Drawing.Size(75, 23);
            this.enqueeButton.TabIndex = 4;
            this.enqueeButton.Text = "Enquee";
            this.enqueeButton.UseVisualStyleBackColor = true;
            this.enqueeButton.Click += new System.EventHandler(this.enqueeButton_Click);
            // 
            // dequeeButton
            // 
            this.dequeeButton.Location = new System.Drawing.Point(277, 27);
            this.dequeeButton.Name = "dequeeButton";
            this.dequeeButton.Size = new System.Drawing.Size(75, 23);
            this.dequeeButton.TabIndex = 7;
            this.dequeeButton.Text = "Dequee";
            this.dequeeButton.UseVisualStyleBackColor = true;
            this.dequeeButton.Click += new System.EventHandler(this.dequeeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 372);
            this.Controls.Add(this.dequeeGroupBox);
            this.Controls.Add(this.listGroupBox);
            this.Controls.Add(this.nqueeGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.nqueeGroupBox.ResumeLayout(false);
            this.nqueeGroupBox.PerformLayout();
            this.dequeeGroupBox.ResumeLayout(false);
            this.dequeeGroupBox.PerformLayout();
            this.listGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox nqueeGroupBox;
        private System.Windows.Forms.Button enqueeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputComplainTextBox;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.GroupBox dequeeGroupBox;
        private System.Windows.Forms.Button dequeeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputComplainTextBox;
        private System.Windows.Forms.TextBox outputSerialTextBox;
        private System.Windows.Forms.TextBox outputNameTextBox;
        private System.Windows.Forms.GroupBox listGroupBox;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

