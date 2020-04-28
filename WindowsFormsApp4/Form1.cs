using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string calcfunc;
        private double XValue;
        private double YValue;
        private double afterminus32X;
        private double afterminus32Y;
    //    private double aftermultiplicationY;
     //   private double aftermultiplicationX;
        private void calculatetotal1()
            
        {
            XValue = System.Double.Parse(XBox.Text);
            YValue = System.Double.Parse(YBox.Text);
            switch (calcfunc)
            {
                case "SubtractX":
                    afterminus32X = XValue - 32;
                    break;
                case "SubtractY":
                    afterminus32Y = YValue - 32;
                    break;

            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //test

            

                calcfunc = "SubtractX";
                calculatetotal1();
                calcfunc = "SubtractY";
            calculatetotal1();

            Convert.ToString(afterminus32X);
                double outputX = afterminus32X * 533;
                double outputY = afterminus32Y * 533;
                double coordinateX = outputX + 266;
                double coordinateY = outputY + 266;

            int valueX;
            int valueY;
            if(Int32.TryParse(YBox.Text,out valueY))
            if (Int32.TryParse(XBox.Text, out valueX))
            {
                    string finalX = coordinateX.ToString();
                    string finalY = coordinateY.ToString();
                


                    // if X is 0-32 then it's positive
                    // if y is between 0-32 then it's positive
                    //if x is between 32-64 it's negative
                    // if y is between 32-64 it's negative
                    if (valueX > 32 && valueY > 32)
                    {
                        string[] finalY1 = finalY.Split(new[] { "-" }, StringSplitOptions.None);
                        string[] finalX1 = finalX.Split(new[] { "-" }, StringSplitOptions.None);
                        Clipboard.SetText(" - " + finalY1[0] + " " + " - " + finalX1[0] + " " + "200");
                        MessageBox.Show("-" + finalY1[0] + " " + "-" + finalX1[0] + " " + "200");
                      
                    }
                    if (valueX <= 32 && valueY > 32)
                    {
                        string[] finalY1 = finalY.Split(new[] { "-" }, StringSplitOptions.None);
                        string[] finalX1 = finalX.Split(new[] { "-" }, StringSplitOptions.None);
                        Clipboard.SetText("-" + finalY1[0] + " " + finalX1[1] + " " + "200");
                        MessageBox.Show("-" + finalY1[0] + " " + finalX1[1] + " " + "200");
                        
                    }
                    if (valueX > 32 && valueY <= 32)
                    {

                        string[] finalY1 = finalY.Split(new[] { "-" }, StringSplitOptions.None);
                        string[] finalX1 = finalX.Split(new[] { "-" }, StringSplitOptions.None);
                        Clipboard.SetText(finalY1[1] + " " + "-" + finalX1[0] + " " + "200");
                        MessageBox.Show(finalY1[1] + " " + "-" + finalX1[0] + " " + "200");
                       
                    }
                    if (valueX < 32 && valueY < 32)
                    {

                        string[] finalY1 = finalY.Split(new[] { "-" }, StringSplitOptions.None);
                        string[] finalX1 = finalX.Split(new[] { "-" }, StringSplitOptions.None);
                        Clipboard.SetText(finalY1[1] + " " + finalX1[1] + " " + "200");
                        MessageBox.Show(finalY1[1] + " " + finalX1[1] + " " + "200" );
                        
                    }
                   
                    if (valueX == 32 && valueY == 32)
                    {
                        Clipboard.SetText("-234 -300 200");
                        MessageBox.Show("-234 -300 200");
                       
                    }


                 
                   







                }


        }

        private void XBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
