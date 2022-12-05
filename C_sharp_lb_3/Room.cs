namespace C_sharp_lb_3;

public class Room
{
    public int ID { get; set; } //Must be unique
    public RoomType roomType { get; set; }
    public int Rent { get; set; }
    public int ResidentsNumber { get => IDrecordBooks.Count}
    public List<int> IDrecordBooks { get; set; } = new List<int>(0);

    Room(int? ID, RoomType rt, List<int> iDrecordBooks)
    {
        if(ID != null) this.ID = (int)ID;
        else ID = CreateRoomID(); //Create        
        roomType = rt;
        Rent = 2400 / (int)rt;
        if (iDrecordBooks is not null) IDrecordBooks = iDrecordBooks;
    }

    private int CreateRoomID()
    {
        if (Campus.DeletedID.Count != 0)
        {
            int temp = Campus.DeletedID[0];
            Campus.DeletedID.RemoveAt(0);
            if (temp > Campus.LastID) Campus.LastID = temp;
            return temp;
        }
        else
        {
            return 1 + Campus.LastID++;
        }
    }
}

public enum RoomType // Number here is the max amount of students in the room
{
    Standart = 4,
    Comfort = 2,
    Single = 1
}