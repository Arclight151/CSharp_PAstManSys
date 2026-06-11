using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//계정 생성 폼
namespace djk_2606_fp
{
    public partial class CreateAccForm : Form
    {
        public CreateAccForm()
        {
            InitializeComponent();
        }
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        private void Form_createAcc_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null)
                conn.Close();
        }

        private void button_createAcc_Click(object sender, EventArgs e)
        {
            string data1, data2, data3;
            data1 = textBox_id.Text;
            data2 = textBox_pw.Text;
            data3 = textBox_name.Text;

            //정보칸 하나라도 빈칸일 경우
            if (data1 == "" || data2 == "" || data3 == "")
            {
                MessageBox.Show("필요한 정보를 모두 입력해 주세요.");
                return;
            }

            connStr =
                "Server=localhost\\SQLEXPRESS;Database=djkDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                string query =
                    @"INSERT INTO UserTable
                    (
                        LoginId,
                        LoginPW,
                        UserName
                    )
                    VALUES
                    (
                        @LoginId,
                        @LoginPW,
                        @UserName
                    )";

                cmd.CommandText = query;

                cmd.Parameters.AddWithValue(
                    "@LoginId", data1);

                cmd.Parameters.AddWithValue(
                    "@LoginPW", data2);

                cmd.Parameters.AddWithValue(
                    "@UserName", data3);

                cmd.ExecuteNonQuery();
                MessageBox.Show($"{data3} 계정 생성 성공");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("계정 생성 중 오류 발생: " + ex.Message);
            }
        }
    }
}
