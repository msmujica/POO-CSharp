using System.Collections;
using System.Text;

public class Biblioteca
{
    private string libraryName;
    private ArrayList bookList = new ArrayList();
    private ArrayList membersList = new ArrayList();

    public string LibraryName
    {
        get { return libraryName; }
        set { libraryName = value; }
    }

    public Biblioteca(string name)
    {
        this.LibraryName = name;
    }

    public void addBook(book Book)
    {
        bookList.Add(Book);
    }

    public void addMember(Members member)
    {
        membersList.Add(member);
    }

    public void getAvaliebleBooks()
    {
        StringBuilder books = new StringBuilder();
        bool avaliableBooks = false;

        foreach (var b in bookList)
        {
            if (((book)b).Avaliable)
            {
                books.Append(((book)b).Title);
            }
        }

        if (books != null)
        {
            Console.WriteLine($"Libros disponibles: {books} ");
        }
        else
        {
            Console.WriteLine($"No hay libros disponibles");
        }
    }
}