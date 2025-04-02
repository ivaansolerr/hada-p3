using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using library;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace proWeb
{
    public partial class Default_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CADCategory cADCategory = new CADCategory();

            for (int i = 1; i <= 4; i++)
            {
                ENCategory newC = new ENCategory();
                newC.Id = i;
                cADCategory.read(newC);
            }

            List<ENCategory> list = new List<ENCategory>();

            list = cADCategory.readAll();

            foreach (ENCategory c in list)
            {
                ddlCategory.Items.Add(c.Name);
            }

        }
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            ENProduct newProduct = new ENProduct();

            newProduct.Code = txtCode.Text;
            newProduct.Name = txtName.Text;
            newProduct.Amount = int.Parse(txtAmount.Text);
            newProduct.Price = float.Parse(txtPrice.Text);

            string cat = ddlCategory.Text;

            if (cat == "Computing") newProduct.Category = 0;
            if (cat == "Telephony") newProduct.Category = 1;
            if (cat == "Gaming") newProduct.Category = 2;
            if (cat == "Home appliances") newProduct.Category = 3;

            newProduct.CreationDate = DateTime.Parse(txtCreationDate.Text);

            newProduct.Create();

            txtCode.Text = null;
            txtName.Text = null;
            txtAmount.Text = null;
            txtPrice.Text = null;
            ddlCategory.Text = null;
            txtCreationDate.Text = null;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ENProduct newProduct = new ENProduct();

            newProduct.Code = txtCode.Text;
            newProduct.Name = txtName.Text;
            newProduct.Amount = int.Parse(txtAmount.Text);
            newProduct.Price = float.Parse(txtPrice.Text);

            string cat = ddlCategory.Text;

            if (cat == "Computing") newProduct.Category = 0;
            if (cat == "Telephony") newProduct.Category = 1;
            if (cat == "Gaming") newProduct.Category = 2;
            if (cat == "Home appliances") newProduct.Category = 3;

            newProduct.CreationDate = DateTime.Parse(txtCreationDate.Text);

            newProduct.Update();

            txtCode.Text = null;
            txtName.Text = null;
            txtAmount.Text = null;
            txtPrice.Text = null;
            ddlCategory.Text = null;
            txtCreationDate.Text = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ENProduct newProduct = new ENProduct();

            newProduct.Code = txtCode.Text;

            newProduct.Delete();

            txtCode.Text = null;
            txtName.Text = null;
            txtAmount.Text = null;
            txtPrice.Text = null;
            ddlCategory.Text = null;
            txtCreationDate.Text = null;
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            ENProduct newProduct = new ENProduct();

            newProduct.Code = txtCode.Text;

            newProduct.Read();

            txtName.Text = newProduct.Name;
            txtAmount.Text = newProduct.Amount.ToString();
            txtPrice.Text = newProduct.Price.ToString();

            int cat = newProduct.Category;

            if (cat == 0) ddlCategory.Text = "Computing";
            if (cat == 1) ddlCategory.Text = "Telephony";
            if (cat == 2) ddlCategory.Text = "Gaming";
            if (cat == 3) ddlCategory.Text = "Home appliances";

            txtCreationDate.Text = newProduct.CreationDate.ToString("yyyy-MM-dd");
        }

        protected void btnReadFirst_Click(object sender, EventArgs e)
        {
            ENProduct newProduct = new ENProduct();

            newProduct.ReadFirst();

            txtCode.Text = newProduct.Code.ToString();
            txtName.Text = newProduct.Name;
            txtAmount.Text = newProduct.Amount.ToString();
            txtPrice.Text = newProduct.Price.ToString();

            int cat = newProduct.Category;

            if (cat == 0) ddlCategory.Text = "Computing";
            if (cat == 1) ddlCategory.Text = "Telephony";
            if (cat == 2) ddlCategory.Text = "Gaming";
            if (cat == 3) ddlCategory.Text = "Home appliances";

            txtCreationDate.Text = newProduct.CreationDate.ToString();
        }

        protected void btnReadPrev_Click(object sender, EventArgs e)
        {
            ENProduct newProduct = new ENProduct();

            newProduct.Code = txtCode.Text;

            newProduct.ReadPrev();

            txtCode.Text = newProduct.Code.ToString();
            txtName.Text = newProduct.Name;
            txtAmount.Text = newProduct.Amount.ToString();
            txtPrice.Text = newProduct.Price.ToString();

            int cat = newProduct.Category;

            if (cat == 0) ddlCategory.Text = "Computing";
            if (cat == 1) ddlCategory.Text = "Telephony";
            if (cat == 2) ddlCategory.Text = "Gaming";
            if (cat == 3) ddlCategory.Text = "Home appliances";

            txtCreationDate.Text = newProduct.CreationDate.ToString();
        }

        protected void btnReadNext_Click(object sender, EventArgs e)
        {
            ENProduct newProduct = new ENProduct();

            newProduct.Code = txtCode.Text;

            newProduct.ReadNext();

            txtCode.Text = newProduct.Code;
            txtName.Text = newProduct.Name;
            txtAmount.Text = newProduct.Amount.ToString();
            txtPrice.Text = newProduct.Price.ToString();

            int cat = newProduct.Category;

            if (cat == 0) ddlCategory.Text = "Computing";
            if (cat == 1) ddlCategory.Text = "Telephony";
            if (cat == 2) ddlCategory.Text = "Gaming";
            if (cat == 3) ddlCategory.Text = "Home appliances";

            txtCreationDate.Text = newProduct.CreationDate.ToString();
        }
    }
}