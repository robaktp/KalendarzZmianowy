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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            string[] shift_name = {"", "A", "B", "C", "D" };
            string[] month_name = { "", "styczniu", "lutym", "marcu", "kwietniu","maju","czerwcu","lipcu","sierpniu","wrzesniu","październiku","listopadzie","grudniu" };
            this.Text = "Praca zmiany " + shift_name[Form1.shift_nr] + " w " + month_name[Form1.datetime.Month] +
                " " + Form1.datetime.Year.ToString() + " roku";


            Display_shift_work(Form1.datetime, Form1.shift_nr);

        }





        private void Display_shift_work(DateTime datetime, int shift_nr)
        {
            int day_tmp, shift_nr_adj = 0;
            string shift_work = "";
            int days_shift_work_in_month = 0,
                days_shift_work_in_month_1_shift = 0,
                days_shift_work_in_month_2_shift = 0,
                days_shift_work_in_month_3_shift = 0;


            // shift calibration
            if (shift_nr == 1) shift_nr_adj = 0;
            if (shift_nr == 2) shift_nr_adj = 4;
            if (shift_nr == 3) shift_nr_adj = 12;
            if (shift_nr == 4) shift_nr_adj = 8;


            int days_in_month = DateTime.DaysInMonth(datetime.Year, datetime.Month); // days in month 
            DateTime datetime_tmp = new DateTime(datetime.Year, datetime.Month, 1);  // first day of month

            dataGridView1.Rows.Add(days_in_month);

            for (int day_of_month = 0; day_of_month < days_in_month; day_of_month++)
            {
                dataGridView1.Rows[day_of_month].Cells[0].Value = datetime_tmp.ToShortDateString();

                day_tmp = ((datetime_tmp - Form1.basedt).Days + shift_nr_adj) % 16; //Form1.basedt    -- (2015, 01, 09) date when shif A start working on 6 am

                shift_work = " - ";
                if (day_tmp < 4)
                {
                    shift_work = "06.00 - 14.00";
                    days_shift_work_in_month_1_shift += 1;
                }

                if (day_tmp < 9 && day_tmp > 4)
                {
                    shift_work = "14.00 - 22.00";
                    days_shift_work_in_month_2_shift += 1;
                }

                if (day_tmp < 14 && day_tmp > 9)
                {
                    shift_work = "22.00 - 06.00";
                    days_shift_work_in_month_3_shift += 1;
                }
                if (day_tmp > 15) shift_work = "Error";


                dataGridView1.Rows[day_of_month].Cells[1].Value = shift_work;

                datetime_tmp = datetime_tmp.AddDays(1);
            }


            days_shift_work_in_month = days_shift_work_in_month_1_shift + days_shift_work_in_month_2_shift + days_shift_work_in_month_3_shift;


            lb_day_of_month_value.Text                  = days_in_month.ToString();
            lb_shift_work_days_in_month_value.Text      = days_shift_work_in_month.ToString();
            lb_shift_work_on_1_shift_value.Text = days_shift_work_in_month_1_shift.ToString();
            lb_shift_work_on_2_shift_value.Text = days_shift_work_in_month_2_shift.ToString();
            lb_shift_work_on_3_shift_value.Text = days_shift_work_in_month_3_shift.ToString();

            lb_h_shift_work_in_month_value.Text = (days_shift_work_in_month * 8).ToString();
            lb_h_shift_work_in_month_1_shift_value.Text = (days_shift_work_in_month_1_shift * 8).ToString();
            lb_h_shift_work_in_month_2_shift_value.Text = (days_shift_work_in_month_2_shift * 8).ToString();
            lb_h_shift_work_in_month_3_shift_value.Text = (days_shift_work_in_month_3_shift * 8).ToString();




        }


    }
}
