
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_categorias = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_categorias
            // 
            this.cb_categorias.FormattingEnabled = true;
            this.cb_categorias.Location = new System.Drawing.Point(224, 75);
            this.cb_categorias.Name = "cb_categorias";
            this.cb_categorias.Size = new System.Drawing.Size(121, 24);
            this.cb_categorias.TabIndex = 1;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(39, 80);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(142, 22);
            this.txt_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addCategory);
            this.groupBox1.Controls.Add(this.btn_addProduct);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.cb_categorias);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Location = new System.Drawing.Point(75, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Location = new System.Drawing.Point(351, 70);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(88, 32);
            this.btn_addCategory.TabIndex = 3;
            this.btn_addCategory.Text = "Nueva";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(257, 216);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(88, 32);
            this.btn_addProduct.TabIndex = 3;
            this.btn_addProduct.Text = "Agregar";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Existencias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(224, 152);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(121, 22);
            this.txt_stock.TabIndex = 1;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(39, 226);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(142, 22);
            this.txt_precio.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(39, 152);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(142, 22);
            this.txt_name.TabIndex = 1;
            // 
            // dgv_productos
            // 
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(75, 350);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(1017, 272);
            this.dgv_productos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 695);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_categorias;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.DataGridView dgv_productos;
    }
}

