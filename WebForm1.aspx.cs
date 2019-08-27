using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumberToWord
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = convert(Convert.ToInt32(TextBox1.Text));
        }
        public static string convert(int num)
        {
            if (num == 0)
                return "zero";

            string str1 = "";


            if ((num / 1000000) > 0)
            {
                str1 += convert(num / 1000000) + " million ";
                num %= 1000000;
            }

            if ((num / 1000) > 0)
            {
                str1 += convert(num / 1000) + " thousand ";
                num %= 1000;
            }

            if ((num / 100) > 0)
            {
                str1 += convert(num / 100) + " hundred ";
                num %= 100;
            }

            if (num > 0)
            {
                if (str1 != "") str1 += "and ";

                var ones = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (num < 20)
                    str1 += ones[num];
                else
                {
                    str1 += tens[num / 10];
                    if ((num % 10) > 0)
                        str1 += " " + ones[num % 10];
                }
            }

            return str1;
        }

    }
}