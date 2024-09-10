using System.Collections;

public class Accounts
{
    private ArrayList allAccountsNumbers = new ArrayList();
    private int numberAccount;
    private int balance;
    
    public int NumberAccount
    {
        get { return numberAccount; }
        set { numberAccount = value; }
    }

    public int Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public Accounts(Bank account)
    {
        foreach (var number in allAccountsNumbers)
        {

            if ( (int)number != account.Account )
            {
                this.NumberAccount = account.Account;
                this.Balance = 0;
            }
            else
            {
                Console.WriteLine("El numero de cuenta esta repetido");
            }
        }
    }

    public void addToBalance(int monto)
    {
        if ( monto > 0)
        {
            this.Balance += monto;
            Console.WriteLine($"Se agregaron: {monto} a tu cuenta, ahora tienes {this.Balance}");
        }
        else
        {
            Console.WriteLine("No se a podido agegar el monto");
        }
    }

    public void removeToBalance(int monto)
    {
        if (this.Balance > monto)
        {
            this.Balance -= monto;
            Console.WriteLine($"Se han descontado {monto} de la cuenta, quedan {this.Balance}");
        }
        else
        {
            Console.WriteLine($"No tienes el saldo suficiente");
        }
    }

    public void transferTo(Accounts transfer, int monto)
    {
        if (this.Balance >= monto)
        {
            this.Balance -= monto;
            transfer.addToBalance(monto);
            Console.WriteLine($"Se a trasnferido con extio {monto}");
        }
    }
}