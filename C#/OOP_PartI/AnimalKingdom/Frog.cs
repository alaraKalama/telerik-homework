namespace AnimalKingdom
{
    public class Frog: Animal, ISound
    {
        public Frog(string name, int age)
            :base (name, age)
        {

        }
        public Frog(string name, int age, Gender sex)
            :base(name, age, sex)
        {

        }

        public override string Sound()
        {
            return "Gribbit!";
        }
    }
}
