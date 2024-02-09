using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenkyoWithHiyori
{
    public partial class BenkyoWithHiyori : Form
    {
        public BenkyoWithHiyori()
        {
            InitializeComponent();
            startStopButton.Text = "START";
            string[] data = { "pomodoro", "45/5", "40/5", "50/10", "100/20" };
            foreach (string value in data)
            {
                comboBox.Items.Add(value);
            }
            comboBox.SelectedIndex = 0;


        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (startStopButton.Text == "START")
            {
                startStopButton.Text = "PAUSE";
                // Add code to handle the "PAUSE" action
            }
            else
            {
                startStopButton.Text = "START";
                // Add code to handle the "START" action
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
        
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
