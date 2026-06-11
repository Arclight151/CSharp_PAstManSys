using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//SQLCMD -S LOCALHOST\SQLEXPRESS -E
//로그인 폼(최초 페이지)
namespace djk_2606_fp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string connStr = 
            "Server=localhost\\SQLEXPRESS;Database=djkDB;Trusted_Connection=True;";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //잔존 db 연결 해제 처리
            if (conn != null)
                conn.Close();
            Application.Exit();
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            string loginId = textBox_id.Text, loginPw = textBox_pw.Text;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                //id, 비번 조회 sql문
                //parameter문 활용하여 sql injection 취약점 대응
                string query =
                    "SELECT UserId, UserName " +
                    "FROM UserTable " +
                    "WHERE LoginID = @id AND LoginPW = @pw";

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", loginId);
                cmd.Parameters.AddWithValue("@pw", loginPw);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    string userName = reader.GetString(1);

                    MessageBox.Show($"{userName}님 로그인 성공");

                    //메인 화면 열기
                    DashboardForm dashboardForm = new DashboardForm(this, userId);
                    dashboardForm.Show();
                    this.Hide();
                    textBox_id.Text = "";
                    textBox_pw.Text = "";
                }
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (conn != null)
                    conn.Close();
            }
        }

        private void button_createAcc_Click(object sender, EventArgs e)
        {
            //계정 생성 폼 열기
            CreateAccForm subForm = new CreateAccForm();
            subForm.ShowDialog();
        }

        //db 연결 테스트용
        private void button_test_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            bool isConn;
            try
            {
                conn.Open();
                isConn = true;
            }
            catch (Exception ex)
            {
                isConn = false;
            }
            MessageBox.Show("연결 테스트 " + (isConn ? "성공" : "실패"));
            conn.Close();
        }
    }
}
