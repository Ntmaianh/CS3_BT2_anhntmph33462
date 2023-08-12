namespace CS3_BT2.View
{
    partial class QuanLySach
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
            groupBox1 = new GroupBox();
            btnXoaForm = new Button();
            btnHienThi = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            cbNXB = new ComboBox();
            radbtnHetHang = new RadioButton();
            radbtnConHang = new RadioButton();
            txtMa = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lable = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgvSach = new DataGridView();
            txtTimKiem = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaForm);
            groupBox1.Controls.Add(btnHienThi);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(388, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnXoaForm
            // 
            btnXoaForm.Location = new Point(31, 171);
            btnXoaForm.Name = "btnXoaForm";
            btnXoaForm.Size = new Size(242, 32);
            btnXoaForm.TabIndex = 3;
            btnXoaForm.Text = "Xóa form";
            btnXoaForm.UseVisualStyleBackColor = true;
            btnXoaForm.Click += btnXoaForm_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(31, 123);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(242, 32);
            btnHienThi.TabIndex = 2;
            btnHienThi.Text = "Hiên thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(30, 76);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(242, 32);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(31, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(242, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbNXB);
            groupBox2.Controls.Add(radbtnHetHang);
            groupBox2.Controls.Add(radbtnConHang);
            groupBox2.Controls.Add(txtMa);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lable);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 227);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // cbNXB
            // 
            cbNXB.FormattingEnabled = true;
            cbNXB.Location = new Point(71, 171);
            cbNXB.Name = "cbNXB";
            cbNXB.Size = new Size(185, 23);
            cbNXB.TabIndex = 0;
            // 
            // radbtnHetHang
            // 
            radbtnHetHang.AutoSize = true;
            radbtnHetHang.Location = new Point(182, 121);
            radbtnHetHang.Name = "radbtnHetHang";
            radbtnHetHang.Size = new Size(74, 19);
            radbtnHetHang.TabIndex = 7;
            radbtnHetHang.TabStop = true;
            radbtnHetHang.Text = "Hết hàng";
            radbtnHetHang.UseVisualStyleBackColor = true;
            // 
            // radbtnConHang
            // 
            radbtnConHang.AutoSize = true;
            radbtnConHang.Location = new Point(71, 121);
            radbtnConHang.Name = "radbtnConHang";
            radbtnConHang.Size = new Size(77, 19);
            radbtnConHang.TabIndex = 0;
            radbtnConHang.TabStop = true;
            radbtnConHang.Text = "Còn hàng";
            radbtnConHang.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(68, 68);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(188, 23);
            txtMa.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(68, 22);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(188, 23);
            txtTen.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 180);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 5;
            label4.Text = "NXB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 123);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Trạng thái";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(6, 76);
            lable.Name = "lable";
            lable.Size = new Size(24, 15);
            lable.TabIndex = 3;
            lable.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 2;
            label1.Text = "Tên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSach);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(12, 267);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(695, 240);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(11, 64);
            dgvSach.Name = "dgvSach";
            dgvSach.RowTemplate.Height = 25;
            dgvSach.Size = new Size(669, 170);
            dgvSach.TabIndex = 9;
            dgvSach.CellMouseClick += dgvSach_CellMouseClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(150, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(462, 23);
            txtTimKiem.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 25);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm";
            // 
            // QuanLySach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 519);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "QuanLySach";
            Text = "QuanLySach";
            Load += QuanLySach_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label lable;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnXoaForm;
        private Button btnHienThi;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbNXB;
        private RadioButton radbtnHetHang;
        private RadioButton radbtnConHang;
        private TextBox txtMa;
        private TextBox txtTen;
        private Label label5;
        private DataGridView dgvSach;
        private TextBox txtTimKiem;
    }
}