using EquiposD;

namespace TecnicoD;


public class Tecnico{

    private string ? specialty;
    private string ? edad;
    private string ? name;
    public string? Specialty { get => specialty; set => specialty = value; }
    public string? Name { get => name; set => name = value; }
    public string? edad { get => edad; set => edad = value; }


    public Persona(){

    }
    public Persona(String specialty,string name, string edad){
        this.Specialty = specialty;
        this.Name = name;
        this.Edad = edad;
    }

}