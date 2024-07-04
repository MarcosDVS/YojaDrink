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
            btnEdit = new Button();
            btnDelete = new Button();
            dgCustomers = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomers).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(24, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgCustomers);
            panel1.Location = new Point(24, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 472);
            panel1.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(647, 77);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(647, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgCustomers
            // 
            dgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomers.Dock = DockStyle.Fill;
            dgCustomers.Location = new Point(0, 0);
            dgCustomers.Name = "dgCustomers";
            dgCustomers.Size = new Size(617, 472);
            dgCustomers.TabIndex = 0;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 561);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Name = "frmCustomer";
            Text = "frmCustomer";
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