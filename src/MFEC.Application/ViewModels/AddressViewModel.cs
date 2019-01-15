using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEC.Application.ViewModels
{
    public class AddressViewModel
    {
        public AddressViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Street is mandatory")]
        [MaxLength(150, ErrorMessage = "Maximum length of 150 chars")]
        [MinLength(2, ErrorMessage = "Minimum length of 2 chars")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Complement is mandatory")]
        [MaxLength(150, ErrorMessage = "Maximum length of 150 chars")]
        [MinLength(2, ErrorMessage = "Minimum length of 2 chars")]
        public string Number { get; set; }

        [MaxLength(150, ErrorMessage = "Maximum length of 150 chars")]
        [MinLength(2, ErrorMessage = "Minimum length of 2 chars")]
        public string Complement { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [MaxLength(150, ErrorMessage = "Maximum length of 150 chars")]
        [MinLength(2, ErrorMessage = "Minimum length of 2 chars")]
        public string District { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [MaxLength(150, ErrorMessage = "Maximum length of 150 chars")]
        [MinLength(2, ErrorMessage = "Minimum length of 2 chars")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [MaxLength(150, ErrorMessage = "Maximum length of 150 chars")]
        [MinLength(2, ErrorMessage = "Minimum length of 2 chars")]
        public string City { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [MaxLength(150, ErrorMessage = "Maximum length of 150 chars")]
        [MinLength(2, ErrorMessage = "Minimum length of 2 chars")]
        public string State { get; set; }

        [ScaffoldColumn(false)]
        public Guid ClientId { get; set; }
    }
}
