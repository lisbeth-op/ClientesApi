using System.ComponentModel.DataAnnotations;

public class Clientes{
[Key]
    public int ClienteId { get; set; }
    [Required(ErrorMessage = "El campo es requerido")] 
    public string Nombres { get; set; }
    [Required(ErrorMessage = "El Rnc es requerido")]
    public string Rnc { get; set; }
    public string Direccion { get; set; }
    public int LimiteCredito { get; set; }

}
