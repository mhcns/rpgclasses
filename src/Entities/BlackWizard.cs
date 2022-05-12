    public class BlackWizard : Hero
    {
        public BlackWizard(string name, int level, int hp, int mp)
        {
            Name = name;
            Level = level;
            this.Class = "Black Wizard";
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

        public string Attack(int bonus)
        {
            if(this.cMP > 5)
            {
                if(bonus > 10)
                {
                    cMP -= 5;
                    return this.Name + " lançou uma magia super efetiva com bonus de " + bonus + ".";
                }
                else return this.Name + " lançou uma magia com bonus de " + bonus + ".";
            }
            else return this.Name + " não tem mana suficiente para lançar magia.";
            
        }
    }