namespace technicalTest.view
{
    partial class formProduct
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
            titulo = new Panel();
            label1 = new Label();
            task = new Panel();
            button5 = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonNew = new Button();
            work = new Panel();
            cancel = new Button();
            save = new Button();
            buttonSearch = new Button();
            search = new TextBox();
            label7 = new Label();
            dgvGridListProduct = new DataGridView();
            price = new TextBox();
            label5 = new Label();
            stock = new TextBox();
            label6 = new Label();
            barCode = new TextBox();
            label4 = new Label();
            productCode = new TextBox();
            label3 = new Label();
            description = new TextBox();
            label2 = new Label();
            titulo.SuspendLayout();
            task.SuspendLayout();
            work.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGridListProduct).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.BackColor = SystemColors.InactiveCaption;
            titulo.Controls.Add(label1);
            titulo.Dock = DockStyle.Top;
            titulo.Location = new Point(0, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(1454, 84);
            titulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 50);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            label1.Click += label1_Click;
            // 
            // task
            // 
            task.BackColor = SystemColors.AppWorkspace;
            task.Controls.Add(button5);
            task.Controls.Add(buttonDelete);
            task.Controls.Add(buttonUpdate);
            task.Controls.Add(buttonNew);
            task.Dock = DockStyle.Right;
            task.Location = new Point(1312, 84);
            task.Name = "task";
            task.Size = new Size(142, 531);
            task.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Info;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(22, 459);
            button5.Name = "button5";
            button5.Size = new Size(108, 49);
            button5.TabIndex = 6;
            button5.Text = "SALIR";
            button5.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.Control;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(22, 172);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(108, 49);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "ELIMINAR";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.Control;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Location = new Point(22, 101);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(108, 49);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "ACTUALIZAR";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonNew
            // 
            buttonNew.BackColor = SystemColors.Control;
            buttonNew.FlatStyle = FlatStyle.Flat;
            buttonNew.Location = new Point(22, 34);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(108, 49);
            buttonNew.TabIndex = 2;
            buttonNew.Text = "NUEVO";
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += ButtonNew_Click;
            // 
            // work
            // 
            work.Controls.Add(cancel);
            work.Controls.Add(save);
            work.Controls.Add(buttonSearch);
            work.Controls.Add(search);
            work.Controls.Add(label7);
            work.Controls.Add(dgvGridListProduct);
            work.Controls.Add(price);
            work.Controls.Add(label5);
            work.Controls.Add(stock);
            work.Controls.Add(label6);
            work.Controls.Add(barCode);
            work.Controls.Add(label4);
            work.Controls.Add(productCode);
            work.Controls.Add(label3);
            work.Controls.Add(description);
            work.Controls.Add(label2);
            work.Dock = DockStyle.Fill;
            work.Location = new Point(0, 84);
            work.Name = "work";
            work.Size = new Size(1312, 531);
            work.TabIndex = 2;
            work.Paint += work_Paint;
            // 
            // cancel
            // 
            cancel.BackColor = SystemColors.Control;
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.Location = new Point(881, 74);
            cancel.Name = "cancel";
            cancel.Size = new Size(108, 49);
            cancel.TabIndex = 14;
            cancel.Text = "CANCELAR";
            cancel.UseVisualStyleBackColor = false;
            cancel.Visible = false;
            cancel.Click += cancel_Click;
            // 
            // save
            // 
            save.BackColor = SystemColors.Control;
            save.FlatStyle = FlatStyle.Flat;
            save.Location = new Point(752, 74);
            save.Name = "save";
            save.Size = new Size(108, 49);
            save.TabIndex = 7;
            save.Text = "GUARDAR";
            save.UseVisualStyleBackColor = false;
            save.Visible = false;
            save.Click += save_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(315, 235);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 13;
            buttonSearch.Text = "BUSCAR";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // search
            // 
            search.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.Location = new Point(112, 233);
            search.Name = "search";
            search.Size = new Size(197, 25);
            search.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(52, 239);
            label7.Name = "label7";
            label7.Size = new Size(49, 17);
            label7.TabIndex = 11;
            label7.Text = "Buscar:";
            // 
            // dgvGridListProduct
            // 
            dgvGridListProduct.AllowUserToAddRows = false;
            dgvGridListProduct.AllowUserToDeleteRows = false;
            dgvGridListProduct.AllowUserToOrderColumns = true;
            dgvGridListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGridListProduct.Location = new Point(42, 264);
            dgvGridListProduct.Name = "dgvGridListProduct";
            dgvGridListProduct.ReadOnly = true;
            dgvGridListProduct.Size = new Size(1208, 217);
            dgvGridListProduct.TabIndex = 10;
            // 
            // price
            // 
            price.Enabled = false;
            price.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.Location = new Point(457, 117);
            price.MaxLength = 12;
            price.Name = "price";
            price.Size = new Size(197, 25);
            price.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(404, 120);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 8;
            label5.Text = "Precio:";
            // 
            // stock
            // 
            stock.Enabled = false;
            stock.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stock.Location = new Point(112, 117);
            stock.MaxLength = 12;
            stock.Name = "stock";
            stock.Size = new Size(197, 25);
            stock.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 123);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 6;
            label6.Text = "Stock:";
            // 
            // barCode
            // 
            barCode.Enabled = false;
            barCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barCode.Location = new Point(457, 55);
            barCode.MaxLength = 255;
            barCode.Name = "barCode";
            barCode.Size = new Size(197, 25);
            barCode.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(337, 61);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 4;
            label4.Text = "Codigo de Barras:";
            // 
            // productCode
            // 
            productCode.Enabled = false;
            productCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productCode.Location = new Point(112, 55);
            productCode.MaxLength = 255;
            productCode.Name = "productCode";
            productCode.Size = new Size(197, 25);
            productCode.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 61);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 2;
            label3.Text = "Codigo:";
            // 
            // description
            // 
            description.Enabled = false;
            description.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.Location = new Point(112, 86);
            description.MaxLength = 255;
            description.Name = "description";
            description.Size = new Size(542, 25);
            description.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 89);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 0;
            label2.Text = "Descripcion:";
            label2.Click += label2_Click;
            // 
            // formProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 615);
            Controls.Add(work);
            Controls.Add(task);
            Controls.Add(titulo);
            Name = "formProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formProduct";
            Load += formProduct_Load;
            titulo.ResumeLayout(false);
            titulo.PerformLayout();
            task.ResumeLayout(false);
            work.ResumeLayout(false);
            work.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGridListProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel titulo;
        private Label label1;
        private Panel task;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonNew;
        private Button button5;
        private Panel work;
        private TextBox description;
        private Label label2;
        private TextBox barCode;
        private Label label4;
        private TextBox productCode;
        private Label label3;
        private TextBox price;
        private Label label5;
        private TextBox stock;
        private Label label6;
        private Button buttonSearch;
        private TextBox search;
        private Label label7;
        private DataGridView dgvGridListProduct;
        private Button cancel;
        private Button save;
    }
}