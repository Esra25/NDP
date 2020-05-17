using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using System.Data.OleDb;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            //Gösterme biçimini belirle.
            dateTimePicker1.Format= DateTimePickerFormat.Long;
            dateTimePicker1.CustomFormat = "dd/MMMM/ yyyy";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sayı girişini engelle.
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //sayı girişini engelle.
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Bilgi girişini kontrol et.
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("   Eksik Bilgi Girdiniz!");
                
                System.Windows.Forms.Application.ExitThread();

            }
            //atama yap.
            string adı="", soyadı="", cinsiyet="", tarih="";
            adı = textBox1.Text;
            soyadı = textBox2.Text;
            if (radioButton1.Checked == true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if(radioButton2.Checked==true)
            {
                cinsiyet = radioButton2.Text;
            }
           
            
            tarih = dateTimePicker1.Text;
            tarih = dateTimePicker1.Value.ToString();
            tarih = dateTimePicker1.Value.Day.ToString()+"/"+ dateTimePicker1.Value.Month.ToString();


            //Formlar arası geçiş.
            Form2 f2 = new Form2();

            f2.Show();
            this.Hide();


            f2.label9.Text = "Adı Soyadı=" + " " + adı +"   "+ soyadı+ "    " + "Cinsiyeti=" + " " + cinsiyet + "    " + "Doğum Tarihi=" + "  " + tarih;


            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            {

                if (e.KeyCode == Keys.Enter)

                {

                    textBox2.Focus();

                }

            }
        }

       
    }
}
