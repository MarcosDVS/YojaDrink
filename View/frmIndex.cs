using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YojaDrink.View.Customer;

namespace YojaDrink.View;

public partial class frmIndex : Form
{
    public frmIndex()
    {
        InitializeComponent();
        CustomizeDesing();
    }
    private void CustomizeDesing()
    {
        panelCustomer.Visible = false;
        panelProduct.Visible = false;
        panelFactura.Visible = false;
    }
    private void HideSubMenu()
    {
        if (panelCustomer.Visible == true) panelCustomer.Visible = false;
        if (panelProduct.Visible == true) panelProduct.Visible = false;
        if (panelFactura.Visible == true) panelFactura.Visible = false;
    }
    private void ShowSubMenu(Panel subMenu)
    {
        if (subMenu.Visible == false)
        {
            HideSubMenu();
            subMenu.Visible = true;
        }
        else subMenu.Visible = false;
    }

    private void btnCustomerOptions_Click(object sender, EventArgs e)
    {
        ShowSubMenu(panelCustomer);
    }

    private void btnProductOptions_Click(object sender, EventArgs e)
    {
        ShowSubMenu(panelProduct);
    }

    private void btnFacturaOptions_Click(object sender, EventArgs e)
    {
        ShowSubMenu(panelFactura);
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void btnResgistrarCustomer_Click(object sender, EventArgs e)
    {
        HideSubMenu();
    }

    private void btnReportesCustomer_Click(object sender, EventArgs e)
    {
        OpenChildForm(new frmCustomer());
        //..
        //Your code
        //..
        HideSubMenu();
    }

    private void btnRegistrarProductos_Click(object sender, EventArgs e)
    {
        HideSubMenu();
    }

    private void btnReportesProductos_Click(object sender, EventArgs e)
    {
        HideSubMenu();
    }

    private void btnRegistrarFacturas_Click(object sender, EventArgs e)
    {
        HideSubMenu();
    }

    private void btnReportesFacturas_Click(object sender, EventArgs e)
    {
        HideSubMenu();
    }
    private Form activeForm = null;
    private void OpenChildForm(Form childFom)
    {
        if (activeForm != null)
            activeForm.Close();
        activeForm = childFom;
        childFom.TopLevel = false;
        childFom.FormBorderStyle = FormBorderStyle.None;
        childFom.Dock = DockStyle.Fill;
        panelChilForm.Controls.Add(childFom);
        panelChilForm.Tag = childFom;
        childFom.BringToFront();
        childFom.Show();
    }

    private void btnHome_Click(object sender, EventArgs e)
    {
        if (activeForm != null)
            activeForm.Close();
        HideSubMenu();
    }
}
