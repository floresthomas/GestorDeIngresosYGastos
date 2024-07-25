namespace ExpenseSystem
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            register_loginbtn = new Button();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            register_btn = new Button();
            checkBox1 = new CheckBox();
            register_password = new TextBox();
            label4 = new Label();
            username_password = new TextBox();
            label3 = new Label();
            label2 = new Label();
            X = new Label();
            textBox1 = new TextBox();
            register_cpassword = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(register_loginbtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 375);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // register_loginbtn
            // 
            register_loginbtn.BackColor = Color.DarkSlateGray;
            register_loginbtn.FlatAppearance.BorderColor = Color.DarkSlateGray;
            register_loginbtn.FlatAppearance.BorderSize = 0;
            register_loginbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            register_loginbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            register_loginbtn.FlatStyle = FlatStyle.Flat;
            register_loginbtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_loginbtn.ForeColor = SystemColors.Control;
            register_loginbtn.Location = new Point(52, 312);
            register_loginbtn.Name = "register_loginbtn";
            register_loginbtn.Size = new Size(152, 34);
            register_loginbtn.TabIndex = 21;
            register_loginbtn.Text = "Inicia sesión aquí";
            register_loginbtn.UseVisualStyleBackColor = false;
            register_loginbtn.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(38, 276);
            label5.Name = "label5";
            label5.Size = new Size(196, 23);
            label5.TabIndex = 20;
            label5.Text = "Ya tienes una cuenta?";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 169);
            label1.Name = "label1";
            label1.Size = new Size(256, 23);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Ingresos y Gastos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(49, 121, 84);
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            register_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = SystemColors.Control;
            register_btn.Location = new Point(298, 293);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(75, 23);
            register_btn.TabIndex = 18;
            register_btn.Text = "Registrarse";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(298, 248);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 19);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // register_password
            // 
            register_password.Location = new Point(298, 169);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(212, 23);
            register_password.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(295, 152);
            label4.Name = "label4";
            label4.Size = new Size(68, 14);
            label4.TabIndex = 15;
            label4.Text = "Contraseña";
            // 
            // username_password
            // 
            username_password.Location = new Point(298, 115);
            username_password.Name = "username_password";
            username_password.Size = new Size(212, 23);
            username_password.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(295, 98);
            label3.Name = "label3";
            label3.Size = new Size(110, 14);
            label3.TabIndex = 13;
            label3.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(293, 49);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 12;
            label2.Text = "Registrarse";
            // 
            // X
            // 
            X.AutoSize = true;
            X.Cursor = Cursors.Hand;
            X.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X.Location = new Point(555, 9);
            X.Name = "X";
            X.Size = new Size(18, 18);
            X.TabIndex = 11;
            X.Text = "X";
            X.Click += X_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 219);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 20;
            // 
            // register_cpassword
            // 
            register_cpassword.AutoSize = true;
            register_cpassword.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_cpassword.Location = new Point(295, 202);
            register_cpassword.Name = "register_cpassword";
            register_cpassword.Size = new Size(122, 14);
            register_cpassword.TabIndex = 19;
            register_cpassword.Text = "Confirmar contraseña";
            register_cpassword.Click += label6_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 375);
            Controls.Add(textBox1);
            Controls.Add(register_cpassword);
            Controls.Add(panel1);
            Controls.Add(register_btn);
            Controls.Add(checkBox1);
            Controls.Add(register_password);
            Controls.Add(label4);
            Controls.Add(username_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(X);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button register_btn;
        private CheckBox checkBox1;
        private TextBox register_password;
        private Label label4;
        private TextBox username_password;
        private Label label3;
        private Label label2;
        private Label X;
        private Label label5;
        private TextBox textBox1;
        private Label register_cpassword;
        private Button register_loginbtn;
    }
}