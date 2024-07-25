namespace ExpenseSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            X = new Label();
            panel2 = new Panel();
            logoutBtn = new Button();
            expensesBtn = new Button();
            incomeBtn = new Button();
            addCategoryBtn = new Button();
            dashboardBtn = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            dashboardForm1 = new DashboardForm();
            expenseForm1 = new ExpenseForm();
            incomeForm1 = new IncomeForm();
            categoryForm1 = new CategoryForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(X);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1379, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 18);
            label1.TabIndex = 13;
            label1.Text = "Sistema de ingresos y gastos";
            // 
            // X
            // 
            X.AutoSize = true;
            X.Cursor = Cursors.Hand;
            X.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X.Location = new Point(1349, 9);
            X.Name = "X";
            X.Size = new Size(18, 18);
            X.TabIndex = 12;
            X.Text = "X";
            X.Click += X_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(logoutBtn);
            panel2.Controls.Add(expensesBtn);
            panel2.Controls.Add(incomeBtn);
            panel2.Controls.Add(addCategoryBtn);
            panel2.Controls.Add(dashboardBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 748);
            panel2.TabIndex = 1;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.DarkSlateGray;
            logoutBtn.FlatAppearance.BorderColor = Color.DarkSlateGray;
            logoutBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            logoutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Tahoma", 12F);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Image = Properties.Resources.logout;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(12, 696);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(201, 40);
            logoutBtn.TabIndex = 7;
            logoutBtn.Text = "Cerrar sesión";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // expensesBtn
            // 
            expensesBtn.BackColor = Color.DarkSlateGray;
            expensesBtn.FlatAppearance.BorderColor = Color.DarkSlateGray;
            expensesBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            expensesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            expensesBtn.FlatStyle = FlatStyle.Flat;
            expensesBtn.Font = new Font("Tahoma", 12F);
            expensesBtn.ForeColor = Color.White;
            expensesBtn.Image = Properties.Resources.expenses;
            expensesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            expensesBtn.Location = new Point(12, 372);
            expensesBtn.Name = "expensesBtn";
            expensesBtn.Size = new Size(201, 40);
            expensesBtn.TabIndex = 6;
            expensesBtn.Text = "Gastos";
            expensesBtn.UseVisualStyleBackColor = false;
            expensesBtn.Click += expensesBtn_Click;
            // 
            // incomeBtn
            // 
            incomeBtn.BackColor = Color.DarkSlateGray;
            incomeBtn.FlatAppearance.BorderColor = Color.DarkSlateGray;
            incomeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            incomeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            incomeBtn.FlatStyle = FlatStyle.Flat;
            incomeBtn.Font = new Font("Tahoma", 12F);
            incomeBtn.ForeColor = Color.White;
            incomeBtn.Image = Properties.Resources.profit;
            incomeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            incomeBtn.Location = new Point(12, 317);
            incomeBtn.Name = "incomeBtn";
            incomeBtn.Size = new Size(201, 40);
            incomeBtn.TabIndex = 5;
            incomeBtn.Text = "Ingresos";
            incomeBtn.UseVisualStyleBackColor = false;
            incomeBtn.Click += incomeBtn_Click;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.BackColor = Color.DarkSlateGray;
            addCategoryBtn.FlatAppearance.BorderColor = Color.DarkSlateGray;
            addCategoryBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            addCategoryBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            addCategoryBtn.FlatStyle = FlatStyle.Flat;
            addCategoryBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCategoryBtn.ForeColor = Color.White;
            addCategoryBtn.Image = Properties.Resources.category__2_;
            addCategoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addCategoryBtn.Location = new Point(12, 262);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(201, 40);
            addCategoryBtn.TabIndex = 4;
            addCategoryBtn.Text = "Añadir categoria";
            addCategoryBtn.UseVisualStyleBackColor = false;
            addCategoryBtn.Click += button2_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.DarkSlateGray;
            dashboardBtn.FlatAppearance.BorderColor = Color.DarkSlateGray;
            dashboardBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            dashboardBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Tahoma", 12F);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Image = Properties.Resources.dashboard;
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(12, 207);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(201, 40);
            dashboardBtn.TabIndex = 2;
            dashboardBtn.Text = "Panel de control";
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 2;
            label2.Text = "Bienvenido, ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(45, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboardForm1);
            panel3.Controls.Add(expenseForm1);
            panel3.Controls.Add(incomeForm1);
            panel3.Controls.Add(categoryForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(230, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1149, 748);
            panel3.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            dashboardForm1.Location = new Point(0, 0);
            dashboardForm1.Name = "dashboardForm1";
            dashboardForm1.Size = new Size(1149, 748);
            dashboardForm1.TabIndex = 3;
            // 
            // expenseForm1
            // 
            expenseForm1.Location = new Point(-3, 0);
            expenseForm1.Name = "expenseForm1";
            expenseForm1.Size = new Size(1149, 748);
            expenseForm1.TabIndex = 3;
            // 
            // incomeForm1
            // 
            incomeForm1.BackColor = Color.White;
            incomeForm1.Location = new Point(0, 0);
            incomeForm1.Name = "incomeForm1";
            incomeForm1.Size = new Size(1149, 748);
            incomeForm1.TabIndex = 1;
            // 
            // categoryForm1
            // 
            categoryForm1.Location = new Point(0, 0);
            categoryForm1.Name = "categoryForm1";
            categoryForm1.Size = new Size(1149, 748);
            categoryForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 793);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label X;
        private Panel panel2;
        private Button dashboardBtn;
        private Label label2;
        private PictureBox pictureBox2;
        private Button expensesBtn;
        private Button incomeBtn;
        private Button addCategoryBtn;
        private Button logoutBtn;
        private Panel panel3;
        private CategoryForm categoryForm1;
        private IncomeForm incomeForm1;
        private ExpenseForm expenseForm1;
        private DashboardForm dashboardForm1;
    }
}