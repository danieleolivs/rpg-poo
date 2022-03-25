namespace RPG.src.Endges
{
    public class Wizard : Hero
    {
        public Wizard (string Name, int Level, string HeroType)
        {
            this.Name  = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
             return this.Name + " Lançou a magia";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou Magia Super efetiva com bonus de ataque de " + Bonus;
            }else{
                return this.Name + " Lançou Magia força fraca com bonus de ataque de " + Bonus;
            }
            
        }
    }
}