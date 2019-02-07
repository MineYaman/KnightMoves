using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace YazilimYapimiOdev2.classlar
{
    public class ucCagir
    {
        public static void ucEkle(Grid grd, UserControl uc)
        {
            if(grd.Children.Count>0)
            {
                grd.Children.Clear();
            }
            grd.Children.Add(uc);
        }
    }
}
