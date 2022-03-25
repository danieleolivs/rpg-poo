namespace RPG.src.Endges
{
    public class Boss : Hero
    {
        public Boss (string Name, int Level, string HeroType)
        {
            this.Name  = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
             return this.Name + " Atacou com a fogo";
        }

        public string Attack(int total){
            if(total >= 100){
                int diferenca = total - 100;
                return this.Name + " Venceu com uma vantagem de " + diferenca + " pontos";
            }else{
                int diferenca =100 - total;
                return this.Name + " Perdeu com uma diferença de " + diferenca + " pontos" ;
            }

        }
    }
}