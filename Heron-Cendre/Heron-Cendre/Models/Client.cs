namespace Heron_Cendre.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Display(nameof = "Nom")]
        [Required(ErrorMessage = "Nom Obligatoire")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Veillez respecter la taille du nom !!")]
        public string Nom { get; set; }

        [Display(nameof = "Prenom")]
        [Required(ErrorMessage = "Prenom Obligatoire")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Veillez respecter la taille du Prenom !!")]
        public string Prenom { get; set; }

        [Display(nameof = "Adresse")]
        [Required(ErrorMessage = "Adresse Obligatoire")]
        public string Adresse { get; set; }

        [Display(nameof = "Numero de telephone")]
        [Required(ErrorMessage = "Contact Obligatoire")]
        public int Telephone { get; set; }

        [Display(nameof = "Adresse Mail")]
        [Required(ErrorMessage = "Email Obligatoire")]
        public string Email { get; set; }

        [Display(nameof = "Date de naissance")]
        public DateTime Date_Naissance { get; set; }

        [Display(nameof = "Mot de passe")]
        [Required(ErrorMessage = "Mot de passe Obligatoire")]
        public string Mot_De_Passe { get; set; }

        [Display(nameof = "Numero de compte")]
        [Required(ErrorMessage = "Ce champ est obligatoire Obligatoire")]
        public int Num_Compte { get; set; }
    }
}
