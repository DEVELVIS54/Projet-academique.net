using System.ComponentModel.DataAnnotations;

namespace TEST1WEB.Models
{
    public class Photo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "veuillez saisir le bon titre")]
        public string Title { get; set; }

        [Display(Name = "description de la photo")]
        public string Description { get; set; }

        public string Author { get; set; }
    }
}