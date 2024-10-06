using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
       
            

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
           //this will provide a shortcut for textbox1,2, and 3 into text1,2, and 3
           string text1 = textBox1.Text;
           string text2 = textBox2.Text;
           string text3 = textBox3.Text;
           
           StudentInfo SI = new StudentInfo(text1, text2, text3);

            //this will add items in listbox and link sa encapsulation katulad ng T1, T2, and T3
            listBox1.Items.Add(SI.T1);
            listBox2.Items.Add(SI.T3);
            listBox3.Items.Add(SI.T2);

            //this will provide clear after clicking button sa submit button to have clear or hindi mag double yung na input 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
        class StudentInfo
        {//create encapslation 
            public string T1 {  get; set; }
            public string T2 { get; set; }

            public string T3 { get; set; }

            public StudentInfo(string text1,string text2, string text3) {
                T1 = text1;
                T2 = text2;
                T3 = text3;
            }



        }

    }
}
