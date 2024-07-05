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

public partial class frmCustomerForm : Form
{
    public string? Message { get; set; } = "";
    private CustomerService customerService;
    frmCustomer _parentForm;
    public Customer request { get; set; } = new();

    public frmCustomerForm(frmCustomer parentForm)
    {
        InitializeComponent();
        customerService = new();
        this._parentForm = parentForm;
    }
    private void Clean()
    {
        txtName.Clear();
        txtSurNames.Clear();
        txtDocumentID.Clear();
        txtPhoneNumber.Clear();
        rhOther.Clear();
    }
    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurNames.Text) ||
            string.IsNullOrWhiteSpace(txtDocumentID.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
            string.IsNullOrWhiteSpace(rhOther.Text))
        {
            MessageBox.Show("Please enter both Name and Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        };

        // Create a new customer object
        request.Name = txtName.Text;
        request.SurNames = txtSurNames.Text;
        request.DocumentId = txtDocumentID.Text;
        request.PhoneNumber = txtPhoneNumber.Text;
        request.Other = rhOther.Text;


        var result = await customerService.Crear(request);
        if (result.Success)
        {
            MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clean();
            await _parentForm.CargarDatos();
            this.Close();
        }
        else
        {
            MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
