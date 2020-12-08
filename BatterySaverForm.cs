using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;
using System.Media;

namespace BatterySaver_Prototype1
{

    public partial class BatterySaverForm : Form
    {
        private int Old_X { get; set; }
        private int Old_Y { get; set; }

        MainAlert alert = new MainAlert();
        private int MaxLevel { get; set; } = 80;


        private static bool firstChecker = true;
        private static bool secondChecker = true;
        public BatterySaverForm()
        {
            InitializeComponent();
            TrayMenuContext();
        }

        ///Startup da "Visible = false" etmek ucun: (ne oldugunu bilmirem)
        protected override void SetVisibleCore(bool value)
        {
            if (!this.IsHandleCreated)
            {
                value = false;
                CreateHandle();
            }
            base.SetVisibleCore(value);
        }


        private void checkTimer_Tick(object sender, EventArgs e)
        {
            PowerStatusInfo();
            if (SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery)  //Battery exist or not
            {
                batteryPercentLabel.Text = "Your system does not have battery."; 
            }
            else
            {
                ///Basic ALGORTIGM                           
                BasicAlgorithm();                               
            }
        }
        private void BasicAlgorithm()
        {
            PowerStatus status = SystemInformation.PowerStatus;            

            if ( /* 1 */ status.PowerLineStatus.ToString() == "Online" &&
                 /* 2 */secondChecker)
            {
                firstChecker = true;
                secondChecker = false;
            }

            if ( /* 1 */ firstChecker &&
                 /* 2 */ status.PowerLineStatus.ToString() == "Online" &&
                 /* 3 */ (status.BatteryLifePercent) * 100 >= MaxLevel)
            {               
                alert.Show();
                SystemSounds.Beep.Play();
                firstChecker = false;
            }

            if (  /* 1 */ status.PowerLineStatus.ToString() == "Offline")
            {
                if ((status.BatteryLifePercent) * 100 >= MaxLevel) 
                {
                    alert.Hide();
                }                
                secondChecker = true;
            }

        }



        private void PowerStatusInfo()
        {            

            PowerStatus argStatus = SystemInformation.PowerStatus;

            batteryPercentLabel.Text = (argStatus.BatteryLifePercent * 100).ToString() + "%";  //Label daime gosterecek faizi
            
            switch (argStatus.PowerLineStatus.ToString())
            {
                case "Online":
                    powerStatusLabel.Text = "Plugged In";
                    break;

                case "Offline":
                    powerStatusLabel.Text = "Plugged Off";
                    break;
                
                case "Unknown":
                    powerStatusLabel.Text = "Error: Unknown";
                    break;               

            }
        }
        private void TrayMenuContext()
        {
            this.batteryNotifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.batteryNotifyIcon.ContextMenuStrip.Items.Add("Open", null, this.MenuOpen_Click);
            this.batteryNotifyIcon.ContextMenuStrip.Items.Add("-");          
            this.batteryNotifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.MenuExit_Click);
        }
        private void MenuOpen_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }
        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
        }
        private void batteryNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Iconun uzerine sol duyme ile basdiqda gelsin
            {
                this.Visible = true;

            }                        

        }
        private void addStartupCheckBox_CheckedChanged(object sender, EventArgs e)
        {            
           
                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                //if (addStartupCheckBox.Checked)
                    rk.SetValue("BatterySaver", Application.ExecutablePath);
                //else
                    rk.DeleteValue("BatterySaver", false);   
               
        }

        //"MaxLimit"- i ozun sece bilesen deye:
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MaxLevel = (int)numericUpDown1.Value;
        }

        //Home Formu mouse ile terpetmek ucun

        private void BatterySaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int X_difference = e.X - Old_X;
                int Y_difference = e.Y - Old_Y;
                this.Location =
                    new Point(Location.X + X_difference, Location.Y + Y_difference);
            }                        
        }

        private void BatterySaverForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Old_X = e.X;
                Old_Y = e.Y;
            }

        }
    }
}
