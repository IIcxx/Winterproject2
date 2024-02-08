using System;
public class Enemy{
    public int hp = 20;
    public Melee melee;
    public string enemy_name;
    public Weapon  weapon;
       public void Attack(Hero target)
  {
    int damage = weapon.GetDamage();
    target.hp -= damage;
    target.hp = Math.Max(0, target.hp);
    
  }
}

