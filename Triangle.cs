using System;

class Triangle
{
  public int SideA;
  public int SideB;
  public int SideC;

  public bool IsNot()
  {
    if (SideA <= 0 || SideC <=0 || SideB <= 0)
    {
      return true;
    }
    else if (SideC > SideB+SideA || SideB > SideC+SideA || SideA > SideB+SideC)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public bool IsEquilateral()
  {
    if (SideA == SideB && SideA == SideC)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public bool IsIsosceles()
  {
    if (SideA == SideB  && SideA != SideC)
    {
      return true;
    } else if (SideA == SideC && SideA != SideB)
    {
      return true;
    } else if (SideB == SideC && SideB != SideA)
    {
      return true;
    } else
    {
      return false;
    }
  }
  public bool IsScalene()
  {
    if (SideA != SideB && SideA != SideC && SideB != SideC)
    {
      return true;
    } else
    {
      return false;
    }
  }
}

public class Program
{
  public static void Main()
  {
    Triangle myTriangle = new Triangle();

    Console.WriteLine("Enter the length of side A: ");
    string stringSideA = Console.ReadLine();
    int mySideA = int.Parse(stringSideA);
    myTriangle.SideA = mySideA;

    Console.WriteLine("Enter the length of side B: ");
    string stringSideB = Console.ReadLine();
    int mySideB = int.Parse(stringSideB);
    myTriangle.SideB = mySideB;

    Console.WriteLine("Enter the length of side C: ");
    string stringSideC = Console.ReadLine();
    int mySideC = int.Parse(stringSideC);
    myTriangle.SideC = mySideC;


    if (myTriangle.IsNot())
    {
      Console.WriteLine("Not a Triangle!");
    }
    else if (myTriangle.IsEquilateral())
    {
      Console.WriteLine("Equilateral Triangle!!");
    }
    else if (myTriangle.IsIsosceles())
    {
      Console.WriteLine("Isosceles Triangle!!");
    }
    else if (myTriangle.IsScalene())
    {
      Console.WriteLine("Scalene Triangle!!");
    }
    else
    {
        Console.WriteLine("Not Triangle..");
    }
  }
}
