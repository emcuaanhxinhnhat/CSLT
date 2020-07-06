namespace quanlyloptinhocvangoaingunganhan
{
    partial class frmTrinhDo
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
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dataGridViewTrinhDo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaTD = new System.Windows.Forms.Label();
            this.TenTD = new System.Windows.Forms.Label();
            this.txtMaTrinhDo = new System.Windows.Forms.TextBox();
            this.txtTenTrinhDo = new System.Windows.Forms.TextBox();
            this.MaTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrinhDo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(85, 370);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(224, 370);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(333, 370);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(469, 369);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(608, 369);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dataGridViewTrinhDo
            // 
            this.dataGridViewTrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrinhDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTrinhDo,
            this.TenTrinhDo});
            this.dataGridViewTrinhDo.Location = new System.Drawing.Point(96, 187);
            this.dataGridViewTrinhDo.Name = "dataGridViewTrinhDo";
            this.dataGridViewTrinhDo.RowHeadersWidth = 51;
            this.dataGridViewTrinhDo.RowTemplate.Height = 24;
            this.dataGridViewTrinhDo.Size = new System.Drawing.Size(555, 150);
            this.dataGridViewTrinhDo.TabIndex = 5;
            this.dataGridViewTrinhDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrinhDo_CellClick);
            this.dataGridViewTrinhDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrinhDo_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "TRÌNH ĐỘ";
            // 
            // MaTD
            // 
            this.MaTD.AutoSize = true;
            this.MaTD.Location = new System.Drawing.Point(65, 101);
            this.MaTD.Name = "MaTD";
            this.MaTD.Size = new System.Drawing.Size(83, 17);
            this.MaTD.TabIndex = 7;
            this.MaTD.Text = "Mã trình độ ";
            // 
            // TenTD
            // 
            this.TenTD.AutoSize = true;
            this.TenTD.Location = new System.Drawing.Point(378, 100);
            this.TenTD.Name = "TenTD";
            this.TenTD.Size = new System.Drawing.Size(89, 17);
            this.TenTD.TabIndex = 8;
            this.TenTD.Text = "Tên trình độ ";
            // 
            // txtMaTrinhDo
            // 
            this.txtMaTrinhDo.Location = new System.Drawing.Point(187, 101);
            this.txtMaTrinhDo.Name = "txtMaTrinhDo";
            this.txtMaTrinhDo.Size = new System.Drawing.Size(100, 22);
            this.txtMaTrinhDo.TabIndex = 9;
            // 
            // txtTenTrinhDo
            // 
            this.txtTenTrinhDo.Location = new System.Drawing.Point(540, 100);
            this.txtTenTrinhDo.Name = "txtTenTrinhDo";
            this.txtTenTrinhDo.Size = new System.Drawing.Size(100, 22);
            this.txtTenTrinhDo.TabIndex = 10;
            // 
            // MaTrinhDo
            // 
            this.MaTrinhDo.DataPropertyName = "MaTrinhDo";
            this.MaTrinhDo.HeaderText = "Mã trình độ";
            this.MaTrinhDo.MinimumWidth = 6;
            this.MaTrinhDo.Name = "MaTrinhDo";
            this.MaTrinhDo.Width = 125;
            // 
            // TenTrinhDo
            // 
            this.TenTrinhDo.DataPropertyName = "TenTrinhDo";
            this.TenTrinhDo.HeaderText = "Tên trình độ ";
            this.TenTrinhDo.MinimumWidth = 6;
            this.TenTrinhDo.Name = "TenTrinhDo";
            this.TenTrinhDo.Width = 125;
            // 
            // frmTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTenTrinhDo);
            this.Controls.Add(this.txtMaTrinhDo);
            this.Controls.Add(this.TenTD);
            this.Controls.Add(this.MaTD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTrinhDo);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Name = "frmTrinhDo";
            this.Text = "frmTrinhDo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrinhDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dataGridViewTrinhDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaTD;
        private System.Windows.Forms.Label TenTD;
        private System.Windows.Forms.TextBox txtMaTrinhDo;
        private System.Windows.Forms.TextBox txtTenTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTrinhDo;
    }
}