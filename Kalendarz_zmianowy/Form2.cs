using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalendarz_zmianowy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.datetime = monthCalendar1.SelectionStart;
            Form1.wheel_days = 0;
            Form1.ActiveForm.Update();
            

            this.Close();
        }
    }
}
