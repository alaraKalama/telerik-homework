namespace AnimalKingdom
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age)
            :base (name, age)
        {
           
        }

        public Dog(string name, int age, Gender sex)
            :base (name, age, sex)
        {
           
        }

        public override string Sound()
        {
            return "Jaff Jaff!";
        }


        
    }
}
