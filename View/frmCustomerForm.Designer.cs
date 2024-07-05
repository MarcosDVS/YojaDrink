namespace YojaDrink.View
{
    partial class frmCustomerForm
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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSurNames = new TextBox();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            txtDocumentID = new TextBox();
            rhOther = new RichTextBox();
            label5 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(258, 27);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 3;
            label2.Text = "SurNames";
            // 
            // txtSurNames
            // 
            txtSurNames.Location = new Point(258, 54);
            txtSurNames.Name = "txtSurNames";
            txtSurNames.Size = new Size(199, 23);
            txtSurNames.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(258, 91);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 7;
            label3.Text = "Phone-Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(258, 118);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(199, 23);
            txtPhoneNumber.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(12, 91);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 5;
            label4.Text = "Document-ID";
            // 
            // txtDocumentID
            // 
            txtDocumentID.Location = new Point(12, 118);
            txtDocumentID.Name = "txtDocumentID";
            txtDocumentID.Size = new Size(199, 23);
            txtDocumentID.TabIndex = 4;
            // 
            // rhOther
            // 
            rhOther.Location = new Point(12, 178);
            rhOther.Name = "rhOther";
            rhOther.Size = new Size(199, 52);
            rhOther.TabIndex = 8;
            rhOther.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 9;
            label5.Text = "Other-Info";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(258, 178);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(199, 52);
            btnSave.TabIndex = 10;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 40);
            ClientSize = new Size(469, 249);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(rhOther);
            Controls.Add(label3);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label4);
            Controls.Add(txtDocumentID);
            Controls.Add(label2);
            Controls.Add(txtSurNames);
            Controls.Add(label1);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(485, 288);
            MinimizeBox = false;
            MinimumSize = new Size(485, 288);
            Name = "frmCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTER CUSTOMER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtSurNames;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label4;
        private TextBox txtDocumentID;
        private RichTextBox rhOther;
        private Label label5;
        private Button btnSave;
    }
}