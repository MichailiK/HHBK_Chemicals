using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IViewProdukt
    {
        int Artikelnummer { get; }
        string Artikelname { get; }
        int Verkaufseinheit { get; }
        string Einheit { get; }
        double PreisVK { get; }
    }
}
