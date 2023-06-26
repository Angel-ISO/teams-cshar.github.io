using EquiposD;

namespace JugadoresD;


public class Jugadores{

    private string ? dorsal;
    private string ? edad;
    private string ? name;
    private string ? PositionJ;
    public string? Dorsal { get => dorsal; set => dorsal = value; }
    public string? Name { get => name; set => name = value; }
    public string? edad { get => edad; set => edad = value; }
    public string? PositionJ { get => PositionJ; set => PositionJ = value; }


    public Persona(){

    }
    public Persona(String id,string name, string edad, string PositionJ){
        this.Dorsal = dorsal;
        this.Name = name;
        this.Edad = edad;
        this.PositionJ = PositionJ;
    }

}