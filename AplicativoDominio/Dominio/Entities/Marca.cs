namespace Dominio;

public class Marca{

    public int IdMarca {get;set;}
    public string Descripcion {get;set;}
    public ICollection<Producto> Productos {get;set;}

}