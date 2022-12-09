using Hostels;
using C_sharp_lb_3;

public static class Campus
{
    public static string picOK = @"..\..\..\Pictures\PicOK.png";
    public static string picDislike = @"..\..\..\Pictures\PicDislike.png";

    public static List<Hostel> hostels = new List<Hostel>(0);
    public static List<Student> CampusStudents = new List<Student>(0);
    public static List<int> DeleteHostels = new List<int>(0);
    public static List<int> DeletedID = new List<int>(0);
    public static int LastID = 0;

    public static int GetID()
    {
        if (DeleteHostels.Count != 0)
        {
            int temp = DeleteHostels[0];
            DeleteHostels.RemoveAt(0);
            return temp;
        }
        else if (hostels.Count == 0)
        {
            return 1;
        }
        else
        {
            int max = 0, value = 0;
            for (int i = 0; i < hostels.Count; i++)
            {
                value = hostels[i].ID;
                if (value > max) max = value;
            }
            return max + 1;
        }
    }

    public static bool switchImageString(string str)
    {
        if (str != "")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool switchImageInt(string str, out int num)
    {
        if (str != "" && int.TryParse(str, out num) && num >= 0)
        {
            return true;
        }
        else
        {
            num = -1;
            return false;
        }
    }

    public static bool FindingHostel(int id, out Hostel? hostel)
    {
        hostel = hostels.Find(h => h.ID == id);
        if (hostel == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static void WritingInFiles()
    {
        DirectoryInfo dirInfo = new DirectoryInfo(@"..\..\..\CampusData");
        if (!dirInfo.Exists)
        {
            dirInfo.Create();
        }
        using (StreamWriter writer = new StreamWriter(@"..\..\..\CampusData\Data.txt", false))
        {
            if (hostels.Count != 0)
            {
                foreach (Hostel hostel in Campus.hostels)
                {
                    writer.WriteAsync("Hotels\n");
                    writer.WriteAsync($"{hostel.ID}\n{hostel.universityName}\n{hostel.hostelAddress}\n");
                    if (hostel.Rooms.Count != 0)
                    {
                        writer.WriteAsync("Rooms\n");
                        foreach (Room room in hostel.Rooms)
                        {                            
                            writer.WriteAsync($"{room.ID}\n{room.roomType}\n");
                            if(room.IDrecordBooks.Count != 0)
                            {
                                foreach(string i in room.IDrecordBooks)
                                {
                                    writer.WriteLineAsync(i);
                                }
                            }
                        }
                    }
                    writer.WriteLineAsync("\n\n");
                }
            }
            writer.WriteLineAsync();
        }


    }

    public static void ReadingFromFiles()
    {

    }

    public static long LongRandom(long min, long max, Random rand)
    {
        long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
        result = (result << 32);
        result = result | (long)rand.Next((Int32)min, (Int32)max);
        return result;
    }
}
