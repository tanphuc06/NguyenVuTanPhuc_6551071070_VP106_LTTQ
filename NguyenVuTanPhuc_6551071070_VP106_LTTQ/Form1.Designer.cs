namespace NguyenVuTanPhuc_6551071070_VP106_LTTQ
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
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtGia = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 59);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 0;
            label1.Text = "Thông tin sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 216);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 1;
            label2.Text = "Giá bán (VND):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 59);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Thao tác";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 170);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 3;
            label4.Text = "Tên sản phẩm: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 122);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 4;
            label5.Text = "Mã sản phẩm: ";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(251, 119);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(174, 31);
            txtMaSP.TabIndex = 5;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(251, 170);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(174, 31);
            txtTenSP.TabIndex = 6;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(251, 216);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(174, 31);
            txtGia.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(480, 116);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(738, 116);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(608, 116);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(867, 116);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 288);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1090, 225);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 258);
            label6.Name = "label6";
            label6.Size = new Size(210, 27);
            label6.TabIndex = 13;
            label6.Text = "Danh sách sản phẩm";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 510);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtGia);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản lý sản phẩm/Hàng hóa -  VP106";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtGia;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private DataGridView dataGridView1;
        private Label label6;
    }
}
