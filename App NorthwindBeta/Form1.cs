using App_Northwind.bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_NorthwindBeta
{
    public partial class Form1 : Form
    {
        private Contexto Contexto = new Contexto();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            App_Northwind.Modelo.Region region = new App_Northwind.Modelo.Region();
            region.RegionID = 6;
            region.RegionDescription = "Medellin";
            Contexto.Regiones.Add(region);
            Contexto.SaveChanges();
        }
    }
}
