namespace karuna_book_lister
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
            components = new System.ComponentModel.Container();
            input_lbl = new Label();
            input_name = new TextBox();
            listView1 = new ListView();
            searchbtn = new Button();
            addbtn = new Button();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            input_author = new TextBox();
            input_publication = new TextBox();
            label3 = new Label();
            input_published_date = new DateTimePicker();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // input_lbl
            // 
            input_lbl.AutoSize = true;
            input_lbl.Location = new Point(12, 91);
            input_lbl.Name = "input_lbl";
            input_lbl.Size = new Size(102, 20);
            input_lbl.TabIndex = 0;
            input_lbl.Text = "BOOK NAME :";
            input_lbl.Click += label1_Click;
            // 
            // input_name
            // 
            input_name.Location = new Point(120, 88);
            input_name.Name = "input_name";
            input_name.Size = new Size(556, 27);
            input_name.TabIndex = 1;
            input_name.TextChanged += input_TextChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(1035, 337);
            listView1.Name = "listView1";
            listView1.Size = new Size(329, 251);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = SystemColors.ControlDark;
            searchbtn.Location = new Point(429, 183);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(148, 50);
            searchbtn.TabIndex = 3;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = SystemColors.ActiveCaption;
            addbtn.Location = new Point(670, 183);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(135, 50);
            addbtn.TabIndex = 4;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(474, 24);
            label1.Name = "label1";
            label1.Size = new Size(411, 38);
            label1.TabIndex = 5;
            label1.Text = "Library Management System";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(713, 91);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "AUTHOR :";
            label2.Click += label2_Click;
            // 
            // input_author
            // 
            input_author.Location = new Point(811, 88);
            input_author.Name = "input_author";
            input_author.Size = new Size(553, 27);
            input_author.TabIndex = 8;
            // 
            // input_publication
            // 
            input_publication.Location = new Point(120, 121);
            input_publication.Name = "input_publication";
            input_publication.Size = new Size(271, 27);
            input_publication.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 10;
            label3.Text = "PUBLICATION :";
            // 
            // input_published_date
            // 
            input_published_date.Location = new Point(811, 128);
            input_published_date.Name = "input_published_date";
            input_published_date.Size = new Size(269, 27);
            input_published_date.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(713, 128);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 12;
            label4.Text = "PUBLISHED :";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(873, 258);
            dataGridView1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(263, 290);
            label5.Name = "label5";
            label5.Size = new Size(217, 31);
            label5.TabIndex = 14;
            label5.Text = "Search result viewer";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1153, 303);
            label6.Name = "label6";
            label6.Size = new Size(100, 31);
            label6.TabIndex = 15;
            label6.Text = "LIBRARY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 607);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(input_published_date);
            Controls.Add(label3);
            Controls.Add(input_publication);
            Controls.Add(input_author);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addbtn);
            Controls.Add(searchbtn);
            Controls.Add(listView1);
            Controls.Add(input_name);
            Controls.Add(input_lbl);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label input_lbl;
        private TextBox input_name;
        private ListView listView1;
        private Button searchbtn;
        private Button addbtn;
        private BindingSource bindingSource1;
        private Label label1;
        private Label label2;
        private TextBox input_author;
        private TextBox input_publication;
        private Label label3;
        private DateTimePicker input_published_date;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
    }
}
