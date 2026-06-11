namespace djk_2606_fp
{
    partial class LedgerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_ledgerName = new System.Windows.Forms.Label();
            this.dataGridView_transactions = new System.Windows.Forms.DataGridView();
            this.button_addTransaction = new System.Windows.Forms.Button();
            this.button_deleteTransaction = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_totalIncome = new System.Windows.Forms.Label();
            this.label_totalExpense = new System.Windows.Forms.Label();
            this.label_balance = new System.Windows.Forms.Label();
            this.button_editTransaction = new System.Windows.Forms.Button();
            this.TransactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ledgerName
            // 
            this.label_ledgerName.AutoSize = true;
            this.label_ledgerName.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_ledgerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.label_ledgerName.Location = new System.Drawing.Point(20, 20);
            this.label_ledgerName.Name = "label_ledgerName";
            this.label_ledgerName.Size = new System.Drawing.Size(109, 30);
            this.label_ledgerName.TabIndex = 0;
            this.label_ledgerName.Text = "거래 내역";
            // 
            // dataGridView_transactions
            // 
            this.dataGridView_transactions.AllowUserToAddRows = false;
            this.dataGridView_transactions.AllowUserToDeleteRows = false;
            this.dataGridView_transactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.dataGridView_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionId,
            this.TransactionDate,
            this.Type,
            this.Amount,
            this.Memo});
            this.dataGridView_transactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.dataGridView_transactions.Location = new System.Drawing.Point(25, 60);
            this.dataGridView_transactions.MultiSelect = false;
            this.dataGridView_transactions.Name = "dataGridView_transactions";
            this.dataGridView_transactions.ReadOnly = true;
            this.dataGridView_transactions.RowHeadersVisible = false;
            this.dataGridView_transactions.RowTemplate.Height = 23;
            this.dataGridView_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_transactions.Size = new System.Drawing.Size(550, 322);
            this.dataGridView_transactions.TabIndex = 1;
            // 
            // button_addTransaction
            // 
            this.button_addTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.button_addTransaction.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_addTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_addTransaction.Location = new System.Drawing.Point(20, 400);
            this.button_addTransaction.Name = "button_addTransaction";
            this.button_addTransaction.Size = new System.Drawing.Size(120, 35);
            this.button_addTransaction.TabIndex = 2;
            this.button_addTransaction.Text = "내역 추가";
            this.button_addTransaction.UseVisualStyleBackColor = false;
            this.button_addTransaction.Click += new System.EventHandler(this.button_addTransaction_Click);
            // 
            // button_deleteTransaction
            // 
            this.button_deleteTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.button_deleteTransaction.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_deleteTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_deleteTransaction.Location = new System.Drawing.Point(272, 400);
            this.button_deleteTransaction.Name = "button_deleteTransaction";
            this.button_deleteTransaction.Size = new System.Drawing.Size(120, 35);
            this.button_deleteTransaction.TabIndex = 3;
            this.button_deleteTransaction.Text = "내역 삭제";
            this.button_deleteTransaction.UseVisualStyleBackColor = false;
            this.button_deleteTransaction.Click += new System.EventHandler(this.button_deleteTransaction_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Gainsboro;
            this.button_close.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_close.Location = new System.Drawing.Point(738, 400);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(120, 35);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "닫기";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(581, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "총 수입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(581, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "총 지출";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(581, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "잔고";
            // 
            // label_totalIncome
            // 
            this.label_totalIncome.AutoSize = true;
            this.label_totalIncome.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_totalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.label_totalIncome.Location = new System.Drawing.Point(581, 92);
            this.label_totalIncome.Name = "label_totalIncome";
            this.label_totalIncome.Size = new System.Drawing.Size(26, 30);
            this.label_totalIncome.TabIndex = 8;
            this.label_totalIncome.Text = "0";
            // 
            // label_totalExpense
            // 
            this.label_totalExpense.AutoSize = true;
            this.label_totalExpense.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_totalExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label_totalExpense.Location = new System.Drawing.Point(581, 189);
            this.label_totalExpense.Name = "label_totalExpense";
            this.label_totalExpense.Size = new System.Drawing.Size(26, 30);
            this.label_totalExpense.TabIndex = 9;
            this.label_totalExpense.Text = "0";
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_balance.ForeColor = System.Drawing.Color.White;
            this.label_balance.Location = new System.Drawing.Point(581, 282);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(26, 30);
            this.label_balance.TabIndex = 10;
            this.label_balance.Text = "0";
            // 
            // button_editTransaction
            // 
            this.button_editTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.button_editTransaction.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_editTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_editTransaction.Location = new System.Drawing.Point(146, 400);
            this.button_editTransaction.Name = "button_editTransaction";
            this.button_editTransaction.Size = new System.Drawing.Size(120, 35);
            this.button_editTransaction.TabIndex = 11;
            this.button_editTransaction.Text = "내역 수정";
            this.button_editTransaction.UseVisualStyleBackColor = false;
            this.button_editTransaction.Click += new System.EventHandler(this.button_editTransaction_Click);
            // 
            // TransactionId
            // 
            this.TransactionId.HeaderText = "ID";
            this.TransactionId.Name = "TransactionId";
            this.TransactionId.ReadOnly = true;
            this.TransactionId.Visible = false;
            // 
            // TransactionDate
            // 
            this.TransactionDate.HeaderText = "날짜";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "유형";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Amount
            // 
            dataGridViewCellStyle1.Format = "N0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Amount.HeaderText = "금액";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Memo
            // 
            this.Memo.HeaderText = "메모";
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            this.Memo.Width = 250;
            // 
            // LedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(884, 451);
            this.Controls.Add(this.button_editTransaction);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.label_totalExpense);
            this.Controls.Add(this.label_totalIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_deleteTransaction);
            this.Controls.Add(this.button_addTransaction);
            this.Controls.Add(this.dataGridView_transactions);
            this.Controls.Add(this.label_ledgerName);
            this.Name = "LedgerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "장부";
            this.Load += new System.EventHandler(this.LedgerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ledgerName;
        private System.Windows.Forms.DataGridView dataGridView_transactions;
        private System.Windows.Forms.Button button_addTransaction;
        private System.Windows.Forms.Button button_deleteTransaction;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_totalIncome;
        private System.Windows.Forms.Label label_totalExpense;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Button button_editTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
    }
}