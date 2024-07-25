namespace ExpenseSystem
{
    partial class ExpenseForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            expense_clearBtn = new Button();
            expense_deleteBtn = new Button();
            expense_updateBtn = new Button();
            expense_addBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            income_date = new Label();
            expense_cost = new TextBox();
            expense_item = new TextBox();
            expense_description = new TextBox();
            income_description = new Label();
            label4 = new Label();
            label3 = new Label();
            expense_category = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // expense_clearBtn
            // 
            expense_clearBtn.BackColor = Color.DarkSlateGray;
            expense_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            expense_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            expense_clearBtn.FlatStyle = FlatStyle.Flat;
            expense_clearBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expense_clearBtn.ForeColor = Color.White;
            expense_clearBtn.Location = new Point(681, 317);
            expense_clearBtn.Name = "expense_clearBtn";
            expense_clearBtn.Size = new Size(98, 43);
            expense_clearBtn.TabIndex = 17;
            expense_clearBtn.Text = "Limpiar";
            expense_clearBtn.UseVisualStyleBackColor = false;
            expense_clearBtn.Click += expense_clearBtn_Click;
            // 
            // expense_deleteBtn
            // 
            expense_deleteBtn.BackColor = Color.DarkSlateGray;
            expense_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            expense_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            expense_deleteBtn.FlatStyle = FlatStyle.Flat;
            expense_deleteBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expense_deleteBtn.ForeColor = Color.White;
            expense_deleteBtn.Location = new Point(543, 317);
            expense_deleteBtn.Name = "expense_deleteBtn";
            expense_deleteBtn.Size = new Size(98, 43);
            expense_deleteBtn.TabIndex = 16;
            expense_deleteBtn.Text = "Borrar";
            expense_deleteBtn.UseVisualStyleBackColor = false;
            expense_deleteBtn.Click += expense_deleteBtn_Click;
            // 
            // expense_updateBtn
            // 
            expense_updateBtn.BackColor = Color.DarkSlateGray;
            expense_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            expense_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            expense_updateBtn.FlatStyle = FlatStyle.Flat;
            expense_updateBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expense_updateBtn.ForeColor = Color.White;
            expense_updateBtn.Location = new Point(368, 317);
            expense_updateBtn.Name = "expense_updateBtn";
            expense_updateBtn.Size = new Size(98, 43);
            expense_updateBtn.TabIndex = 15;
            expense_updateBtn.Text = "Editar";
            expense_updateBtn.UseVisualStyleBackColor = false;
            expense_updateBtn.Click += expense_updateBtn_Click;
            // 
            // expense_addBtn
            // 
            expense_addBtn.BackColor = Color.DarkSlateGray;
            expense_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            expense_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            expense_addBtn.FlatStyle = FlatStyle.Flat;
            expense_addBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expense_addBtn.ForeColor = Color.White;
            expense_addBtn.Location = new Point(230, 317);
            expense_addBtn.Name = "expense_addBtn";
            expense_addBtn.Size = new Size(98, 43);
            expense_addBtn.TabIndex = 14;
            expense_addBtn.Text = "Agregar";
            expense_addBtn.UseVisualStyleBackColor = false;
            expense_addBtn.Click += expense_addBtn_Click;
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
            // expense_cost
            // 
            expense_cost.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expense_cost.Location = new Point(170, 187);
            expense_cost.Name = "expense_cost";
            expense_cost.Size = new Size(158, 27);
            expense_cost.TabIndex = 11;
            // 
            // expense_item
            // 
            expense_item.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expense_item.Location = new Point(170, 123);
            expense_item.Name = "expense_item";
            expense_item.Size = new Size(158, 27);
            expense_item.TabIndex = 10;
            // 
            // expense_description
            // 
            expense_description.Location = new Point(543, 59);
            expense_description.Multiline = true;
            expense_description.Name = "expense_description";
            expense_description.Size = new Size(508, 110);
            expense_description.TabIndex = 9;
            // 
            // income_description
            // 
            income_description.AutoSize = true;
            income_description.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_description.Location = new Point(443, 58);
            income_description.Name = "income_description";
            income_description.Size = new Size(96, 19);
            income_description.TabIndex = 7;
            income_description.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(116, 191);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 5;
            label4.Text = "Costo:";
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
            // expense_category
            // 
            expense_category.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expense_category.FormattingEnabled = true;
            expense_category.Location = new Point(170, 59);
            expense_category.Name = "expense_category";
            expense_category.Size = new Size(158, 27);
            expense_category.TabIndex = 2;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(49, 121, 84);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(14, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1083, 241);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 1;
            label1.Text = "Lista de gastos";
            // 
            // panel2
            // 
            panel2.Controls.Add(expense_clearBtn);
            panel2.Controls.Add(expense_deleteBtn);
            panel2.Controls.Add(expense_updateBtn);
            panel2.Controls.Add(expense_addBtn);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(income_date);
            panel2.Controls.Add(expense_cost);
            panel2.Controls.Add(expense_item);
            panel2.Controls.Add(expense_description);
            panel2.Controls.Add(income_description);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(expense_category);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 391);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 291);
            panel1.TabIndex = 3;
            // 
            // ExpenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ExpenseForm";
            Size = new Size(1149, 748);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button expense_clearBtn;
        private Button expense_deleteBtn;
        private Button expense_updateBtn;
        private Button expense_addBtn;
        private DateTimePicker dateTimePicker1;
        private Label income_date;
        private TextBox expense_cost;
        private TextBox expense_item;
        private TextBox expense_description;
        private Label income_description;
        private Label label4;
        private Label label3;
        private ComboBox expense_category;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
    }
}
