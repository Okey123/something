using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace кресты
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        bool ch = true;
        int nch = 0;
        int nnch = 0;

        bool b1;
        bool b2;
        bool b3;
        bool b4;
        bool b5;
        bool b6;
        bool b7;
        bool b8;
        bool b9;

        bool bn1;
        bool bn2;
        bool bn3;
        bool bn4;
        bool bn5;
        bool bn6;
        bool bn7;
        bool bn8;
        bool bn9;

        private void ko()
        {
                if (b1 & b2 & b3 == true || b4 & b5 & b6 == true || b7 & b8 & b9 == true || b1 & b4 & b7 == true || b2 & b5 & b8 == true || b3 & b6 & b9 == true || b1 & b5 & b9 == true || b3 & b5 & b9 == true)
                {
                    if (nch / 2 == 0)
                    {
                        label1.Text = "x`s Win";
                    }
                    else
                    {
                        
                        label1.Text = "o`s Win";
                    }
                }
        }

        private string  so(bool b1)
        {
            string boom;
            if (ch == true)
            {
                b1 = true;
                boom = "x";
                ch = false;
            }
            else
            {
                bn1 = true;
                boom = "o";
                
                ch = true;
            }
            return boom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (nch == 9 || nch > 9)
            {
                Close();
            }
           
            button1.Text = so();
            nch++;
            ko();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (nch == 9 || nch > 9)
            {
                Close();
            }

            button2.Text = so();
            nch++;
            ko();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (nch == 9 || nch > 9)
            {
                Close();
            }

            button3.Text = so();
            nch++;
            ko();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (nch == 9 || nch > 9)
            {
                Close();
            }
            button4.Text = so();
            nch++;
            ko();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (nch == 9 || nch > 9)
            {
                Close();
            }
            button5.Text = so();
            nch++;
            ko();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (nch == 9 || nch > 9)
            {
                Close();
            }
            button6.Text = so();
            nch++;
            ko();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (nch == 9 || nch > 9)
            {
                Close();
            }
            button7.Text = so();
            nch++;
            ko();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (nch == 9 || nch > 9)
            {
                Close();
            }
            button8.Text = so();
            nch++;
            ko();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (nch == 9 || nch > 9)
            {
                Close();
            }
            button9.Text = so();
            nch++;
            ko();
        }

    }
}
