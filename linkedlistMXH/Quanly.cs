using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace linkedlistMXH
{
    public partial class Quanly : Form
    {
        string strConn = @"Data Source=LAPTOP-02MQR8KD;Initial Catalog=quanLyBaiDangMXH;Integrated Security=True";
        SqlConnection conn = null;

        private LinkedList<Post> posts;

        public class Post
        {
            public string PostID { get; set; }
            public string noiDungBaiDang { get; set; }
            public string tacGia { get; set; }
            public string ngayDang { get; set; }
        }

        public Quanly()
        {
            InitializeComponent();
            posts = new LinkedList<Post>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            HienThi();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void HienThi()
        {
            string query = "SELECT * FROM baiDang";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvbaiDang.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtPostID.Text == "" || txtNoiDungBaiDang.Text == "" || txtTacGia.Text == "" || dtpngayDang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                string query = "INSERT INTO baiDang VALUES(@postID, @noiDungBaiDang, @tacGia, @ngayDang)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@postID", txtPostID.Text);
                cmd.Parameters.AddWithValue("@noiDungBaiDang", txtNoiDungBaiDang.Text);
                cmd.Parameters.AddWithValue("@tacGia", txtTacGia.Text);
                cmd.Parameters.AddWithValue("@ngayDang", dtpngayDang.Value);
                cmd.ExecuteNonQuery();

                // Thêm vào linkedList
                // Tạo một bài đăng mới
                Post newPost = new Post
                {
                    PostID = txtPostID.Text,
                    noiDungBaiDang = txtNoiDungBaiDang.Text,
                    tacGia = txtTacGia.Text,
                    ngayDang = dtpngayDang.Value.ToString()
                };

                // Thêm vào linkedList
                posts.AddLast(newPost);
                HienThi();
            }
        }

        private void btnSuaBaiDang_Click(object sender, EventArgs e)
        {
            if (txtPostID.Text == "" || txtNoiDungBaiDang.Text == "" || txtTacGia.Text == "" || dtpngayDang.Text == "")
            { 
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            { 
                string query = "UPDATE baiDang SET noiDungBaiDang = @noiDungBaiDang, tacGia = @tacGia, ngayDang = @ngayDang WHERE postID = @postID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@postID", txtPostID.Text);
                cmd.Parameters.AddWithValue("@noiDungBaiDang", txtNoiDungBaiDang.Text);
                cmd.Parameters.AddWithValue("@tacGia", txtTacGia.Text);
                cmd.Parameters.AddWithValue("@ngayDang", dtpngayDang.Value);
                cmd.ExecuteNonQuery();
                // Sửa trong linkedList
                foreach (Post post in posts)
                { 
                    if (post.PostID == txtPostID.Text)
                    { 
                        post.noiDungBaiDang = txtNoiDungBaiDang.Text;
                        post.tacGia = txtTacGia.Text;
                        post.ngayDang = dtpngayDang.Value.ToString();
                    }
                }
                HienThi();
            }
        }

        private void btnXoaBaiDang_Click(object sender, EventArgs e)
        {
            if (txtPostID.Text == "")
            { 
                MessageBox.Show("Vui lòng nhập mã bài đăng cần xóa");
                return;
            }
            else
            { 
                string query = "DELETE FROM baiDang WHERE postID = @postID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@postID", txtPostID.Text);
                cmd.ExecuteNonQuery();
                // Xóa trong linkedList
                foreach (Post post in posts)
                { 
                    if (post.PostID == txtPostID.Text)
                    { 
                        posts.Remove(post);
                        break;
                    }
                }
                HienThi();
            }
        }

        private void dgvbaiDang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            { 
                txtPostID.Text = dgvbaiDang.Rows[index].Cells["postID"].Value.ToString();
                txtNoiDungBaiDang.Text = dgvbaiDang.Rows[index].Cells["noiDungBaiDang"].Value.ToString();
                txtTacGia.Text = dgvbaiDang.Rows[index].Cells["tacGia"].Value.ToString();
                dtpngayDang.Text = dgvbaiDang.Rows[index].Cells["ngayDang"].Value.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
            label5.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label5.Text = button2.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            PictureBox pt = new PictureBox();
            int r = dgvbaiDang.CurrentCell.RowIndex;
            openfile.Filter = "Image Files |*.gif;*.png;*.jpg;*.bmp;*.wmf;*.png";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pt.Image = new Bitmap(openfile.FileName);
                MemoryStream mmst = new MemoryStream();
                pt.Image.Save(mmst, pt.Image.RawFormat);
                dgvbaiDang.Rows[r].Cells["Hình ảnh"].Value = mmst.ToArray();
            }
            else dgvbaiDang.Rows[r].Cells["Hình ảnh"].Value = DBNull.Value;

        }
    }
}
