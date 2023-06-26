namespace EquiposD;
public class Equipo {
    private string ? id;
    private string ? name;
    private DateTime dateRegistered;
    public string? Id { get => id; set => id = value; }
    public string? Name { get => name; set => name = value; }
    public DateTime DateRegistered { get => dateRegistered; set => dateRegistered = value; }

    public Persona(){

    }
    public Persona(String id,string name, string emailAddress, DateTime date){
        this.Id = id;
        this.Name = name;
        this.DateRegistered = date;
    }

}