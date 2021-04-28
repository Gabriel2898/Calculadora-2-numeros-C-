using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CALCU
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        double a;
        double b;
        double c;

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "1";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "1";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "2";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "2";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "3";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "3";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "4";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "5";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "6";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "6";
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "7";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "7";
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "8";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "8";
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "9";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "9";
            }
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "0";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "0";
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "/";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "*";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "-";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "+";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (this.txtpantalla.Text.Contains('.') == false)
            {
                this.txtpantalla.Text = this.txtpantalla.Text + ".";
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.txtpantalla.Text);
            switch (c)
            {
                case "+":
                    this.txtpantalla.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.txtpantalla.Text = Convert.ToString(b - a);
                    break;

                case "*":
                    this.txtpantalla.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.txtpantalla.Text = Convert.ToString(b / a);
                    break;
            }
        }
    }
}