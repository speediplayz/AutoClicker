using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Input;
using System.Reflection;

namespace Auto_Clicker
{
    public partial class Form1 : Form
    {

        int clicks = 0;

        public Form1()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            InitializeComponent();

            grpTrigger.SendToBack();
            grpOutput.SendToBack();
            timer1.Interval = 1000 / (int)txtCPS.Value;
        }

        private Key getSpecialKey(string input)
        {
            string key = input.ToLower();
            if (key == "enter") return Key.Enter;
            if (key == "lshift") return Key.LeftShift;
            if (key == "rshift") return Key.RightShift;
            if (key == "lctrl") return Key.LeftCtrl;
            if (key == "rctrl") return Key.RightCtrl;
            if (key == "lalt") return Key.LeftAlt;
            if (key == "ralt") return Key.RightAlt;
            if (key == "tab") return Key.Tab;
            if (key == "capslock") return Key.CapsLock;
            if (key == "backspace") return Key.Back;
            if (key == "space") return Key.Space;
            if (key == "up") return Key.Up;
            if (key == "down") return Key.Down;
            if (key == "left") return Key.Left;
            if (key == "right") return Key.Right;
            return Key.LeftShift;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.LeftAlt) && Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.Z))
            {
                chkToggled.Checked = false;
                cmdToggle.Text = "Start";
            }
            if (txtTrigger.Text != "")
            {
                KeyConverter c = new KeyConverter();
                Key key = txtTrigger.Text.Length == 1 ? (Key)c.ConvertFromString(txtTrigger.Text) : getSpecialKey(txtTrigger.Text);

                if (Keyboard.IsKeyDown(key) || chkToggled.Checked)
                {
                    DoInput();
                }
            }
            else if (chkLeft.Checked)
            {
                if ((MouseButtons & MouseButtons.Left) == MouseButtons.Left || chkToggled.Checked)
                {
                    DoInput();
                }
            }
            else if (chkRight.Checked)
            {
                if ((MouseButtons & MouseButtons.Right) == MouseButtons.Right || chkToggled.Checked)
                {
                    DoInput();
                }
            }

            txtClicks.Text = clicks.ToString();
        }

        private void DoInput()
        {
            if (chkPressLeft.Checked)
            {
                if (chkStacked.Checked)
                {
                    MouseInputSender.LeftStack();
                    clicks += 10;
                }
                else
                {
                    MouseInputSender.Left();
                    clicks++;
                }
            }
            else if (chkPressRight.Checked)
            {
                if (chkStacked.Checked)
                {
                    MouseInputSender.RightStack();
                    clicks += 10;
                }
                else
                {
                    MouseInputSender.Right();
                    clicks++;
                }
            }
            else if (chkScroll.Checked)
            {
                int scrolls = (int)numScrollLines.Value;
                MouseInputSender.ScrollWheel(scrolls);
            }
            else if (txtKeyToPress.Text != "")
            {
                SendKeys.Send(txtKeyToPress.Text);
                clicks++;
            }
        }

        private void txtCPS_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / (int)txtCPS.Value;
        }

        private void cmdToggle_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                cmdToggle.Text = "Start";
            } else
            {
                timer1.Enabled = true;
                cmdToggle.Text = "Stop";
            }
        }
    }
}
