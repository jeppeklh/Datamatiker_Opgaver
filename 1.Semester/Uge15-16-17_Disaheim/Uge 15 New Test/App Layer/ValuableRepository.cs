using System.Diagnostics;
using System.Xml.Linq;

namespace Uge_15_opgaver
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise)
                {
                    if (((Merchandise)valuable).ItemId == id)
                    {
                        return valuable;
                    }
                }
                else if (valuable is Course)
                {
                    if (((Course)valuable).Name == id)
                    {
                        return valuable;
                    }
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double value = 0;
            foreach (IValuable valuable in valuables)
            {
                value += valuable.GetValue();
            }
            return value;
        }
        public int Count()
        {
            return valuables.Count;
        }
        public void Save(string fileName = "ValuableRepository.txt")
        {
            using StreamWriter sw = new(fileName);
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Book)
                {
                    sw.WriteLine($"BOG;{((Book)valuable).ItemId};{((Book)valuable).Title};{((Book)valuable).Price}");
                }
                else if (valuable is Amulet)
                {
                    sw.WriteLine($"AMULET;{((Amulet)valuable).ItemId};{((Amulet)valuable).Quality};{((Amulet)valuable).Design}");
                }
                else if (valuable is Course)
                {
                    sw.WriteLine($"KURSUS;{((Course)valuable).Name};{((Course)valuable).DurationInMinutes};{((Course)valuable).GetValue}");
                }
            }
        }
        public void Load(string fileName = "ValuableRepository.txt")
        {
            using StreamReader sr = new(fileName);
            string[] lines = sr.ReadToEnd().Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length - 1; i++)
            {
                string[] valuableProperties = lines[i].Split(';');
                switch (valuableProperties[0])
                {
                    case "BOG":
                        Book book = new(valuableProperties[1], valuableProperties[2], double.Parse(valuableProperties[3]));
                        valuables.Add(book);
                        break;
                    case "AMULET":
                        Level quality = new();
                        switch (valuableProperties[2])
                        {
                            case "low":
                                quality = Level.low;
                                break;
                            case "medium":
                                quality = Level.medium;
                                break;
                            case "high":
                                quality = Level.high;
                                break;
                        }
                        Amulet amulet = new(valuableProperties[1], quality, valuableProperties[3]);
                        valuables.Add(amulet);
                        break;
                    case "KURSUS":
                        Course course = new(valuableProperties[1], int.Parse(valuableProperties[2]));
                        valuables.Add(course);
                        break;
                }
            }
        }
    }
}
