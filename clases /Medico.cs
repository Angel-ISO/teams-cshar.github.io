using EquiposD;

namespace MedicoD;


public class Medico{

    private string ? role;
    private string ? edad;
    private string ? name;
    public string? Role { get => role; set => role = value; }
    public string? Name { get => name; set => name = value; }
    public string? edad { get => edad; set => edad = value; }


    public Persona(){

    }
    public Persona(String role,string name, string edad){
        this.Role = role;
        this.Name = name;
        this.Edad = edad;
    }

}