namespace djk_2606_fp
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.label_ledgerList = new System.Windows.Forms.Label();
            this.button_createLedger = new System.Windows.Forms.Button();
            this.button_openLedger = new System.Windows.Forms.Button();
            this.button_deleteLedger = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.dataGridView_ledgers = new System.Windows.Forms.DataGridView();
            this.LedgerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LedgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ledgers)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.label_title.Location = new System.Drawing.Point(30, 25);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(175, 31);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "자산 관리 시스템";
            // 
            // label_ledgerList
            // 
            this.label_ledgerList.AutoSize = true;
            this.label_ledgerList.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.label_ledgerList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.label_ledgerList.Location = new System.Drawing.Point(32, 90);
            this.label_ledgerList.Name = "label_ledgerList";
            this.label_ledgerList.Size = new System.Drawing.Size(74, 20);
            this.label_ledgerList.TabIndex = 1;
            this.label_ledgerList.Text = "장부 목록";
            // 
            // button_createLedger
            // 
            this.button_createLedger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.button_createLedger.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_createLedger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_createLedger.Location = new System.Drawing.Point(36, 390);
            this.button_createLedger.Name = "button_createLedger";
            this.button_createLedger.Size = new System.Drawing.Size(110, 35);
            this.button_createLedger.TabIndex = 5;
            this.button_createLedger.Text = "새 장부";
            this.button_createLedger.UseVisualStyleBackColor = false;
            this.button_createLedger.Click += new System.EventHandler(this.button_createLedger_Click);
            // 
            // button_openLedger
            // 
            this.button_openLedger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.button_openLedger.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_openLedger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_openLedger.Location = new System.Drawing.Point(156, 390);
            this.button_openLedger.Name = "button_openLedger";
            this.button_openLedger.Size = new System.Drawing.Size(110, 35);
            this.button_openLedger.TabIndex = 6;
            this.button_openLedger.Text = "열기";
            this.button_openLedger.UseVisualStyleBackColor = false;
            this.button_openLedger.Click += new System.EventHandler(this.button_openLedger_Click);
            // 
            // button_deleteLedger
            // 
            this.button_deleteLedger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.button_deleteLedger.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_deleteLedger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_deleteLedger.Location = new System.Drawing.Point(276, 390);
            this.button_deleteLedger.Name = "button_deleteLedger";
            this.button_deleteLedger.Size = new System.Drawing.Size(110, 35);
            this.button_deleteLedger.TabIndex = 7;
            this.button_deleteLedger.Text = "삭제";
            this.button_deleteLedger.UseVisualStyleBackColor = false;
            this.button_deleteLedger.Click += new System.EventHandler(this.button_deleteLedger_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Gainsboro;
            this.button_logout.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_logout.Location = new System.Drawing.Point(494, 390);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(110, 35);
            this.button_logout.TabIndex = 8;
            this.button_logout.Text = "로그아웃";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // dataGridView_ledgers
            // 
            this.dataGridView_ledgers.AllowUserToAddRows = false;
            this.dataGridView_ledgers.AllowUserToDeleteRows = false;
            this.dataGridView_ledgers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.dataGridView_ledgers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ledgers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LedgerID,
            this.LedgerName,
            this.Description});
            this.dataGridView_ledgers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.dataGridView_ledgers.Location = new System.Drawing.Point(36, 120);
            this.dataGridView_ledgers.MultiSelect = false;
            this.dataGridView_ledgers.Name = "dataGridView_ledgers";
            this.dataGridView_ledgers.ReadOnly = true;
            this.dataGridView_ledgers.RowTemplate.Height = 23;
            this.dataGridView_ledgers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ledgers.Size = new System.Drawing.Size(560, 240);
            this.dataGridView_ledgers.TabIndex = 9;
            // 
            // LedgerID
            // 
            this.LedgerID.HeaderText = "ID";
            this.LedgerID.Name = "LedgerID";
            this.LedgerID.ReadOnly = true;
            this.LedgerID.Width = 75;
            // 
            // LedgerName
            // 
            this.LedgerName.HeaderText = "장부";
            this.LedgerName.Name = "LedgerName";
            this.LedgerName.ReadOnly = true;
            this.LedgerName.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "설명";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 295;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(640, 460);
            this.Controls.Add(this.dataGridView_ledgers);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_deleteLedger);
            this.Controls.Add(this.button_openLedger);
            this.Controls.Add(this.button_createLedger);
            this.Controls.Add(this.label_ledgerList);
            this.Controls.Add(this.label_title);
            this.Name = "DashboardForm";
            this.Text = "자산관리시스템_장부목록";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Form_dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ledgers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_ledgerList;
        private System.Windows.Forms.Button button_createLedger;
        private System.Windows.Forms.Button button_openLedger;
        private System.Windows.Forms.Button button_deleteLedger;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.DataGridView dataGridView_ledgers;
        private System.Windows.Forms.DataGridViewTextBoxColumn LedgerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LedgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}