namespace linkedlistMXH
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoiDungBaiDang = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPostID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpngayDang = new System.Windows.Forms.DateTimePicker();
            this.dgvbaiDang = new System.Windows.Forms.DataGridView();
            this.PostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungBaiDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaBaiDang = new System.Windows.Forms.Button();
            this.btnXoaBaiDang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaiDang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung bài đăng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tác giả";
            // 
            // txtNoiDungBaiDang
            // 
            this.txtNoiDungBaiDang.Location = new System.Drawing.Point(410, 135);
            this.txtNoiDungBaiDang.Name = "txtNoiDungBaiDang";
            this.txtNoiDungBaiDang.Size = new System.Drawing.Size(316, 22);
            this.txtNoiDungBaiDang.TabIndex = 2;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(410, 198);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(316, 22);
            this.txtTacGia.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(103, 336);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 55);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm Bài Đăng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(696, 336);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 55);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvbaiDang);
            this.groupBox1.Location = new System.Drawing.Point(12, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 432);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bài Đăng";
            // 
            // txtPostID
            // 
            this.txtPostID.Location = new System.Drawing.Point(410, 73);
            this.txtPostID.Name = "txtPostID";
            this.txtPostID.Size = new System.Drawing.Size(316, 22);
            this.txtPostID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "PostID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày Đăng";
            // 
            // dtpngayDang
            // 
            this.dtpngayDang.Location = new System.Drawing.Point(410, 266);
            this.dtpngayDang.Name = "dtpngayDang";
            this.dtpngayDang.Size = new System.Drawing.Size(316, 22);
            this.dtpngayDang.TabIndex = 10;
            // 
            // dgvbaiDang
            // 
            this.dgvbaiDang.BackgroundColor = System.Drawing.Color.White;
            this.dgvbaiDang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbaiDang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostID,
            this.noiDungBaiDang,
            this.tacGia,
            this.ngayDang});
            this.dgvbaiDang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbaiDang.Location = new System.Drawing.Point(3, 18);
            this.dgvbaiDang.Name = "dgvbaiDang";
            this.dgvbaiDang.RowHeadersWidth = 51;
            this.dgvbaiDang.RowTemplate.Height = 24;
            this.dgvbaiDang.Size = new System.Drawing.Size(896, 411);
            this.dgvbaiDang.TabIndex = 0;
            this.dgvbaiDang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbaiDang_CellClick);
            // 
            // PostID
            // 
            this.PostID.DataPropertyName = "PostID";
            this.PostID.HeaderText = "PostID";
            this.PostID.MinimumWidth = 6;
            this.PostID.Name = "PostID";
            this.PostID.Width = 125;
            // 
            // noiDungBaiDang
            // 
            this.noiDungBaiDang.DataPropertyName = "noiDungBaiDang";
            this.noiDungBaiDang.HeaderText = "Nội Dung Bài Đăng";
            this.noiDungBaiDang.MinimumWidth = 6;
            this.noiDungBaiDang.Name = "noiDungBaiDang";
            this.noiDungBaiDang.Width = 125;
            // 
            // tacGia
            // 
            this.tacGia.DataPropertyName = "tacGia";
            this.tacGia.HeaderText = "Tác Giả";
            this.tacGia.MinimumWidth = 6;
            this.tacGia.Name = "tacGia";
            this.tacGia.Width = 125;
            // 
            // ngayDang
            // 
            this.ngayDang.DataPropertyName = "ngayDang";
            this.ngayDang.HeaderText = "Ngày Đăng";
            this.ngayDang.MinimumWidth = 6;
            this.ngayDang.Name = "ngayDang";
            this.ngayDang.Width = 125;
            // 
            // btnSuaBaiDang
            // 
            this.btnSuaBaiDang.Location = new System.Drawing.Point(296, 336);
            this.btnSuaBaiDang.Name = "btnSuaBaiDang";
            this.btnSuaBaiDang.Size = new System.Drawing.Size(127, 55);
            this.btnSuaBaiDang.TabIndex = 11;
            this.btnSuaBaiDang.Text = "Sửa Bài Đăng";
            this.btnSuaBaiDang.UseVisualStyleBackColor = true;
            this.btnSuaBaiDang.Click += new System.EventHandler(this.btnSuaBaiDang_Click);
            // 
            // btnXoaBaiDang
            // 
            this.btnXoaBaiDang.Location = new System.Drawing.Point(491, 336);
            this.btnXoaBaiDang.Name = "btnXoaBaiDang";
            this.btnXoaBaiDang.Size = new System.Drawing.Size(127, 55);
            this.btnXoaBaiDang.TabIndex = 12;
            this.btnXoaBaiDang.Text = "Xóa Bài Đăng";
            this.btnXoaBaiDang.UseVisualStyleBackColor = true;
            this.btnXoaBaiDang.Click += new System.EventHandler(this.btnXoaBaiDang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 861);
            this.Controls.Add(this.btnXoaBaiDang);
            this.Controls.Add(this.btnSuaBaiDang);
            this.Controls.Add(this.dtpngayDang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPostID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtNoiDungBaiDang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài Đăng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaiDang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoiDungBaiDang;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvbaiDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungBaiDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDang;
        private System.Windows.Forms.TextBox txtPostID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpngayDang;
        private System.Windows.Forms.Button btnSuaBaiDang;
        private System.Windows.Forms.Button btnXoaBaiDang;
    }
}

