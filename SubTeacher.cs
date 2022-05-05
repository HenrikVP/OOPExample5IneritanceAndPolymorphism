namespace OOPExample5IneritanceAndPolymorphism
{
    internal class SubTeacher : Teacher
    {
        private int _month = 7;  // Backing store
        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                if ((value > 0) && (value < 13))
                {
                    _month = value;
                }
                else Console.WriteLine("Wrong value");
            }
        }
        public int Hours { get; set; }
    }
}
