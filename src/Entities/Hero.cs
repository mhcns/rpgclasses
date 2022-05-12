public class Hero
{
    public string Name { get; set; }
    public int Level { get; set; }
    public string Class { get; set; }
    public int cHP { get; set; } // current HP e MP correspondem ao HP e MP atuais dos personagens.
    public int cMP { get; set; }
    public int HP { get; set; }
    public int MP { get; set; }

    public Hero(string name, int level, string Class, int hp, int mp)
    {
        Name = name;
        Level = level;
        this.Class = Class;
        HP = hp;
        MP = mp;
        cHP = HP;
        cMP = MP; 
    }
    public Hero(){}

    // os cHP e cMP não podem ser maiores do que o HP e MP totais. Logo os métodos sets têm que ser personalizados.
    public void setCHP(int chp)
    {
        if (chp > HP) cHP = HP;
        else cHP = chp;
    }
    public void setCMP(int cmp)
    {
        if (cmp > MP) cMP = MP;
        else cMP = cmp;
    }

    public virtual string Attack()
    {
        return this.Name + " atacou com a sua espada.";
    }
}