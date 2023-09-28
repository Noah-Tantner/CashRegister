using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //all the variables you could ever want:
        double total;
        double tendered;
        double change;
        double doener;
        double pommes;
        double drinks;

        double doenerPrice;
        double pommesPrice;
        double drinksPrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateCostButton_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                double tax = 0.19;

                doenerPrice = 7.00;
                pommesPrice = 2.50;
                drinksPrice = 1.50;

                doener = Convert.ToDouble(doenerInput.Text);
                pommes = Convert.ToDouble(pommesInput.Text);
                drinks = Convert.ToDouble(drinksInput.Text);



                //calculations
                double subtotal = doener * doenerPrice + pommes * pommesPrice + drinks * drinksPrice;
                double specificTax = subtotal * tax;
                total = subtotal + specificTax;

                //output
                subtotalOutput.Text = subtotal.ToString("C");
                taxOutput.Text = specificTax.ToString("C");
                totalOutput.Text = total.ToString("C");
            }
            catch
            {
                subtotalOutput.Text += "Gib";
                taxOutput.Text += "Zahlen";
                totalOutput.Text += "ein";
            }
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                    tendered = Convert.ToDouble(tenderedInput.Text);
                    change = tendered - total;

                    changeOutput.Text = change.ToString("C");
            }
            catch
            {
                changeOutput.Text = "Nein";
            }
            
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            try
            {

                int delayTime = 0;

                SoundPlayer printerSound = new SoundPlayer(Properties.Resources.printerSound);

                double doenerPriceTotal = doener * doenerPrice;
                double pommesPriceTotal = pommes * pommesPrice;
                double drinksPriceTotal = drinks * drinksPrice;

                receiptLabel.BackColor = Color.White;

                if (tenderedInput.Text != "")
                {
                    //the printerSound is used irregularly on purpose to more accurately recreate how a receipt getting printed sounds
                    receiptLabel.Text = "Ihr Kauf:                                              ";
                    printerSound.Play();
                    Thread.Sleep(delayTime);

                    Refresh();

                    receiptLabel.Text += "\nDÖNER KEBAB Hochdorf";
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += "\n31. Juni 2023";
                    printerSound.Play();
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += $"\n\nDöner      x  {doener}         ";
                    receiptLabel.Text += doenerPriceTotal.ToString("C");
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += $"\nPommes  x  {pommes}         ";
                    receiptLabel.Text += pommesPriceTotal.ToString("C");
                    Thread.Sleep(delayTime);
                    printerSound.Play();
                    Refresh();

                    receiptLabel.Text += $"\nCola         x   {drinks}         ";
                    receiptLabel.Text += drinksPriceTotal.ToString("C");
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += $"\n\nBar:                         {tendered.ToString("C")}";
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += $"\nWechselgeld:          {change.ToString("C")}";
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += "\n\n        Danke für ihren Einkauf!";
                    printerSound.Play();
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += "\n\n           Döner Kebab Laden     ";
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += "\nAchselweg 69, 394810 Hochdorf";
                    Thread.Sleep(delayTime);
                    printerSound.Play();
                    Refresh();

                    receiptLabel.Text += "\n----------------------------------------------";
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += "\n\nTelefonnummer: +49 192 6785";
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += "\n                                      ";
                    Thread.Sleep(delayTime);
                    Refresh();

                    receiptLabel.Text += "\n                                      ";
                    Thread.Sleep(delayTime);
                    Refresh();
                }
                else receiptLabel.Text = "Du musst bezahlen.";
            }
            catch
            {
                receiptLabel.Text = "Junge lass den Scheiß";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
