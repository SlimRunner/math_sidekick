using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sidekick
{
    public partial class TrinomialsForm : Form
    {
        public TrinomialsForm()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);
            Graphics g = PlotCanvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawBezier(pen, 0, 0, 50, 0, 0, 50, 50, 50);

            string answer;
            double x1, x2;
            double i1, i2;
            double discriminant;
            double aTerm, bTerm, cTerm;
            
            double.TryParse(TermA_Input.Text, out aTerm);
            double.TryParse(TermB_Input.Text, out bTerm);
            double.TryParse(TermC_Input.Text, out cTerm);

            discriminant = bTerm * bTerm - 4 * aTerm * cTerm;

            if (discriminant > 0)
            {
                //two real roots
                x1 = (-bTerm + Math.Sqrt(discriminant)) / (aTerm * 2);
                x2 = (-bTerm - Math.Sqrt(discriminant)) / (aTerm * 2);
            }
            else if (discriminant < 0)
            {
                //two complex roots
                //discriminant = Math.Abs(discriminant);
                //x1 = (-bTerm + Math.Sqrt(discriminant)) / aTerm * 2;
                //x2 = (-bTerm - Math.Sqrt(discriminant)) / aTerm * 2;

                x1 = double.NaN;
                x2 = double.NaN;
            }
            else
            {
                //one root
                x1 = (-bTerm + Math.Sqrt(discriminant)) / (aTerm * 2);
                x2 = x1;
            }

            answer = "x1: " + x1 + Environment.NewLine + "x2: " + x2;

            MessageBox.Show(answer);
        }
    }
}
