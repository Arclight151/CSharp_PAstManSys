namespace djk_2606_fp
{
    partial class CreateLedgerForm
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
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font(
                "맑은 고딕",
                16F,
                System.Drawing.FontStyle.Bold);

            this.label_title.ForeColor =
                System.Drawing.Color.FromArgb(
                    180, 200, 240);

            this.label_title.Location =
                new System.Drawing.Point(25, 20);

            this.label_title.Name = "label_title";
            this.label_title.Size =
                new System.Drawing.Size(124, 30);

            this.label_title.TabIndex = 0;
            this.label_title.Text = "새 장부 생성";

            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font =
                new System.Drawing.Font(
                    "맑은 고딕",
                    10F);

            this.label_name.ForeColor =
                System.Drawing.Color.FromArgb(
                    230, 236, 250);

            this.label_name.Location =
                new System.Drawing.Point(28, 75);

            this.label_name.Name = "label_name";
            this.label_name.Size =
                new System.Drawing.Size(51, 19);

            this.label_name.TabIndex = 1;
            this.label_name.Text = "장부명";

            // 
            // textBox_name
            // 
            this.textBox_name.BackColor =
                System.Drawing.Color.FromArgb(
                    210, 220, 245);

            this.textBox_name.ForeColor =
                System.Drawing.Color.FromArgb(
                    18, 24, 50);

            this.textBox_name.Font =
                new System.Drawing.Font(
                    "맑은 고딕",
                    10F);

            this.textBox_name.Location =
                new System.Drawing.Point(32, 100);

            this.textBox_name.Name = "textBox_name";

            this.textBox_name.Size =
                new System.Drawing.Size(320, 25);

            this.textBox_name.TabIndex = 2;

            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font =
                new System.Drawing.Font(
                    "맑은 고딕",
                    10F);

            this.label_description.ForeColor =
                System.Drawing.Color.FromArgb(
                    230, 236, 250);

            this.label_description.Location =
                new System.Drawing.Point(28, 145);

            this.label_description.Name = "label_description";

            this.label_description.Size =
                new System.Drawing.Size(37, 19);

            this.label_description.TabIndex = 3;
            this.label_description.Text = "설명";

            // 
            // textBox_description
            // 
            this.textBox_description.BackColor =
                System.Drawing.Color.FromArgb(
                    210, 220, 245);

            this.textBox_description.ForeColor =
                System.Drawing.Color.FromArgb(
                    18, 24, 50);

            this.textBox_description.Font =
                new System.Drawing.Font(
                    "맑은 고딕",
                    10F);

            this.textBox_description.Location =
                new System.Drawing.Point(32, 170);

            this.textBox_description.Multiline = true;

            this.textBox_description.Name =
                "textBox_description";

            this.textBox_description.Size =
                new System.Drawing.Size(320, 100);

            this.textBox_description.TabIndex = 4;

            // 
            // button_create
            // 
            this.button_create.BackColor =
                System.Drawing.Color.FromArgb(
                    210, 245, 220);

            this.button_create.ForeColor =
                System.Drawing.Color.FromArgb(
                    18, 24, 50);

            this.button_create.Font =
                new System.Drawing.Font(
                    "맑은 고딕",
                    10F);

            this.button_create.Location =
                new System.Drawing.Point(80, 295);

            this.button_create.Name =
                "button_create";

            this.button_create.Size =
                new System.Drawing.Size(90, 35);

            this.button_create.TabIndex = 5;
            this.button_create.Text = "생성";
            this.button_create.UseVisualStyleBackColor = false;

            this.button_create.Click +=
                new System.EventHandler(
                    this.button_create_Click);

            // 
            // button_cancel
            // 
            this.button_cancel.BackColor =
                System.Drawing.Color.Gainsboro;

            this.button_cancel.ForeColor =
                System.Drawing.Color.FromArgb(
                    18, 24, 50);

            this.button_cancel.Font =
                new System.Drawing.Font(
                    "맑은 고딕",
                    10F);

            this.button_cancel.Location =
                new System.Drawing.Point(210, 295);

            this.button_cancel.Name =
                "button_cancel";

            this.button_cancel.Size =
                new System.Drawing.Size(90, 35);

            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "취소";
            this.button_cancel.UseVisualStyleBackColor = false;

            this.button_cancel.Click +=
                new System.EventHandler(
                    this.button_cancel_Click);

            // 
            // Form_createLedger
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 12F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(
                    12, 16, 32);

            this.ClientSize =
                new System.Drawing.Size(384, 361);

            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_title);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Name = "CreateLedgerForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text = "새 장부 생성";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_cancel;
    }
}