public class person
{
    private int ci;
    private string name;
    private string lastName;
    private int yearsOld;

    public int CI
    {
        get { return ci; }
        set { ci = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int YearsOld
    {
        get { return yearsOld; }
        set { yearsOld = value; }
    }

    public person(int ci, string name, string lastName, int years)
    {
        this.CI = ci;
        this.Name = name;
        this.LastName = lastName;
        this.YearsOld = years;
    }
}