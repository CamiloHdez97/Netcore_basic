namespace Dominio;

public class Pais
{
    public int IdPais {get; set;}
    public string NombrePais{get; set;}
    public ICollection<Region> regiones {get; set;}

}