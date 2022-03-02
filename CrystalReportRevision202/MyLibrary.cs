using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
namespace CrystalReportRevision202
{
    class MyLibrary
    {
        public static void imprimer(ReportClass cr, string filtre ="", string chemain = "")
        {
          
            cr.SetDatabaseLogon("sa", "P@ssw0rd");
         if (chemain != "")
                cr.SetParameterValue("chemain", chemain);
            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();

        }
    }
}
