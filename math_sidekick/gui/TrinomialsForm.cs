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

using math_sidekick.libraries.parser;
using math_sidekick.libraries.math;

namespace math_sidekick
{
    public partial class TrinomialsForm : Form
    {
        public TrinomialsForm()
        {
            InitializeComponent();
        }

        //Pen pen = new Pen(Color.Black, 3);
        //Graphics g = PlotCanvas.CreateGraphics();
        //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //g.DrawBezier(pen, 0, 0, 50, 0, 0, 50, 50, 50);

        private void TextInputGroup_TextChanged(object sender, EventArgs e)
        {
            TextBox castSender = (TextBox)sender;
            if (castSender.BackColor != SystemColors.Window)
            {
                castSender.BackColor = SystemColors.Window;
            }
        }
        
        private void TextInputGroup_Enter(object sender, EventArgs e)
        {
            TextBox castSender = (TextBox)sender;
            castSender.SelectAll();
        }

        private void TextOutputGroup_Enter(object sender, EventArgs e)
        {
            TextBox castSender = (TextBox)sender;
            castSender.SelectAll();
        }

        private void FindRootsButton_Click(object sender, EventArgs e)
        {
            const int ERR_A_TERM_FIELD = 1;
            const int ERR_B_TERM_FIELD = 1 << 1;
            const int ERR_C_TERM_FIELD = 1 << 2;
            
            int errBitField = 0;

            if (!ExpressionParser.TryParseComplex(TermA_Input.Text, out Complex aTerm))
                errBitField |= ERR_A_TERM_FIELD;
            if (!ExpressionParser.TryParseComplex(TermB_Input.Text, out Complex bTerm))
                errBitField |= ERR_B_TERM_FIELD;
            if (!ExpressionParser.TryParseComplex(TermC_Input.Text, out Complex cTerm))
                errBitField |= ERR_C_TERM_FIELD;

            if (errBitField == 0)
            {
                Complex[] result = MyMath.FindRootsQuadTrinom(aTerm, bTerm, cTerm);

                if (Equals(result[0],result[1]))
                {//there's one root
                    FirstResultDisplay.Text = ExpressionParser.ComposeComplex(result[0]);
                    SecondResultDisplay.Text = "";
                }
                else
                {//there's two roots
                    FirstResultDisplay.Text = ExpressionParser.ComposeComplex(result[0]);
                    SecondResultDisplay.Text = ExpressionParser.ComposeComplex(result[1]);
                }
            }
            else
            {
                string errMessage;

                switch (errBitField)
                {
                    case 0b001:
                        errMessage = "Term a has";
                        break;
                    case 0b010:
                        errMessage = "Term b has";
                        break;
                    case 0b011:
                        errMessage = "Terms a and b have";
                        break;
                    case 0b100:
                        errMessage = "Term c has";
                        break;
                    case 0b101:
                        errMessage = "Terms a and c have";
                        break;
                    case 0b110:
                        errMessage = "Terms b and c have";
                        break;
                    case 0b111:
                        errMessage = "Terms a, b, and c have";
                        break;
                    default:
                        errMessage = "Terms a, b, and c have";
                        break;
                }

                if ((errBitField & ERR_A_TERM_FIELD) != 0)
                {
                    TermA_Input.BackColor = Color.Pink;
                }

                if ((errBitField & ERR_B_TERM_FIELD) != 0)
                {
                    TermB_Input.BackColor = Color.Pink;
                }

                if ((errBitField & ERR_C_TERM_FIELD) != 0)
                {
                    TermC_Input.BackColor = Color.Pink;
                }

                ToolTip myToolTip = new ToolTip
                {
                    IsBalloon = true
                };
                myToolTip.Show(errMessage + " syntax errors.", TermA_Input, 2500);
            }

        }
    }
}
