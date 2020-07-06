namespace quanlyloptinhocvangoaingunganhan
{
    partial class frmChucDanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.machucdanh = new System.Windows.Forms.Label();
            this.tenchucdanh = new System.Windows.Forms.Label();
            this.dataGridViewChucDanh = new System.Windows.Forms.DataGridView();
            this.MaCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaChucDanh = new System.Windows.Forms.TextBox();
            this.txtTenChucDanh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỨC DANH ";
            // 
            // machucdanh
            // 
            this.machucdanh.AutoSize = true;
            this.machucdanh.Location = new System.Drawing.Point(85, 92);
            this.machucdanh.Name = "machucdanh";
            this.machucdanh.Size = new System.Drawing.Size(101, 17);
            this.machucdanh.TabIndex = 1;
            this.machucdanh.Text = "Mã chức danh ";
            // 
            // tenchucdanh
            // 
            this.tenchucdanh.AutoSize = true;
            this.tenchucdanh.Location = new System.Drawing.Point(85, 138);
            this.tenchucdanh.Name = "tenchucdanh";
            this.tenchucdanh.Size = new System.Drawing.Size(107, 17);
            this.tenchucdanh.TabIndex = 2;
            this.tenchucdanh.Text = "Tên chức danh ";
            // 
            // dataGridViewChucDanh
            // 
            this.dataGridViewChucDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChucDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCD,
            this.TenCD});
            this.dataGridViewChucDanh.Location = new System.Drawing.Point(88, 208);
            this.dataGridViewChucDanh.Name = "dataGridViewChucDanh";
            this.dataGridViewChucDanh.RowHeadersWidth = 51;
            this.dataGridViewChucDanh.RowTemplate.Height = 24;
            this.dataGridViewChucDanh.Size = new System.Drawing.Size(506, 150);
            this.dataGridViewChucDanh.TabIndex = 3;
            this.dataGridViewChucDanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChucDanh_CellClick);
            this.dataGridViewChucDanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChucDanh_CellContentClick);
            // 
            // MaCD
            // 
            this.MaCD.DataPropertyName = "MaChucDanh";
            this.MaCD.HeaderText = "Mã chức danh ";
            this.MaCD.MinimumWidth = 6;
            this.MaCD.Name = "MaCD";
            this.MaCD.Width = 125;
            // 
            // TenCD
            // 
            this.TenCD.DataPropertyName = "TenChucDanh";
            this.TenCD.HeaderText = "Tên chức danh ";
            this.TenCD.MinimumWidth = 6;
            this.TenCD.Name = "TenCD";
            this.TenCD.Width = 125;
            // 
            // txtMaChucDanh
            // 
            this.txtMaChucDanh.Location = new System.Drawing.Point(232, 86);
            this.txtMaChucDanh.Name = "txtMaChucDanh";
            this.txtMaChucDanh.Size = new System.Drawing.Size(100, 22);
            this.txtMaChucDanh.TabIndex = 4;
            // 
            // txtTenChucDanh
            // 
            this.txtTenChucDanh.Location = new System.Drawing.Point(232, 132);
            this.txtTenChucDanh.Name = "txtTenChucDanh";
            this.txtTenChucDanh.Size = new System.Drawing.Size(100, 22);
            this.txtTenChucDanh.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(45, 407);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(186, 406);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(332, 406);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(467, 406);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(623, 406);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmChucDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenChucDanh);
            this.Controls.Add(this.txtMaChucDanh);
            this.Controls.Add(this.dataGridViewChucDanh);
            this.Controls.Add(this.tenchucdanh);
            this.Controls.Add(this.machucdanh);
            this.Controls.Add(this.label1);
            this.Name = "frmChucDanh";
            this.Text = "frmChucDanh";
            this.Load += new System.EventHandler(this.frmChucDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucDanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label machucdanh;
        private System.Windows.Forms.Label tenchucdanh;
        private System.Windows.Forms.DataGridView dataGridViewChucDanh;
        private System.Windows.Forms.TextBox txtMaChucDanh;
        private System.Windows.Forms.TextBox txtTenChucDanh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCD;
    }
}