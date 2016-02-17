namespace Valentine
{
    partial class FormValentine
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValentine));
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.FirstTimer = new System.Windows.Forms.Timer(this.components);
            this.LastTimer = new System.Windows.Forms.Timer(this.components);
            this.lblFinal1 = new System.Windows.Forms.Label();
            this.lblFinal2 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTimer
            // 
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MainPanel.Controls.Add(this.lblFinal2);
            this.MainPanel.Controls.Add(this.lblFinal1);
            this.MainPanel.Controls.Add(this.lblStart);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(600, 600);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStart.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.Location = new System.Drawing.Point(252, 224);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(241, 90);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Press me\r\nmy honey Jul";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            this.lblStart.MouseLeave += new System.EventHandler(this.lblStart_MouseLeave);
            this.lblStart.MouseHover += new System.EventHandler(this.lblStart_MouseHover);
            // 
            // FirstTimer
            // 
            this.FirstTimer.Enabled = true;
            this.FirstTimer.Interval = 300;
            this.FirstTimer.Tick += new System.EventHandler(this.FirstTimer_Tick);
            // 
            // LastTimer
            // 
            this.LastTimer.Interval = 300;
            this.LastTimer.Tick += new System.EventHandler(this.LastTimer_Tick);
            // 
            // lblFinal1
            // 
            this.lblFinal1.AutoSize = true;
            this.lblFinal1.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinal1.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblFinal1.Location = new System.Drawing.Point(64, 81);
            this.lblFinal1.Name = "lblFinal1";
            this.lblFinal1.Size = new System.Drawing.Size(485, 34);
            this.lblFinal1.TabIndex = 1;
            this.lblFinal1.Text = "Thank you for being in my life. ";
            this.lblFinal1.Visible = false;
            // 
            // lblFinal2
            // 
            this.lblFinal2.AutoSize = true;
            this.lblFinal2.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinal2.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblFinal2.Location = new System.Drawing.Point(157, 465);
            this.lblFinal2.Name = "lblFinal2";
            this.lblFinal2.Size = new System.Drawing.Size(257, 34);
            this.lblFinal2.TabIndex = 2;
            this.lblFinal2.Text = "Be my valentine";
            this.lblFinal2.Visible = false;
            // 
            // FormValentine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormValentine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valentine";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Timer FirstTimer;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Timer LastTimer;
        private System.Windows.Forms.Label lblFinal2;
        private System.Windows.Forms.Label lblFinal1;
    }
}

