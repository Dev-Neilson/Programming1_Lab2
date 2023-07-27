namespace Who_are_you
/*=====================================================================================
* Programming lab #2
* 
* 
* *By: NEILM5 - 10005526
*=====================================================================================
*/

{
    internal class Program
    {
        static void Main()
        {   // Question 2: Output an addition equation.
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32 (Console.ReadLine());
            
            Console.WriteLine("Please enter another number.. ");
            int num2 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Thank you\n" + num1 + " + " + num2 + " = " + (num1 + num2));

            // Question 3: TV Time Calculator, average watch time over week, month, year
            // Take user average Watch time.
            //Averages: Month: 30.437 Year: 356.25 
            Console.WriteLine("on average, how many hours a day do you watch T.V for? ");
            float usrWatchTime = Convert.ToSingle (Console.ReadLine());

            //Assigning average values to variables.
            float usrWatchWeek = Convert.ToSingle (usrWatchTime * 7);
            float usrWatchMon = Convert.ToSingle(usrWatchTime * 30.437);
            float usrWatchYear = Convert.ToSingle(usrWatchTime * 356.25);

            Console.WriteLine("Your average watch time is as follows \n: " + usrWatchTime + " Hrs per day. \n: " + usrWatchWeek + " Hrs Per Week. \n: " + usrWatchMon + " Hrs Per Month. \n: " + usrWatchYear + " Hrs per Year. \n: ");

            //Question 5:
            //Age calculator, calculates how many days they have lived for.
            Console.WriteLine("Age Calculator: How old are you? ");
            int age = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Your current age is: " + age + "\n you are " + (age * 356) + " Days old \n or " + (age * 356) * 24 + " Hours old. ");

            // Question 6:
            //Write a script that calculates the total elapsed time and non travel time.
            //Formula is: Distance = Average Speed *(Elapsed_time - non_Traveled time)
            //Take input time and average speed, store it. use formula and provide distance traveled to user.
             
            Console.WriteLine("Im going to calculate the distance you have traveled \nWhat is your average speed? Km/hr");
            int avSpeed = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("How many hours have you been traveling for? ");
            int elapsedTime = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("How many hours have you been resting for? ");
            int restTime = Convert.ToInt32 (Console.ReadLine());
            
            //Calculating distance
            int distance = avSpeed * (elapsedTime - restTime);

            Console.WriteLine("You have traveled: " + distance + " km traveled.. ");

        }
    }
}