namespace OOPExample5IneritanceAndPolymorphism
{
    internal class Manager : Person
    {
        public override void GetNumber()
        {
            Console.WriteLine("School admin: 44123456");
        }
        public override void GetNumber(bool dontCare)
        {
            Console.WriteLine("School admin: 44123456");
        }
    }
}
