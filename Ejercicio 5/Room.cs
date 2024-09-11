using System.Collections;

public class Room
{
    private int numberRoom;
    private int maximumGuest;
    private int groupSize;
    private int roomAccount;
    private bool occupied;
    private ArrayList roomService = new ArrayList();

    public int NumberRoom
    {
        get { return numberRoom; }
        set { numberRoom = value; }
    }

    public int MaximumGuest
    {
        get { return maximumGuest; }
        set { maximumGuest = value; }
    }

    public int GroupSize
    {
        get { return groupSize; }
        set { groupSize = value; }
    }

    public int RoomAccount
    {
        get { return roomAccount; }
        set { roomAccount = value; }
    }

    public bool Occupied
    {
        get { return occupied; }
        set { occupied = value; }
    }

    public ArrayList RoomService
    {
        get { return roomService; }
        set { roomService = value; }
    }

    public Room(int number, int maximumGuest, int roomAccount)
    {
        this.NumberRoom = number;
        this.MaximumGuest = maximumGuest;
        this.GroupSize = 0;
        this.Occupied = false;
    }

    public void getNumberRoom()
    {
        Console.WriteLine($"Numero de habitacion: {this.NumberRoom}");
    }

    public void getMaximumGroupOfRoom()
    {
        Console.WriteLine($"Numero maximo de huespedes: {this.MaximumGuest}");
    }

    public void getGuests()
    {
        Console.WriteLine($"Actualmente hay: {this.MaximumGuest} en la habitacion");
    }

    public void getAccount(RoomBill bill)
    {
        Console.WriteLine(bill.getAccount(roomService));
    }

    public void setOccupied(bool occupied)
    {
        this.Occupied = occupied;
        Console.WriteLine("Ocupada");
    }

    public void setUnoccupied(bool occupied)
    {
        this.Occupied = occupied;
        Console.WriteLine("Desocupada");
    }

    public void setRoomService(RoomService service)
    {
        roomService.Add(service);
    }


}