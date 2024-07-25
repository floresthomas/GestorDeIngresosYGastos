namespace ExpenseSystem
{
    partial class CategoryForm
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
            category_deleteBtn = new Button();
            category_clearBtn = new Button();
            category_updateBtn = new Button();
            category_addBtn = new Button();
            category_status = new ComboBox();
            label3 = new Label();
            category_type = new ComboBox();
            label2 = new Label();
            category_category = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(category_deleteBtn);
            panel1.Controls.Add(category_clearBtn);
            panel1.Controls.Add(category_updateBtn);
            panel1.Controls.Add(category_addBtn);
            panel1.Controls.Add(category_status);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(category_type);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(category_category);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 704);
            panel1.TabIndex = 0;
            // 
            // category_deleteBtn
            // 
            category_deleteBtn.BackColor = Color.DarkSlateGray;
            category_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            category_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            category_deleteBtn.FlatStyle = FlatStyle.Flat;
            category_deleteBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_deleteBtn.ForeColor = Color.White;
            category_deleteBtn.Location = new Point(179, 344);
            category_deleteBtn.Name = "category_deleteBtn";
            category_deleteBtn.Size = new Size(98, 43);
            category_deleteBtn.TabIndex = 7;
            category_deleteBtn.Text = "Borrar";
            category_deleteBtn.UseVisualStyleBackColor = false;
            category_deleteBtn.Click += category_deleteBtn_Click;
            // 
            // category_clearBtn
            // 
            category_clearBtn.BackColor = Color.DarkSlateGray;
            category_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            category_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            category_clearBtn.FlatStyle = FlatStyle.Flat;
            category_clearBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_clearBtn.ForeColor = Color.White;
            category_clearBtn.Location = new Point(23, 344);
            category_clearBtn.Name = "category_clearBtn";
            category_clearBtn.Size = new Size(98, 43);
            category_clearBtn.TabIndex = 6;
            category_clearBtn.Text = "Limpiar";
            category_clearBtn.UseVisualStyleBackColor = false;
            category_clearBtn.Click += category_clearBtn_Click;
            // 
            // category_updateBtn
            // 
            category_updateBtn.BackColor = Color.DarkSlateGray;
            category_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            category_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            category_updateBtn.FlatStyle = FlatStyle.Flat;
            category_updateBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_updateBtn.ForeColor = Color.White;
            category_updateBtn.Location = new Point(179, 274);
            category_updateBtn.Name = "category_updateBtn";
            category_updateBtn.Size = new Size(98, 43);
            category_updateBtn.TabIndex = 5;
            category_updateBtn.Text = "Editar";
            category_updateBtn.UseVisualStyleBackColor = false;
            category_updateBtn.Click += category_updateBtn_Click;
            // 
            // category_addBtn
            // 
            category_addBtn.BackColor = Color.DarkSlateGray;
            category_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 121, 84);
            category_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 121, 84);
            category_addBtn.FlatStyle = FlatStyle.Flat;
            category_addBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_addBtn.ForeColor = Color.White;
            category_addBtn.Location = new Point(23, 274);
            category_addBtn.Name = "category_addBtn";
            category_addBtn.Size = new Size(98, 43);
            category_addBtn.TabIndex = 0;
            category_addBtn.Text = "Agregar";
            category_addBtn.UseVisualStyleBackColor = false;
            category_addBtn.Click += category_addBtn_Click;
            // 
            // category_status
            // 
            category_status.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_status.FormattingEnabled = true;
            category_status.Items.AddRange(new object[] { "Activo", "Inactivo" });
            category_status.Location = new Point(23, 206);
            category_status.Name = "category_status";
            category_status.Size = new Size(254, 31);
            category_status.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 184);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 3;
            label3.Text = "Estado";
            // 
            // category_type
            // 
            category_type.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_type.FormattingEnabled = true;
            category_type.Items.AddRange(new object[] { "Ingresos", "Gastos" });
            category_type.Location = new Point(23, 127);
            category_type.Name = "category_type";
            category_type.Size = new Size(254, 31);
            category_type.TabIndex = 2;
            category_type.SelectedIndexChanged += category_type_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 105);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            label2.Click += label2_Click;
            // 
            // category_category
            // 
            category_category.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_category.Location = new Point(23, 50);
            category_category.Name = "category_category";
            category_category.Size = new Size(254, 33);
            category_category.TabIndex = 0;
            category_category.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(327, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 704);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 16);
            label4.Name = "label4";
            label4.Size = new Size(117, 19);
            label4.TabIndex = 8;
            label4.Text = "Lista categorias";
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
            dataGridView1.Location = new Point(26, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(760, 640);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Size = new Size(1149, 748);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox category_category;
        private Label label1;
        private ComboBox category_type;
        private Button category_addBtn;
        private ComboBox category_status;
        private Label label3;
        private Button category_updateBtn;
        private Button category_deleteBtn;
        private Button category_clearBtn;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
