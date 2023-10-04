// See https://aka.ms/new-console-template for more information

House house1 = new House(2002, 7000);
Console.WriteLine(house1.CanBeSold(house1.Year));

class House
{
  public House (int year, int size)
  {
    Year = year;
    Size = size;
  }

  public int Year { get; set; }
  public int Size { get; set; }

  private int HowOld(int year)
  {
    return DateTime.Now.Year - year;
  }

  public bool CanBeSold(int year)
  {
    if (HowOld(year) > 15)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
