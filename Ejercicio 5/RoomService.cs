public class RoomService
{
    private string serviceName;
    private int servicePrice;

    public string ServiceName
    {
        get { return serviceName; }
        set { serviceName = value; }
    }

    public int ServicePrice
    {
        get { return servicePrice; }
        set { servicePrice = value; }
    }

    public RoomService(string name, int price)
    {
        this.ServiceName = name;
        this.ServicePrice = price;
    }
}