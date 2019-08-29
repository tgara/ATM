using System.ComponentModel.DataAnnotations;

namespace ATM.Models
{
    public class VerificationCompte
    {
        public int Id { get; set; }

        [Display(Name = "Numero de compte")]
        public string NumeroCompte { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string NomPrenom { get { return Nom + "" + Prenom; } }
        [DataType(DataType.Currency)]
        public decimal Solde { get; set; }



    }
}