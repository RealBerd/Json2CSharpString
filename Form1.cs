using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string ParseJson2CSharpString(string json, int lineLen = 8, bool strictLenLimit = false)
        {
            json = json.Trim();
            int counter = 0;
            List<string> resLines = new List<string>();
            string line = "";
            int i = 0;
            int l = json.Length;

            for (; i < l; i++)
            {
                char c = json[i];
                if (c == '"' || c == '\'')

                {
                    if (strictLenLimit && lineLen - counter < 2) newLine();

                    line += "\\" + c;
                    counter += 2;
                }
                else
                {
                    line += c;
                    counter++;
                }
                if (counter >= lineLen) newLine();
            }
            if (!string.IsNullOrEmpty(line)) newLine();

            string result = "";
            foreach (var resLine in resLines)
            {
                result += "\"" + resLine + "\" + \r\n";
            }
            result = result.Substring(0, result.Length - 5);

            return result;

            void newLine()
            {
                resLines.Add(line);
                line = "";
                counter = 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text)) return;

            textBox2.Text = ParseJson2CSharpString(
                textBox1.Text,
                Convert.ToInt32(numericUpDown1.Value),
                checkBox1.Checked); ;


        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
