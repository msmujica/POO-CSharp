using System.Collections;

public class Members
{
    private int id;
    private string name;
    private ArrayList borrowedBook = new ArrayList();

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public ArrayList BorrowedBook
    {
        get { return borrowedBook; }
        set { borrowedBook = value; }
    }

    public Members(int id, string name)
    {
        this.ID = id;
        this.Name = name;
    }

    public void setBorrowedBook(book libro)
    {
        if (libro.Avaliable)
        {
            libro.unAvaliableBook();
            borrowedBook.Add(libro);
            Console.WriteLine($"El libro {libro.Title} se a agragado");
        }
        else
        {
            Console.WriteLine($"El libro no pudo se agregado");
        }
    }
    
    public void setReturnBook(book libro)
    {
        if (borrowedBook.Contains(libro))
        {
            libro.avaliableBook();
            borrowedBook.Remove(libro);
            Console.WriteLine($"{this.Name} ha devuelto el libro '{libro.Title}'.");
        }
        else
        {
            Console.WriteLine($"El libro '{libro.Title}' no fue prestado por {this.Name}.");
        }
    }
}