using System;
using System.Drawing;

using System.Windows.Forms;

namespace Kalendarz_zmianowy
{
    public partial class Form1 : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            var screen = Screen.FromPoint(this.Location);
            this.Location = new Point(screen.WorkingArea.Right - this.Width - 20, screen.WorkingArea.Bottom - this.Height - 60);
            base.OnLoad(e);
        }
        // ---        variables ----------------

       
       static public double wheel_days = 0;
       private bool Flag = true ;
       static public DateTime basedt = new DateTime(2015, 01, 09); // date when shif A start working on 6 am
       static public DateTime datetime = new DateTime();
       static public int shift_nr;
       


       //-------------------- color definition ----------------------------------
       static Color colShiftA = Color.Orange;
       static Color colShiftB = Color.SpringGreen;
       static Color colShiftC = Color.Aquamarine;
       static Color colShiftD = Color.SkyBlue;
       static Color colSunday = Color.Tomato;
       static Color colSaturday = Color.PeachPuff;
       static Color colorNowaday = Color.DeepSkyBlue;


        // -------------------------------------------------

        public Form1()
        {
            
            InitializeComponent();
            this.MouseWheel += Form1_MouseWheel;
            datetime = DateTime.Now;
            date_refresh(datetime, wheel_days);


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "Kalendarz 4BOP";
            notifyIcon1.BalloonTipTitle = "Kalendarz 4BOP";
          

        }



   // ----- notify icon duoble click funk-------------------------

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

            if (Flag == true)
            {
                WindowState = FormWindowState.Normal;
                Flag = false;
                date_refresh(datetime, wheel_days); // -------------- refresh form -----------

            }
            else
            {
                WindowState = FormWindowState.Minimized;
                Flag = true;
            }
        }

        // ---- contetx menu buttons ---------------------


        private void ShowCalendarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Flag = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Tomasz Puchniarz\nWersja: 1.2 \nData: Listopad 2015");
        }


        private void enterDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            
            
            form2.Show();

            this.SuspendLayout();
        }





        // ------------ refresh date ----------------------------------

        public void date_refresh(DateTime dt_tmp, double wheel_days_tmp)
        {



            ldate1.BackColor = Color.Empty;
            ldate2.BackColor = Color.Empty;
            ldate3.BackColor = Color.Empty;
            ldate4.BackColor = Color.Empty;
            ldate5.BackColor = Color.Empty;
            ldate6.BackColor = Color.Empty;
            ldate7.BackColor = Color.Empty;
            ldate8.BackColor = Color.Empty;
            ldate9.BackColor = Color.Empty;
            ldate10.BackColor = Color.Empty;
            ldate11.BackColor = Color.Empty;
            ldate12.BackColor = Color.Empty;
            ldate13.BackColor = Color.Empty;
            ldate14.BackColor = Color.Empty;

            DateTime dt = new DateTime();
            dt = dt_tmp;
            dt = dt.AddDays(wheel_days_tmp);  // mouse wheel up or down click 



            ldate1.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate1.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate1.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate1.BorderStyle = BorderStyle.FixedSingle;
            else ldate1.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate2.Text = dt.ToShortDateString();
            if(dt.DayOfWeek == DayOfWeek.Sunday)  ldate2.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate2.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate2.BorderStyle = BorderStyle.FixedSingle;
            else ldate2.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate3.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate3.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate3.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate3.BorderStyle = BorderStyle.FixedSingle;
            else ldate3.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate4.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate4.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate4.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate4.BorderStyle = BorderStyle.FixedSingle;
            else ldate4.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate5.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate5.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate5.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate5.BorderStyle = BorderStyle.FixedSingle;
            else ldate5.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate6.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate6.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate6.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate6.BorderStyle = BorderStyle.FixedSingle;
            else ldate6.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate7.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate7.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate7.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate7.BorderStyle = BorderStyle.FixedSingle;
            else ldate7.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate8.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate8.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate8.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate8.BorderStyle = BorderStyle.FixedSingle;
            else ldate8.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate9.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate9.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate9.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate9.BorderStyle = BorderStyle.FixedSingle;
            else ldate9.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate10.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate10.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate10.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate10.BorderStyle = BorderStyle.FixedSingle;
            else ldate10.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate11.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate11.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate11.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate11.BorderStyle = BorderStyle.FixedSingle;
            else ldate11.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate12.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate12.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate12.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate12.BorderStyle = BorderStyle.FixedSingle;
            else ldate12.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate13.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate13.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate13.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate13.BorderStyle = BorderStyle.FixedSingle;
            else ldate13.BorderStyle = BorderStyle.None;
            dt = dt.AddDays(1);
            ldate14.Text = dt.ToShortDateString();
            if (dt.DayOfWeek == DayOfWeek.Sunday) ldate14.BackColor = colSunday;
            if (dt.DayOfWeek == DayOfWeek.Saturday) ldate14.BackColor = colSaturday;
            if (dt.DayOfYear == DateTime.Now.DayOfYear) ldate14.BorderStyle = BorderStyle.FixedSingle;
            else ldate14.BorderStyle = BorderStyle.None;

            dt = dt_tmp;
            dt = dt.AddDays(wheel_days_tmp);  // mouse wheel up or down click

            int[] nrd  = new int[15];

            nrd[0] = (dt - basedt).Days;
            for(int i=1;i<15;i++)
            {
                nrd[i] = nrd[0]+i;
                nrd[i] %= 16;
            }
            nrd[0]%=16;


            lDay1s1.Text = returnshiftname(nrd[0], 1);
            colorshift(ref lDay1s1);
            lDay1s2.Text = returnshiftname(nrd[0], 2);
            colorshift(ref lDay1s2);
            lDay1s3.Text = returnshiftname(nrd[0], 3);
            colorshift(ref lDay1s3);
            lDay2s1.Text = returnshiftname(nrd[1], 1);
            colorshift(ref lDay2s1);
            lDay2s2.Text = returnshiftname(nrd[1], 2);
            colorshift(ref lDay2s2);
            lDay2s3.Text = returnshiftname(nrd[1], 3);
            colorshift(ref lDay2s3);
            lDay3s1.Text = returnshiftname(nrd[2], 1);
            colorshift(ref lDay3s1);
            lDay3s2.Text = returnshiftname(nrd[2], 2);
            colorshift(ref lDay3s2);
            lDay3s3.Text = returnshiftname(nrd[2], 3);
            colorshift(ref lDay3s3);
            lDay4s1.Text = returnshiftname(nrd[3], 1);
            colorshift(ref lDay4s1);
            lDay4s2.Text = returnshiftname(nrd[3], 2);
            colorshift(ref lDay4s2);
            lDay4s3.Text = returnshiftname(nrd[3], 3);
            colorshift(ref lDay4s3);
            lDay5s1.Text = returnshiftname(nrd[4], 1);
            colorshift(ref lDay5s1);
            lDay5s2.Text = returnshiftname(nrd[4], 2);
            colorshift(ref lDay5s2);
            lDay5s3.Text = returnshiftname(nrd[4], 3);
            colorshift(ref lDay5s3);
            lDay6s1.Text = returnshiftname(nrd[5], 1);
            colorshift(ref lDay6s1);
            lDay6s2.Text = returnshiftname(nrd[5], 2);
            colorshift(ref lDay6s2);
            lDay6s3.Text = returnshiftname(nrd[5], 3);
            colorshift(ref lDay6s3);
            lDay7s1.Text = returnshiftname(nrd[6], 1);
            colorshift(ref lDay7s1);
            lDay7s2.Text = returnshiftname(nrd[6], 2);
            colorshift(ref lDay7s2);
            lDay7s3.Text = returnshiftname(nrd[6], 3);
            colorshift(ref lDay7s3);
            lDay8s1.Text = returnshiftname(nrd[7], 1);
            colorshift(ref lDay8s1);
            lDay8s2.Text = returnshiftname(nrd[7], 2);
            colorshift(ref lDay8s2);
            lDay8s3.Text = returnshiftname(nrd[7], 3);
            colorshift(ref lDay8s3);
            lDay9s1.Text = returnshiftname(nrd[8], 1);
            colorshift(ref lDay9s1);
            lDay9s2.Text = returnshiftname(nrd[8], 2);
            colorshift(ref lDay9s2);
            lDay9s3.Text = returnshiftname(nrd[8], 3);
            colorshift(ref lDay9s3);
            lDay10s1.Text = returnshiftname(nrd[9], 1);
            colorshift(ref lDay10s1);
            lDay10s2.Text = returnshiftname(nrd[9], 2);
            colorshift(ref lDay10s2);
            lDay10s3.Text = returnshiftname(nrd[9], 3);
            colorshift(ref lDay10s3);
            lDay11s1.Text = returnshiftname(nrd[10], 1);
            colorshift(ref lDay11s1);
            lDay11s2.Text = returnshiftname(nrd[10], 2);
            colorshift(ref lDay11s2);
            lDay11s3.Text = returnshiftname(nrd[10], 3);
            colorshift(ref lDay11s3);
            lDay12s1.Text = returnshiftname(nrd[11], 1);
            colorshift(ref lDay12s1);
            lDay12s2.Text = returnshiftname(nrd[11], 2);
            colorshift(ref lDay12s2);
            lDay12s3.Text = returnshiftname(nrd[11], 3);
            colorshift(ref lDay12s3);
            lDay13s1.Text = returnshiftname(nrd[12], 1);
            colorshift(ref lDay13s1);
            lDay13s2.Text = returnshiftname(nrd[12], 2);
            colorshift(ref lDay13s2);
            lDay13s3.Text = returnshiftname(nrd[12], 3);
            colorshift(ref lDay13s3);
            lDay14s1.Text = returnshiftname(nrd[13], 1);
            colorshift(ref lDay14s1);
            lDay14s2.Text = returnshiftname(nrd[13], 2);
            colorshift(ref lDay14s2);
            lDay14s3.Text = returnshiftname(nrd[13], 3);
            colorshift(ref lDay14s3);

        }



        private string returnshiftname(int s, int iShift) // - return name shift.  s - nr day 1 to 16 ishift - 1.2.3 
        {
            string sShift ="";
            if (s < 0 || s > 15) return sShift = "Err";

            switch (iShift)
            {
                case 1:
                    {
                        if (s < 4) sShift = "  A  ";
                        if (s < 8 && s > 3) sShift = "  C  ";
                        if (s < 12 && s > 7) sShift = "  D  ";
                        if (s > 11) sShift = "  B  ";
                        break;
                    }

                case 2:
                    {
                        if (s == 0) sShift = "  D  ";
                        if (s < 5 && s > 0) sShift = "  B  ";
                        if (s < 9 && s > 4) sShift = "  A  ";
                        if (s < 13 && s > 8) sShift = "  C  ";
                        if (s > 12) sShift = "  D  ";
                        break;
                    }
                case 3:
                    {
                        if (s < 2) sShift = "  C  ";
                        if (s < 6 && s > 1) sShift = "  D  ";
                        if (s < 10 && s > 5) sShift = "  B  ";
                        if (s < 14 && s > 9) sShift = "  A  ";
                        if (s > 13) sShift = "  C  ";
                        break;
                    }

                default:
                    {
                        sShift = "Err";
                        break;
                    }
            }
           
            return sShift;

        }
        
        private void colorshift(ref Label lab)
    {
                if (lab.Text == "  A  ") lab.BackColor = colShiftA;
                else if (lab.Text == "  B  ") lab.BackColor = colShiftB;
                else if (lab.Text == "  C  ") lab.BackColor = colShiftC;
                else lab.BackColor = colShiftD;
                
            return;

    }


        // keyup and keydown events for change the date

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Up)  // if key press up 
            {
                wheel_days -= 1;

                date_refresh(datetime, wheel_days);                      // -------------- refresh form -----------

                return true;

            }

            if (keyData == Keys.Down);  // if key press down 
            {
                wheel_days += 1;

                date_refresh(datetime, wheel_days);                      // -------------- refresh form -----------

                return true;

            }


            return base.ProcessCmdKey(ref msg, keyData);
        }
        


        // mouse wheel event ---------------------------------------------------------------------------


        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
           
            wheel_days -= e.Delta / 120;      //  e.delta given muosewheel direction (when up give 120, when down give -120



            date_refresh(datetime, wheel_days);                      // -------------- refresh form -----------

        }

        // buttons press events ------------------------------------------------------------------------



        private void bt_today_Click(object sender, EventArgs e)
        {
            wheel_days = 0;
            datetime = DateTime.Now;
            date_refresh(datetime, wheel_days);                      // -------------- refresh form -----------

        }


        private void bt_zmA_Click(object sender, EventArgs e)
        {
            shift_nr = 1; // shift name zmA

            Form3 form3 = new Form3();

            form3.Show();

            this.SuspendLayout();
        }


        private void bt_zmB_Click(object sender, EventArgs e)
        {
            shift_nr = 2; // shift name zmB

            Form3 form3 = new Form3();

            form3.Show();

            this.SuspendLayout();
        }

        private void bt_zmC_Click(object sender, EventArgs e)
        {
            shift_nr = 3; // shift name zmC

            Form3 form3 = new Form3();

            form3.Show();

            this.SuspendLayout();
        }

        private void bt_zmD_Click(object sender, EventArgs e)
        {
            shift_nr = 4; // shift name zmD

            Form3 form3 = new Form3();

            form3.Show();

            this.SuspendLayout();
        }


        // mouse click events ------------------------------------------------------------------------

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, new Point(e.X, e.Y)); //       places the menu at the pointer position
            }
        }





        private void Form1_Activated(object sender, EventArgs e)        // activated form
        {
            date_refresh(datetime, wheel_days);                      // -------------- refresh form -----------
        }


    }
}
