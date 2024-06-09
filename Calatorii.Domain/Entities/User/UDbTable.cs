using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calatorii.Domain.Entities.User
{
<<<<<<< HEAD
    public class UDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Username")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Username cannot be longer than 30 characters")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Password cannot be longer than 30 characters")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [StringLength(30)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime? LastLogin { get; set; }

        [StringLength(30)]
        public string LastIp { get; set; }

        [Required]
        [StringLength(20)]
        public string Role { get; set; } // This property should already exist
    }
=======
     public class UDbTable
     {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int Id { get; set; }
          
          [Required]
          [Display(Name = "Username")]
          [StringLength(30, MinimumLength = 8, ErrorMessage = "Username cannot be loger then 30 characters")]
          public string Username { get; set; }

          [Required]
          [Display(Name = "Password")]
          [StringLength(30, MinimumLength = 8, ErrorMessage = "Password cannot be loger then 30 characters")]
          public string Password { get; set; }
          
          [Required]
          [Display(Name = "Email Address")]
          [StringLength(30)]
          public string Email { get; set; }

          [DataType(DataType.Date)]
          public DateTime ? LastLogin { get; set; }

          [StringLength(30)]
          public string LastIp { get; set; }
     }
>>>>>>> c07de0dcb2c15f00cd2a80f79ac72649b834707e
}
