using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_Phrases
{
    public partial class Form1 : Form
    {
        List<string> Provers = new List<string>() { "Absence makes the heart grow fonder", "Actions speak louder than words.", "A journey of a thousand miles begins with a single step", "All good things must come to an end", "If it ain’t broke, don’t fix it", "If you play with fire, you’ll get burned", "A picture is worth a thousand words", "A watched pot never boils", "Beggars can’t be choosers", "	Better late than never", "	Don’t bite the hand that feeds you", "Easy come, easy go", "No man is an island", "The early bird gets the worm" };
        List<string> Phrases_Verb = new List<string>() {"do","go","Rest","Ride","Beat","Become","Begin","Bend","Sleep","Work","Need","Study","Practice","Learn","Make","Call","Arise","Burn","Forget" };
        List<string> Slng = new List<string> {"chill","cool","Busted","Ride","Hip", "Frenemy", "BAE", "Basic", "Coin", "Dying", "Epic", "Fierce" };
        List<string> idoms = new List<string> { "A blessing in disguise : a good thing that seemed bad at first ", "Beat around the bush : as part of a sentence", "Better late than never: Better to arrive late than not to come at all", "Break a leg : Good luck", "Call it a day: Stop working on something", "Hang in there: Don't give up", "Hit the sack : Go to sleep", "Let someone off the hook : 	To not hold someone responsible for something", "It's not rocket science : It's not complicated", "Make a long story short: Something common", "A dime a dozen :Tell something briefly"};
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Provers.Add(textBox1.Text);
            Refresh("Data Added!", Provers, comboBox1);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phrases_Verb.Add(textBox1.Text);
           
            Refresh("Data Added!",Phrases_Verb, comboBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Slng.Add(textBox1.Text);
          
            Refresh("Data Added!", Slng, comboBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Provers.Remove(comboBox1.SelectedItem.ToString());
          
            Refresh("Data Deleted!", Provers, comboBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string msg = "View Added!";
            Refresh(msg, Provers, comboBox1);
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            Phrases_Verb.Remove(comboBox1.SelectedItem.ToString());
           
            Refresh("Data Deleted!", Phrases_Verb, comboBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
         
            Refresh("View Added!", Phrases_Verb, comboBox1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            Refresh("View Added!", Slng, comboBox1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Slng.Remove(comboBox1.SelectedItem.ToString());
          
            Refresh("Data Deleted!", Slng, comboBox1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string id = "GOOD";
            string me = "Good is use for more people";
            comboBox2.Items.Add(id+" : "+me);
        }
        public void Refresh(string msg , List<string> proverb, ComboBox combo)
        {
            combo.Items.Clear();
            foreach (var item in proverb)
            {
                combo.Items.Add(item);
            }
            MessageBox.Show(msg);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Select");
                }
                else
                {
                    Provers.Remove(comboBox1.SelectedItem.ToString());
                    Provers.Add(textBox1.Text);
                    Refresh("View Updated", Provers, comboBox1);
                }
            }
            catch { MessageBox.Show("Something wrong"); }
           
            //textBox1.Text = comboBox1.SelectedItem.ToString();
           
           // select[1] = "sdf";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Select");
                }
                else
                {
                    Phrases_Verb.Remove(comboBox1.SelectedItem.ToString());
                    Phrases_Verb.Add(textBox1.Text);
                    Refresh("View Updated", Phrases_Verb, comboBox1);
                }
            }
            catch { MessageBox.Show("Something wrong"); }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Select");
                }
                else
                {
                    Slng.Remove(comboBox1.SelectedItem.ToString());
                    Slng.Add(textBox1.Text);
                    Refresh("View Updated", Slng, comboBox1);
                }
            }
            catch { MessageBox.Show("Something wrong"); }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string t1 = textBox2.Text+ " : "+textBox3.Text;
            
            idoms.Add(t1);
            Refresh("Value Added", idoms, comboBox2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string t1 = textBox2.Text + " : " + textBox3.Text;
            try
            {
                if (textBox2.Text == "" || textBox3.Text=="")
                {
                    MessageBox.Show("Please Select");
                }
                else
                {
                    Slng.Remove(comboBox2.SelectedItem.ToString());
                    Slng.Add(t1);
                    Refresh("View Updated", Slng, comboBox2);
                }
            }
            catch { MessageBox.Show("Something wrong"); }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            idoms.Remove(comboBox2.SelectedItem.ToString());

            Refresh("Data Deleted!", idoms, comboBox2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Refresh("View Added", idoms,comboBox2);
        }
    }
}
