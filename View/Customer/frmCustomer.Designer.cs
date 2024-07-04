namespace YojaDrink.View.Customer
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            panel1 = new Panel();
            dgCustomers = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomers).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.WhiteSmoke;
            btnClose.Location = new Point(12, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgCustomers);
            panel1.Location = new Point(12, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 502);
            panel1.TabIndex = 1;
            // 
            // dgCustomers
            // 
            dgCustomers.AllowDrop = true;
            dgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomers.Dock = DockStyle.Fill;
            dgCustomers.Location = new Point(0, 0);
            dgCustomers.Name = "dgCustomers";
            dgCustomers.Size = new Size(644, 502);
            dgCustomers.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnEdit.ForeColor = Color.WhiteSmoke;
            btnEdit.Location = new Point(662, 47);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(60, 27);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(662, 86);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 27);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(734, 561);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Name = "frmCustomer";
            Text = "frmCustomer";
            Load += frmCustomer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Panel panel1;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgCustomers;
    }
}