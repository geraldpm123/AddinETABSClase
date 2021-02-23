using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Autodesk.Revit.UI;

namespace AddinETABSClase
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class App : IExternalApplication
    {
        private string m_ruta = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public Result OnStartup(UIControlledApplication application)
        {
            //Añadir una pestaña para als herramientas
            application.CreateRibbonTab("CSI");
            //Crear un panel
            RibbonPanel panel1 = application.CreateRibbonPanel("CSI", "ETABS v18");

            PushButton boton0 = panel1.AddItem((new PushButtonData("boton0", "ETABS", m_ruta, "AddinETABSClase.com01"))) as PushButton;
            Uri uriImage0 = new Uri("pack://application:,,,/AddinETABSClase;component/Resources/ETABSx32.png");
            boton0.LargeImage = new BitmapImage(uriImage0);
            boton0.ToolTip = "ETABS";
            boton0.LongDescription = "Herramientas para el software ETABS";
            
            return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
