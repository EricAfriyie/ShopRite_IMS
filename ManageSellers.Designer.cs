namespace ShopRite_IMS
{
    partial class ManageSellers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV3 = new System.Windows.Forms.DataGridView();
            this.SellerPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SellerMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.SellerAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.SellerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SellerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(345, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.DGV3);
            this.panel1.Controls.Add(this.SellerPass);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SellerMobile);
            this.panel1.Controls.Add(this.SellerAge);
            this.panel1.Controls.Add(this.SellerName);
            this.panel1.Controls.Add(this.SellerId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(140, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 731);
            this.panel1.TabIndex = 5;
            // 
            // DGV3
            // 
            this.DGV3.AllowUserToOrderColumns = true;
            this.DGV3.BackgroundColor = System.Drawing.Color.White;
            this.DGV3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV3.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV3.EnableHeadersVisualStyles = false;
            this.DGV3.Location = new System.Drawing.Point(383, 129);
            this.DGV3.MultiSelect = false;
            this.DGV3.Name = "DGV3";
            this.DGV3.RowHeadersVisible = false;
            this.DGV3.RowHeadersWidth = 51;
            this.DGV3.RowTemplate.Height = 24;
            this.DGV3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV3.Size = new System.Drawing.Size(644, 548);
            this.DGV3.TabIndex = 16;
            this.DGV3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV3_CellContentClick);
            // 
            // SellerPass
            // 
            this.SellerPass.Animated = true;
            this.SellerPass.BorderColor = System.Drawing.Color.White;
            this.SellerPass.BorderThickness = 3;
            this.SellerPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerPass.DefaultText = "";
            this.SellerPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerPass.FillColor = System.Drawing.Color.Crimson;
            this.SellerPass.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SellerPass.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.SellerPass.FocusedState.ForeColor = System.Drawing.Color.White;
            this.SellerPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerPass.ForeColor = System.Drawing.Color.White;
            this.SellerPass.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SellerPass.Location = new System.Drawing.Point(44, 359);
            this.SellerPass.Name = "SellerPass";
            this.SellerPass.PasswordChar = '\0';
            this.SellerPass.PlaceholderForeColor = System.Drawing.Color.White;
            this.SellerPass.PlaceholderText = "Password";
            this.SellerPass.SelectedText = "";
            this.SellerPass.Size = new System.Drawing.Size(297, 36);
            this.SellerPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SellerPass.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Crimson;
            this.button4.Location = new System.Drawing.Point(141, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 41);
            this.button4.TabIndex = 13;
            this.button4.Text = "EDIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(235, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(44, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerMobile
            // 
            this.SellerMobile.Animated = true;
            this.SellerMobile.BorderColor = System.Drawing.Color.White;
            this.SellerMobile.BorderThickness = 3;
            this.SellerMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerMobile.DefaultText = "";
            this.SellerMobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerMobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerMobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerMobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerMobile.FillColor = System.Drawing.Color.Crimson;
            this.SellerMobile.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SellerMobile.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.SellerMobile.FocusedState.ForeColor = System.Drawing.Color.White;
            this.SellerMobile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerMobile.ForeColor = System.Drawing.Color.White;
            this.SellerMobile.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SellerMobile.Location = new System.Drawing.Point(44, 297);
            this.SellerMobile.Name = "SellerMobile";
            this.SellerMobile.PasswordChar = '\0';
            this.SellerMobile.PlaceholderForeColor = System.Drawing.Color.White;
            this.SellerMobile.PlaceholderText = "Mobile";
            this.SellerMobile.SelectedText = "";
            this.SellerMobile.Size = new System.Drawing.Size(297, 36);
            this.SellerMobile.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SellerMobile.TabIndex = 6;
            // 
            // SellerAge
            // 
            this.SellerAge.Animated = true;
            this.SellerAge.BorderColor = System.Drawing.Color.White;
            this.SellerAge.BorderThickness = 3;
            this.SellerAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerAge.DefaultText = "";
            this.SellerAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerAge.FillColor = System.Drawing.Color.Crimson;
            this.SellerAge.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SellerAge.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.SellerAge.FocusedState.ForeColor = System.Drawing.Color.White;
            this.SellerAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerAge.ForeColor = System.Drawing.Color.White;
            this.SellerAge.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SellerAge.Location = new System.Drawing.Point(44, 234);
            this.SellerAge.Name = "SellerAge";
            this.SellerAge.PasswordChar = '\0';
            this.SellerAge.PlaceholderForeColor = System.Drawing.Color.White;
            this.SellerAge.PlaceholderText = "Age";
            this.SellerAge.SelectedText = "";
            this.SellerAge.Size = new System.Drawing.Size(297, 36);
            this.SellerAge.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SellerAge.TabIndex = 5;
            // 
            // SellerName
            // 
            this.SellerName.Animated = true;
            this.SellerName.BorderColor = System.Drawing.Color.White;
            this.SellerName.BorderThickness = 3;
            this.SellerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerName.DefaultText = "";
            this.SellerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerName.FillColor = System.Drawing.Color.Crimson;
            this.SellerName.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SellerName.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.SellerName.FocusedState.ForeColor = System.Drawing.Color.White;
            this.SellerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerName.ForeColor = System.Drawing.Color.White;
            this.SellerName.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SellerName.Location = new System.Drawing.Point(44, 163);
            this.SellerName.Name = "SellerName";
            this.SellerName.PasswordChar = '\0';
            this.SellerName.PlaceholderForeColor = System.Drawing.Color.White;
            this.SellerName.PlaceholderText = "Name";
            this.SellerName.SelectedText = "";
            this.SellerName.Size = new System.Drawing.Size(297, 36);
            this.SellerName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SellerName.TabIndex = 4;
            // 
            // SellerId
            // 
            this.SellerId.Animated = true;
            this.SellerId.BorderColor = System.Drawing.Color.White;
            this.SellerId.BorderThickness = 3;
            this.SellerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerId.DefaultText = "";
            this.SellerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerId.FillColor = System.Drawing.Color.Crimson;
            this.SellerId.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SellerId.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.SellerId.FocusedState.ForeColor = System.Drawing.Color.White;
            this.SellerId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerId.ForeColor = System.Drawing.Color.White;
            this.SellerId.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SellerId.Location = new System.Drawing.Point(44, 105);
            this.SellerId.Name = "SellerId";
            this.SellerId.PasswordChar = '\0';
            this.SellerId.PlaceholderForeColor = System.Drawing.Color.White;
            this.SellerId.PlaceholderText = "ID";
            this.SellerId.SelectedText = "";
            this.SellerId.Size = new System.Drawing.Size(297, 36);
            this.SellerId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SellerId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(384, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "MANAGE SELLERS";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Crimson;
            this.button7.Location = new System.Drawing.Point(4, 212);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 46);
            this.button7.TabIndex = 22;
            this.button7.Text = "Categories";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Crimson;
            this.button6.Location = new System.Drawing.Point(4, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 41);
            this.button6.TabIndex = 21;
            this.button6.Text = "Products";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Crimson;
            this.button5.Location = new System.Drawing.Point(4, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 49);
            this.button5.TabIndex = 20;
            this.button5.Text = "Selling";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bauhaus 93", 13.4F);
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(22, 677);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 31;
            this.button3.Text = "logout";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManageSellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 724);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageSellers";
            this.Text = "ManageSellers";
            this.Load += new System.EventHandler(this.ManageSellers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox SellerMobile;
        private Guna.UI2.WinForms.Guna2TextBox SellerAge;
        private Guna.UI2.WinForms.Guna2TextBox SellerName;
        private Guna.UI2.WinForms.Guna2TextBox SellerId;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox SellerPass;
        private System.Windows.Forms.DataGridView DGV3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
    }
}