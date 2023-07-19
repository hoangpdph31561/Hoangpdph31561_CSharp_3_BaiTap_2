namespace Hoangpdph31561_CSharp_3_BaiTap_2.View
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            cmbNhaXuatBan = new ComboBox();
            radHetHang = new RadioButton();
            radConHang = new RadioButton();
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClearForm = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            dgvSach = new DataGridView();
            txtTimKiem = new TextBox();
            label5 = new Label();
            err = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbNhaXuatBan);
            groupBox1.Controls.Add(radHetHang);
            groupBox1.Controls.Add(radConHang);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 367);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cmbNhaXuatBan
            // 
            cmbNhaXuatBan.FormattingEnabled = true;
            cmbNhaXuatBan.Location = new Point(224, 283);
            cmbNhaXuatBan.Name = "cmbNhaXuatBan";
            cmbNhaXuatBan.Size = new Size(301, 28);
            cmbNhaXuatBan.TabIndex = 8;
            // 
            // radHetHang
            // 
            radHetHang.AutoSize = true;
            radHetHang.Location = new Point(408, 204);
            radHetHang.Name = "radHetHang";
            radHetHang.Size = new Size(91, 24);
            radHetHang.TabIndex = 7;
            radHetHang.TabStop = true;
            radHetHang.Text = "Hết hàng";
            radHetHang.UseVisualStyleBackColor = true;
            // 
            // radConHang
            // 
            radConHang.AutoSize = true;
            radConHang.Location = new Point(224, 202);
            radConHang.Name = "radConHang";
            radConHang.Size = new Size(93, 24);
            radConHang.TabIndex = 6;
            radConHang.TabStop = true;
            radConHang.Text = "Còn hàng";
            radConHang.UseVisualStyleBackColor = true;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(224, 121);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(301, 27);
            txtMaSach.TabIndex = 5;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(224, 51);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(301, 27);
            txtTenSach.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 286);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhà xuất bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 206);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 124);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 54);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClearForm);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(639, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 367);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnClearForm
            // 
            btnClearForm.Location = new Point(6, 263);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(237, 65);
            btnClearForm.TabIndex = 2;
            btnClearForm.Text = "Clear thông tin";
            btnClearForm.UseVisualStyleBackColor = true;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(6, 157);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(237, 65);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 51);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(237, 65);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSach);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(12, 385);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(876, 339);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(49, 93);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.RowTemplate.Height = 29;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(780, 221);
            dgvSach.TabIndex = 2;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(224, 43);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(397, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.Text = "Nhập tên để tìm kiếm";
            txtTimKiem.MouseClick += txtTimKiem_MouseClick;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            txtTimKiem.Move += txtTimKiem_Move;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 50);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // QuanLySach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 803);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QuanLySach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLySach";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cmbNhaXuatBan;
        private RadioButton radHetHang;
        private RadioButton radConHang;
        private TextBox txtMaSach;
        private TextBox txtTenSach;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClearForm;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvSach;
        private TextBox txtTimKiem;
        private Label label5;
        private ErrorProvider err;
    }
}