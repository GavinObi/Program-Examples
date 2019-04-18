using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ExtraClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Hero> myHero = new List<Hero>(); //Hero list
        List<SideKick> mySidekick = new List<SideKick>();//Sidekick list
        List<Vilain> myVillians = new List<Vilain>();//Villain list

        FileHandler fh = new FileHandler(); //instanciating the FileHandler class

        private void Form1_Load(object sender, EventArgs e)
        {
            //Reading the data from each of the files onto the form
            foreach (string item in fh.Read("hero.txt"))
	        {
                string[] items = item.Split(','); //split on the deliminator (, # ;)
                //adding the data from the text files to the Hero list created globally 
                myHero.Add(new Hero(items[0], double.Parse(items[1]), int.Parse(items[2]), int.Parse(items[3])));
	        }
            
               
            foreach (string item in fh.Read("villain.txt"))
            {
                string[] items = item.Split(',');
                //adding the data from the text files to the Villains list created globally 
                myVillians.Add(new Vilain(items[0], double.Parse(items[1]), int.Parse(items[2]), int.Parse(items[3])));
            }

            foreach (string item in fh.Read("sidekick.txt"))
            {
                string[] items = item.Split(',');
                //adding the data from the text files to the Sidekick list created globally 
                mySidekick.Add(new SideKick(items[0], double.Parse(items[1]), int.Parse(items[2]), int.Parse(items[3])));
            } 

            DisplayInComboBox(); //displaying the charater's Names into the comboboxes
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adding new characters  
            if (lbxTypes.SelectedIndex == 0)
            {
                Hero h = new Hero(txtAlias.Text, double.Parse(txtHealth.Text), int.Parse(txtAttack.Text), int.Parse(txtChance.Text));
                myHero.Add(h);
                fh.Write("hero.txt", new List<string> { h.ToString() }, false);
                //bool x = false : so the file is appended and NOT overwritten True = Overwite existing data     
            }
            else if (lbxTypes.SelectedIndex == 1)
            {
                
                Vilain v = new Vilain(txtAlias.Text, double.Parse(txtHealth.Text), int.Parse(txtAttack.Text), int.Parse(txtChance.Text));
                myVillians.Add(v);
                fh.Write("villain.txt", new List<string> { v.ToString() }, false);
               
            }
            else
            {
                SideKick s = new SideKick(txtAlias.Text, double.Parse(txtHealth.Text), int.Parse(txtAttack.Text), int.Parse(txtChance.Text));
                mySidekick.Add(s);
                fh.Write("sidekick.txt", new List<string> { s.ToString() }, false);
            }

            MessageBox.Show("Added");

            txtAlias.Clear();
            txtAttack.Clear();
            txtChance.Clear();
            txtHealth.Clear();

            DisplayInComboBox();
        }

        public void DisplayInComboBox()
        {
            List<string> bindingdata = new List<string>();

            foreach (Hero item in myHero)
                bindingdata.Add(item.Alias); 
            cbxHero.DataSource = bindingdata;

            bindingdata = new List<string>();
            foreach (Vilain item in myVillians)
                 bindingdata.Add(item.Alias);
            cbxVillian.DataSource = bindingdata;

            bindingdata = new List<string>();
            foreach (SideKick item in mySidekick)
                 bindingdata.Add(item.Alias);
            cbxSide.DataSource = bindingdata;
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            Hero h = myHero[cbxHero.SelectedIndex];
            Vilain v = myVillians[cbxVillian.SelectedIndex];
            SideKick s = mySidekick[cbxSide.SelectedIndex];

            double heroHealth = h.Health;
            double villHealth = v.Health;
            double sideHealth = s.Health;

            int chanceTotal = h.Chance + v.Chance + s.Chance;

            bool over = true;
            while (over)
            {
                Random r = new Random();
                int num = r.Next(1, chanceTotal);
                if (num <= h.Chance)
                {
                    rtbFight.AppendText("\nHero Attacked\n");
                    villHealth -= h.Attack;
                }
                else if ((num> h.Chance) && (num <= v.Chance))
                {
                    rtbFight.AppendText("\nVillan Attacked\n");
                    heroHealth -= v.Attack;
                    sideHealth -= v.Attack;
                }
                else
                {
                    rtbFight.AppendText("\nSidekick Attacked\n");
                    villHealth -= s.Attack;
                }

                rtbFight.AppendText("=======================\n");
                rtbFight.AppendText("Hero Health: " + heroHealth);
                rtbFight.AppendText("\nSidekick Health: " + sideHealth);
                rtbFight.AppendText("\nVillain Health: " + villHealth);
                rtbFight.AppendText("\n=======================\n\n");

                if (heroHealth < 0 && sideHealth <0)
                {
                    rtbFight.AppendText("\nVillain has won\n");
                    over = false;
                }
                else if (villHealth < 0)
                {
                    rtbFight.AppendText("\nHeros have won\n");
                    over = false;
                }

                Thread.Sleep(200);
            }
        }
    }
}
