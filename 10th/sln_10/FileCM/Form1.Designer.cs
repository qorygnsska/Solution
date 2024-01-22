namespace FileCM
{
    partial class Form1
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
            this.btnSrc = new System.Windows.Forms.Button();
            this.btnDest = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.lblSrc = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.lvSrc = new System.Windows.Forms.ListView();
            this.lvDest = new System.Windows.Forms.ListView();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.chFileSrc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileDest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspgrbar = new System.Windows.Forms.ToolStripProgressBar();
            this.gbBox.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(442, 14);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(75, 23);
            this.btnSrc.TabIndex = 0;
            this.btnSrc.Text = "대상경로";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(442, 61);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(75, 23);
            this.btnDest.TabIndex = 1;
            this.btnDest.Text = "결과경로";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(954, 24);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 60);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "실행";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(44, 15);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.ReadOnly = true;
            this.txtSrc.Size = new System.Drawing.Size(393, 21);
            this.txtSrc.TabIndex = 3;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(44, 64);
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(393, 21);
            this.txtDest.TabIndex = 4;
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.Location = new System.Drawing.Point(41, 110);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(29, 12);
            this.lblSrc.TabIndex = 5;
            this.lblSrc.Text = "대상";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(558, 110);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(29, 12);
            this.lblDest.TabIndex = 6;
            this.lblDest.Text = "결과";
            // 
            // gbBox
            // 
            this.gbBox.Controls.Add(this.rbCopy);
            this.gbBox.Controls.Add(this.rbMove);
            this.gbBox.Location = new System.Drawing.Point(560, 24);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(359, 60);
            this.gbBox.TabIndex = 7;
            this.gbBox.TabStop = false;
            this.gbBox.Text = "선택";
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Checked = true;
            this.rbCopy.Location = new System.Drawing.Point(68, 22);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(71, 16);
            this.rbCopy.TabIndex = 0;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "파일복사";
            this.rbCopy.UseVisualStyleBackColor = true;
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Location = new System.Drawing.Point(213, 22);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(71, 16);
            this.rbMove.TabIndex = 1;
            this.rbMove.Text = "파일이동";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // lvSrc
            // 
            this.lvSrc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileSrc});
            this.lvSrc.GridLines = true;
            this.lvSrc.HideSelection = false;
            this.lvSrc.Location = new System.Drawing.Point(43, 140);
            this.lvSrc.Name = "lvSrc";
            this.lvSrc.Size = new System.Drawing.Size(404, 358);
            this.lvSrc.TabIndex = 8;
            this.lvSrc.UseCompatibleStateImageBehavior = false;
            this.lvSrc.View = System.Windows.Forms.View.Details;
            // 
            // lvDest
            // 
            this.lvDest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileDest});
            this.lvDest.GridLines = true;
            this.lvDest.HideSelection = false;
            this.lvDest.Location = new System.Drawing.Point(560, 140);
            this.lvDest.Name = "lvDest";
            this.lvDest.Size = new System.Drawing.Size(409, 358);
            this.lvDest.TabIndex = 9;
            this.lvDest.UseCompatibleStateImageBehavior = false;
            this.lvDest.View = System.Windows.Forms.View.Details;
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbl,
            this.tspgrbar,
            this.tsslblStatus});
            this.ssBar.Location = new System.Drawing.Point(0, 513);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(1085, 22);
            this.ssBar.TabIndex = 10;
            this.ssBar.Text = "statusStrip1";
            // 
            // chFileSrc
            // 
            this.chFileSrc.Text = "파일";
            this.chFileSrc.Width = 400;
            // 
            // chFileDest
            // 
            this.chFileDest.Text = "파일";
            this.chFileDest.Width = 400;
            // 
            // tsslbl
            // 
            this.tsslbl.Name = "tsslbl";
            this.tsslbl.Size = new System.Drawing.Size(94, 17);
            this.tsslbl.Text = "전체 진행사항 : ";
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(28, 17);
            this.tsslblStatus.Text = "0 %";
            // 
            // tspgrbar
            // 
            this.tspgrbar.Name = "tspgrbar";
            this.tspgrbar.Size = new System.Drawing.Size(200, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 535);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.lvDest);
            this.Controls.Add(this.lvSrc);
            this.Controls.Add(this.gbBox);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.lblSrc);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtSrc);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.btnSrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 복사/이동";
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.GroupBox gbBox;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.RadioButton rbMove;
        private System.Windows.Forms.ListView lvSrc;
        private System.Windows.Forms.ColumnHeader chFileSrc;
        private System.Windows.Forms.ListView lvDest;
        private System.Windows.Forms.ColumnHeader chFileDest;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslbl;
        private System.Windows.Forms.ToolStripProgressBar tspgrbar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
    }
}

