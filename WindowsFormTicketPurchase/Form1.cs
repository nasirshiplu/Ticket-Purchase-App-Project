using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTicketPurchase
{
    public partial class TicketPurcheseUI : Form
    {
        public TicketPurcheseUI()
        {
            InitializeComponent();
        }
        List<string> ticketList = new List<string>(); 
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextBox.Text;
            int ticketNumber = Convert.ToInt32(numberOfTicketTextBox.Text);
            ticketList.Add(customerName);
            ticketList.Add(Convert.ToString(ticketNumber));
            customerNameTextBox.Text = "";
            numberOfTicketTextBox.Text = "";
            string name =ticketList[0];
            int ticket =Convert.ToInt32( ticketList[1]);

            MessageBox.Show(name + ", Please pay " + (ticket*10) + " taka to purchase " + ticket + " ticket(s)");

        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            string name = ticketList[0];
            int ticket = Convert.ToInt32(ticketList[1]);

            MessageBox.Show("Name  : " + name + "\n" + "Number of ticket(s) : " + ticket + "\n " + "Ticket Price : " + (ticket * 10) + " taka  ");

        }
    }
}
