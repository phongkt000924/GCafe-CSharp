
namespace GCafe
{
    partial class fComputer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvMay = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtIdMay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLoaiMay = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThoatMay = new System.Windows.Forms.Button();
            this.btnXoaMay = new System.Windows.Forms.Button();
            this.btnSuaMay = new System.Windows.Forms.Button();
            this.btnThemMay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMay)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvMay);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 619);
            this.panel1.TabIndex = 0;
            // 
            // dtgvMay
            // 
            this.dtgvMay.AllowUserToAddRows = false;
            this.dtgvMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.loai,
            this.status,
            this.Price});
            this.dtgvMay.Location = new System.Drawing.Point(0, -3);
            this.dtgvMay.Name = "dtgvMay";
            this.dtgvMay.RowHeadersWidth = 51;
            this.dtgvMay.RowTemplate.Height = 29;
            this.dtgvMay.Size = new System.Drawing.Size(621, 619);
            this.dtgvMay.TabIndex = 0;
            this.dtgvMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMay_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtGia);
            this.panel3.Controls.Add(this.txtIdMay);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cboLoaiMay);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnThoatMay);
            this.panel3.Controls.Add(this.btnXoaMay);
            this.panel3.Controls.Add(this.btnSuaMay);
            this.panel3.Controls.Add(this.btnThemMay);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(639, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 616);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GCafe.Properties.Resources.slogan;
            this.pictureBox1.Location = new System.Drawing.Point(0, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(17, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 1);
            this.panel4.TabIndex = 13;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGia.Location = new System.Drawing.Point(146, 205);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(213, 30);
            this.txtGia.TabIndex = 12;
            // 
            // txtIdMay
            // 
            this.txtIdMay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdMay.Location = new System.Drawing.Point(146, 103);
            this.txtIdMay.Name = "txtIdMay";
            this.txtIdMay.Size = new System.Drawing.Size(213, 30);
            this.txtIdMay.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(365, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "/1H";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "GIÁ:";
            // 
            // cboLoaiMay
            // 
            this.cboLoaiMay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLoaiMay.FormattingEnabled = true;
            this.cboLoaiMay.Items.AddRange(new object[] {
            "NORMAL",
            "VIP",
            "SVIP"});
            this.cboLoaiMay.Location = new System.Drawing.Point(146, 154);
            this.cboLoaiMay.Name = "cboLoaiMay";
            this.cboLoaiMay.Size = new System.Drawing.Size(213, 30);
            this.cboLoaiMay.TabIndex = 8;
            this.cboLoaiMay.SelectedIndexChanged += new System.EventHandler(this.cboLoaiMay_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(23, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "LOẠI MÁY:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID MÁY:";
            // 
            // btnThoatMay
            // 
            this.btnThoatMay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoatMay.Location = new System.Drawing.Point(19, 406);
            this.btnThoatMay.Name = "btnThoatMay";
            this.btnThoatMay.Size = new System.Drawing.Size(387, 53);
            this.btnThoatMay.TabIndex = 4;
            this.btnThoatMay.Text = "THOÁT";
            this.btnThoatMay.UseVisualStyleBackColor = true;
            this.btnThoatMay.Click += new System.EventHandler(this.btnThoatMay_Click);
            // 
            // btnXoaMay
            // 
            this.btnXoaMay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaMay.Location = new System.Drawing.Point(309, 318);
            this.btnXoaMay.Name = "btnXoaMay";
            this.btnXoaMay.Size = new System.Drawing.Size(99, 51);
            this.btnXoaMay.TabIndex = 3;
            this.btnXoaMay.Text = "XÓA";
            this.btnXoaMay.UseVisualStyleBackColor = true;
            this.btnXoaMay.Click += new System.EventHandler(this.btnXoaMay_Click);
            // 
            // btnSuaMay
            // 
            this.btnSuaMay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuaMay.Location = new System.Drawing.Point(164, 316);
            this.btnSuaMay.Name = "btnSuaMay";
            this.btnSuaMay.Size = new System.Drawing.Size(99, 51);
            this.btnSuaMay.TabIndex = 2;
            this.btnSuaMay.Text = "SỬA";
            this.btnSuaMay.UseVisualStyleBackColor = true;
            this.btnSuaMay.Click += new System.EventHandler(this.btnSuaMay_Click);
            // 
            // btnThemMay
            // 
            this.btnThemMay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemMay.Location = new System.Drawing.Point(16, 318);
            this.btnThemMay.Name = "btnThemMay";
            this.btnThemMay.Size = new System.Drawing.Size(99, 51);
            this.btnThemMay.TabIndex = 1;
            this.btnThemMay.Text = "THÊM";
            this.btnThemMay.UseVisualStyleBackColor = true;
            this.btnThemMay.Click += new System.EventHandler(this.btnThemMay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(104, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "CÀI ĐẶT MÁY";
            // 
            // id
            // 
            this.id.HeaderText = "ID Máy";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // loai
            // 
            this.loai.HeaderText = "Loại Máy";
            this.loai.MinimumWidth = 6;
            this.loai.Name = "loai";
            // 
            // status
            // 
            this.status.HeaderText = "Trạng Thái";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // fComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1072, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fComputer";
            this.Load += new System.EventHandler(this.fComputer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMay)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoatMay;
        private System.Windows.Forms.Button btnXoaMay;
        private System.Windows.Forms.Button btnSuaMay;
        private System.Windows.Forms.Button btnThemMay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtIdMay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLoaiMay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        //private System.Windows.Forms.DataGridView GridViewMay;
        private System.Windows.Forms.DataGridView dtgvMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}