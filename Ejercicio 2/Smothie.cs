using System.Collections;
using System.Text;

namespace RepartidoCirculo.Ejercicio_2;

public class Smothie
{
    private string smothieName;
    private int basePrice;
    private ArrayList smothie = new ArrayList();

    public string SmothieName
    {
        get { return smothieName; }
        set { smothieName = value; }
    }

    public int BasePrice
    {
        get { return basePrice; }
        set { basePrice = value; }
    }

    public Smothie(string name, int price)
    {
        this.SmothieName = name;
        this.basePrice = price;
    }
    public void setAddIngredient(Ingredientes ingrediente)
    {
        smothie.Add(ingrediente);
    }

    public int getFullPrice()
    {
        int resultado = this.basePrice;
        foreach (var item in smothie)
        {
            resultado += ((Ingredientes)item).Precio;
        }
        
        return resultado;
    }

    public void getFullSmothie()
    {
        StringBuilder ingre = new StringBuilder();
        foreach (var item in smothie)
        {
            ingre.Append(((Ingredientes)item).Nombre + ", ");
        }
        
        Console.WriteLine($"{this.smothieName}, contiene: {ingre} ");
    }
}