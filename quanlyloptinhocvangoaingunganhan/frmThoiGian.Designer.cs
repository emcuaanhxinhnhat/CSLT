﻿namespace quanlyloptinhocvangoaingunganhan
{
    partial class frmThoiGian
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
            this.MaTG = new System.Windows.Forms.Label();
            this.TenTG = new System.Windows.Forms.Label();
            this.txtMaThoiGian = new System.Windows.Forms.TextBox();
            this.txtTenThoiGian = new System.Windows.Forms.TextBox();
            this.dataGridViewThoiGian = new System.Windows.Forms.DataGridView();
            this.MaThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThoiGian)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỜI GIAN";
            // 
            // MaTG
            // 
            this.MaTG.AutoSize = true;
            this.MaTG.Location = new System.Drawing.Point(71, 104);
            this.MaTG.Name = "MaTG";
            this.MaTG.Size = new System.Drawing.Size(89, 17);
            this.MaTG.TabIndex = 1;
            this.MaTG.Text = "Mã thời gian ";
            // 
            // TenTG
            // 
            this.TenTG.AutoSize = true;
            this.TenTG.Location = new System.Drawing.Point(357, 104);
            this.TenTG.Name = "TenTG";
            this.TenTG.Size = new System.Drawing.Size(95, 17);
            this.TenTG.TabIndex = 2;
            this.TenTG.Text = "Tên thời gian ";
            // 
            // txtMaThoiGian
            // 
            this.txtMaThoiGian.Location = new System.Drawing.Point(167, 98);
            this.txtMaThoiGian.Name = "txtMaThoiGian";
            this.txtMaThoiGian.Size = new System.Drawing.Size(100, 22);
            this.txtMaThoiGian.TabIndex = 3;
            // 
            // txtTenThoiGian
            // 
            this.txtTenThoiGian.Location = new System.Drawing.Point(483, 104);
            this.txtTenThoiGian.Name = "txtTenThoiGian";
            this.txtTenThoiGian.Size = new System.Drawing.Size(100, 22);
            this.txtTenThoiGian.TabIndex = 4;
            // 
            // dataGridViewThoiGian
            // 
            this.dataGridViewThoiGian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThoiGian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThoiGian,
            this.TenThoiGian});
            this.dataGridViewThoiGian.Location = new System.Drawing.Point(74, 152);
            this.dataGridViewThoiGian.Name = "dataGridViewThoiGian";
            this.dataGridViewThoiGian.RowHeadersWidth = 51;
            this.dataGridViewThoiGian.RowTemplate.Height = 24;
            this.dataGridViewThoiGian.Size = new System.Drawing.Size(591, 150);
            this.dataGridViewThoiGian.TabIndex = 5;
            this.dataGridViewThoiGian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThoiGian_CellClick);
            this.dataGridViewThoiGian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThoiGian_CellContentClick);
            // 
            // MaThoiGian
            // 
            this.MaThoiGian.DataPropertyName = "MaThoiGian";
            this.MaThoiGian.HeaderText = "Mã thời gian";
            this.MaThoiGian.MinimumWidth = 6;
            this.MaThoiGian.Name = "MaThoiGian";
            this.MaThoiGian.Width = 125;
            // 
            // TenThoiGian
            // 
            this.TenThoiGian.DataPropertyName = "TenThoiGian";
            this.TenThoiGian.HeaderText = "Tên thời gian";
            this.TenThoiGian.MinimumWidth = 6;
            this.TenThoiGian.Name = "TenThoiGian";
            this.TenThoiGian.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(74, 358);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(215, 358);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 7;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(329, 358);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(457, 357);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(590, 358);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát ";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewThoiGian);
            this.Controls.Add(this.txtTenThoiGian);
            this.Controls.Add(this.txtMaThoiGian);
            this.Controls.Add(this.TenTG);
            this.Controls.Add(this.MaTG);
            this.Controls.Add(this.label1);
            this.Name = "frmThoiGian";
            this.Text = "frmThoiGian";
            this.Load += new System.EventHandler(this.frmThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThoiGian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaTG;
        private System.Windows.Forms.Label TenTG;
        private System.Windows.Forms.TextBox txtMaThoiGian;
        private System.Windows.Forms.TextBox txtTenThoiGian;
        private System.Windows.Forms.DataGridView dataGridViewThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThoiGian;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
    }
}