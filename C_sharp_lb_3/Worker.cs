namespace C_sharp_lb_3;
public class Worker
{
    private int salary;
    private string individualTaxNumber;

    public string[] Name { get; set; } = new string[2]; //Name Surname
    public Position position { get; set; }
    public int Salary
    {
        get => salary;
        set
        {
            if (value >= 8000 && value <= 40000) salary = value;
            else throw new Exception("Salary error");
        }
    }
    public string IndividualTaxNumber
    {
        get => individualTaxNumber;
        set
        {
            int temp;
            if (value.Length == 10 && int.TryParse(value, out temp)) individualTaxNumber = value;
            else throw new Exception("IndividualTaxNumber error");
        }
    }

    Worker(string[] name, Position position, int salary, string IndividualTaxNumber)
    {
        Name = name;
        this.position = position;
        Salary = salary;
        this.IndividualTaxNumber = IndividualTaxNumber;
    }
}

public enum Position
{
    Commandant,
    Head_of_economic_part,
    Guard,
    Cleaner
}