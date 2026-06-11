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
//장부 목록 폼
namespace djk_2606_fp
{
    public partial class DashboardForm : Form
    {
        string connStr =
            "Server=localhost\\SQLEXPRESS;Database=djkDB;Trusted_Connection=True;";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        private int userId;
        Form parentForm;
        //매개변수로 부모 폼을 받아 창닫기 시 돌아갈 수 있도록 설정
        public DashboardForm(Form loginForm, int userId)
        {
            InitializeComponent();
            parentForm = loginForm;
            this.userId = userId;
        }

        private void Form_dashboard_Load(object sender, EventArgs e)
        {
            LoadLedgers();
        }

        private void LoadLedgers() //생성,삭제후 datagridview에 장부목록 업데이트
        {
            try
            {
                dataGridView_ledgers.Rows.Clear();

                conn = new SqlConnection(connStr);

                conn.Open();

                string sql =
                    @"SELECT
                    LedgerId,
                    Name,
                    Description
                    FROM LedgerTable
                    WHERE UserId = @UserId";

                cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@UserId",
                    userId);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView_ledgers.Rows.Add(
                        reader["LedgerId"],
                        reader["Name"],
                        reader["Description"]);
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "장부 조회 실패\n" + ex.Message);
            }
        }

        private void Form_dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show(); //로그인폼으로 돌아가기
        }

        private void button_createLedger_Click(object sender, EventArgs e)
        {
            CreateLedgerForm form =
                new CreateLedgerForm(userId);

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadLedgers();
            }
        }

        private void button_openLedger_Click(object sender, EventArgs e)
        {
            if (dataGridView_ledgers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "장부를 선택하세요.");
                return;
            }

            int ledgerId =
                Convert.ToInt32(
                    dataGridView_ledgers
                    .SelectedRows[0]
                    .Cells["LedgerId"]
                    .Value);

            LedgerForm ledgerForm =
                new LedgerForm(ledgerId);
            ledgerForm.ShowDialog();
        }

        private void button_deleteLedger_Click(object sender, EventArgs e)
        {
            if (dataGridView_ledgers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "삭제할 장부를 선택하세요.");

                return;
            }

            int ledgerId =
                Convert.ToInt32(
                    dataGridView_ledgers
                    .SelectedRows[0]
                    .Cells["LedgerId"]
                    .Value);

            string ledgerName =
                dataGridView_ledgers
                .SelectedRows[0]
                .Cells["LedgerName"]
                .Value
                .ToString();

            DialogResult result =
                MessageBox.Show(
                    $"'{ledgerName}' 장부를 삭제하시겠습니까?",
                    "삭제 확인",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql =
                        @"DELETE FROM LedgerTable
                        WHERE LedgerId = @LedgerId";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@LedgerId",
                        ledgerId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "장부가 삭제되었습니다.");

                LoadLedgers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "삭제 실패\n" + ex.Message);
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    $"로그아웃 하시겠습니까?",
                    "로그아웃",
                    MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
