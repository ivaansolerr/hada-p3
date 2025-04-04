using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            if (!IsPostBack)
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

                if (ddlCategory.Items.Count > 0)
                {
                    ddlCategory.Items.Clear();
                }

                foreach (ENCategory c in list)
                {
                    ddlCategory.Items.Add(new ListItem(c.Name, c.Id.ToString()));
                }
            }
<<<<<<< HEAD

            List<ENCategory> list = new List<ENCategory>();

            list = cADCategory.readAll();

            if (ddlCategory.Items.Count > 0)
            {
                ddlCategory.Items.Clear();
            }

            foreach (ENCategory c in list)
            {
                ddlCategory.Items.Add(c.Name);
            }
=======
>>>>>>> andrei
        }
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != null && txtName.Text != null && txtAmount.Text != null
                && txtPrice.Text != null && ddlCategory.Text != null && txtCreationDate.Text != null)
            {
                ENProduct newProduct = new ENProduct();

                newProduct.Code = txtCode.Text;
                newProduct.Name = txtName.Text;

                try
                {
                    int amount = int.Parse(txtAmount.Text);
                    newProduct.Amount = amount;
                }
                catch (Exception ex)
                {
                    DisplayMessage.Text = "Operation failed";
                    Console.WriteLine("User operation has failed. Error: {0}",ex.Message);
                    txtCode.Text = null;
                    txtName.Text = null;
                    txtAmount.Text = null;
                    txtPrice.Text = null;
                    ddlCategory.Text = null;
                    txtCreationDate.Text = null;
                    return;
                }

<<<<<<< HEAD
            if (cat == "Computing") newProduct.Category = 1;
            if (cat == "Telephony") newProduct.Category = 2;
            if (cat == "Gaming") newProduct.Category = 3;
            if (cat == "Home appliances") newProduct.Category = 4;
=======
                try
                {
                    float price = float.Parse(txtPrice.Text);
                    newProduct.Price = price;
                }
                catch (Exception ex)
                {
                    DisplayMessage.Text = "Operation failed.";
                    Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                    txtCode.Text = null;
                    txtName.Text = null;
                    txtAmount.Text = null;
                    txtPrice.Text = null;
                    ddlCategory.Text = null;
                    txtCreationDate.Text = null;
                    return;
                }
>>>>>>> andrei

                newProduct.Category = int.Parse(ddlCategory.SelectedValue);
                newProduct.CreationDate = DateTime.Parse(txtCreationDate.Text);

                newProduct.Create();
                DisplayMessage.Text = "Operation succeeded.";
                txtCode.Text = null;
                txtName.Text = null;
                txtAmount.Text = null;
                txtPrice.Text = null;
                ddlCategory.Text = null;
                txtCreationDate.Text = null;
                return;
            }

            txtCode.Text = null;
            txtName.Text = null;
            txtAmount.Text = null;
            txtPrice.Text = null;
            ddlCategory.Text = null;
            txtCreationDate.Text = null;

            DisplayMessage.Text = "Operation failed";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != null && txtName.Text != null && txtAmount.Text != null
                && txtPrice.Text != null && ddlCategory.Text != null && txtCreationDate.Text != null)
            {
                ENProduct newProduct = new ENProduct();

                newProduct.Code = txtCode.Text;
                newProduct.Name = txtName.Text;

                try
                {
                    int amount = int.Parse(txtAmount.Text);
                    newProduct.Amount = amount;
                }
                catch (Exception ex)
                {
                    DisplayMessage.Text = "Operation failed";
                    Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                    txtCode.Text = null;
                    txtName.Text = null;
                    txtAmount.Text = null;
                    txtPrice.Text = null;
                    ddlCategory.Text = null;
                    txtCreationDate.Text = null;
                    return;
                }

<<<<<<< HEAD
            if (cat == "Computing") newProduct.Category = 1;
            if (cat == "Telephony") newProduct.Category = 2;
            if (cat == "Gaming") newProduct.Category = 3;
            if (cat == "Home appliances") newProduct.Category = 4;
=======
                try
                {
                    float price = float.Parse(txtPrice.Text);
                    newProduct.Price = price;
                }
                catch (Exception ex)
                {
                    DisplayMessage.Text = "Operation failed";
                    Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                    txtCode.Text = null;
                    txtName.Text = null;
                    txtAmount.Text = null;
                    txtPrice.Text = null;
                    ddlCategory.Text = null;
                    txtCreationDate.Text = null;
                    return;
                }
>>>>>>> andrei

                newProduct.Category = int.Parse(ddlCategory.SelectedValue);
                newProduct.CreationDate = DateTime.Parse(txtCreationDate.Text);

                newProduct.Update();
                DisplayMessage.Text = "Operation succeeded.";
                txtCode.Text = null;
                txtName.Text = null;
                txtAmount.Text = null;
                txtPrice.Text = null;
                ddlCategory.Text = null;
                txtCreationDate.Text = null;
                return;
            }

            txtCode.Text = null;
            txtName.Text = null;
            txtAmount.Text = null;
            txtPrice.Text = null;
            ddlCategory.Text = null;
            txtCreationDate.Text = null;

            DisplayMessage.Text = "Operation failed";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != null)
            {
                ENProduct newProduct = new ENProduct();

                newProduct.Code = txtCode.Text;

                if (newProduct.Delete())
                {
                    DisplayMessage.Text = "Operation succeeded";
                    txtCode.Text = null;
                    txtName.Text = null;
                    txtAmount.Text = null;
                    txtPrice.Text = null;
                    ddlCategory.Text = null;
                    txtCreationDate.Text = null;
                    return;
                }
            }

            txtCode.Text = null;
            txtName.Text = null;
            txtAmount.Text = null;
            txtPrice.Text = null;
            ddlCategory.Text = null;
            txtCreationDate.Text = null;

            DisplayMessage.Text = "Operation failed";
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            DisplayMessage.Text = "";

            if (txtCode.Text != null)
            {
                ENProduct newProduct = new ENProduct();

                newProduct.Code = txtCode.Text;

                if (newProduct.Read())
                {
                    txtName.Text = newProduct.Name;
                    txtAmount.Text = newProduct.Amount.ToString();
                    txtPrice.Text = newProduct.Price.ToString();
                    ddlCategory.SelectedValue = newProduct.Category.ToString();
                    txtCreationDate.Text = newProduct.CreationDate.ToString("yyyy-MM-dd");
                }

                else
                {
                    txtCode.Text = null;
                    txtName.Text = null;
                    txtAmount.Text = null;
                    txtPrice.Text = null;
                    ddlCategory.Text = null;
                    txtCreationDate.Text = null;
                }

<<<<<<< HEAD
            if (cat == 1) ddlCategory.Text = "Computing";
            if (cat == 2) ddlCategory.Text = "Telephony";
            if (cat == 3) ddlCategory.Text = "Gaming";
            if (cat == 4) ddlCategory.Text = "Home appliances";

            txtCreationDate.Text = newProduct.CreationDate.ToString("yyyy-MM-dd");
=======
            }
>>>>>>> andrei
        }

        protected void btnReadFirst_Click(object sender, EventArgs e)
        {
            DisplayMessage.Text = "";

            if (txtCode.Text != null)
            {
                ENProduct newProduct = new ENProduct();

                if (newProduct.ReadFirst())
                {
                    txtCode.Text = newProduct.Code.ToString();
                    txtName.Text = newProduct.Name;
                    txtAmount.Text = newProduct.Amount.ToString();
                    txtPrice.Text = newProduct.Price.ToString();
                    ddlCategory.SelectedValue = newProduct.Category.ToString();
                    txtCreationDate.Text = newProduct.CreationDate.ToString("yyyy-MM-dd");
                }

<<<<<<< HEAD
            int cat = newProduct.Category;

            if (cat == 1) ddlCategory.Text = "Computing";
            if (cat == 2) ddlCategory.Text = "Telephony";
            if (cat == 3) ddlCategory.Text = "Gaming";
            if (cat == 4) ddlCategory.Text = "Home appliances";

            txtCreationDate.Text = newProduct.CreationDate.ToString("yyyy-MM-dd");
=======
                else
                {
                    txtCode.Text = null;
                    txtName.Text = null;
                    txtAmount.Text = null;
                    txtPrice.Text = null;
                    ddlCategory.Text = null;
                    txtCreationDate.Text = null;
                }
            }
>>>>>>> andrei
        }

        protected void btnReadPrev_Click(object sender, EventArgs e)
        {
            DisplayMessage.Text = "";

            if (txtCode.Text != null)
            {
                ENProduct newProduct = new ENProduct();

                newProduct.Code = txtCode.Text;

                if (newProduct.ReadPrev())
                {
                    txtCode.Text = newProduct.Code.ToString();
                    txtName.Text = newProduct.Name;
                    txtAmount.Text = newProduct.Amount.ToString();
                    txtPrice.Text = newProduct.Price.ToString();
                    ddlCategory.SelectedValue = newProduct.Category.ToString();
                    txtCreationDate.Text = newProduct.CreationDate.ToString("yyyy-MM-dd");
                }

<<<<<<< HEAD
            int cat = newProduct.Category;

            if (cat == 1) ddlCategory.Text = "Computing";
            if (cat == 2) ddlCategory.Text = "Telephony";
            if (cat == 3) ddlCategory.Text = "Gaming";
            if (cat == 4) ddlCategory.Text = "Home appliances";

            txtCreationDate.Text = newProduct.CreationDate.ToString("yyyy-MM-dd");
=======
                else
                {
                    txtCode.Text = null;
                    txtName.Text = null;
                    txtAmount.Text = null;
                    txtPrice.Text = null;
                    ddlCategory.Text = null;
                    txtCreationDate.Text = null;
                }
            }
>>>>>>> andrei
        }

        protected void btnReadNext_Click(object sender, EventArgs e)
        {
            DisplayMessage.Text = "";

            if (txtCode.Text != null)
            {
                ENProduct newProduct = new ENProduct();

                newProduct.Code = txtCode.Text;

                if (newProduct.ReadNext())
                {
                    txtCode.Text = newProduct.Code;
                    txtName.Text = newProduct.Name;
                    txtAmount.Text = newProduct.Amount.ToString();
                    txtPrice.Text = newProduct.Price.ToString();
                    ddlCategory.SelectedValue = newProduct.Category.ToString();
                    txtCreationDate.Text = newProduct.CreationDate.ToString("yyyy-MM-dd");
                }

<<<<<<< HEAD
            int cat = newProduct.Category;

            if (cat == 1) ddlCategory.Text = "Computing";
            if (cat == 2) ddlCategory.Text = "Telephony";
            if (cat == 3) ddlCategory.Text = "Gaming";
            if (cat == 4) ddlCategory.Text = "Home appliances";

            txtCreationDate.Text = newProduct.CreationDate.ToString("yyyy-MM-dd");
=======
                else
                {
                    txtCode.Text = null;
                    txtName.Text = null;
                    txtAmount.Text = null;
                    txtPrice.Text = null;
                    ddlCategory.Text = null;
                    txtCreationDate.Text = null;
                }
            }
>>>>>>> andrei
        }
    }
}