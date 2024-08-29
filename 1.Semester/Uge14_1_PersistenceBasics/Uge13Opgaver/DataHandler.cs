using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Uge13Opgaver
{
    public class DataHandler
    {
        public string DataFileName { get; set; }

        public DataHandler(string dataFileName)
        {
            this.DataFileName = dataFileName;
        }

        public void SavePerson(Person person)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string line = $"{person.Name};{person.BirthDate.ToString("dd-MM-yyyy HH:mm:ss", culture)};{person.Height};{person.IsMarried};{person.NoOfChildren}";

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(DataFileName, append: true);
                writer.WriteLine(line);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public Person LoadPerson()
        {
            Person person = null;

            StreamReader reader = null;
            try
            {
                reader = new StreamReader(DataFileName);
                string line = reader.ReadLine();
                if (line != null)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length >= 5)
                    {
                        string name = parts[0];
                        DateTime birthDate = DateTime.Parse(parts[1]);
                        double height = double.Parse(parts[2]);
                        bool isMarried = bool.Parse(parts[3]);
                        int noOfChildren = int.Parse(parts[4]);

                        person = new Person(name, birthDate, height, isMarried, noOfChildren);
                    }
                    else
                    {
                        Console.WriteLine("Invalid data found: " + line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return person;
        }

        public void SavePersons(Person[] persons)
        {
            CultureInfo culture = new CultureInfo("en-US");
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(DataFileName, append: false);
                foreach (Person person in persons)
                {
                    string line = $"{person.Name};{person.BirthDate.ToString("dd-MM-yyyy HH:mm:ss", culture)};{person.Height};{person.IsMarried};{person.NoOfChildren}";
                    writer.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public Person[] LoadPersons()
        {
            Person[] persons = null;
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(DataFileName);
                string[] lines = File.ReadAllLines(DataFileName);
                persons = new Person[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(';');
                    if (parts.Length >= 5)
                    {
                        string name = parts[0];
                        DateTime birthDate = DateTime.Parse(parts[1]);
                        double height = double.Parse(parts[2]);
                        bool isMarried = bool.Parse(parts[3]);
                        int noOfChildren = int.Parse(parts[4]);

                        persons[i] = new Person(name, birthDate, height, isMarried, noOfChildren);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid data found in line {i + 1}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return persons;
        }

    }
}