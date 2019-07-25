using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhycApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            //Slide indicator
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;

            //hide and show controls for  user to veiw in form

            homeC1.Hide();
            cervicalSpine1.Show();
            thoracicSpine1.Hide();
            lumbarSpine1.Hide();
            sacralC1.Hide();
            shoulderC1.Hide();
            elbowC1.Hide();
            wristC1.Hide();
            pelvisC1.Hide();
            kneeC1.Hide();
            ankelC1.Hide();

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            //hide and show controls for  user to veiw in form

            homeC1.Show();
            cervicalSpine1.Hide();
            thoracicSpine1.Hide();
            lumbarSpine1.Hide();
            sacralC1.Hide();
            shoulderC1.Hide();
            elbowC1.Hide();
            wristC1.Hide();
            pelvisC1.Hide();
            kneeC1.Hide();
            ankelC1.Hide();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;

            //hide and show controls for  user to veiw in form

            homeC1.Hide();
            cervicalSpine1.Hide();
            thoracicSpine1.Show();
            lumbarSpine1.Hide();
            sacralC1.Hide();
            shoulderC1.Hide();
            elbowC1.Hide();
            wristC1.Hide();
            pelvisC1.Hide();
            kneeC1.Hide();
            ankelC1.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;

            //hide and show controls for  user to veiw in form

            homeC1.Hide();
            cervicalSpine1.Hide();
            thoracicSpine1.Hide();
            lumbarSpine1.Show();
            sacralC1.Hide();
            shoulderC1.Hide();
            elbowC1.Hide();
            wristC1.Hide();
            pelvisC1.Hide();
            kneeC1.Hide();
            ankelC1.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;

            //hide and show controls for  user to veiw in form

            homeC1.Hide();
            cervicalSpine1.Hide();
            thoracicSpine1.Hide();
            lumbarSpine1.Hide();
            sacralC1.Hide();
            shoulderC1.Show();
            elbowC1.Hide();
            wristC1.Hide();
            pelvisC1.Hide();
            kneeC1.Hide();
            ankelC1.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;

            //hide and show controls for  user to veiw in form

            homeC1.Hide();
            cervicalSpine1.Hide();
            thoracicSpine1.Hide();
            lumbarSpine1.Hide();
            sacralC1.Hide();
            shoulderC1.Hide();
            elbowC1.Show();
            wristC1.Hide();
            pelvisC1.Hide();
            kneeC1.Hide();
            ankelC1.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;

            //hide and show controls for  user to veiw in form

            homeC1.Hide();
            cervicalSpine1.Hide();
            thoracicSpine1.Hide();
            lumbarSpine1.Hide();
            sacralC1.Hide();
            shoulderC1.Hide();
            elbowC1.Hide();
            wristC1.Show();
            pelvisC1.Hide();
            kneeC1.Hide();
            ankelC1.Hide();

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button15.Height;
            SidePanel.Top = button15.Top;

            //hide and show controls for  user to veiw in form

            homeC1.Hide();
            cervicalSpine1.Hide();
            thoracicSpine1.Hide();
            lumbarSpine1.Hide();
            sacralC1.Hide();
            shoulderC1.Hide();
            elbowC1.Hide();
            wristC1.Hide();
            pelvisC1.Show();
            kneeC1.Hide();
            ankelC1.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button8.Height;
            SidePanel.Top = button8.Top;

            //hide and show controls for  user to veiw in form

            homeC1.Hide();
            cervicalSpine1.Hide();
            thoracicSpine1.Hide();
            lumbarSpine1.Hide();
            sacralC1.Hide();
            shoulderC1.Hide();
            elbowC1.Hide();
            wristC1.Hide();
            pelvisC1.Hide();
            kneeC1.Show();
            ankelC1.Hide();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button9.Height;
            SidePanel.Top = button9.Top;

            //hide and show controls for  user to veiw in form

            homeC1.Hide();
            cervicalSpine1.Hide();
            thoracicSpine1.Hide();
            lumbarSpine1.Hide();
            sacralC1.Hide();
            shoulderC1.Hide();
            elbowC1.Hide();
            wristC1.Hide();
            pelvisC1.Hide();
            kneeC1.Hide();
            ankelC1.Show();
        }
    }
}
