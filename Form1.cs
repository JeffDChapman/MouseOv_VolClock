using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Digital
{
    public partial class DigitalClock : Form
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        bool TurnDownVol = false;
        bool TurnUpVol = false;

        public DigitalClock()
        {
            InitializeComponent();
        }

        private void SecondTimer_Tick(object sender, EventArgs e)
        {
            this.TimeLable.Text = DateTime.Now.ToString("hh:mm:ss");
            if (TurnDownVol)
                {keybd_event((byte)Keys.VolumeDown, 0, 0, 0);}
            if (TurnUpVol)
                { keybd_event((byte)Keys.VolumeUp, 0, 0, 0); }
        }

        private void DigitalClock_ResizeEnd(object sender, EventArgs e)
        {
            int formH = this.Height;
            int formW = this.Width;
            this.TimeLable.Top = (this.Height / 2) - 25;
            this.TimeLable.Left = (this.Width / 2) - 70;
        }

        private void SoundCode()
        {
            keybd_event((byte)Keys.VolumeUp, 0, 0, 0); // increase volume
            keybd_event((byte)Keys.VolumeDown, 0, 0, 0); // decrease volume}
        }

        private void DigitalClock_MouseEnter(object sender, EventArgs e)
        {
            TurnUpVol = false;
            TurnDownVol = true;
        }

        private void DigitalClock_MouseLeave(object sender, EventArgs e)
        {
            TurnDownVol = false;
        }

        private void TimeLable_MouseEnter(object sender, EventArgs e)
        {
            TurnDownVol = false;
            TurnUpVol = true;
        }

        private void TimeLable_Leave(object sender, EventArgs e)
        {
            TurnUpVol = false;
        }
    }
}
