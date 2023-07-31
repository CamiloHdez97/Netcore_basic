namespace Dominio;

public class Persona
{
    public int IdPersona {get; set;}
    public string NombrePersona {get; set;}
    public string ApellidoPersona {get; set;}
    public int EdadPersona {get; set;}
    public int IdProv {get; set;}
    public Provincia Provincia{get; set;}
    public int IdTipoPer {get; set;}
    public TipoPersona TipoPersona{get;set;}

}