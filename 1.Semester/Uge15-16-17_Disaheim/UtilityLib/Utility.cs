using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Uge_15_opgaver
//{
//    public class Utility
//    {
//        public static double GetValueOfBook(Book book)
//        {
//            return book.Price;
//        }

//        public static double GetValueOfAmulet(Amulet amulet)
//        {
            
//            switch (amulet.Quality)
//            {
//                case Level.low:
//                    return 12.5;

//                case Level.high:
//                    return 27.5;

//                case Level.medium:
//                    return 20.0;

//                default:
//                    throw new ArgumentException("Invalid quality");


//            }
//        }
//        public static double GetValueOfCourse(Course course)
//        {
//            //126
//            //hours = 2
//            //minutes = 6
//            //hours++ (hours = 3)
//            int hours = course.DurationInMinutes / 60;
//            int minutes = course.DurationInMinutes % 60;
//            if(minutes > 0)
//            {
//                hours++;
//            }
//            int x = 875 * hours;


//            return x;
//        }



//    }
//}