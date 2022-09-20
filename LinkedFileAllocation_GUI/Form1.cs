using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedFileAllocation_GUI
{
    public partial class FILE_ALLOCATION_GUI : Form
    {
        public FILE_ALLOCATION_GUI()
        {
           
            InitializeComponent();
            description.Hide();
        }

        //LENGTHOFFILE

        int length_of_file1 = 0;
        int length_of_file2 = 0;
        int length_of_file3 = 0;
       

        public void File_1_calulation()
        {
            length_of_file1++;
            String a = Convert.ToString(length_of_file1);
            length1.Text = a;
        }

        public void File_2_calulation()
        {
            length_of_file2++;
            String b = Convert.ToString(length_of_file2);
            length2.Text = b;
        }

        public void File_3_calulation()
        {
            length_of_file3++;
            String c = Convert.ToString(length_of_file3);
            length3.Text = c;
        }

        //PROCESS ALLOCATION BUTTON
        bool alloc1 = false;
        bool alloc2 = false;
        bool alloc3 = false;

        //TEXT TO BE DISPLAY ON LABELS 
        String lab1 = " ";
        String lab2 = " ";
        String lab3 = " ";

        //BUTTON IN PROCESS 
        bool button1inprocess = true;
        bool button2inprocess = true;
        bool button3inprocess = true;
        bool button4inprocess = true;
        bool button5inprocess = true;
        bool button6inprocess = true;
        bool button7inprocess = true;
        bool button8inprocess = true;
        bool button9inprocess = true;
        bool button10inprocess = true;
        bool button11inprocess = true;
        bool button12inprocess = true;
        bool button13inprocess = true;
        bool button14inprocess = true;
        bool button15inprocess = true;
        bool button16inprocess = true;
        bool button17inprocess = true;
        bool button18inprocess = true;
        bool button19inprocess = true;
        bool button20inprocess = true;
        bool button21inprocess = true;
        bool button22inprocess = true;
        bool button23inprocess = true;
        bool button24inprocess = true;


        private void aprocess1_Click(object sender, EventArgs e)
        {
            alloc1 = true;
            alloc2 = false;
            alloc3 = false;
            

            aprocess1.BackColor= Color.White;
            aprocess2.BackColor= Color.Black;
            aprocess3.BackColor = Color.Black;

        }

        private void aprocess2_Click(object sender, EventArgs e)
        {
             alloc1 = false;
             alloc2 = true;
             alloc3 = false;
            
            aprocess1.BackColor = Color.Black;
            aprocess2.BackColor = Color.White;
            aprocess3.BackColor = Color.Black;

           
        }

        private void aprocess3_Click(object sender, EventArgs e)
        {
            alloc1 = false;
            alloc2 = false;
            alloc3 = true;
           
            aprocess1.BackColor = Color.Black;
            aprocess2.BackColor = Color.Black;
            aprocess3.BackColor = Color.White;
           
        }

        private void aprocess4_Click(object sender, EventArgs e)
        {
            alloc1 = false;
            alloc2 = false;
            alloc3 = false;
            
            aprocess1.BackColor = Color.Black;
            aprocess2.BackColor = Color.Black;
            aprocess3.BackColor = Color.Black;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkalloc();
            if (button1inprocess == true) {
                if (alloc1 == true)
                {
                    
                    button1.BackColor = Color.Yellow;
                    lab1 = "1 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();

                }
                if (alloc2 == true)
                {
                    button1.BackColor = Color.Green;
                    lab2 = "1 -> ";
                    labelshow2.Text = lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button1.BackColor = Color.Red;
                    lab3 = "1 -> ";
                    labelshow3.Text = lab3;
                    File_3_calulation();
                }
               button1inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ","WARNING");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2inprocess == true)
            {
                if (alloc1 == true)
                {
                    button2.BackColor = Color.Yellow;
                    lab1 = "2 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button2.BackColor = Color.Green;
                    lab2 = "2 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button2.BackColor = Color.Red;
                    lab3 = "2 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button2inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3inprocess == true)
            {
                if (alloc1 == true)
                {
                    button3.BackColor = Color.Yellow;
                    lab1 = "3 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button3.BackColor = Color.Green;
                    lab2 = "3 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button3.BackColor = Color.Red;
                    lab3 = "3 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button3inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4inprocess == true)
            {
                if (alloc1 == true)
                {
                    button4.BackColor = Color.Yellow;
                    lab1 = "4 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button4.BackColor = Color.Green;
                    lab2 = "4 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();

                }
                if (alloc3 == true)
                {
                    button4.BackColor = Color.Red;
                    lab3 = "4 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button4inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5inprocess == true)
            {
                if (alloc1 == true)
                {
                    button5.BackColor = Color.Yellow;
                    lab1 = "5 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button5.BackColor = Color.Green;
                    lab2 = "5 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();

                }
                if (alloc3 == true)
                {
                    button5.BackColor = Color.Red;
                    lab3 = "5 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button5inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6inprocess == true)
            {
                if (alloc1 == true)
                {
                    button6.BackColor = Color.Yellow;
                    lab1 = "6 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button6.BackColor = Color.Green;
                    lab2 = "6 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button6.BackColor = Color.Red;
                    lab3 = "6 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button6inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7inprocess == true)
            {
                if (alloc1 == true)
                {
                    button7.BackColor = Color.Yellow;
                    lab1 = "7 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button7.BackColor = Color.Green;
                    lab2 = "7 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button7.BackColor = Color.Red;
                    lab3 = "7 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button7inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8inprocess == true)
            {
                if (alloc1 == true)
                {
                    button8.BackColor = Color.Yellow;
                    lab1 = "8 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button8.BackColor = Color.Green;
                    lab2 = "8 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button8.BackColor = Color.Red;
                    lab3 = "8 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button8inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9inprocess == true)
            {
                if (alloc1 == true)
                {
                    button9.BackColor = Color.Yellow;
                    lab1 = "9 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button9.BackColor = Color.Green;
                    lab2 = "9 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button9.BackColor = Color.Red;
                    lab3 = "9 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button9inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10inprocess == true)
            {
                if (alloc1 == true)
                {
                    button10.BackColor = Color.Yellow;
                    lab1 = "10 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button10.BackColor = Color.Green;
                    lab2 = "10 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button10.BackColor = Color.Red;
                    lab3 = "10 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button10inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11inprocess == true)
            {
                if (alloc1 == true)
                {
                    button11.BackColor = Color.Yellow;
                    lab1 = "11 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button11.BackColor = Color.Green;
                    lab2 = "11 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button11.BackColor = Color.Red;
                    lab3 = "11 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button11inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12inprocess == true)
            {
                if (alloc1 == true)
                {
                    button12.BackColor = Color.Yellow;
                    lab1 = "12 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button12.BackColor = Color.Green;
                    lab2 = "12 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button12.BackColor = Color.Red;
                    lab3 = "12 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button12inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13inprocess == true)
            {
                if (alloc1 == true)
                {
                    button13.BackColor = Color.Yellow;
                    lab1 = "13 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();

                }
                if (alloc2 == true)
                {
                    button13.BackColor = Color.Green;
                    lab2 = "13 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button13.BackColor = Color.Red;
                    lab3 = "13 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button13inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14inprocess == true)
            {
                if (alloc1 == true)
                {
                    button14.BackColor = Color.Yellow;
                    lab1 = "14 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();

                }
                if (alloc2 == true)
                {
                    button14.BackColor = Color.Green;
                    lab2 = "14 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button14.BackColor = Color.Red;
                    lab3 = "14 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button14inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15inprocess == true)
            {
                if (alloc1 == true)
                {
                    button15.BackColor = Color.Yellow;
                    lab1 = "15 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button15.BackColor = Color.Green;
                    lab2 = "15 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button15.BackColor = Color.Red;
                    lab3 = "15 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button15inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16inprocess == true)
            {
                if (alloc1 == true)
                {
                    button16.BackColor = Color.Yellow;
                    lab1 = "16 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button16.BackColor = Color.Green;
                    lab2 = "16 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button16.BackColor = Color.Red;
                    lab3 = "16 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button16inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17inprocess == true)
            {
                if (alloc1 == true)
                {
                    button17.BackColor = Color.Yellow;
                    lab1 = "17 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button17.BackColor = Color.Green;
                    lab2 = "17 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button17.BackColor = Color.Red;
                    lab3 = "17 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button17inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18inprocess == true)
            {
                if (alloc1 == true)
                {
                    button18.BackColor = Color.Yellow;
                    lab1 = "18 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();

                }
                if (alloc2 == true)
                {
                    button18.BackColor = Color.Green;
                    lab2 = "18 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button18.BackColor = Color.Red;
                    lab3 = "18 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button18inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19inprocess == true)
            {
                if (alloc1 == true)
                {
                    button19.BackColor = Color.Yellow;
                    lab1 = "19 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();

                }
                if (alloc2 == true)
                {
                    button19.BackColor = Color.Green;
                    lab2 = "19 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button19.BackColor = Color.Red;
                    lab3 = "19 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button18inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20inprocess == true)
            {
                if (alloc1 == true)
                {
                    button20.BackColor = Color.Yellow;
                    lab1 = "20 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button20.BackColor = Color.Green;
                    lab2 = "20 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button20.BackColor = Color.Red;
                    lab3 = "20 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button20inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21inprocess == true)
            {
                if (alloc1 == true)
                {
                    button21.BackColor = Color.Yellow;
                    lab1 = "21 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button21.BackColor = Color.Green;
                    lab2 = "21 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button21.BackColor = Color.Red;
                    lab3 = "21 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button21inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22inprocess == true)
            {
                if (alloc1 == true)
                {
                    button22.BackColor = Color.Yellow;
                    lab1 = "22 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button22.BackColor = Color.Green;
                    lab2 = "22 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button22.BackColor = Color.Red;
                    lab3 = "22 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button22inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23inprocess == true)
            {
                if (alloc1 == true)
                {
                    button23.BackColor = Color.Yellow;
                    lab1 = "23 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button23.BackColor = Color.Green;
                    lab2 = "23 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button23.BackColor = Color.Red;
                    lab3 = "23 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button23inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24inprocess == true)
            {
                if (alloc1 == true)
                {
                    button24.BackColor = Color.Yellow;
                    lab1 = "24 -> ";
                    labelshow1.Text += lab1;
                    File_1_calulation();
                }
                if (alloc2 == true)
                {
                    button24.BackColor = Color.Green;
                    lab2 = "24 -> ";
                    labelshow2.Text += lab2;
                    File_2_calulation();
                }
                if (alloc3 == true)
                {
                    button24.BackColor = Color.Red;
                    lab3 = "24 -> ";
                    labelshow3.Text += lab3;
                    File_3_calulation();
                }
                button24inprocess = false;
            }
            else
            {
                MessageBox.Show(" BLOCK IS TAKEN ", "WARNING");
            }
        }

        public void checkalloc()
        {
            if (alloc1 == false && alloc2 == false && alloc3 == false) 
            {
                MessageBox.Show(" PLEASE CHOOSE A FILE ", "ERROR");
            }

        }

        private void description_button_Click(object sender, EventArgs e)
        {
            description.Show();
        }

        private void DESC_BACK_Click(object sender, EventArgs e)
        {
            description.Hide();
        }
    }
}
//SELF DONE