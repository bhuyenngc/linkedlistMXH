using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using static linkedlistMXH.Program;

namespace linkedlistMXH
{
    public partial class Quanly : Form
    {
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

        private void HienThi()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PostID");
            dt.Columns.Add("noiDungBaiDang");
            dt.Columns.Add("tacGia");
            dt.Columns.Add("ngayDang");

            foreach (Post post in posts)
            {
                dt.Rows.Add(post.PostID, post.noiDungBaiDang, post.tacGia, post.ngayDang);
            }

            dgvbaiDang.DataSource = dt;
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


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtPostID.Text == "" || txtNoiDungBaiDang.Text == "" || txtTacGia.Text == "" || dtpngayDang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
                Application.Exit();

        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
            label5.Text = button1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label5.Text = button2.Text;
        }
    }
}
   