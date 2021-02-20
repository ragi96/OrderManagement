using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagment.View
{
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void CmdCustomerManagment_Click(object sender, EventArgs e)
        {
            var view = new CustomerManagmentView();
            view.Show();
            this.Close();
        }

        private void CmdOrderManagment_Click(object sender, EventArgs e)
        {
            var view = new OrderManagmentView();
            view.Show();
            this.Close();
        }
        private void CmdArticleManagment_Click(object sender, EventArgs e)
        {
            var view = new ArticleManagmentView();
            view.Show();
            this.Close();
        }

        private void CmdYearCompare_Click(object sender, EventArgs e)
        {
            var view = new YearlyCompareView();
            view.Show();
            this.Close();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
