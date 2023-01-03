
namespace GCafe
{
    partial class fGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGuest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvGuest = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuaMK = new System.Windows.Forms.Button();
            this.btnXoaKhach = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKhach = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMoneyC = new System.Windows.Forms.TextBox();
            this.txtTKC = new System.Windows.Forms.TextBox();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.btnThoatKhach = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassC = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGuest)).BeginInit();
            this.dtgvGuest.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvGuest);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 622);
            this.panel1.TabIndex = 0;
            // 
            // dtgvGuest
            // 
            this.dtgvGuest.AllowUserToAddRows = false;
            this.dtgvGuest.AllowUserToDeleteRows = false;
            this.dtgvGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.user,
            this.Pass,
            this.Money});
            this.dtgvGuest.Controls.Add(this.btnReset);
            this.dtgvGuest.Location = new System.Drawing.Point(0, 0);
            this.dtgvGuest.Name = "dtgvGuest";
            this.dtgvGuest.ReadOnly = true;
            this.dtgvGuest.RowHeadersWidth = 30;
            this.dtgvGuest.RowTemplate.Height = 29;
            this.dtgvGuest.Size = new System.Drawing.Size(621, 622);
            this.dtgvGuest.TabIndex = 0;
            this.dtgvGuest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGuest_CellClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // user
            // 
            this.user.HeaderText = "Tài Khoản";
            this.user.MinimumWidth = 6;
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Mật Khẩu";
            this.Pass.MinimumWidth = 6;
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            // 
            // Money
            // 
            this.Money.HeaderText = "Số Tiền";
            this.Money.MinimumWidth = 6;
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(0, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(32, 30);
            this.btnReset.TabIndex = 3;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.Controls.Add(this.btnSuaMK);
            this.panel2.Controls.Add(this.btnXoaKhach);
            this.panel2.Controls.Add(this.txtMoney);
            this.panel2.Controls.Add(this.txtTK);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTimKhach);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(639, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 344);
            this.panel2.TabIndex = 1;
            // 
            // btnSuaMK
            // 
            this.btnSuaMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuaMK.Location = new System.Drawing.Point(61, 304);
            this.btnSuaMK.Name = "btnSuaMK";
            this.btnSuaMK.Size = new System.Drawing.Size(139, 29);
            this.btnSuaMK.TabIndex = 13;
            this.btnSuaMK.Text = "Reset Pass";
            this.btnSuaMK.UseVisualStyleBackColor = true;
            this.btnSuaMK.Click += new System.EventHandler(this.btnSuaMK_Click);
            // 
            // btnXoaKhach
            // 
            this.btnXoaKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaKhach.Location = new System.Drawing.Point(237, 304);
            this.btnXoaKhach.Name = "btnXoaKhach";
            this.btnXoaKhach.Size = new System.Drawing.Size(94, 29);
            this.btnXoaKhach.TabIndex = 12;
            this.btnXoaKhach.Text = "Xóa";
            this.btnXoaKhach.UseVisualStyleBackColor = true;
            this.btnXoaKhach.Click += new System.EventHandler(this.btnXoaKhach_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoney.Location = new System.Drawing.Point(37, 250);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(344, 34);
            this.txtMoney.TabIndex = 9;
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTK.Location = new System.Drawing.Point(37, 174);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(344, 34);
            this.txtTK.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "SỐ TIỀN CÒN LẠI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "TÊN TÀI KHOẢN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // btnTimKhach
            // 
            this.btnTimKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKhach.Location = new System.Drawing.Point(328, 46);
            this.btnTimKhach.Name = "btnTimKhach";
            this.btnTimKhach.Size = new System.Drawing.Size(77, 33);
            this.btnTimKhach.TabIndex = 2;
            this.btnTimKhach.Text = "TÌM";
            this.btnTimKhach.UseVisualStyleBackColor = true;
            this.btnTimKhach.Click += new System.EventHandler(this.btnTimKhach_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(12, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(310, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.txtPassC);
            this.panel3.Controls.Add(this.txtMoneyC);
            this.panel3.Controls.Add(this.txtTKC);
            this.panel3.Controls.Add(this.btnThemKhach);
            this.panel3.Controls.Add(this.btnThoatKhach);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(639, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 272);
            this.panel3.TabIndex = 2;
            // 
            // txtMoneyC
            // 
            this.txtMoneyC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoneyC.Location = new System.Drawing.Point(61, 197);
            this.txtMoneyC.Name = "txtMoneyC";
            this.txtMoneyC.Size = new System.Drawing.Size(344, 30);
            this.txtMoneyC.TabIndex = 7;
            // 
            // txtTKC
            // 
            this.txtTKC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTKC.Location = new System.Drawing.Point(61, 79);
            this.txtTKC.Name = "txtTKC";
            this.txtTKC.Size = new System.Drawing.Size(344, 30);
            this.txtTKC.TabIndex = 5;
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemKhach.Location = new System.Drawing.Point(92, 233);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(94, 29);
            this.btnThemKhach.TabIndex = 4;
            this.btnThemKhach.Text = "THÊM";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // btnThoatKhach
            // 
            this.btnThoatKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoatKhach.Location = new System.Drawing.Point(237, 233);
            this.btnThoatKhach.Name = "btnThoatKhach";
            this.btnThoatKhach.Size = new System.Drawing.Size(94, 29);
            this.btnThoatKhach.TabIndex = 4;
            this.btnThoatKhach.Text = "THOÁT";
            this.btnThoatKhach.UseVisualStyleBackColor = true;
            this.btnThoatKhach.Click += new System.EventHandler(this.btnThoatKhach_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "SỐ TIỀN NẠP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "MẬT KHẨU:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "TÊN TÀI KHOẢN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(92, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "TẠO TÀI KHOẢN";
            // 
            // txtPassC
            // 
            this.txtPassC.Location = new System.Drawing.Point(61, 141);
            this.txtPassC.Name = "txtPassC";
            this.txtPassC.Size = new System.Drawing.Size(344, 27);
            this.txtPassC.TabIndex = 8;
            // 
            // fGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1072, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fGuest";
            this.Load += new System.EventHandler(this.fGuest_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGuest)).EndInit();
            this.dtgvGuest.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKhach;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSuaMK;
        private System.Windows.Forms.Button btnXoaKhach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtTKC;
        private System.Windows.Forms.Button btnThoatKhach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvGuest;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.TextBox txtMoneyC;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPassC;
    }
}