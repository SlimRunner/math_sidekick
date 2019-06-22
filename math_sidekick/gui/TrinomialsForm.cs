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
        }

        private void FindRootsButton_Click(object sender, EventArgs e)
        {
            const string STRF_REAL = "0.###;-0.###;";
            const string STRF_IMAG = "0.###;0.###;";

            double.TryParse(TermA_Input.Text, out double aTerm);
            double.TryParse(TermB_Input.Text, out double bTerm);
            double.TryParse(TermC_Input.Text, out double cTerm);

            Complex[] result = MyMath.FindRootsQuadTrinom(aTerm, bTerm, cTerm);
            string[] stringResult = new string[2];

            if (Equals(result[0],result[1]))
            {//there's one root
                FirstResultDisplay.Text = ExpressionParser.ComposeComplex(result[0]);
            }
            else
            {//there's two roots
                FirstResultDisplay.Text = ExpressionParser.ComposeComplex(result[0]);
                SecondResultDisplay.Text = ExpressionParser.ComposeComplex(result[1]);
            }
        }
    }
}
