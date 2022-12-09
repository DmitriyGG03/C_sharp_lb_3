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
                            if (room.IDrecordBooks.Count != 0)
                            {
                                foreach (string i in room.IDrecordBooks)
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

        using (StreamWriter writer = new StreamWriter(@"..\..\..\CampusData\Students.txt", false))
        {
            foreach (Hostel hostel in Campus.hostels)
            {
                if (hostel.Students.Count != 0)
                {
                    writer.WriteAsync($"{hostel.ID}\n");
                    foreach (Student student in hostel.Students)
                    {
                        writer.WriteAsync($"{student.FullName[0]}\n{student.FullName[1]}\n{student.FullName[2]}\n" +
                            $"{student.Faculty}\n{student.Group}\n{student.sex}\n{student.Course}\n{student.IDrecordBook}\n");
                    }
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(@"..\..\..\CampusData\Workers.txt", false))
        {
            foreach (Hostel hostel in Campus.hostels)
            {
                if (hostel.Workers.Count != 0)
                {
                    writer.WriteAsync($"{hostel.ID}\n");
                    foreach (Worker workers in hostel.Workers)
                    {
                        writer.WriteAsync($"{workers.Name[0]}\n{workers.Name[1]}\n{workers.position}\n" +
                            $"{workers.IndividualTaxNumber}\n");
                    }
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(@"..\..\..\CampusData\Campus.txt", false))
        {
            if (CampusStudents.Count != 0)
            {
                writer.WriteAsync($"{CampusStudents.Count}\n");
                foreach (Student student in CampusStudents)
                {
                    writer.WriteAsync($"{student.FullName[0]}\n{student.FullName[1]}\n{student.FullName[2]}\n" +
                        $"{student.Faculty}\n{student.Group}\n{student.sex}\n{student.Course}\n{student.IDrecordBook}\n");
                }
            }
            if (DeleteHostels.Count != 0)
            {
                writer.WriteAsync($"{DeleteHostels.Count}\n");
                foreach (int numbers in DeleteHostels)
                {
                    writer.WriteAsync($"{numbers}\n");
                }
            }
            if (DeletedID.Count != 0)
            {
                writer.WriteAsync($"{DeletedID.Count}\n");
                foreach (int numbers in DeletedID)
                {
                    writer.WriteAsync($"{numbers}\n");
                }
            }
            writer.WriteLine($"{LastID}");
        }
    }


    public static void ReadingFromFiles()
    {
        using (StreamReader reader = new StreamReader(@"..\..\..\CampusData\Data.txt", false))
        {

        }
    }

    public static long LongRandom(long min, long max, Random rand)
    {
        long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
        result = (result << 32);
        result = result | (long)rand.Next((Int32)min, (Int32)max);
        return result;
    }
}


