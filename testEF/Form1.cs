using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// se ha modificado Model.tt  siguiendo instrucciones de la web:
/*
 * 
 * https://msdn.microsoft.com/en-us/library/jj682076(v=vs.113).aspx
 * Debido a que no permitía crear Master Detail con el metodo de dragdrop desde Data Sources.
 * 
 */
//


namespace testEF
{
    public partial class Form1 : Form
    {

        bd_notasAlumnosEntities bdnotas;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bdnotas = new bd_notasAlumnosEntities();
            

            alumnoBindingSource.DataSource = bdnotas.alumnos.ToList();



        }
    }
}
