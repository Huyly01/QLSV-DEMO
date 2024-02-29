namespace QLSV
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMASV = new TextBox();
            txtTENSV = new TextBox();
            txtKHOA = new TextBox();
            txtLOP = new TextBox();
            txtDIACHI = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            dataGridViewSV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MASV = new DataGridViewTextBoxColumn();
            TENSV = new DataGridViewTextBoxColumn();
            KHOA = new DataGridViewTextBoxColumn();
            LOP = new DataGridViewTextBoxColumn();
            DIACHI = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Ma sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 90);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "Lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 120);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // txtMASV
            // 
            txtMASV.Location = new Point(128, 8);
            txtMASV.Name = "txtMASV";
            txtMASV.Size = new Size(163, 23);
            txtMASV.TabIndex = 5;
            // 
            // txtTENSV
            // 
            txtTENSV.Location = new Point(128, 33);
            txtTENSV.Name = "txtTENSV";
            txtTENSV.Size = new Size(163, 23);
            txtTENSV.TabIndex = 6;
            // 
            // txtKHOA
            // 
            txtKHOA.Location = new Point(128, 61);
            txtKHOA.Name = "txtKHOA";
            txtKHOA.Size = new Size(163, 23);
            txtKHOA.TabIndex = 7;
            // 
            // txtLOP
            // 
            txtLOP.Location = new Point(128, 90);
            txtLOP.Name = "txtLOP";
            txtLOP.Size = new Size(163, 23);
            txtLOP.TabIndex = 8;
            // 
            // txtDIACHI
            // 
            txtDIACHI.Location = new Point(128, 120);
            txtDIACHI.Multiline = true;
            txtDIACHI.Name = "txtDIACHI";
            txtDIACHI.Size = new Size(274, 57);
            txtDIACHI.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(128, 208);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(252, 208);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(11, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSV.Columns.AddRange(new DataGridViewColumn[] { ID, MASV, TENSV, KHOA, LOP, DIACHI });
            dataGridViewSV.Location = new Point(11, 237);
            dataGridViewSV.Name = "dataGridView1";
            dataGridViewSV.Size = new Size(593, 150);
            dataGridViewSV.TabIndex = 14;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // MASV
            // 
            MASV.DataPropertyName = "MASV";
            MASV.HeaderText = "MASV";
            MASV.Name = "MASV";
            // 
            // TENSV
            // 
            TENSV.DataPropertyName = "TENSV";
            TENSV.HeaderText = "Tên sinh viên";
            TENSV.Name = "TENSV";
            // 
            // KHOA
            // 
            KHOA.DataPropertyName = "KHOA";
            KHOA.HeaderText = "Khoa";
            KHOA.Name = "KHOA";
            // 
            // LOP
            // 
            LOP.DataPropertyName = "LOP";
            LOP.HeaderText = "Lớp ";
            LOP.Name = "LOP";
            // 
            // DIACHI
            // 
            DIACHI.DataPropertyName = "DIACHI";
            DIACHI.HeaderText = "Địa chỉ";
            DIACHI.Name = "DIACHI";
            DIACHI.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewSV);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtDIACHI);
            Controls.Add(txtLOP);
            Controls.Add(txtKHOA);
            Controls.Add(txtTENSV);
            Controls.Add(txtMASV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMASV;
        private TextBox txtTENSV;
        private TextBox txtKHOA;
        private TextBox txtLOP;
        private TextBox txtDIACHI;
        private Button button2;
        private Button button3;
        private Button button1;
        private DataGridView dataGridViewSV;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MASV;
        private DataGridViewTextBoxColumn TENSV;
        private DataGridViewTextBoxColumn KHOA;
        private DataGridViewTextBoxColumn LOP;
        private DataGridViewTextBoxColumn DIACHI;
    }
}
