namespace djk_2606_fp
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_createAcc = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.button_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(66, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "자산 관리 시스템";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(42, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(37, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PW";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.textBox_id.Location = new System.Drawing.Point(83, 150);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(136, 22);
            this.textBox_id.TabIndex = 3;
            // 
            // textBox_pw
            // 
            this.textBox_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.textBox_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.textBox_pw.Location = new System.Drawing.Point(83, 184);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(136, 22);
            this.textBox_pw.TabIndex = 4;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_login.Location = new System.Drawing.Point(226, 152);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(64, 51);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "로그인";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_createAcc
            // 
            this.button_createAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.button_createAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_createAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_createAcc.Location = new System.Drawing.Point(124, 245);
            this.button_createAcc.Name = "button_createAcc";
            this.button_createAcc.Size = new System.Drawing.Size(84, 23);
            this.button_createAcc.TabIndex = 6;
            this.button_createAcc.Text = "계정 생성";
            this.button_createAcc.UseVisualStyleBackColor = false;
            this.button_createAcc.Click += new System.EventHandler(this.button_createAcc_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.label_name.Location = new System.Drawing.Point(168, 381);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(154, 21);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "2021111730 김동주";
            // 
            // button_test
            // 
            this.button_test.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.button_test.Location = new System.Drawing.Point(111, 283);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(111, 23);
            this.button_test.TabIndex = 8;
            this.button_test.Text = "DB 상태 테스트";
            this.button_test.UseVisualStyleBackColor = false;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_createAcc);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "자산관리시스템_로그인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_createAcc;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_test;
    }
}

