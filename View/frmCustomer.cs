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
    public CustomerService customerService;
    public string Filtro { get; set; } = "";
    public frmCustomer()
    {
        InitializeComponent();
        customerService = new();
    }
    private async void frmCustomer_Load(object sender, EventArgs e)
    {
        await CargarDatos();
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
            MessageBox.Show(customers.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private int? GetId()
    {
        try
        {
            return int.Parse
            (
                dgCustomers.Rows[dgCustomers.CurrentRow.Index]
                .Cells[0]
                .Value.ToString()
            );
        }
        catch
        {
            return null;
        }
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

    private void btnEdit_Click(object sender, EventArgs e)
    {
        int? customerId = GetId();

        if (dgCustomers.SelectedRows.Count > 0)
        {
            // Preguntar confirmación
            DialogResult question = MessageBox.Show("Are you sure you want to edit it?", "Confirm edition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                if (customerId != null)
                {
                    frmCustomerForm customerForm = new(this, customerId);
                    customerForm.ShowDialog();

                }
            }
        }
        else
        {
            MessageBox.Show("Please select a customer to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        int? customerId = GetId();
        var result = await customerService.Eliminar(customerId);
        // Preguntar confirmación
        DialogResult question = MessageBox.Show("Are you sure you want to delete it?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (question == DialogResult.Yes)
        {
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarDatos(); // Refrescar el DataGridView
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
