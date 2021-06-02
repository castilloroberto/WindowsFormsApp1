using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

     
        List<Productos> Productos = new List<Productos>();
        List<Categorias> categorias = new List<Categorias>();
        public Form1()
        {
            InitializeComponent();
        }

 

       

        private void btn_addProduct_Click(object sender, EventArgs e)
        {

            int categoria = Convert.ToInt32(cb_categorias.SelectedValue);
            DataAcces.InsertProduct(new Productos(txt_ID.Text,txt_name.Text,Double.Parse(txt_precio.Text),null,int.Parse(txt_stock.Text),categoria));

            //float precio = float.Parse(txt_precio.Text);
            //int stock = int.Parse(txt_stock.Text);
            //Product p = new Product(txt_ID.Text, txt_name.Text, cb_categorias.Text, precio, stock);
            //Productos.Add(p);
            //UpdateDgv();


        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {




            DataAcces.InsertCategory(new Categorias());
            //string prompValue = Promp.ShowDialog("Nombre Categoria:","Nueva Categoria");
            //if (prompValue != "")
            //{
            //    categorias.Add(new Category(categorias.Count+1,prompValue,true));
            //    UpdateCB();
            //}



        }
        private void UpdateCB()
        {
            cb_categorias.DataSource = null;

            cb_categorias.DataSource = categorias;
            cb_categorias.DisplayMember = "Nombre";
            cb_categorias.ValueMember = "ID";
        }
        private void UpdateDgv()
        {
            dgv_productos.DataSource = null;
            dgv_productos.DataSource = Productos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Productos =  DataAcces.GetProductos();
            UpdateDgv();
            categorias = DataAcces.GetCategorias();
            UpdateCB();
        }
    }
}
