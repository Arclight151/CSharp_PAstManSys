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
//장부 생성 폼
namespace djk_2606_fp
{
    public partial class CreateLedgerForm : Form
    {
        private int userId;
        public CreateLedgerForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        string connStr =
            "Server=localhost\\SQLEXPRESS;Database=djkDB;Trusted_Connection=True;";

        private void button_create_Click(object sender, EventArgs e)
        {
            //장부명 빈칸일시
            if (textBox_name.Text.Trim() == "")
            {
                MessageBox.Show("장부명을 입력하세요.");
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql =
                        @"INSERT INTO LedgerTable
                        (
                            UserId,
                            Name,
                            Description
                        )
                        VALUES
                        (
                            @UserId,
                            @Name,
                            @Description
                        )";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@UserId",
                        userId);

                    cmd.Parameters.AddWithValue(
                        "@Name",
                        textBox_name.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        textBox_description.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "장부가 생성되었습니다.");

                this.DialogResult =
                    DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "장부 생성 실패\n" + ex.Message);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
