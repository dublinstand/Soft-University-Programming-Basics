using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInThePool
{
    class PipesInThePool
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int firstPipePerHour = int.Parse(Console.ReadLine());
            int secondPipePerHour = int.Parse(Console.ReadLine());
            double hoursWorking = double.Parse(Console.ReadLine());

            double firstPipeVolumeFilled = (double)firstPipePerHour * hoursWorking;
            //int firstPipeVolumeFilledToInt = Convert.ToInt32(firstPipeVolumeFilled);

            double secondPipeVolumeFilled = (double)secondPipePerHour * hoursWorking;
            //int secondPipeVolumeFilledToInt = Convert.ToInt32(secondPipeVolumeFilled);

            double volumeFilled = firstPipeVolumeFilled + secondPipeVolumeFilled;

            double percentageFull = (volumeFilled / poolVolume) * 100;
            double firstPipePercentage = Math.Floor(firstPipeVolumeFilled / volumeFilled * 100);
            //int firstPipePercentageToInt = Convert.ToInt32(firstPipePercentage);
            double secondPipePercentage = Math.Floor(secondPipeVolumeFilled / volumeFilled * 100);
            //int secondPipePercentageToInt = Convert.ToInt32(secondPipePercentage);


            if (volumeFilled <= poolVolume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", (int)percentageFull, (int)firstPipePercentage, (int)secondPipePercentage);
            }
            else
            {
                double overflownVolume = Math.Abs(volumeFilled - poolVolume);
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hoursWorking, overflownVolume);
            }
            

        }
    }
}
