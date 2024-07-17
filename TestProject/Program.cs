Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;
string attacker = "Hero";
do
{
    int attackDamage = random.Next(1, 11);
    if (attacker == "Hero")
    {
        monsterHealth -= attackDamage;
        Console.WriteLine($"Monster was damaged and lost {attackDamage} health and now has {monsterHealth} health.");
        attacker = "Monster";
    }
    else if (attacker == "Monster")
    {
        heroHealth -= attackDamage;
        Console.WriteLine($"Hero was damaged and lost {attackDamage} health and now has {heroHealth} health.");
        attacker = "Hero";
    }
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");
