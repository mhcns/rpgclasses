using System;

public class Ninja : Hero
{
    public Ninja(string name, int level, int hp, int mp)
    {
        Name = name;
        Level = level;
        this.Class = "Ninja";
        HP = hp;
        MP = mp;
        cHP = HP;
        cMP = MP; 
    }

    public override string Attack()
    {
        return this.Name + " disparou uma rajada de golpes com sua adaga.";
    }

    public string Steal()
    {   //random para dar um ar de rpg
        Random random = new Random();
        int d20 = random.Next(1, 20);
        if (cMP > 10)
        {
            cMP -= 10;
            if (d20 > 12)
            {
                return this.Name + " roubou um item de seu alvo.";
            }
            else return this.Name + " falhou em furtar o seu alvo.";
        }
        else return this.Name + " não tem mana suficiente para tentar furtar seu alvo.";
    }
}