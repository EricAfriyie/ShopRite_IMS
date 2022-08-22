using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopRite_IMS
{
    public partial class Login : Form
    {
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox logUsername;
        private Button button1;
        private Guna.UI2.WinForms.Guna2TextBox logPassword;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private PictureBox pictureBox1;
        private Panel panel1;

        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.logPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2CheckBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.logPassword);
            this.panel1.Controls.Add(this.logUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(320, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 391);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(642, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHOPRITE SUPERCHEK MANAGEMENT SYSTEM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // logUsername
            // 
            this.logUsername.Animated = true;
            this.logUsername.BorderColor = System.Drawing.Color.White;
            this.logUsername.BorderThickness = 3;
            this.logUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logUsername.DefaultText = "";
            this.logUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.logUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.logUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logUsername.FillColor = System.Drawing.Color.DodgerBlue;
            this.logUsername.FocusedState.BorderColor = System.Drawing.Color.White;
            this.logUsername.FocusedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.logUsername.FocusedState.ForeColor = System.Drawing.Color.White;
            this.logUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logUsername.ForeColor = System.Drawing.Color.White;
            this.logUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logUsername.Location = new System.Drawing.Point(45, 168);
            this.logUsername.Name = "logUsername";
            this.logUsername.PasswordChar = '\0';
            this.logUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.logUsername.PlaceholderText = "Username";
            this.logUsername.SelectedText = "";
            this.logUsername.Size = new System.Drawing.Size(231, 36);
            this.logUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.logUsername.TabIndex = 1;
            // 
            // logPassword
            // 
            this.logPassword.Animated = true;
            this.logPassword.BorderColor = System.Drawing.Color.White;
            this.logPassword.BorderThickness = 3;
            this.logPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logPassword.DefaultText = "";
            this.logPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.logPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.logPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logPassword.FillColor = System.Drawing.Color.DodgerBlue;
            this.logPassword.FocusedState.BorderColor = System.Drawing.Color.White;
            this.logPassword.FocusedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.logPassword.FocusedState.ForeColor = System.Drawing.Color.White;
            this.logPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logPassword.ForeColor = System.Drawing.Color.White;
            this.logPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logPassword.Location = new System.Drawing.Point(45, 224);
            this.logPassword.Name = "logPassword";
            this.logPassword.PasswordChar = '*';
            this.logPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.logPassword.PlaceholderText = "Password";
            this.logPassword.SelectedText = "";
            this.logPassword.Size = new System.Drawing.Size(231, 36);
            this.logPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.logPassword.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(45, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(51, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clear";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2CheckBox1.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2CheckBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.Crimson;
            this.guna2CheckBox1.Location = new System.Drawing.Point(134, 353);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(153, 23);
            this.guna2CheckBox1.TabIndex = 5;
            this.guna2CheckBox1.Text = "ShowPassword";
            this.guna2CheckBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.guna2CheckBox1.UseMnemonic = false;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 804);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            logPassword.Text = "";
            logUsername.Text = "";


        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
                logPassword.PasswordChar = '\0';
            else
                logPassword.PasswordChar = '*';

        }
    }
}
