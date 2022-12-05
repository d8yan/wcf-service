using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GardenInterface.ServiceReference1;

namespace GardenInterface
{
    public partial class _Default : Page
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProductDetails();
            }
        }
        protected void BindProductDetails()
        {
            IList<Product> objProductDetails = new List<Product>();
            objProductDetails = client.getAll();
            GridView1.DataSource = objProductDetails;
            GridView1.DataBind();
        }
        //ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Product product= new Product();
            product.Name = name.Text;
            product.Price = Convert.ToDecimal(price.Text);
            string res = client.add(product);
            lbmsg.Text = res.ToString();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ID= Int32.Parse(ID.Text);
            product.Name = name.Text;
            product.Price = Convert.ToDecimal(price.Text);
            string res = client.update(product);
            lbmsg.Text = res.ToString();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ID = Int32.Parse(ID.Text);
            string res = client.delete(product);
            lbmsg.Text = res.ToString();
        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            
                BindProductDetails();
            
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = client.get(Int32.Parse(ID.Text));
            searchID.Text = "Searched Product ID is " + product.ID;
            searchName.Text = "Searched Product Name is " + product.Name;
            searchPrice.Text = "Searched Product Price is " + product.Price;

        }
    }
}