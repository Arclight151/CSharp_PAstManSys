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
//거래 내역 작성/수정 폼
namespace djk_2606_fp
{
    public partial class CreateTransactionForm : Form
    {
        string connStr =
            "Server=localhost\\SQLEXPRESS;Database=djkDB;Trusted_Connection=True;";

        private int ledgerId;
        private int transactionId = -1;

        public CreateTransactionForm(int ledgerId)
        {
            InitializeComponent();
            this.ledgerId = ledgerId;
        }

        public CreateTransactionForm(
            int ledgerId, int transactionId, DateTime date, string type, int amount, string memo)
        {
            InitializeComponent();
            this.ledgerId = ledgerId;
            this.transactionId = transactionId;
            dateTimePicker_date.Value = date;
            comboBox_type.Text = type;
            textBox_amount.Text = amount.ToString();
            textBox_memo.Text = memo;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (comboBox_type.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "유형을 선택하세요.");

                return;
            }

            if (!int.TryParse(
                textBox_amount.Text,
                out int amount))
            {
                MessageBox.Show(
                    "금액을 숫자로 입력하세요.");

                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql;
                    if (transactionId == -1) //신규 작성 시
                    {
                        sql =
                        @"INSERT INTO TransactionTable
                        (
                            LedgerId,
                            TransactionDate,
                            Type,
                            Amount,
                            Memo
                        )
                        VALUES
                        (
                            @LedgerId,
                            @TransactionDate,
                            @Type,
                            @Amount,
                            @Memo
                        )";
                    }
                    else //수정 시
                    {
                        sql =
                        @"UPDATE TransactionTable
                        SET
                            TransactionDate=@TransactionDate,
                            Type=@Type,
                            Amount=@Amount,
                            Memo=@Memo
                        WHERE
                            TransactionId=@TransactionId";
                    }

                    SqlCommand cmd =
                        new SqlCommand(
                            sql,
                            conn);
                    if (transactionId == -1) //신규시에만 사용
                    {
                        cmd.Parameters.AddWithValue(
                        "@LedgerId",
                        ledgerId);
                    }

                    cmd.Parameters.AddWithValue(
                        "@TransactionDate",
                        dateTimePicker_date.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@Type",
                        comboBox_type.Text);

                    cmd.Parameters.AddWithValue(
                        "@Amount",
                        amount);

                    cmd.Parameters.AddWithValue(
                        "@Memo",
                        textBox_memo.Text);

                    if (transactionId != -1) //수정시에만 사용
                    {
                        cmd.Parameters.AddWithValue(
                            "@TransactionId",
                            transactionId);
                    }
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "거래 내역이 저장되었습니다.");

                this.DialogResult =
                    DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    $"거래 내역 작성을 취소합니다. ",
                    "취소",
                    MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
