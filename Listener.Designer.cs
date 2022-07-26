namespace IoT_Emulator {
    partial class Listener {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IntervalTxt = new System.Windows.Forms.TextBox();
            this.ListenToTxt = new System.Windows.Forms.TextBox();
            this.MethodLbl = new System.Windows.Forms.Label();
            this.ShowRespBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(691, 21);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(37, 24);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // IntervalTxt
            // 
            this.IntervalTxt.BackColor = System.Drawing.Color.White;
            this.IntervalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalTxt.Location = new System.Drawing.Point(507, 21);
            this.IntervalTxt.Name = "IntervalTxt";
            this.IntervalTxt.ReadOnly = true;
            this.IntervalTxt.Size = new System.Drawing.Size(56, 24);
            this.IntervalTxt.TabIndex = 1;
            this.IntervalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListenToTxt
            // 
            this.ListenToTxt.BackColor = System.Drawing.Color.White;
            this.ListenToTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListenToTxt.Location = new System.Drawing.Point(69, 21);
            this.ListenToTxt.Name = "ListenToTxt";
            this.ListenToTxt.ReadOnly = true;
            this.ListenToTxt.Size = new System.Drawing.Size(429, 24);
            this.ListenToTxt.TabIndex = 2;
            // 
            // MethodLbl
            // 
            this.MethodLbl.AutoSize = true;
            this.MethodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MethodLbl.Location = new System.Drawing.Point(15, 23);
            this.MethodLbl.Name = "MethodLbl";
            this.MethodLbl.Size = new System.Drawing.Size(45, 20);
            this.MethodLbl.TabIndex = 3;
            this.MethodLbl.Text = "GET";
            // 
            // ShowRespBtn
            // 
            this.ShowRespBtn.Location = new System.Drawing.Point(572, 22);
            this.ShowRespBtn.Name = "ShowRespBtn";
            this.ShowRespBtn.Size = new System.Drawing.Size(110, 23);
            this.ShowRespBtn.TabIndex = 4;
            this.ShowRespBtn.Text = "Show Response";
            this.ShowRespBtn.UseVisualStyleBackColor = true;
            this.ShowRespBtn.Click += new System.EventHandler(this.ShowRespBtn_Click);
            // 
            // Listener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ShowRespBtn);
            this.Controls.Add(this.MethodLbl);
            this.Controls.Add(this.ListenToTxt);
            this.Controls.Add(this.IntervalTxt);
            this.Controls.Add(this.CloseBtn);
            this.Name = "Listener";
            this.Size = new System.Drawing.Size(745, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox IntervalTxt;
        private System.Windows.Forms.TextBox ListenToTxt;
        private System.Windows.Forms.Label MethodLbl;
        private System.Windows.Forms.Button ShowRespBtn;
    }
}
