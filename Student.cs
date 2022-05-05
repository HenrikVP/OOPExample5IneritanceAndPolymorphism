namespace OOPExample5IneritanceAndPolymorphism
{
    //A sealed class cannot be inherited from (derived)
    internal sealed class Student : Person
    {
        public int PcId { get; set; }
    }
}
