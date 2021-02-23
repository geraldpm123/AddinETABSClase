using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSiAPIv1;

namespace AddinETABSClase
{
    public partial class frmCom01HerramientasETABS : Form
    {
        string _rutaETABS = "C:\\Program Files\\Computers and Structures\\ETABS 18\\ETABS.exe";
        cSapModel _modeloSap;
        public frmCom01HerramientasETABS()
        {
            InitializeComponent();
        }

        private void CrearModeloSap()
        {
            int ret = 0;
            //PARTE INICIAL--------------------------------------------------------------------------------
            cHelper myHelper = new Helper();
            cOAPI ETABSObject = myHelper.CreateObject(_rutaETABS);
            //Abrir el programa ETABS
            ret = ETABSObject.ApplicationStart();
            if (ret != 0)
            {
                MessageBox.Show("No se pudo Abrir la aplicacion ETABS. ¿Desea especificar ahora la direccion del programa?", "Error de inicializacion", MessageBoxButtons.YesNo);
                return;
            }
            //Obtener una referencia al modelo cSapModel para acceder a todas las clases y funciones del OAPI
            _modeloSap = ETABSObject.SapModel;
        }

        private void btnNuevoETABS_Click(object sender, EventArgs e)
        {
            CrearModeloSap();
            _modeloSap.File.NewBlank();
        }


    }
}
