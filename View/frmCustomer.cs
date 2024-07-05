using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YojaDrink.Interface.Model;
using YojaDrink.Interface.Service;

namespace YojaDrink.View;

public partial class frmCustomer : Form
{
    private CustomerService customerService;
    public string Filtro { get; set; } = "";
    public string? Message { get; set; } = "";
    public frmCustomer()
    {
        InitializeComponent();
        customerService = new CustomerService();
    }
    public async Task CargarDatos()
    {
        var customers = await customerService.Consultar(Filtro);
        if (customers.Success)
        {
            dgCustomers.DataSource = null; // Clear the existing data source
            dgCustomers.DataSource = customers.Data; // Bind the new data
        }
        else
        {
            Message = customers.Message;
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private async void frmCustomer_Load(object sender, EventArgs e)
    {
        await CargarDatos();
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        Filtro = txtSearch.Text;
        await CargarDatos();
    }
}
