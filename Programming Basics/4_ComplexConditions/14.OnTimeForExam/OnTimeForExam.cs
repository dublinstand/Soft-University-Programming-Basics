using System;

class OnTimeForExam2
{
    static void Main2()
    {
        var examHours = int.Parse(Console.ReadLine());
        var examMinutes = int.Parse(Console.ReadLine());
        var studentHours = int.Parse(Console.ReadLine());
        var studentMinutes = int.Parse(Console.ReadLine());

        var examTime = examHours * 60 + examMinutes;
        var studentTime = studentHours * 60 + studentMinutes;
        var minutesDifference = studentTime - examTime;

        if (minutesDifference < -30)
            Console.WriteLine("Early");
        else if (minutesDifference <= 0)
            Console.WriteLine("On time");
        else
            Console.WriteLine("Late");

        if (minutesDifference != 0)
        {
            var hours = Math.Abs(minutesDifference / 60);
            var minutes = Math.Abs(minutesDifference % 60);
            if (hours > 0)
            {
                if (minutes < 10)
                    Console.Write(hours + ":0" + minutes + " hours");
                else
                    Console.Write(hours + ":" + minutes + " hours");
            }
            else
                Console.Write(minutes + " minutes");
            if (minutesDifference < 0)
                Console.WriteLine(" before the start");
            else
                Console.WriteLine(" after the start");
        }
    }
}

class OnTimeForExam
{
    static void Main()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());
        int arrivingHour = int.Parse(Console.ReadLine());
        int arrivingMinutes = int.Parse(Console.ReadLine());
        
        int totalExamMinutes = examMinutes + (60 * examHour);
        int totalArrivingMinutes = arrivingMinutes + (60 * arrivingHour);
        
        int diffMinutes = Math.Abs(totalExamMinutes - totalArrivingMinutes);
        
        int diffHours = diffMinutes / 60;
        int newDiffMinutes = diffMinutes - (diffHours * 60);
        

        if (totalExamMinutes == totalArrivingMinutes)
        {
            Console.WriteLine("On time");
        }
        else if (totalExamMinutes < totalArrivingMinutes)
        {
            Console.WriteLine("Late");
            if (diffHours >= 1 && newDiffMinutes < 10)
            {
                Console.WriteLine("{0}:0{1} hours after the start", diffHours, newDiffMinutes);
            }
            else if (diffHours >= 1 && newDiffMinutes > 10)
            {
                Console.WriteLine("{0}:{1} hours after the start", diffHours, newDiffMinutes);
            }
            else if (diffHours < 1)
            {
                Console.WriteLine("{0} minutes after the start", newDiffMinutes);
            }
           
        }
        else if (totalExamMinutes > totalArrivingMinutes)
        {
            if (diffHours >= 1 && newDiffMinutes < 10)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0}:0{1} hours before the start", diffHours, newDiffMinutes);
            }
            else if (diffHours >= 1 && newDiffMinutes > 10)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0}:{1} hours before the start", diffHours, newDiffMinutes);
            }
            else if (diffHours < 1 && newDiffMinutes > 30)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", newDiffMinutes);
            }
            
            else if (diffHours < 1 && newDiffMinutes <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", newDiffMinutes);
            }

        }

    }
}



