using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IControllerProdukt
    {
        // TODO "dynamic" mit Produkt ersetzen
        dynamic ProduktnameAusgeben(int Artikelnummer);
        dynamic ArtikelnameAusgeben(int Artikelname);
        dynamic VerkaufseiunheitAusgeben(int Verkaufseinheit);
        dynamic EinheitAusgeben(string Einheit);
        dynamic PreisVkAusgeben(double PreisVk);
    }
}