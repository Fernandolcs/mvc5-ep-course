using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MFEC.Application.ViewModels
{
    public class ClientViewModel
    {
        public ClientViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [MaxLength(150, ErrorMessage = "Maximum length of 150 chars")]
        [MinLength(2, ErrorMessage = "Minimum length of 2 chars")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is mandatory")]
        [MaxLength(100, ErrorMessage = "Maximum length of 100 chars")]
        [MinLength(2, ErrorMessage = "Minimum length of 2 chars")]
        [EmailAddress(ErrorMessage = "Please insert a valid email address")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "CPF is mandatory")]
        [MaxLength(11, ErrorMessage = "Maximum length of 11 chars")]
        [MinLength(11, ErrorMessage = "Minimum length of 11 chars")]
        public string CPF { get; set; }

        [Display(Name = "Birth Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Invalid inserted date")]
        public string BirthDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegisterDate { get; set; }

        [ScaffoldColumn(false)]
        public bool IsActive { get; set; }

        [ScaffoldColumn(false)]
        public bool IsExcluded { get; set; }

        public IEnumerable<AddressViewModel> Addresses { get; set; }
    }
}
