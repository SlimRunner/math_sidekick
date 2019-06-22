using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using math_sidekick.libraries;

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
            double aTerm, bTerm, cTerm;
            
            double.TryParse(TermA_Input.Text, out aTerm);
            double.TryParse(TermB_Input.Text, out bTerm);
            double.TryParse(TermC_Input.Text, out cTerm);

            Complex[] result = MyMath.FindRootsQuadTrinom(aTerm, bTerm, cTerm);

            answer = string.Format(
                "x1 = {0:0.###} + {1:0.###}i\nx2 = {2:0.###} + {3:0.###}i",
                result[0].Real,
                result[0].Imaginary,
                result[1].Real,
                result[1].Imaginary);

            MessageBox.Show(answer);
        }
    }
}
