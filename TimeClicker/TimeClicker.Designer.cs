namespace TimeClicker
{
    partial class TimeClicker
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnMacroSwitch = new System.Windows.Forms.Button();
            this.txtCursor = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxDiff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 154);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(229, 45);
            this.dateTimePicker.TabIndex = 10;
            // 
            // btnMacroSwitch
            // 
            this.btnMacroSwitch.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMacroSwitch.Location = new System.Drawing.Point(12, 204);
            this.btnMacroSwitch.Name = "btnMacroSwitch";
            this.btnMacroSwitch.Size = new System.Drawing.Size(383, 45);
            this.btnMacroSwitch.TabIndex = 12;
            this.btnMacroSwitch.Text = "Start";
            this.btnMacroSwitch.UseVisualStyleBackColor = true;
            this.btnMacroSwitch.Click += new System.EventHandler(this.btnMacroSwitch_Click);
            // 
            // txtCursor
            // 
            this.txtCursor.AutoSize = true;
            this.txtCursor.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCursor.Location = new System.Drawing.Point(90, 54);
            this.txtCursor.Name = "txtCursor";
            this.txtCursor.Size = new System.Drawing.Size(205, 54);
            this.txtCursor.TabIndex = 13;
            this.txtCursor.Text = "X : 0, Y: 0";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(99, 119);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(92, 28);
            this.textBoxX.TabIndex = 14;
            this.textBoxX.Text = "0";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(245, 119);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(92, 28);
            this.textBoxY.TabIndex = 15;
            this.textBoxY.Text = "0";
            // 
            // textBoxDiff
            // 
            this.textBoxDiff.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxDiff.Location = new System.Drawing.Point(245, 154);
            this.textBoxDiff.Name = "textBoxDiff";
            this.textBoxDiff.Size = new System.Drawing.Size(150, 44);
            this.textBoxDiff.TabIndex = 16;
            this.textBoxDiff.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(58, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(204, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Y";
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.AutoSize = true;
            this.txtCurrentTime.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCurrentTime.Location = new System.Drawing.Point(12, 9);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.Size = new System.Drawing.Size(395, 45);
            this.txtCurrentTime.TabIndex = 19;
            this.txtCurrentTime.Text = "1970-01-01 오전 0:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 259);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDiff);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.txtCursor);
            this.Controls.Add(this.btnMacroSwitch);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "Form1";
            this.Text = "TimeClicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        protected System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnMacroSwitch;
        private System.Windows.Forms.Label txtCursor;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxDiff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtCurrentTime;
    }
}

