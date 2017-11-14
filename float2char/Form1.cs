using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace float2char
{
    public partial class Form1 : Form
    {
        FDOUBLE fdouble;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(chkVildFloat(textBox1.Text.Trim()))
            {
                float data = float.Parse(textBox1.Text.Trim());
                fdouble.fVal0 = data;
                textBox2.Text = fdouble.cVal0.ToString("X2"); textBox2.Text += " ";
                textBox2.Text += fdouble.cVal1.ToString("X2"); textBox2.Text += " ";
                textBox2.Text += fdouble.cVal2.ToString("X2"); textBox2.Text += " ";
                textBox2.Text += fdouble.cVal3.ToString("X2");
            }
            else
            {
                MessageBox.Show("数据格式错误");
            }
        }
        public static string HexToString(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }

        public static String byte2HexStr(byte[] b)
        {
            String stmp = "";
            stmp = HexToString(b);
            return stmp.ToString().ToLower().Trim();
        }

        private bool chkVildFloat(string str)
        {
            //先判断是否有"."号
            if (str.Contains("."))
            {
                try
                {
                    //是否能转为浮点数
                    float temp = float.Parse(str);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private bool chkVildDouble(string str)
        {
            //先判断是否有"."号
            if (str.Contains("."))
            {
                try
                {
                    //是否能转为浮点数
                    double temp = double.Parse(str);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public struct FDOUBLE
        {
            [FieldOffset(0)]
            public double dbVal;
            [FieldOffset(0)]
            public float fVal0;
            [FieldOffset(4)]
            public float fVal1;
            [FieldOffset(0)]
            public int nVal0;
            [FieldOffset(4)]
            public int nVal1;
            [FieldOffset(0)]
            public short nsVal0;
            [FieldOffset(2)]
            public short nsVal1;
            [FieldOffset(4)]
            public short nsVal2;
            [FieldOffset(6)]
            public short nsVal3;
            [FieldOffset(0)]
            public byte cVal0;
            [FieldOffset(1)]
            public byte cVal1;
            [FieldOffset(2)]
            public byte cVal2;
            [FieldOffset(3)]
            public byte cVal3;
            [FieldOffset(4)]
            public byte cVal4;
            [FieldOffset(5)]
            public byte cVal5;
            [FieldOffset(6)]
            public byte cVal6;
            [FieldOffset(7)]
            public byte cVal7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox2.Text.Trim();
            string[] strArray = str.Split(' ');
            fdouble.cVal0 = Convert.ToByte(strArray[0], 16);
            fdouble.cVal1 = Convert.ToByte(strArray[1], 16);
            fdouble.cVal2 = Convert.ToByte(strArray[2], 16);
            fdouble.cVal3 = Convert.ToByte(strArray[3], 16);
            textBox1.Text = fdouble.fVal0.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chkVildDouble(textBox10.Text.Trim()))
            {
                double data = double.Parse(textBox10.Text.Trim());
                fdouble.dbVal = data;
                textBox9.Text = fdouble.cVal0.ToString("X2"); textBox9.Text += " ";
                textBox9.Text += fdouble.cVal1.ToString("X2"); textBox9.Text += " ";
                textBox9.Text += fdouble.cVal2.ToString("X2"); textBox9.Text += " ";
                textBox9.Text += fdouble.cVal3.ToString("X2"); textBox9.Text += " ";
                textBox9.Text += fdouble.cVal4.ToString("X2"); textBox9.Text += " ";
                textBox9.Text += fdouble.cVal5.ToString("X2"); textBox9.Text += " ";
                textBox9.Text += fdouble.cVal6.ToString("X2"); textBox9.Text += " ";
                textBox9.Text += fdouble.cVal7.ToString("X2");
            }
            else
            {
                MessageBox.Show("数据格式错误");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = textBox9.Text.Trim();
            string[] strArray = str.Split(' ');
            fdouble.cVal0 = Convert.ToByte(strArray[0], 16);
            fdouble.cVal1 = Convert.ToByte(strArray[1], 16);
            fdouble.cVal2 = Convert.ToByte(strArray[2], 16);
            fdouble.cVal3 = Convert.ToByte(strArray[3], 16);
            fdouble.cVal4 = Convert.ToByte(strArray[4], 16);
            fdouble.cVal5 = Convert.ToByte(strArray[5], 16);
            fdouble.cVal6 = Convert.ToByte(strArray[6], 16);
            fdouble.cVal7 = Convert.ToByte(strArray[7], 16);
            textBox10.Text = fdouble.dbVal.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
