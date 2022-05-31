using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DubberTestInterface
{
    public partial class Lottery : Form
    {
        Label[] labelArray;
        public Lottery()
        {
            InitializeComponent();
            labelArray = new Label[] { lottoNum1Label, lottoNum2Label, lottoNum3Label, lottoNum4Label, lottoNum5Label, lottoNum6Label };
            noLabels();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
            Random rndNo = new Random();
            var intList = new List<int>();
            
            for (int i = 0; intList.Count < 6; i++)
            {
                int value = rndNo.Next(1, 49);

                if (!intList.Contains(value))
                {
                    intList.Add(value);
                }
            }

            intList.Sort();

            for (int i = 0; i < 6; i++)
            {
                int number = intList[i];

                labelArray[i].Text = number.ToString();

                if (number < 10)
                {
                    labelArray[i].ForeColor = Color.Gray;
                }
                else if (9 < number && number < 20)
                {
                    labelArray[i].ForeColor = Color.Blue;
                }
                else if (19 < number && number < 30)
                {
                    labelArray[i].ForeColor = Color.Pink;
                }
                else if (29 < number && number < 40)
                {
                    labelArray[i].ForeColor = Color.Green;
                }
                else if (number > 39)
                {
                    labelArray[i].ForeColor = Color.Yellow;
                }

            }
        }

        //removes the default labels from showing on start-up
         private void noLabels()
         {

            foreach(var labelText in labelArray)
            {
                labelText.Text = String.Empty;
            }
         }
    }
}
