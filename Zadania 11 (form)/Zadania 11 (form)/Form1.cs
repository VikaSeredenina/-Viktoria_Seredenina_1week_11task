using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_11__form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class String
        {
            // поля
            int n;
            StringBuilder Line;

            // конструктор, позволяющий создать строку из n символов
            public String(string str)
            {
                Line = new StringBuilder(str);
                n = str.Length;
            }

            // метод для подсчета количества пробелов в строке
            public int probel()
            {
                int count = 0;
                for (int i = 0; i < Line.Length; i++)
                    if (char.IsWhiteSpace(Line[i])) count++;
                return count;
            }

            // метод для замены в строке всех прописных символов на строчные
            public string simvol()
            {
                return Line.ToString().ToLower();
            }

            // метод для удаления из строки всех знаков препинания
            public string delete()
            {
                return Line.ToString().Replace(",", "").Replace("!", "").Replace(".", "").Replace(";", "").Replace(":", "");
            }

            //Свойство возвращающее общее количество элементов в строке 
            public int N
            {
                get { return Line.Length; }
            }

            //Свойство позволяющее установить значение поля, в соответствии с введенным значением строки с клавиатуры, 
            //а также получить значение данного поля
            public int Set_N
            {
                get { return n; } // действия, выполняемые при получении значения свойства

                set { n = value; } //действия, выполняемые при установке значения свойства
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            String Line = new String(str); //экземпляр класса

            textBox2.Text +=  Line.probel();

           textBox4.Text += Line.simvol();

           textBox3.Text += Line.delete();

           textBox5.Text += Line.N;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox3.Clear();
            textBox4.Text = "";
            textBox4.Clear();
            textBox5.Text = "";
            textBox5.Clear();
        }
    }
}
