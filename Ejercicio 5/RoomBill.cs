using System.Collections;
using System.Text;

public class RoomBill
{
    private int dayPrice;
    private int occupiedDays;
    private int totalAccount;


    public int DayPrice
    {
        get { return dayPrice; }
        set { dayPrice = value; }
    }

    public int OccupiedDyas
    {
        get { return occupiedDays; }
        set { occupiedDays = value; }
    }

    public int TotalAccount
    {
        get { return totalAccount; }
        set { totalAccount = value; }
    }

    public RoomBill(int dayPrice, int occupiedDays)
    {
        this.DayPrice = dayPrice;
        this.OccupiedDyas = occupiedDays;
    }

    public void getPrice()
    {
        Console.WriteLine($"Precio por dia {this.DayPrice}");
    }

    public void getOccupied()
    {
        Console.WriteLine(($"Dias ocupada {this.OccupiedDyas}"));
    }

    public void getSerive(Room room)
    {
        StringBuilder orderServices = new StringBuilder();
        ArrayList services = room.RoomService;
        foreach (var s in services)
        {
            orderServices.Append(((RoomService)s).ServicePrice);
        }
        
        Console.WriteLine($"Servicios ordenados: {orderServices}");
    }

    public int getAccount(ArrayList services)
    {
        int ammount = this.DayPrice * this.OccupiedDyas;
        foreach (var s in services)
        {
            ammount = ((RoomService)s).ServicePrice;
        }
        
        return ammount;
    }
}