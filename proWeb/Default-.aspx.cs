using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
<<<<<<< HEAD
using library;
=======
using System.Xml.Linq;
using library;
using static System.Runtime.CompilerServices.RuntimeHelpers;
>>>>>>> main

namespace proWeb
{
    public partial class Default_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
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
            if (cat == "Gaming") newProduct.Category= 2;
            if (cat == "Home appliances") newProduct.Category= 3;

            newProduct.CreationDate = DateTime.Parse(txtCreationDate.Text);

            newProduct.Create();
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
        }

        protected void btnDelete_Click(object sender, EventArgs e)
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

            newProduct.Delete();
        }

        protected void btnRead_Click(object sender, EventArgs e)
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

            newProduct.Read();
        }

        protected void btnReadFirst_Click(object sender, EventArgs e)
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

            newProduct.ReadFirst();
        }

        protected void btnReadPrev_Click(object sender, EventArgs e)
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

            newProduct.ReadPrev();
        }

        protected void btnReadNext_Click(object sender, EventArgs e)
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

            newProduct.ReadNext();
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
        }

        protected void btnDelete_Click(object sender, EventArgs e)
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

            newProduct.Delete();
        }

        protected void btnRead_Click(object sender, EventArgs e)
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

            newProduct.Read();
        }

        protected void btnReadFirst_Click(object sender, EventArgs e)
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

            newProduct.ReadFirst();
        }

        protected void btnReadPrev_Click(object sender, EventArgs e)
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

            newProduct.ReadPrev();
        }

        protected void btnReadNext_Click(object sender, EventArgs e)
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

            newProduct.ReadNext();
        }
    }
}