public class Knight : Hero
{
    public Knight(string name, int level, int hp, int mp)
    {
        Name = name;
        Level = level;
        this.Class = "Knight";
        HP = hp;
        MP = mp;
        cHP = HP;
        cMP = MP; 
    }

    public string Taunt(){
        if(cMP > 7)
        {
            cMP -= 7;
            return this.Name + " fez com que o próximo ataque do inimigo seja direcionado a ele.";
        }
        else return this.Name + " não tem mana suficiente para usar o Taunt.";
    }
}