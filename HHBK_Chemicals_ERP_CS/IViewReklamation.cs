namespace HHBK_Chemicals_ERP_CS
{
    internal interface IViewReklamation
    {
        //Reklamation erfassung
        string Kundendaten { get; set; }
        string Bestelldaten { get; set; }

        string Reklamationsgrund { get; set; }
        // Verfahren wählen
    }
}