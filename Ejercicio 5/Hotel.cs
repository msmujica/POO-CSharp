using System;
using System.Collections;

public class Hotel
{
    private string name; // Nombre del hotel
    private ArrayList rooms = new ArrayList(); // Lista de habitaciones
    private ArrayList services = new ArrayList(); // Lista de servicios de habitación ofrecidos

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Constructor para definir el nombre del hotel
    public Hotel(string name)
    {
        this.Name = name;
    }

    // Obtener el nombre del hotel
    public void GetHotelName()
    {
        Console.WriteLine($"Nombre del hotel: {this.Name}");
    }

    // Obtener todas las habitaciones del hotel
    public void GetRooms()
    {
        Console.WriteLine("Habitaciones del hotel:");
        foreach (Room room in rooms)
        {
            room.getNumberRoom();
            room.getMaximumGroupOfRoom();
        }
    }

    // Conocer los servicios ofrecidos en el hotel
    public void GetRoomServices()
    {
        Console.WriteLine("Servicios a la habitación disponibles:");
        foreach (RoomService service in services)
        {
            Console.WriteLine($"Servicio: {service.ServiceName}, Precio: {service.ServicePrice}");
        }
    }

    // Agregar un servicio a la oferta de servicios del hotel
    public void AddService(RoomService service)
    {
        services.Add(service);
        Console.WriteLine($"Servicio '{service.ServiceName}' agregado a la oferta de servicios.");
    }

    // Agregar una habitación al hotel
    public void AddRoom(Room room)
    {
        rooms.Add(room);
        Console.WriteLine($"Habitación número {room.NumberRoom} agregada al hotel.");
    }

    // Hacer check-in a un grupo de huéspedes en una habitación específica
    public void CheckIn(GuestGroup group, int roomNumber)
    {
        foreach (Room room in rooms)
        {
            if (room.NumberRoom == roomNumber)
            {
                if (room.Occupied)
                {
                    Console.WriteLine("La habitación ya está ocupada.");
                    return;
                }
                if (group.GroupSize > room.MaximumGuest)
                {
                    Console.WriteLine("El grupo es demasiado grande para la capacidad de la habitación.");
                    return;
                }

                room.GroupSize = group.GroupSize;
                room.setOccupied(true);
                Console.WriteLine($"Check-in realizado para un grupo de {group.GroupSize} huéspedes en la habitación {room.NumberRoom}.");
                return;
            }
        }
        Console.WriteLine("Número de habitación no encontrado.");
    }

    // Hacer check-out de un grupo de huéspedes y liberar la habitación
    public void CheckOut(int roomNumber)
    {
        foreach (Room room in rooms)
        {
            if (room.NumberRoom == roomNumber)
            {
                if (!room.Occupied)
                {
                    Console.WriteLine("La habitación ya está desocupada.");
                    return;
                }

                room.GroupSize = 0;
                room.setUnoccupied(false);
                Console.WriteLine($"Check-out realizado para la habitación {room.NumberRoom}.");
                return;
            }
        }
        Console.WriteLine("Número de habitación no encontrado.");
    }
}
