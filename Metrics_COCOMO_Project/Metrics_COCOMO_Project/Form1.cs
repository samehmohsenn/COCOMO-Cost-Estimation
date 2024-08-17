using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Metrics_COCOMO_Project
{


    public partial class Form1 : Form
    {
        //for basic values
        public static double organic_a = 2.4,
                    organic_b = 1.05,
                    organic_c = 2.5,
                    organic_d = 0.38,
                    semidetached_a = 3.0,
                    semidetached_b = 1.12,
                    semidetached_c = 2.5,
                    semidetached_d = 0.35,
                    embedded_a = 3.6,
                    embedded_b = 1.20,
                    embedded_c = 2.5,
                    embedded_d = 0.32,
                    //for basic values (a)
                    basic_organic_a = 2.4,
                    basic_semidetached_a = 3.0,
                    basic_embedded_a = 3.6,
                    //for intermediate values (a)
                    intermediate_organic_a = 3.2,
                    intermediate_semidetached_a = 3.0,
                    intermediate_embedded_a = 2.8;
        //for EAF values
        public static double[] EAFvalues = new double[15];

        private void effortButton_Click(object sender, EventArgs e)
        {

            if (projecttype_combobox.SelectedIndex == 0)
            {
                //organic
                effort = organic_a * Math.Pow(KLOC, organic_b);
            }
            else if (projecttype_combobox.SelectedIndex == 1)
            {
                //semidetached
                effort = semidetached_a * Math.Pow(KLOC, semidetached_b);

            }
            else if (projecttype_combobox.SelectedIndex == 2)
            {
                //embedded
                effort = embedded_a * Math.Pow(KLOC, embedded_b);

            }
            if (intermediate_radiobutton.Checked)
            {
                effort_label.Text = "Initial Effort = " + effort.ToString();
            }
            else
            {
                effort_label.Text = "Actual Effort = " + effort.ToString();

            }
        }

        private void calculateTDEV_button_click(object sender, EventArgs e)
        {
            if (projecttype_combobox.SelectedIndex == 0)
            {
                //organic
                TDEV = organic_c * Math.Pow(effort, organic_d);
            }
            else if (projecttype_combobox.SelectedIndex == 1)
            {
                //semidetached
                TDEV = semidetached_c * Math.Pow(effort, semidetached_d);

            }
            else if (projecttype_combobox.SelectedIndex == 2)
            {
                //embedded
                TDEV = embedded_c * Math.Pow(effort, embedded_d);

            }

            TDEV_label.Text = "TDEV = " + TDEV.ToString();





        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void basic_radiobutton_Click(object sender, EventArgs e)
        {
            organic_a = basic_organic_a;
            semidetached_a = basic_semidetached_a;
            embedded_a = basic_embedded_a;

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void intermediate_radiobutton_Click(object sender, EventArgs e)
        {
            organic_a = intermediate_organic_a;
            semidetached_a = intermediate_semidetached_a;
            embedded_a = intermediate_embedded_a;



        }

        public double tempValue, EAF=1;
        public double ActualEffort;

        private void button1_Click_2(object sender, EventArgs e)
        {
            //to calculate EAF
            //for product attributes
            tempValue = 0;
            EAF = 1;
            ActualEffort = 0;

            //first value first group
            if (radioButton1.Checked)
                tempValue= double.Parse(radioButton1.Text);
            else if (radioButton2.Checked)
                tempValue = double.Parse(radioButton2.Text);
            else if (radioButton3.Checked)
                tempValue = double.Parse(radioButton3.Text);
            else if (radioButton4.Checked)
                tempValue = double.Parse(radioButton4.Text);
            else if (radioButton5.Checked)
                tempValue = double.Parse(radioButton5.Text);
            else if (radioButton6.Checked)
                tempValue = double.Parse(radioButton6.Text);
            EAF *= tempValue;
            tempValue = 0; //if any error happens we will know becaise EAF will be zero


            //second value first group
            if (radioButton12.Checked)
                tempValue = double.Parse(radioButton12.Text);
            else if (radioButton11.Checked)
                tempValue = double.Parse(radioButton11.Text);
            else if (radioButton10.Checked)
                tempValue = double.Parse(radioButton10.Text);
            else if (radioButton9.Checked)
                tempValue = double.Parse(radioButton9.Text);
            else if (radioButton8.Checked)
                tempValue = double.Parse(radioButton8.Text);
            else if (radioButton7.Checked)
                tempValue = double.Parse(radioButton7.Text);
            EAF *= tempValue;
            tempValue = 0;

            //third value first group
            if (radioButton18.Checked)
                tempValue = double.Parse(radioButton18.Text);
            else if (radioButton17.Checked)
                tempValue = double.Parse(radioButton17.Text);
            else if (radioButton16.Checked)
                tempValue = double.Parse(radioButton16.Text);
            else if (radioButton15.Checked)
                tempValue = double.Parse(radioButton15.Text);
            else if (radioButton14.Checked)
                tempValue = double.Parse(radioButton14.Text);
            else if (radioButton13.Checked)
                tempValue = double.Parse(radioButton13.Text);
            EAF *= tempValue;
            tempValue = 0;


            //for hardware attributes
            //first value second group
            if (radioButton19.Checked)
                tempValue = double.Parse(radioButton19.Text);
            else if (radioButton24.Checked)
                tempValue = double.Parse(radioButton24.Text);
            else if (radioButton29.Checked)
                tempValue = double.Parse(radioButton29.Text);
            else if (radioButton36.Checked)
                tempValue = double.Parse(radioButton36.Text);
            else if (radioButton40.Checked)
                tempValue = double.Parse(radioButton40.Text);
            else if (radioButton42.Checked)
                tempValue = double.Parse(radioButton42.Text);
            EAF *= tempValue;
            tempValue = 0;
            //second value second group
            if (radioButton20.Checked)
                tempValue = double.Parse(radioButton20.Text);
            else if (radioButton23.Checked)
                tempValue = double.Parse(radioButton23.Text);
            else if (radioButton28.Checked)
                tempValue = double.Parse(radioButton28.Text);
            else if (radioButton35.Checked)
                tempValue = double.Parse(radioButton35.Text);
            else if (radioButton39.Checked)
                tempValue = double.Parse(radioButton39.Text);
            else if (radioButton41.Checked)
                tempValue = double.Parse(radioButton41.Text);
            EAF *= tempValue;
            tempValue = 0;
            //third value second group
            if (radioButton22.Checked)
                tempValue = double.Parse(radioButton22.Text);
            else if (radioButton31.Checked)
                tempValue = double.Parse(radioButton31.Text);
            else if (radioButton27.Checked)
                tempValue = double.Parse(radioButton27.Text);
            else if (radioButton34.Checked)
                tempValue = double.Parse(radioButton34.Text);
            else if (radioButton38.Checked)
                tempValue = double.Parse(radioButton38.Text);
            else if (radioButton26.Checked)
                tempValue = double.Parse(radioButton26.Text);
            EAF *= tempValue;
            tempValue = 0;
            //fourth value second group
            if (radioButton21.Checked)
                tempValue = double.Parse(radioButton21.Text);
            else if (radioButton32.Checked)
                tempValue = double.Parse(radioButton32.Text);
            else if (radioButton30.Checked)
                tempValue = double.Parse(radioButton30.Text);
            else if (radioButton33.Checked)
                tempValue = double.Parse(radioButton33.Text);
            else if (radioButton37.Checked)
                tempValue = double.Parse(radioButton37.Text);
            else if (radioButton25.Checked)
                tempValue = double.Parse(radioButton25.Text);
            EAF *= tempValue;
            tempValue = 0;
            //for personnel attributes
            //first value third group
            if (radioButton59.Checked)
                tempValue = double.Parse(radioButton59.Text);
            else if (radioButton64.Checked)
                tempValue = double.Parse(radioButton64.Text);
            else if (radioButton51.Checked)
                tempValue = double.Parse(radioButton51.Text);
            else if (radioButton69.Checked)
                tempValue = double.Parse(radioButton69.Text);
            else if (radioButton72.Checked)
                tempValue = double.Parse(radioButton72.Text);
            else if (radioButton46.Checked)
                tempValue = double.Parse(radioButton46.Text);
            EAF *= tempValue;
            tempValue = 0;
            //second value third group
            if (radioButton58.Checked)
                tempValue = double.Parse(radioButton58.Text);
            else if (radioButton63.Checked)
                tempValue = double.Parse(radioButton63.Text);
            else if (radioButton50.Checked)
                tempValue = double.Parse(radioButton50.Text);
            else if (radioButton68.Checked)
                tempValue = double.Parse(radioButton68.Text);
            else if (radioButton71.Checked)
                tempValue = double.Parse(radioButton71.Text);
            else if (radioButton45.Checked)
                tempValue = double.Parse(radioButton45.Text);
            EAF *= tempValue;
            tempValue = 0;
            //third value third group
            if (radioButton57.Checked)
                tempValue = double.Parse(radioButton57.Text);
            else if (radioButton62.Checked)
                tempValue = double.Parse(radioButton62.Text);
            else if (radioButton49.Checked)
                tempValue = double.Parse(radioButton49.Text);
            else if (radioButton67.Checked)
                tempValue = double.Parse(radioButton67.Text);
            else if (radioButton70.Checked)
                tempValue = double.Parse(radioButton70.Text);
            else if (radioButton44.Checked)
                tempValue = double.Parse(radioButton44.Text);
            EAF *= tempValue;
            tempValue = 0;
            //fourth value third group
            if (radioButton56.Checked)
                tempValue = double.Parse(radioButton56.Text);
            else if (radioButton61.Checked)
                tempValue = double.Parse(radioButton61.Text);
            else if (radioButton48.Checked)
                tempValue = double.Parse(radioButton48.Text);
            else if (radioButton66.Checked)
                tempValue = double.Parse(radioButton66.Text);
            else if (radioButton54.Checked)
                tempValue = double.Parse(radioButton54.Text);
            else if (radioButton43.Checked)
                tempValue = double.Parse(radioButton43.Text);
            EAF *= tempValue;
            tempValue = 0;
            //fifth value third group
            if (radioButton55.Checked)
                tempValue = double.Parse(radioButton55.Text);
            else if (radioButton60.Checked)
                tempValue = double.Parse(radioButton60.Text);
            else if (radioButton53.Checked)
                tempValue = double.Parse(radioButton53.Text);
            else if (radioButton65.Checked)
                tempValue = double.Parse(radioButton65.Text);
            else if (radioButton52.Checked)
                tempValue = double.Parse(radioButton52.Text);
            else if (radioButton47.Checked)
                tempValue = double.Parse(radioButton47.Text);
            EAF *= tempValue;
            tempValue = 0;
            //for project attributes
            //first value fourth and last group
            if (radioButton81.Checked)
                tempValue = double.Parse(radioButton81.Text);
            else if (radioButton76.Checked)
                tempValue = double.Parse(radioButton76.Text);
            else if (radioButton75.Checked)
                tempValue = double.Parse(radioButton75.Text);
            else if (radioButton84.Checked)
                tempValue = double.Parse(radioButton84.Text);
            else if (radioButton88.Checked)
                tempValue = double.Parse(radioButton88.Text);
            else if (radioButton87.Checked)
                tempValue = double.Parse(radioButton87.Text);
            EAF *= tempValue;
            tempValue = 0;
            //second value fourth group
            if (radioButton80.Checked)
                tempValue = double.Parse(radioButton80.Text);
            else if (radioButton77.Checked)
                tempValue = double.Parse(radioButton77.Text);
            else if (radioButton74.Checked)
                tempValue = double.Parse(radioButton74.Text);
            else if (radioButton83.Checked)
                tempValue = double.Parse(radioButton83.Text);
            else if (radioButton89.Checked)
                tempValue = double.Parse(radioButton89.Text);
            else if (radioButton86.Checked)
                tempValue = double.Parse(radioButton86.Text);
            EAF *= tempValue;
            tempValue = 0;
            //third and last value fourth and last group
            if (radioButton79.Checked)
                tempValue = double.Parse(radioButton79.Text);
            else if (radioButton78.Checked)
                tempValue = double.Parse(radioButton78.Text);
            else if (radioButton73.Checked)
                tempValue = double.Parse(radioButton73.Text);
            else if (radioButton82.Checked)
                tempValue = double.Parse(radioButton82.Text);
            else if (radioButton90.Checked)
                tempValue = double.Parse(radioButton90.Text);
            else if (radioButton85.Checked)
                tempValue = double.Parse(radioButton85.Text);
            EAF *= tempValue;
            tempValue = 0;
            ActualEffort = effort * EAF;
            actualEffort_label.Text = ActualEffort.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {




        }

        public double effort;
        public double KLOC;
        public double TDEV;


        private void updateMode(object sender, EventArgs e)
        {
            if (KLOC_textbox.Text != "")
            {

                if (int.Parse(KLOC_textbox.Text) >= 2 && int.Parse(KLOC_textbox.Text) < 50)
                    projecttype_combobox.SelectedIndex = 0;
                else if (int.Parse(KLOC_textbox.Text) >= 50 && int.Parse(KLOC_textbox.Text) < 300)
                    projecttype_combobox.SelectedIndex = 1;
                else if (int.Parse(KLOC_textbox.Text) >= 300)
                    projecttype_combobox.SelectedIndex = 2;
                KLOC = int.Parse(KLOC_textbox.Text);
            }
            else
            {
                projecttype_combobox.SelectedIndex = 3;
                KLOC = 0;
            }
        }
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
