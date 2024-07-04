using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
}
