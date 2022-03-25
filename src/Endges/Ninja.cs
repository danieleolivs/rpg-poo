namespace RPG.src.Endges
{
    public class Ninja : Hero
    {
         public Ninja (string Name, int Level, string HeroType)
        {
            this.Name  = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
             return this.Name + " Atacou com a Kusarigama";
        }

        public string Attack(int Forca){

            if (Forca > 10){
                return this.Name + " Atacou com força super força de " + Forca;
            }else{
                return this.Name + " Atacou com força fraca de " + Forca;
            }
            
        }
    }
}