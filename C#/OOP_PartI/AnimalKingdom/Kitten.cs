namespace AnimalKingdom
{
    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age)
            :base(name, age)
        {
            this.Sex = Gender.Female;
        }
        public Kitten(string name, int age, Gender sex)
            :base (name, age, Gender.Female)
        {

        }
    }
}
