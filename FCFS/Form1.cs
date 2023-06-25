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

namespace FCFS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b0, b1, b2, b3, b4, b5;
            int[] wt = new int[6];
            int[] tat = new int[6];

            b0 = Convert.ToInt32(text0.Text);
            b1 = Convert.ToInt32(text1.Text);
            b2 = Convert.ToInt32(text2.Text);
            b3 = Convert.ToInt32(text3.Text);
            b4 = Convert.ToInt32(text4.Text);
            b5 = Convert.ToInt32(text5.Text);


            wt[0] = 0;
            wt[1] = wt[0] + b0;
            wt[2] = wt[1] + b1;
            wt[3] = wt[2] + b2;
            wt[4] = wt[3] + b3;
            wt[5] = wt[4] + b4;

            tat[0] = 0;
            tat[1] = tat[0] + b1;
            tat[2] = tat[1] + b2;
            tat[3] = tat[2] + b3;
            tat[4] = tat[3] + b4;
            tat[5] = tat[4] + b5;

            for (int i=0; i<100 ; i++)
            {
                Thread.Sleep(b0*10);
                progressBar1.Value = i;
                progressBar1.Update();

            }

            wt0.Text = ("0");
            tat0.Text = (Convert.ToString(b0));

            for (int i = 0; i <100; i++)
            {
                
                Thread.Sleep(b1*10);
                progressBar2.Value = i;
                progressBar2.Update();
            }

            wt1.Text = Convert.ToString(wt[1]);
            tat1.Text = Convert.ToString(tat[1]);

            for (int i = 0; i < 100; i++)
            {
                
                Thread.Sleep(b2*10);
                progressBar3.Value = i;
                progressBar3.Update();
            }

            wt2.Text = Convert.ToString(wt[2]);
            tat2.Text = Convert.ToString(tat[2]);

            for (int i = 0; i < 100; i++)
            {

                Thread.Sleep(b3 * 10);
                progressBar4.Value = i;
                progressBar4.Update();
            }

            wt3.Text = Convert.ToString(wt[3]);
            tat3.Text = Convert.ToString(tat[3]);

            for (int i = 0; i < 100; i++)
            {

                Thread.Sleep(b4 * 10);
                progressBar5.Value = i;
                progressBar5.Update();
            }

            wt4.Text = Convert.ToString(wt[4]);
            tat4.Text = Convert.ToString(tat[4]);

            for (int i = 0; i < 100; i++)
            {

                Thread.Sleep(b5 * 10);
                progressBar6.Value = i;
                progressBar6.Update();
            }

            wt5.Text = Convert.ToString(wt[5]);
            tat5.Text = Convert.ToString(tat[5]);

            int sum = 0;
            for(int i=0; i<6; i++)
            {
                sum += wt[i];
            }
            int sum2 = 0;
            for (int i = 0; i < 6; i++)
            {
                sum2 += tat[i];
            }
            double Avgwt = sum / 6;
            double Avgtat = sum2 / 6;
            avgwt.Text= Convert.ToString(Avgwt);
            AVGTAT.Text= Convert.ToString(Avgtat);
        }
    }


}
