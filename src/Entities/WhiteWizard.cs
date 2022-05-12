public class WhiteWizard : Hero
{
    public WhiteWizard(string name, int level, int hp, int mp)
    {
        Name = name;
        Level = level;
        this.Class = "White Wizard";
        HP = hp;
        MP = mp;
        cHP = HP;
        cMP = MP; 
    }
    public override string Attack()
    {
        if(this.cMP > 5){
            cMP -= 5;
            return this.Name + " lançou uma magia.";
        } 
        else return this.Name + " não tem mana suficiente para lançar magia.";
    }
    public string Cure(Hero target)
    {
        if(this.cMP > 15){
            cMP -= 15;
            int hp = target.cHP;
            target.setCHP(hp + 50);
            return this.Name + " curou " + target.Name + " por " + (target.cHP - hp) + " HP, de " + hp + " para " + target.cHP + ".";
        }
        else return this.Name + " não tem mana suficiente para curar o aliado.";
    }
}