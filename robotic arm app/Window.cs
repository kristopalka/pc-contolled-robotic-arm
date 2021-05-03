using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using S = RoboticArm.Properties.Settings;


namespace RoboticArm
{
    public partial class Window : Form
    {

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Shown(object sender, EventArgs e)
        {
            this.Visible = true;
        }


        private void OpenSettings(object sender, EventArgs e)
        {
            Settings settings_form = new Settings();
            settings_form.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////////
        
        //servo
        
        private void servo4_Scroll(object sender, EventArgs e)
        {
            Arduino.Send(4, (byte)(180-servo4.Value));
        }

        private void servo3_Scroll(object sender, EventArgs e)
        {
            Arduino.Send(3, (byte)(180 - servo3.Value));
        }

        private void servo2_Scroll(object sender, EventArgs e)
        {
            Arduino.Send(2, (byte)servo2.Value);
        }

        private void servo1_Scroll(object sender, EventArgs e)
        {
            Arduino.Send(1, (byte)servo1.Value);
        }

        //stepper

        private void StepperRightButton_MouseDown(object sender, MouseEventArgs e)
        {
            Arduino.Send(5, (byte)StepperSpeed.Value);
        }

        private void StepperLeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            Arduino.Send(7, (byte)StepperSpeed.Value);
        }

        private void StepperStop(object sender, MouseEventArgs e)
        {
            Arduino.Send(6, 0);
        }

        //slider

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Arduino.Send(9, 0);
        }

        private void SliderRightButton_Click(object sender, EventArgs e)
        {
            Arduino.Send(10, 0);
        }

        private void SliderLeftButton_Click(object sender, EventArgs e)
        {
            Arduino.Send(8, 0);
        }

        //sequence

        private void NextMoveButton_Click(object sender, EventArgs e)
        {
            Arduino.Send(100, 0);
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Arduino.Send(101, 0);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Arduino.Send(102, 0);
        }

        private void StepperLeftButton_Click(object sender, EventArgs e)
        {

        }
    }
}
