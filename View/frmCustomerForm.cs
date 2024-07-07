using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YojaDrink.Interface.Context;
using YojaDrink.Interface.Model;
using YojaDrink.Interface.Service;

namespace YojaDrink.View;

public partial class frmCustomerForm : Form
{
    frmCustomer _parentForm;
    public string Filtro { get; set; } = "";
    public Customer request { get; set; } = new();
    public int? id;

    public frmCustomerForm(frmCustomer parentForm, int? id = null)
    {
        InitializeComponent();
        this._parentForm = parentForm;
        this.id = id;
        if (id != null)
        {
            CargarDatos();
        }
    }
    private async void CargarDatos()
    {
        var result = await _parentForm.customerService.Consultar(Filtro);
        request = result.Data.Find(c=> c.Id == id);
        if (request != null)
        {
            txtName.Text = request.Name;
            txtSurNames.Text = request.SurNames;
            txtDocumentID.Text = request.DocumentId;
            txtPhoneNumber.Text = request.PhoneNumber;
            rhOther.Text = request.Other;
        }
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
            string.IsNullOrWhiteSpace(txtDocumentID.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
        {
            MessageBox.Show("Please enter all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Create a new customer object
        request.Name = txtName.Text;
        request.SurNames = txtSurNames.Text;
        request.DocumentId = txtDocumentID.Text;
        request.PhoneNumber = txtPhoneNumber.Text;
        request.Other = rhOther.Text;

        try
        {
            Result result;
            if (id == null)
            {
                // Create a new customer object
                result = await _parentForm.customerService.Crear(request);
            }
            else
            {
                // Call the Modificar method to update the customer
                result = await _parentForm.customerService.Modificar(request);
            }

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Call the ReloadParentData method to update the DataGridView in the parent form
                await _parentForm.CargarDatos();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Clean();
            this.Close();
        }
    }

}
