using System.Data;
namespace QLSV
{
   public partial class Form1 : Form
    {
        bllSV bllSV;
        public Form1()
        {
            InitializeComponent();
            bllSV = new bllSV();
        }
        public void ShowAllSV()
        {
            DataTable dt = bllSV.getAllSinhVien();
            dataGridViewSV.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllSV();
        }
        public bool CheckData()
        {
            {
                if (string.IsNullOrEmpty(txtMASV.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin mã sinh viên!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMASV.Focus();
                    return false;
                }
                return true;
                if (string.IsNullOrEmpty(txtTENSV.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tên sinh viên!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTENSV.Focus();
                    return false;
                }
                return true;

                if (string.IsNullOrEmpty(txtKHOA.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin khoa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKHOA.Focus();
                    return false;
                }
                return true;

                if (string.IsNullOrEmpty(txtLOP.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin lớp !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLOP.Focus();
                    return false;
                }
                return true;

                if (string.IsNullOrEmpty(txtDIACHI.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin địa chỉ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDIACHI.Focus();
                    return false;
                }
                return true;

            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                TTSV sv = new TTSV();
                sv.MASV = txtMASV.Text;
                sv.TENSV = txtTENSV.Text;
                sv.KHOA = txtKHOA.Text;
                sv.LOP = txtLOP.Text;
                sv.DIACHI = txtDIACHI.Text;

                if (bllSV.InsertSinhVien(sv))
                    ShowAllSV();
                else
                    MessageBox.Show("Đã sảy ra lỗi vui lòng thử lại sau!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        int ID;

    }
}
