namespace Digital
{
    partial class DigitalClock
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

        #region Windows Form Designer generated code

        private System.Windows.Forms.Timer tmrShowTime;
        private System.Windows.Forms.Label lblTime = new System.Windows.Forms.Label();
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimeLable = new System.Windows.Forms.Label();
            this.SecondTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeLable
            // 
            this.TimeLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLable.AutoSize = true;
            this.TimeLable.Font = new System.Drawing.Font("Britannic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLable.Location = new System.Drawing.Point(78, 52);
            this.TimeLable.Margin = new System.Windows.Forms.Padding(200);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(125, 30);
            this.TimeLable.TabIndex = 0;
            this.TimeLable.Text = "00:00:00";
            this.TimeLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TimeLable.Leave += new System.EventHandler(this.TimeLable_Leave);
            this.TimeLable.MouseEnter += new System.EventHandler(this.TimeLable_MouseEnter);
            // 
            // SecondTimer
            // 
            this.SecondTimer.Enabled = true;
            this.SecondTimer.Interval = 250;
            this.SecondTimer.Tick += new System.EventHandler(this.SecondTimer_Tick);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.ControlBox = false;
            this.Controls.Add(this.TimeLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Location = new System.Drawing.Point(1500, 500);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DigitalClock";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResizeEnd += new System.EventHandler(this.DigitalClock_ResizeEnd);
            this.MouseEnter += new System.EventHandler(this.DigitalClock_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DigitalClock_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Timer SecondTimer;

     }
}

