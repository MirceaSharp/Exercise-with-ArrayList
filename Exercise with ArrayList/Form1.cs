using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_with_ArrayList
{
    public partial class ArrayListDemo : Form
    {
        ArrayList AnimalsList = new ArrayList();


        public ArrayListDemo()
        {
         
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            lbResult.DataSource = null;

            using (StreamReader readObject = new StreamReader("Animals.txt"))
            { 
                string input = "";

                while(readObject.EndOfStream != true)
                {

                    input = readObject.ReadLine();
                    AnimalsList.Add(input);


                }
            }
            
            lbResult.DataSource = AnimalsList;
            




        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(txtInput.Text)))
            {
                string input = txtInput.Text;
                AnimalsList.Add(input);

            }
            else
            {
                MessageBox.Show("Please write something in the textbox!");
            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            lbResult.DataSource = null;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            AnimalsList.Sort();
            lbResult.DataSource = null;
            lbResult.DataSource = AnimalsList;
        }
    }
}
