using System;

namespace djk_2606_fp
{
    partial class CreateTransactionForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 리소스를 정리합니다.
        /// </summary>
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
            this.label_date = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_memo = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_memo = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.label_title.Location = new System.Drawing.Point(25, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(215, 30);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "거래 내역 추가/수정";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.label_date.Location = new System.Drawing.Point(28, 75);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(37, 19);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "날짜";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.label_type.Location = new System.Drawing.Point(28, 145);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(37, 19);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "유형";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.label_amount.Location = new System.Drawing.Point(28, 215);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(37, 19);
            this.label_amount.TabIndex = 5;
            this.label_amount.Text = "금액";
            // 
            // label_memo
            // 
            this.label_memo.AutoSize = true;
            this.label_memo.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label_memo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.label_memo.Location = new System.Drawing.Point(28, 285);
            this.label_memo.Name = "label_memo";
            this.label_memo.Size = new System.Drawing.Size(37, 19);
            this.label_memo.TabIndex = 7;
            this.label_memo.Text = "메모";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dateTimePicker_date.Location = new System.Drawing.Point(30, 100);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(300, 25);
            this.dateTimePicker_date.TabIndex = 2;
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "수입",
            "지출"});
            this.comboBox_type.Location = new System.Drawing.Point(30, 170);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(300, 25);
            this.comboBox_type.TabIndex = 4;
            // 
            // textBox_amount
            // 
            this.textBox_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.textBox_amount.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.textBox_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.textBox_amount.Location = new System.Drawing.Point(30, 240);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(300, 25);
            this.textBox_amount.TabIndex = 6;
            // 
            // textBox_memo
            // 
            this.textBox_memo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.textBox_memo.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.textBox_memo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.textBox_memo.Location = new System.Drawing.Point(30, 310);
            this.textBox_memo.Name = "textBox_memo";
            this.textBox_memo.Size = new System.Drawing.Size(300, 25);
            this.textBox_memo.TabIndex = 8;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.button_save.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_save.Location = new System.Drawing.Point(60, 360);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 35);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "저장";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.button_cancel.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_cancel.Location = new System.Drawing.Point(190, 360);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 35);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "취소";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // CreateTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(380, 430);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_memo);
            this.Controls.Add(this.label_memo);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "거래 내역 추가/수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_memo;

        private System.Windows.Forms.DateTimePicker dateTimePicker_date;

        private System.Windows.Forms.ComboBox comboBox_type;

        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_memo;

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
    }
}