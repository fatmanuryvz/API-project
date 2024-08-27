//using FirstExample_API.Models;
using Microsoft.AspNetCore.Mvc;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using System.ComponentModel.DataAnnotations;


namespace MagicVilla_VillaAPI.Models.Dto

{
    public class VillaDTO
    {
        public int Id { get; set; } 
        [Required] //ismi boş girersek hata verir!  Yazdığımız "[ApiController]" sayesindee hiç bir işlem yapmadan aşağıdaki özellikler döner.
        [MaxLength(30)]
        public string Name { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }


    }
}
