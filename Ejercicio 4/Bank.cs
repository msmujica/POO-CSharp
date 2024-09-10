using System.Collections;

public class Bank
{
    private int ciPerson;
    private int account;

    public int CIperson
    {
        get { return ciPerson; }
        set { ciPerson = value; }
    }

    public int Account
    {
        get { return account; }
        set { account = value; }
    }

    public Bank(int numberAccount, person ci)
    {
        this.Account = numberAccount;
        this.CIperson = ((person)ci).CI;
    }
}