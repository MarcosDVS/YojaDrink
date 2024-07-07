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
    frmCustomer customerReport;
    private Form? activeForm = null; //para mostrar todos los formularios en frmIndex 
    public frmIndex()
    {
        InitializeComponent();
        CustomizeDesing();
    }
    #region Funciones para el menu desplegable
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
    #endregion
    
    #region Botones desplegables
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
    #endregion
    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }
    #region Opciones de los botones desplegables
    private void btnResgistrarCustomer_Click(object sender, EventArgs e)
    {
        
        frmCustomerForm customerForm = new(customerReport);
        customerForm.ShowDialog();
        HideSubMenu();
    }

    private void btnReportesCustomer_Click(object sender, EventArgs e)
    {
        if (activeForm != null)
        {
            activeForm.Close();
            activeForm = null;
        }
        else
        {
            
            OpenChildForm(new frmCustomer());
        }
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
    #endregion

    #region Mostrar todos los formularios en frmIndex especificamente en el panelChilForm
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
    #endregion
    private void btnHome_Click(object sender, EventArgs e)
    {
        if (activeForm != null)
            activeForm.Close();
        HideSubMenu();
    }
}
