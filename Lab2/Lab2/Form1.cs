using System;
using System.Windows.Forms;
using S7PROSIMLib;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public S7PROSIMLib.S7ProSim PS = new S7PROSIMLib.S7ProSim();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_stateon_Click(object sender, EventArgs e)
        {
            PS.Connect();
            PS.SetState("RUN");
            PS.SetScanMode(ScanModeConstants.ContinuousScan);
            label_state.Text = PS.GetState();
            button_connectoff.Enabled = true;
            button1.Enabled = true;
            button_signal.Enabled = true;
            checkbox_Fuel.Enabled = true;
            checkbox_Oil.Enabled = true;
            checkbox_Temperature.Enabled = true;
        }
        private void button_connectoff_Click(object sender, EventArgs e)
        {
            PS.SetState("STOP");
            label_state.Text = PS.GetState();
            PS.Disconnect();
            PS.SetScanMode(ScanModeConstants.ContinuousScan);
            button_connectoff.Enabled = false;
            button1.Enabled = false;
            button_signal.Enabled = false;
            checkbox_Fuel.Enabled = false;
            checkbox_Oil.Enabled = false;
            checkbox_Temperature.Enabled = false;
        }
        private void checkBox_engine_Click(object sender, EventArgs e)
        {
           
            if (label_onoff.Text == "Вим")
            {
                object I0_0 = true;
                PS.WriteInputPoint(0, 0, ref I0_0);
                if (label_signal.Text == "Вім" && (checkbox_Temperature.Checked == true || checkbox_Oil.Checked == true || checkbox_Fuel.Checked == true))
                {
                    signal();
                }
               
                label_onoff.Text = "Вім";
                
            }
            else
            {
                object I0_0 = false;
                label_onoff.Text = "Вим";
                PS.WriteInputPoint(0, 0, ref I0_0);
            }

        }
        private void checkbox_Temperature_CheckedChanged(object sender, EventArgs e)
        {
            object I0_1 = checkbox_Temperature.Checked;
            PS.WriteInputPoint(0, 1, ref I0_1);
            if (label_onoff.Text == "Вім" && label_signal.Text == "Вім" && checkbox_Temperature.Checked == true)
            {
                signal();
            }
            
        }
        private void checkbox_Oil_CheckedChanged(object sender, EventArgs e)
        {
            object I0_2 = checkbox_Oil.Checked;
            PS.WriteInputPoint(0, 2, ref I0_2);
            if (label_onoff.Text == "Вім" && label_signal.Text == "Вім" && checkbox_Oil.Checked == true)
            {
                signal();
            }
            
        }
        private void checkbox_Fuel_CheckedChanged(object sender, EventArgs e)
        {
            object I0_3 = checkbox_Fuel.Checked;
            PS.WriteInputPoint(0, 3, ref I0_3);
            if (label_onoff.Text == "Вім" && label_signal.Text == "Вім" && checkbox_Fuel.Checked == true)
            {
                signal();
            }
            

        }
        private void button_signal_Click(object sender, EventArgs e)
        {
            if (label_signal.Text == "Вим")
            {
                object I0_4 = false;
                label_signal.Text = "Вім";
                PS.WriteInputPoint(0, 4, ref I0_4);
            }
            else
            {
                object I0_4 = true;
                label_signal.Text = "Вим";
                PS.WriteInputPoint(0, 4, ref I0_4);
            }
        }

        private void timer_ReadOutput_Tick(object sender, EventArgs e)
        {
            
            object Q0_5 = true;
            PS.ReadOutputPoint(0, 0, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref Q0_5);
        }

        private void signal()
        {
            
                MessageBox.Show(
                "Попереджувальний сигнал",
                "Попередження про несправність",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
        }
    }
}
