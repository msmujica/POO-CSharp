public class book
{
    private string title;
    private string author;
    private bool available;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public bool Avaliable
    {
        get { return available; }
        set { available = value; }
    }

    public book(string title, string author)
    {
        this.Title = title;
        this.Author = author;
        this.Avaliable = true;
    }

    public void avaliableBook()
    {
        this.Avaliable = true;
    }

    public void unAvaliableBook()
    {
        this.Avaliable = false;
    }
}