using System.ComponentModel.DataAnnotations;

namespace ClimateApi.Models
{
    public class ciudades
    {
        [Key]
        public int idciudad{get;set;}
        public string codigopostal{get;set;}
        public string nombre{get;set;}
        public int temperatura{get;set;}
        public int humedad{get;set;}

    }
}