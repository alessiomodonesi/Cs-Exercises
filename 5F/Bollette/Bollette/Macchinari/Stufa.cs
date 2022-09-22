namespace Bolletta
{
    class Stufa : Macchinari
    {
        public Stufa()
        {
            this.acquistoMacchinario = 350;
            this.installazioneMacchinario = 250;
            this.rendimentoMacchinario = 1;
            this.tipoConsumo = "luce";
            this.costoMateria = 0.28;
        }

        public override void UtilizzoAnnuale(double consumo)
        {
            this.utilizzoAnnuale = consumo * (this.potereCalorifico / this.rendimentoMacchinario);
        }
    }
}