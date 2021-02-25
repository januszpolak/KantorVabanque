using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KantorVabanque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetPoundPrice();
        }

        public void GetPoundPrice()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("http://www.kantorvabanque.pl/");

            var priceBuy = doc.DocumentNode.SelectSingleNode("//table/tbody/tr[4]/td[3]").InnerText;
            var priceSell = doc.DocumentNode.SelectSingleNode("//table/tbody/tr[4]/td[4]").InnerText;

            label1.Text = priceBuy.ToString();
            label3.Text = priceSell.ToString();

        }
    }
}
