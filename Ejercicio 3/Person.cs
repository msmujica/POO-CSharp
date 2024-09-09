namespace RepartidoCirculo.Ejercicio_3;

public class person
{
    private string name;
    private string role;
    private string firstProgenitor;
    private string secondProgenitor;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Role
    {
        get { return role; }
        set { role = value; }
    }

    public string FirstProgenitor
    {
        get { return firstProgenitor; }
        set { firstProgenitor = value; }
    }

    public string SecondProgenitor
    {
        get { return secondProgenitor; }
        set { secondProgenitor = value; }
    }

    public person(string name, string role, string mom, string dad)
    {
        this.Name = name;
        this.Role = role;
        this.FirstProgenitor = mom;
        this.SecondProgenitor = dad;
    }

    public string getName()
    {
        return $"Su nombre es: {this.name}";
    }

    public string getShowFamilyTree()
    {
        return $"{this.name} es el hijo de: {this.firstProgenitor} y {this.secondProgenitor}";
    }
}