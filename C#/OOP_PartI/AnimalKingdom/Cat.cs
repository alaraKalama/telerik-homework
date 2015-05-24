namespace AnimalKingdom
{
    public class Cat:Animal, ISound
    {
        public Cat(string name, int age)
            :base(name, age)
        {

        }
        public Cat(string name, int age, Gender sex)
            :base(name, age, sex)
        {

        }

        public override string Sound()
        {
            return "Meoooow!";
        }
    }
}
