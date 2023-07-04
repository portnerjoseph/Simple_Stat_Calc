using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traveling_Salesman_Problem
{
    public partial class StatCalc : Form
    {
        public StatCalc()
        {
            InitializeComponent();
        }
        string[] separators = { ",", "!", "?", ";", ":", " " };
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            
            double sum = 0;
            double mean = 0;
            double sdtot = 0;
            int medianindex;
            int medianindex2;
            double Q1 = 0;
            double median = 0;
            double Q3 = 0;
            double Qrange;
            string[] words = txt_edgeInput.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            double[] data = new double[words.Length];
            int length2 = data.Length;
            for (int x=0;x<words.Length;x++)
            {
                data[x] = Convert.ToDouble(words[x]);
            }
            for (int x = 0; x < length2; x++)
            {
                sum += data[x];
            }
            mean = sum / length2;
            Array.Sort(data);
            medianindex2 = (length2 / 2) - 1;
            medianindex = length2 / 2;
            if (length2 % 2 == 0)
            {
                
                median = (data[medianindex] + data[medianindex2]) / 2;
                if(medianindex%2==0)
                {
                    Q1 = (data[medianindex2/2] + data[medianindex/2] ) / 2;
                    Q3= (data[(medianindex / 2)+medianindex] + data[(medianindex / 2)+medianindex2] ) / 2;
                }
                else
                {
                    Q1 = data[medianindex2 / 2];
                    Q3 = data[(medianindex / 2) + medianindex];
                }

            }
            else
            {

                median = data[medianindex];
                if ((medianindex2-1) % 2 == 0)
                {
                    Q1 = (data[medianindex2 / 2] + data[medianindex / 2]) / 2;
                    Q3 = (data[(medianindex / 2) + medianindex+1] + data[(medianindex / 2) + medianindex ]) / 2;
                }
                else
                {
                    Q1 = data[medianindex2 / 2];
                    Q3 = data[(medianindex / 2) + medianindex+1];
                }
            }
            Qrange = Q3 - Q1;
            lbl_outlyer.Text = "Outliers\n";
            for (int x = 0; x < length2; x++)
            {
                sdtot += Math.Pow(data[x] - mean, 2);
                if (data[x] < (Q1 - (Qrange * 1.5)) || data[x] > (Q3 + (Qrange * 1.5)))
                {
                    lbl_outlyer.Text += ""+data[x] + "\n";
               }
            }

            lbl_max.Text = "Max: " + data[length2-1] + "    Min: " + data[0];
            lbl_sdsample.Text ="SD sample: "+Math.Sqrt(sdtot /(length2 - 1));
            lbl_Sdpop.Text = "SD population: "+Math.Sqrt(sdtot / length2);
            lbl_mean.Text = "Mean: " + mean;
            lbl_stats.Text = "Median: " + median +"    Q1: "+Q1 + "    Q3: " + Q3;
            lbl_Qrange.Text = "Interquartile range: " + Qrange+"    Range: "+(data[length2-1]-data[0]);
           
        }

        
    }
}
