namespace OOPExample5IneritanceAndPolymorphism
{
    //Abstract so cannot create a Person object (instantiate)
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        //Overloading when having same methodname and different parameters
        public virtual void GetNumber()
        {
            Console.WriteLine(this.GetType().Name + " " + Phone);
        }
        public virtual void GetNumber(bool showName)
        {
            if (showName) Console.WriteLine(Name + " " + Phone);
            else Console.WriteLine(Phone);
        }
    }


}
