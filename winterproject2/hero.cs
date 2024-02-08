using System;
public class Hero{
    public int hp = 20;
    public Melee melee;
    public string heroName;
    public Weapon weapon;
      public void Attack(Enemy target)
  {
    int damage = weapon.GetDamage();
    target.hp -= damage;
    target.hp = Math.Max(0, target.hp);
    
  }
}


