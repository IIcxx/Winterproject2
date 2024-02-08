using System;

public class Melee{

  public string name;
  private Random generator;

  public Melee()
  {
    generator = new Random();
  }

  public int GetDamage()
  {
    return generator.Next(1, 3);
  }
}
public class Weapon{

  public string name;
  private Random generator;

  public Weapon()
  {
    generator = new Random();
  }

  public int GetDamage()
  {
    return generator.Next(2, 5);
  }
}


