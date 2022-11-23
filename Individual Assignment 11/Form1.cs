using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public class Pet
        {
            private string petName;
            private string petType;
            private int petAge;
            public Pet(string name, string type, int age)
            {
                petName = name;
                petType = type;
                petAge = age;
            }
            public string getName
            {
                get { return petName; }
            }
            public string getType
            {
                get { return petType; }
            }
            public int getAge
            {
                get { return petAge; }
            }
        }

        Pet[] pets = new Pet[18];
        int numOfPets = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (numOfPets != 18)
            {
                try
                {
                    pets[numOfPets] = new Pet(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text));
                    numOfPets++;
                    addListItem();
                }
                catch
                {
                    MessageBox.Show("Wrong input");
                }
            }
        }

        public void addListItem()
        {
            listBox1.Items.Clear();
            foreach (Pet pet in pets)
            { 
                if (pet != null)
                {
                listBox1.Items.Add(pet.getName + " - " + pet.getType + " - " + pet.getAge);
                }
            }
        }

    }
}
