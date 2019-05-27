using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CoffeeShop
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }
        List<string> Names=new List<string>();
        List<string> Numbers = new List<string>();
        List<string> Address = new List<string>();
        List<string> Items = new List<string>();
        List<decimal> Reats = new List<decimal>();
        List<decimal> quantitys = new List<decimal>();

        public int FixtReat()
        {
            int reat = itemComboBox.SelectedIndex == 1 ? 120:itemComboBox.SelectedIndex==2?100:itemComboBox.SelectedIndex==2?90:itemComboBox.SelectedIndex==4?80:0;
            return reat;
        }

        public string Show()
        {
            string output = "";
            foreach (var Name in Names)
            {
                int Index = 0;
                output = output + "Customer Name= " + Name + "\nPhone No.= " + Numbers[Index] + "\nAddress= " +
                         Address[Index] + "\nItem= " + Items[Index] + "\nReat= " + Reats[Index] + "\nQuantity= " +
                         quantitys[Index] + "\nTotal Price:" + Reats[Index] + "*" + quantitys[Index] + " =" +
                         (Convert.ToDecimal(Reats[Index])*(Convert.ToDecimal(quantitys[Index]))) + "\n\n";
                Index++;
            }
            return output;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Names.Add(nameTextBox.Text);
            Numbers.Add(phoneNoTextBox.Text);
            Address.Add(addessRichTextBox.Text);
            Items.Add(itemComboBox.Text);
           Reats.Add(FixtReat());
            quantitys.Add(Convert.ToDecimal(quantityTextBox.Text));
            outputRichTextBox.Text = Show();
            Clear();

        }

        public void Clear()
        {
            nameTextBox.Text = "";
            phoneNoTextBox.Text = "";
            addessRichTextBox.Text = "";
            itemComboBox.SelectedIndex = 0;
            quantityTextBox.Text = "";
        }
    }
}
