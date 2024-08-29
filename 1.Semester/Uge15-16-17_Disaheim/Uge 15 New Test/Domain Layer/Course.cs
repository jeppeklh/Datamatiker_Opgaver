namespace Uge_15_opgaver
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public static double CourseHourValue { get; set; } = 875;

        public Course(string name)
        {
            Name = name;
        }
        public Course(string name, int durationInMinutes) : this(name)
        {
            DurationInMinutes = durationInMinutes;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }
        public double GetValue()
        {
            int hours = DurationInMinutes / 60;
            int minutes = DurationInMinutes % 60;
            if (minutes > 0)
            {
                hours++;
            }
            return CourseHourValue * hours;
        }
    }
}
