using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        enum MyEnum
        {
            jeden,
            dwa,
            trzy
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //monthCalendar1
            //dateTimePicker1.Value        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1,"Buuum");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = comboBox1.SelectedItem;
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(MyEnum)))
            {
                comboBox1.Items.Add(item);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
        }

        private void button5_Click(object sender, EventArgs e)
        {
          var result=  openFileDialog1.ShowDialog();
            if (result==DialogResult.OK)
            {
              //  openFileDialog1.SafeFileName
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
           // printDialog1.ShowDialog();
            progressBar1.Value += 1;
            progressBar1.Step = 1;
            progressBar1.PerformStep();
          //  timer1.Interval();
            timer1.Start();
             
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }
    }
}
