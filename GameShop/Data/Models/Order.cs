using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; } 

        [Display(Name = "Wprowadź nazwę")]     
        [StringLength(40, MinimumLength = 2)]
        [Required(ErrorMessage = "Długość nazwy co najmniej 2 znaki")]
        public string? ClientName { get; set; }

        [Display(Name = "Wprowadź swój adres e-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Długość adresu co najmniej 3 znaki")]
        public string? Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
