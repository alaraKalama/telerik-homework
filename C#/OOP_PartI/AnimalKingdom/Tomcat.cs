namespace AnimalKingdom
{
    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            :base(name, age)
        {
            this.Sex = Gender.Male;
        }
        public Tomcat(string name, int age, Gender sex)
            :base(name, age, Gender.Male)
        {

        }
    }
}
