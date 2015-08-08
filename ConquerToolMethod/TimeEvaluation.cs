using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquerToolMethod
{
    public class TimeEvaluation
    {
        //Given an arrive time set the start
        static public DateTime GetArrivalTime(int hours, int minutes, int second, int xStart, 
                                                    int yStart, int xEnd, int yEnd, int arenaLvl, int speed)
        {
            DateTime arrivalTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, second);
            TimeSpan timeNeeded = CourseTimeEvaluation(xStart, yStart, xEnd, yEnd, arenaLvl, speed);
            DateTime startTime = new DateTime();
            startTime = arrivalTime.Subtract(timeNeeded);

            return startTime;
        }

        // this method will return the time of the trip
        static public TimeSpan CourseTimeEvaluation(int xStart, int yStart, int xEnd, int yEnd, int arenaLvl, int speed)
        {
            TimeSpan timeOfTravel = new TimeSpan();
            float time = 0;

            float distance = SpaceEvaluation.EvaluateDistance(xStart, yStart, xEnd, yEnd);
            if (distance > 20 && arenaLvl > 0)
            {
                float speedDistance = distance - 20;
                float augmentedSpeed = (float) (((arenaLvl * 0.1) + 1) * speed);

                time = ((float) 20 / speed);
                time = time + (speedDistance / augmentedSpeed);
                timeOfTravel = ConvertDecimalDegreesToSexagesimal(time);
            }
            else
            {
                time = distance / speed;
                timeOfTravel = ConvertDecimalDegreesToSexagesimal(time);
            }

            return timeOfTravel;
        }

        //Conversion from decimal to sexagesimal degrees
        static TimeSpan ConvertDecimalDegreesToSexagesimal(double decimalTime)
        {
            var ts = TimeSpan.FromHours(Math.Abs(decimalTime));
            int hours = (int)Math.Sign(decimalTime) * (int)Math.Floor(ts.TotalHours);
            int minutes = ts.Minutes;
            int seconds = ts.Seconds;

            TimeSpan time = new TimeSpan(hours, minutes, seconds);
            return time;
        }
    }
}
