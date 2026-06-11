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
//거래 내역 조회(장부 내부) 폼
namespace djk_2606_fp
{
    public partial class LedgerForm : Form
    {
        string connStr = "Server=localhost\\SQLEXPRESS;Database=djkDB;Trusted_Connection=True;";

        private int ledgerId;
        public LedgerForm(int ledgerId)
        {
            InitializeComponent();
            this.ledgerId = ledgerId;
        }

        private void LedgerForm_Load(object sender, EventArgs e)
        {
            LoadLedgerInfo();
            LoadTransactions();
        }

        private void LoadLedgerInfo()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql =
                        @"SELECT Name
                        FROM LedgerTable
                        WHERE LedgerId = @LedgerId";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@LedgerId",
                        ledgerId);

                    object result =
                        cmd.ExecuteScalar();

                    if (result != null)
                    {
                        label_ledgerName.Text =
                            result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTransactions() //거래내역 목록 갱신
        {
            try
            {
                dataGridView_transactions.Rows.Clear();

                using (SqlConnection conn =
                    new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql =
                        @"SELECT
                            TransactionId,
                            TransactionDate,
                            Type,
                            Amount,
                            Memo
                        FROM TransactionTable
                        WHERE LedgerId = @LedgerId
                        ORDER BY TransactionDate DESC";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@LedgerId",
                        ledgerId);

                    SqlDataReader reader =
                        cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dataGridView_transactions.Rows.Add(
                            reader["TransactionId"],
                            Convert.ToDateTime(
                                reader["TransactionDate"]).ToString("yyyy-MM-dd"),
                            reader["Type"],
                            reader["Amount"],
                            reader["Memo"]);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadSummary();
        }

        private void LoadSummary() //통계(수입/지출/잔액) 갱신
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                    ISNULL(
                        SUM(
                            CASE
                            WHEN Type='수입'
                            THEN Amount
                            ELSE 0
                            END
                        ),0),
                    ISNULL(
                        SUM(
                            CASE
                            WHEN Type='지출'
                            THEN Amount
                            ELSE 0
                            END
                        ),0)
                    FROM TransactionTable
                    WHERE LedgerId=@LedgerId";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@LedgerId",
                        ledgerId);

                    SqlDataReader reader =
                        cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int income =
                            Convert.ToInt32(
                                reader[0]);

                        int expense =
                            Convert.ToInt32(
                                reader[1]);

                        int balance =
                            income - expense;

                        label_totalIncome.Text =
                            //"총 수입 : " + <-별도 레이블 추가
                            income.ToString("N0") +
                            "원";

                        label_totalExpense.Text =
                            //"총 지출 : " +
                            expense.ToString("N0") +
                            "원";

                        label_balance.Text =
                            //"현재 잔액 : " +
                            balance.ToString("N0") +
                            "원";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_addTransaction_Click(object sender, EventArgs e)
        {
            CreateTransactionForm form = new CreateTransactionForm(ledgerId);
            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadTransactions();
            }
        }

        private void button_deleteTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridView_transactions.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "삭제할 내역을 선택하세요.");
                return;
            }

            int transactionId =
                Convert.ToInt32(
                    dataGridView_transactions
                    .SelectedRows[0]
                    .Cells["TransactionId"]
                    .Value);

            DialogResult result =
                MessageBox.Show(
                    "선택한 내역을 삭제하시겠습니까?",
                    "삭제 확인",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql =
                        @"DELETE
                        FROM TransactionTable
                        WHERE TransactionId =
                        @TransactionId";

                    SqlCommand cmd =
                        new SqlCommand(
                            sql,
                            conn);

                    cmd.Parameters.AddWithValue(
                        "@TransactionId",
                        transactionId);

                    cmd.ExecuteNonQuery();
                }

                LoadTransactions();

                MessageBox.Show(
                    "삭제되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_editTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridView_transactions
                .SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "수정할 내역을 선택하세요.");
                return;
            }

            DataGridViewRow row =
                dataGridView_transactions
                .SelectedRows[0];

            int transactionId =
                Convert.ToInt32(
                    row.Cells["TransactionId"]
                    .Value);

            DateTime transactionDate =
                Convert.ToDateTime(
                    row.Cells["TransactionDate"]
                    .Value);

            string type =
                row.Cells["Type"]
                .Value
                .ToString();

            int amount =
                Convert.ToInt32(
                    row.Cells["Amount"]
                    .Value);

            string memo =
                row.Cells["Memo"]
                .Value
                .ToString();

            CreateTransactionForm form =
                new CreateTransactionForm(
                    ledgerId,
                    transactionId,
                    transactionDate,
                    type,
                    amount,
                    memo);

            if (form.ShowDialog()
                == DialogResult.OK)
            {
                LoadTransactions();
            }
        }
    }
}
