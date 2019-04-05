using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TimeClicker
{
    public partial class TimeClicker : Form
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        const uint LBUTTONDOWN = 0x0002;    // 왼쪽 마우스 버튼 눌림
        const uint LBUTTONUP = 0x0004;      // 왼쪽 마우스 버튼 떼어짐

        private int diffTick = 0;
        private bool _running;

        public TimeClicker()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtCurrentTime.Text = DateTime.Now.ToString();
            txtCursor.Text = $"X : {Cursor.Position.X} Y : {Cursor.Position.Y}";

            if (_running)
            {
                DateTime checkTime = dateTimePicker.Value.AddTicks(diffTick);
                if (DateTime.Now >= checkTime)
                {
                    Cursor.Position = new Point(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text));
                    mouse_event(LBUTTONDOWN, 0, 0,0, 0);
                    mouse_event(LBUTTONUP, 0, 0,0, 0);
                    btnMacroSwitch_Click(null, null);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            timer1.Interval = 10;
            timer1.Start();

            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Value = DateTime.Now.AddSeconds(20);
        }

        private void btnMacroSwitch_Click(object sender, EventArgs e)
        {
            _running = !_running;
            btnMacroSwitch.Text = _running ?  "Stop" : "Start";
            btnMacroSwitch.ForeColor = _running ? System.Drawing.Color.Red : System.Drawing.Color.Black;

            textBoxX.ReadOnly = _running;
            textBoxY.ReadOnly = _running;
            textBoxDiff.ReadOnly = _running;
            dateTimePicker.Enabled = !_running;

            if (_running)
                diffTick = int.Parse(textBoxDiff.Text);
        }
    }
}
