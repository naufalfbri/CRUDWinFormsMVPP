using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDWinFormsMVPP.Models
{
    public class PetModel
    {
        [DisplayName("Pet ID")]
        public int Id { get; set; }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage = "Nama hewan wajib diisi.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Nama minimal 2 karakter.")]
        public string Name { get; set; }

        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Jenis hewan wajib diisi.")]
        public string Type { get; set; }

        [DisplayName("Pet Colour")]
        [Required(ErrorMessage = "Warna hewan wajib diisi.")]
        public string Colour { get; set; }
    }
}
