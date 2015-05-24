namespace AnimalKingdom
{
    public class Fox : Animal, ISound
    {
        public Fox(string name, int age)
            :base(name, age)
        {

        }
        public Fox(string name, int age, Gender sex)
            :base (name, age, sex)
        {

        }

        public override string Sound()
        {
            return "Kakakakaka-ka-ka!";
        }
    }
}
