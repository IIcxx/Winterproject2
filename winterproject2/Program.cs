using System;
using System.Security.Cryptography;
int Round = 0;
Hero player = new Hero();
player.weapon = new Weapon();
player.weapon.name = "Dragons Breath";

Enemy challenger = new Enemy();
challenger.enemy_name = "Challenger";
challenger.weapon = new Weapon();
challenger.weapon.name = "slayer of mortals";

Buffs rageVial = new Buffs();
Buffs HealthPotion = new Buffs();
Debuffs Posion = new Debuffs();
Debuffs Slowdown = new Debuffs();
rageVial.Rage = 2;
Console.WriteLine("WELCOME TO THE ARENA WARRIOR!  \n what is your name?");
player.heroName = Console.ReadLine();
Console.WriteLine($"Well welcome {player.heroName}, your battle shall begin! You will attack each other until one of you lose");

Random generator = new Random();
Console.ReadLine();
while (player.hp > 0 && challenger.hp > 0)
{

  Round++;
  System.Console.WriteLine($"Round number {Round}.");
  System.Console.WriteLine($"{player.heroName}'s health: {player.hp} || {challenger.enemy_name}'s health: {challenger.hp}\n");

  player.Attack(challenger);
  System.Console.WriteLine();
  challenger.Attack(player);


 
  System.Console.WriteLine($"\n here is your inventory! \n Sword: {player.weapon.name} \n Rage Vials: {rageVial.Amount} \n Healing potions: {HealthPotion.Amount} \n Slowdowns: {Slowdown.Amount} \n Poisons: {Posion.Amount} \n 'E' lets you use self buffs and 'F' lets you throw debuffs at enemies");
    
ConsoleKeyInfo result = Console.ReadKey();
    if((result.KeyChar == 'E') || (result.KeyChar == 'e')){
        System.Console.WriteLine($"\nHere are all your Buffs! \n Rage Vials: {rageVial.Amount} \n Healing potions: {HealthPotion.Amount} \n Press 1 to use a Rage Vial and 2 to use Healing potions");
        ConsoleKeyInfo result_while = Console.ReadKey();
        if(result_while.KeyChar == '1' && rageVial.Amount > 0){
         
        }
        else if(result_while.KeyChar == '2' && HealthPotion.Amount > 0){

         player.hp += HealthPotion.Healing;
         HealthPotion.Amount--;
         System.Console.WriteLine($"Health Potion used, you have {HealthPotion.Amount} left");
        }
       
    }
    else if ((result.KeyChar == 'F') || (result.KeyChar == 'f')){
        System.Console.WriteLine($"\nHere are all your throwable debuffs! \n Slowdowns: {Slowdown.Amount}\n Poisons: {Posion.Amount} \n Press 1 to use Slowdown and 2 to use Posion");
         ConsoleKeyInfo result_while = Console.ReadKey();
        if(result_while.KeyChar == '1' && Posion.Amount > 0){
         
        }
        else if(result_while.KeyChar == '2' && Posion.Amount > 0){
         challenger.hp -= Posion.debuffDamage;
         Posion.Amount--;
         System.Console.WriteLine($"Poison debuff used, you have {Posion.Amount} left");
        }
       
    }
  Console.ReadLine();
}
if(player.hp <= 0){
    System.Console.WriteLine("You lost!");
}
else if(challenger.hp <= 0){
    System.Console.WriteLine($"You won {player.heroName}!");
}
Console.ReadLine();
