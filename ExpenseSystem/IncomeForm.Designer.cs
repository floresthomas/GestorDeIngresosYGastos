namespace ExpenseSystem
{
    partial class IncomeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            income_clearBtn = new Button();
            income_deleteBtn = new Button();
            income_updateBtn = new Button();
            income_addBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            income_date = new Label();
            income_cost = new TextBox();
            income_item = new TextBox();
            income_description = new TextBox();
            income_descriptionLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            income_category = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 291);
            panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 121, 84);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(14, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1083, 241);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(127, 19);
            label1.TabIndex = 1;
            label1.Text = "Lista de ingresos";
            // 
            // panel2
            // 
            panel2.Controls.Add(income_clearBtn);
            panel2.Controls.Add(income_deleteBtn);
            panel2.Controls.Add(income_updateBtn);
            panel2.Controls.Add(income_addBtn);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(income_date);
            panel2.Controls.Add(income_cost);
            panel2.Controls.Add(income_item);
            panel2.Controls.Add(income_description);
            panel2.Controls.Add(income_descriptionLabel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(income_category);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 391);
            panel2.TabIndex = 6;
            // 
            // income_clearBtn
            // 
            income_clearBtn.BackColor = Color.DarkSlateGray;
            income_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            income_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            income_clearBtn.FlatStyle = FlatStyle.Flat;
            income_clearBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_clearBtn.ForeColor = Color.White;
            income_clearBtn.Location = new Point(681, 317);
            income_clearBtn.Name = "income_clearBtn";
            income_clearBtn.Size = new Size(98, 43);
            income_clearBtn.TabIndex = 17;
            income_clearBtn.Text = "Limpiar";
            income_clearBtn.UseVisualStyleBackColor = false;
            // 
            // income_deleteBtn
            // 
            income_deleteBtn.BackColor = Color.DarkSlateGray;
            income_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            income_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            income_deleteBtn.FlatStyle = FlatStyle.Flat;
            income_deleteBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_deleteBtn.ForeColor = Color.White;
            income_deleteBtn.Location = new Point(543, 317);
            income_deleteBtn.Name = "income_deleteBtn";
            income_deleteBtn.Size = new Size(98, 43);
            income_deleteBtn.TabIndex = 16;
            income_deleteBtn.Text = "Borrar";
            income_deleteBtn.UseVisualStyleBackColor = false;
            income_deleteBtn.Click += income_deleteBtn_Click_1;
            // 
            // income_updateBtn
            // 
            income_updateBtn.BackColor = Color.DarkSlateGray;
            income_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            income_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            income_updateBtn.FlatStyle = FlatStyle.Flat;
            income_updateBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_updateBtn.ForeColor = Color.White;
            income_updateBtn.Location = new Point(355, 317);
            income_updateBtn.Name = "income_updateBtn";
            income_updateBtn.Size = new Size(98, 43);
            income_updateBtn.TabIndex = 15;
            income_updateBtn.Text = "Editar";
            income_updateBtn.UseVisualStyleBackColor = false;
            income_updateBtn.Click += income_updateBtn_Click_1;
            // 
            // income_addBtn
            // 
            income_addBtn.BackColor = Color.DarkSlateGray;
            income_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            income_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            income_addBtn.FlatStyle = FlatStyle.Flat;
            income_addBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_addBtn.ForeColor = Color.White;
            income_addBtn.Location = new Point(230, 317);
            income_addBtn.Name = "income_addBtn";
            income_addBtn.Size = new Size(98, 43);
            income_addBtn.TabIndex = 14;
            income_addBtn.Text = "Agregar";
            income_addBtn.UseVisualStyleBackColor = false;
            income_addBtn.Click += income_addBtn_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(543, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(388, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // income_date
            // 
            income_date.AutoSize = true;
            income_date.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_date.Location = new Point(490, 194);
            income_date.Name = "income_date";
            income_date.Size = new Size(55, 19);
            income_date.TabIndex = 12;
            income_date.Text = "Fecha:";
            // 
            // income_cost
            // 
            income_cost.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_cost.Location = new Point(170, 187);
            income_cost.Name = "income_cost";
            income_cost.Size = new Size(158, 27);
            income_cost.TabIndex = 11;
            // 
            // income_item
            // 
            income_item.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_item.Location = new Point(170, 123);
            income_item.Name = "income_item";
            income_item.Size = new Size(158, 27);
            income_item.TabIndex = 10;
            // 
            // income_description
            // 
            income_description.Location = new Point(543, 59);
            income_description.Multiline = true;
            income_description.Name = "income_description";
            income_description.Size = new Size(508, 110);
            income_description.TabIndex = 9;
            // 
            // income_descriptionLabel
            // 
            income_descriptionLabel.AutoSize = true;
            income_descriptionLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_descriptionLabel.Location = new Point(443, 58);
            income_descriptionLabel.Name = "income_descriptionLabel";
            income_descriptionLabel.Size = new Size(96, 19);
            income_descriptionLabel.TabIndex = 7;
            income_descriptionLabel.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 190);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 5;
            label4.Text = "Ingreso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(116, 131);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 3;
            label3.Text = "Item:";
            // 
            // income_category
            // 
            income_category.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_category.FormattingEnabled = true;
            income_category.Location = new Point(170, 59);
            income_category.Name = "income_category";
            income_category.Size = new Size(158, 27);
            income_category.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 62);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 1;
            label2.Text = "Categoria:";
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "IncomeForm";
            Size = new Size(1149, 748);
            Load += IncomeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private Button income_clearBtn;
        private Button income_deleteBtn;
        private Button income_updateBtn;
        private Button income_addBtn;
        private DateTimePicker dateTimePicker1;
        private Label income_date;
        private TextBox income_cost;
        private TextBox income_item;
        private TextBox income_description;
        private Label income_descriptionLabel;
        private Label label4;
        private Label label3;
        private ComboBox income_category;
        private Label label2;
    }
}
