using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopDB.BLL;
using ShopDB.DLL.DAO;

namespace ShopDB
{
    public partial class ShopUI : Form
    {
        private Shop aShop;
        private List<Shop> asShops; 
        public ShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ShopBll aShopBll=new ShopBll();
            aShop=new Shop(productCodeTextBox.Text,productNameTextBox.Text,Convert.ToInt32(qtyTextBox.Text));
            string msg = aShopBll.SaveProduct(aShop);
            MessageBox.Show(msg);
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            
            asShops=new List<Shop>();
            ShopBll aShopBll=new ShopBll();
            asShops = aShopBll.GetAllProduct();
            dataGridView1.DataSource = asShops;

                }

    }
}
