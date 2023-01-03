
namespace GCafe
{
    partial class fService
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtIdDV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboLoaiDV = new System.Windows.Forms.ComboBox();
            this.btnThoaiDV = new System.Windows.Forms.Button();
            this.XoaDV = new System.Windows.Forms.Button();
            this.SuaDV = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvDichVu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDichVu)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(19, 297);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 1);
            this.panel4.TabIndex = 13;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenDV.Location = new System.Drawing.Point(170, 91);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(213, 30);
            this.txtTenDV.TabIndex = 12;
            // 
            // txtIdDV
            // 
            this.txtIdDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdDV.Location = new System.Drawing.Point(170, 41);
            this.txtIdDV.Name = "txtIdDV";
            this.txtIdDV.Size = new System.Drawing.Size(213, 30);
            this.txtIdDV.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(379, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "/1H";
            // 
            // cboLoaiDV
            // 
            this.cboLoaiDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLoaiDV.FormattingEnabled = true;
            this.cboLoaiDV.Items.AddRange(new object[] {
            "DO AN",
            "NUOC"});
            this.cboLoaiDV.Location = new System.Drawing.Point(170, 143);
            this.cboLoaiDV.Name = "cboLoaiDV";
            this.cboLoaiDV.Size = new System.Drawing.Size(213, 30);
            this.cboLoaiDV.TabIndex = 8;
            // 
            // btnThoaiDV
            // 
            this.btnThoaiDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoaiDV.Location = new System.Drawing.Point(19, 304);
            this.btnThoaiDV.Name = "btnThoaiDV";
            this.btnThoaiDV.Size = new System.Drawing.Size(387, 55);
            this.btnThoaiDV.TabIndex = 4;
            this.btnThoaiDV.Text = "THOÁT";
            this.btnThoaiDV.UseVisualStyleBackColor = true;
            this.btnThoaiDV.Click += new System.EventHandler(this.btnThoatMay_Click);
            // 
            // XoaDV
            // 
            this.XoaDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XoaDV.Location = new System.Drawing.Point(305, 239);
            this.XoaDV.Name = "XoaDV";
            this.XoaDV.Size = new System.Drawing.Size(99, 52);
            this.XoaDV.TabIndex = 3;
            this.XoaDV.Text = "XÓA";
            this.XoaDV.UseVisualStyleBackColor = true;
            this.XoaDV.Click += new System.EventHandler(this.XoaDV_Click);
            // 
            // SuaDV
            // 
            this.SuaDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SuaDV.Location = new System.Drawing.Point(160, 239);
            this.SuaDV.Name = "SuaDV";
            this.SuaDV.Size = new System.Drawing.Size(99, 52);
            this.SuaDV.TabIndex = 2;
            this.SuaDV.Text = "SỬA";
            this.SuaDV.UseVisualStyleBackColor = true;
            this.SuaDV.Click += new System.EventHandler(this.SuaDV_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemDV.Location = new System.Drawing.Point(19, 239);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(99, 54);
            this.btnThemDV.TabIndex = 1;
            this.btnThemDV.Text = "THÊM";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(80, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "CÀI ĐẶT DỊCH VỤ";
            // 
            // dtgvDichVu
            // 
            this.dtgvDichVu.AllowUserToAddRows = false;
            this.dtgvDichVu.AllowUserToDeleteRows = false;
            this.dtgvDichVu.AllowUserToResizeColumns = false;
            this.dtgvDichVu.AllowUserToResizeRows = false;
            this.dtgvDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.ten,
            this.Type,
            this.Price});
            this.dtgvDichVu.Location = new System.Drawing.Point(8, 10);
            this.dtgvDichVu.Name = "dtgvDichVu";
            this.dtgvDichVu.ReadOnly = true;
            this.dtgvDichVu.RowHeadersVisible = false;
            this.dtgvDichVu.RowHeadersWidth = 51;
            this.dtgvDichVu.RowTemplate.Height = 29;
            this.dtgvDichVu.ShowEditingIcon = false;
            this.dtgvDichVu.Size = new System.Drawing.Size(605, 597);
            this.dtgvDichVu.TabIndex = 0;
            this.dtgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDichVu_CellClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 106.9519F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // ID
            // 
            this.ID.FillWeight = 106.6407F;
            this.ID.HeaderText = "ID Dịch Vụ";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 121;
            // 
            // ten
            // 
            this.ten.FillWeight = 100.1273F;
            this.ten.HeaderText = "Tên Dịch Vụ";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 202;
            // 
            // Type
            // 
            this.Type.FillWeight = 95.0888F;
            this.Type.HeaderText = "Loại Dịch Vụ";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 121;
            // 
            // Price
            // 
            this.Price.FillWeight = 91.19129F;
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 121;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtGiaDV);
            this.panel3.Controls.Add(this.txtTenDV);
            this.panel3.Controls.Add(this.txtIdDV);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cboLoaiDV);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnThoaiDV);
            this.panel3.Controls.Add(this.XoaDV);
            this.panel3.Controls.Add(this.SuaDV);
            this.panel3.Controls.Add(this.btnThemDV);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(639, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 370);
            this.panel3.TabIndex = 5;
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaDV.Location = new System.Drawing.Point(170, 196);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(213, 30);
            this.txtGiaDV.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "GIÁ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(9, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "TÊN DICH VỤ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "LOẠI DICH VU:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(9, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID DỊCH VỤ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvDichVu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 619);
            this.panel1.TabIndex = 3;
            // 
            // fService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1072, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fService";
            this.Load += new System.EventHandler(this.fService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDichVu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtIdDV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboLoaiDV;
        private System.Windows.Forms.Button btnThoaiDV;
        private System.Windows.Forms.Button SuaDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvDichVu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button XoaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}