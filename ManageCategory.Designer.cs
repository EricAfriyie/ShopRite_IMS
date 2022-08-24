namespace ShopRite_IMS
{
    partial class ManageCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Catdesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.Catname = new Guna.UI2.WinForms.Guna2TextBox();
            this.CatId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.DGV1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Catdesc);
            this.panel1.Controls.Add(this.Catname);
            this.panel1.Controls.Add(this.CatId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(143, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 731);
            this.panel1.TabIndex = 6;
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToOrderColumns = true;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.BackgroundColor = System.Drawing.Color.White;
            this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV1.EnableHeadersVisualStyles = false;
            this.DGV1.Location = new System.Drawing.Point(397, 124);
            this.DGV1.Margin = new System.Windows.Forms.Padding(0);
            this.DGV1.MultiSelect = false;
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.RowHeadersWidth = 100;
            this.DGV1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(617, 548);
            this.DGV1.TabIndex = 16;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1012, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Crimson;
            this.button4.Location = new System.Drawing.Point(147, 329);
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
            this.button2.Location = new System.Drawing.Point(241, 329);
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
            this.button1.Location = new System.Drawing.Point(50, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Catdesc
            // 
            this.Catdesc.Animated = true;
            this.Catdesc.BorderColor = System.Drawing.Color.White;
            this.Catdesc.BorderThickness = 3;
            this.Catdesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Catdesc.DefaultText = "";
            this.Catdesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Catdesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Catdesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Catdesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Catdesc.FillColor = System.Drawing.Color.Crimson;
            this.Catdesc.FocusedState.BorderColor = System.Drawing.Color.White;
            this.Catdesc.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.Catdesc.FocusedState.ForeColor = System.Drawing.Color.White;
            this.Catdesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Catdesc.ForeColor = System.Drawing.Color.White;
            this.Catdesc.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.Catdesc.Location = new System.Drawing.Point(44, 234);
            this.Catdesc.Name = "Catdesc";
            this.Catdesc.PasswordChar = '\0';
            this.Catdesc.PlaceholderForeColor = System.Drawing.Color.White;
            this.Catdesc.PlaceholderText = "Description";
            this.Catdesc.SelectedText = "";
            this.Catdesc.Size = new System.Drawing.Size(297, 36);
            this.Catdesc.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Catdesc.TabIndex = 5;
            // 
            // Catname
            // 
            this.Catname.Animated = true;
            this.Catname.BorderColor = System.Drawing.Color.White;
            this.Catname.BorderThickness = 3;
            this.Catname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Catname.DefaultText = "";
            this.Catname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Catname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Catname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Catname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Catname.FillColor = System.Drawing.Color.Crimson;
            this.Catname.FocusedState.BorderColor = System.Drawing.Color.White;
            this.Catname.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.Catname.FocusedState.ForeColor = System.Drawing.Color.White;
            this.Catname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Catname.ForeColor = System.Drawing.Color.White;
            this.Catname.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.Catname.Location = new System.Drawing.Point(44, 163);
            this.Catname.Name = "Catname";
            this.Catname.PasswordChar = '\0';
            this.Catname.PlaceholderForeColor = System.Drawing.Color.White;
            this.Catname.PlaceholderText = "Name";
            this.Catname.SelectedText = "";
            this.Catname.Size = new System.Drawing.Size(297, 36);
            this.Catname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Catname.TabIndex = 4;
            // 
            // CatId
            // 
            this.CatId.Animated = true;
            this.CatId.BorderColor = System.Drawing.Color.White;
            this.CatId.BorderThickness = 3;
            this.CatId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatId.DefaultText = "";
            this.CatId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CatId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CatId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatId.FillColor = System.Drawing.Color.Crimson;
            this.CatId.FocusedState.BorderColor = System.Drawing.Color.White;
            this.CatId.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.CatId.FocusedState.ForeColor = System.Drawing.Color.White;
            this.CatId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CatId.ForeColor = System.Drawing.Color.White;
            this.CatId.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.CatId.Location = new System.Drawing.Point(44, 105);
            this.CatId.Name = "CatId";
            this.CatId.PasswordChar = '\0';
            this.CatId.PlaceholderForeColor = System.Drawing.Color.White;
            this.CatId.PlaceholderText = "ID";
            this.CatId.SelectedText = "";
            this.CatId.Size = new System.Drawing.Size(297, 36);
            this.CatId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CatId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "MANAGE CATEGORIES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(28, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(44, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 27);
            this.label4.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Crimson;
            this.button7.Location = new System.Drawing.Point(2, 210);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 46);
            this.button7.TabIndex = 19;
            this.button7.Text = "Selling";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Crimson;
            this.button6.Location = new System.Drawing.Point(2, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 41);
            this.button6.TabIndex = 18;
            this.button6.Text = "Sellers";
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
            this.button5.Location = new System.Drawing.Point(2, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 49);
            this.button5.TabIndex = 17;
            this.button5.Text = "Products";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 730);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategory";
            this.Text = "ManageCategory";
            this.Load += new System.EventHandler(this.ManageCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox Catdesc;
        private Guna.UI2.WinForms.Guna2TextBox Catname;
        private Guna.UI2.WinForms.Guna2TextBox CatId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}