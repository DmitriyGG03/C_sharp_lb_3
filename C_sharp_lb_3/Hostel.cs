using C_sharp_lb_3;
using System.Text;

namespace Hostels;
public class Hostel : ICloneable
{
    public int ID { get; set; } = 0;
    public string universityName { get; set; }
    public string hostelAddress { get; set; }
    public double hostelProfit { get; set; }

    private List<Worker> Workers { get; set; } = new List<Worker>(0);
    private List<Student> Students { get; set; } = new List<Student>(0);
    public List<Room> Rooms { get; set; } = new List<Room>(0);
    public int StuffNumber { get => Workers.Count; }
    public int StudentAmount { get => Students.Count; }
    public int RoomsNumber { get => Rooms.Count; }



    public Hostel(int? ID, string universityName, string hostelAddress, List<Worker> workers, List<Room> rooms)
    {
        if (ID is null) this.ID = Campus.GetID();
        else this.ID = (int)ID;
        this.universityName = universityName;
        this.hostelAddress = hostelAddress;
        Workers = workers;
        Rooms = rooms;
        CalcProfit();
    }

    public void CalcProfit()
    {
        double profit = 0.0;
        foreach (Room room in Rooms)
        {
            profit += room.ResidentsNumber * room.Rent;
        }
        foreach(Worker worker in Workers)
        {
            profit -= (int)worker.position;
        }
        hostelProfit = profit;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Назва університету:\t{universityName}\n");
        sb.Append($"Адреса гуртожитку:\t{hostelAddress}\n");
        sb.Append($"Кількість працівників:\t{StuffNumber}\n");
        sb.Append($"Кількість кімнат:\t\t{RoomsNumber}\n");
        sb.Append($"Кількість студентів:\t{StudentAmount}\n");
        sb.Append($"Прибуток:\t\t{hostelProfit}\n");
        return sb.ToString();
    }

    public object Clone()
    {
        return new Hostel(ID, universityName, hostelAddress, Workers, Rooms);
    }
}
