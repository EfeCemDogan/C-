using System;

namespace ConsoleApp
{
    class Program
    {
        // static void Main()
        // {
        //     string[] names = { "Rowena", "Robin", "Bao" };
            
        //     foreach (string name in names)
        //     {
        //         Console.WriteLine(name);
        //     }
        // }


        // static void Main() {
        //         int[] inventory = { 200, 450, 700, 175, 250 };
        //         int sum = 0;
        //         int bin = 0;

        //         foreach (int items in inventory)
        //         {
        //             sum += items;
        //             bin++;
        //             Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        //         }

        //         Console.WriteLine($"We have {sum} items in inventory.");
        //     }

        // static void Main() {
        //     string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        //     foreach (string orderID in orderIDs)
        //     {
        //         if (orderID.StartsWith("B"))
        //         {
        //             Console.WriteLine(orderID);
        //         }
        //     }
        // }

        // static void Main() {
        //     Random random = new Random();
        //     string[] orderIDs = new string[5];
        //     // Loop through each blank orderID
        //     for (int i = 0; i < orderIDs.Length; i++)
        //     {
        //         // Get a random value that equates to ASCII letters A through E
        //         int prefixValue = random.Next(65, 70);
        //         // Convert the random value into a char, then a string
        //         string prefix = Convert.ToChar(prefixValue).ToString();
        //         // Create a random number, pad with zeroes
        //         string suffix = random.Next(1, 1000).ToString("000");
        //         // Combine the prefix and suffix together, then assign to current OrderID
        //         orderIDs[i] = prefix + suffix;
        //     }
        //     // Print out each orderID
        //     foreach (var orderID in orderIDs)
        //     {
        //         Console.WriteLine(orderID);
        //     }
        // }

        // static void Main() {
        // /*
        //     The following code creates five random OrderIDs
        //     to test the fraud detection process.  OrderIDs 
        //     consist of a letter from A to E, and a three
        //     digit number. Ex. A123.
        // */
        //     Random random = new Random();
        //     string[] orderIDs = new string[5];

        //     for (int i = 0; i < orderIDs.Length; i++)
        //     {
        //         int prefixValue = random.Next(65, 70);
        //         string prefix = Convert.ToChar(prefixValue).ToString();
        //         string suffix = random.Next(1, 1000).ToString("000");

        //         orderIDs[i] = prefix + suffix;
        //     }

        //     foreach (var orderID in orderIDs)
        //     {
        //         Console.WriteLine(orderID);
        //     }

        // }

        // static void Main() {
        //     Random dice = new Random();
        //     int roll1 = dice.Next(1, 7);
        //     int roll2 = dice.Next(1, 7);
        //     int roll3 = dice.Next(1, 7);
        //     int total = roll1 + roll2 + roll3;
        //     Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
        //     if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
        //         if ((roll1 == roll2) && (roll2 == roll3)) {
        //             Console.WriteLine("You rolled triples!  +6 bonus to total!");
        //             total += 6; 
        //         } else {
        //             Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        //             total += 2;
        //         }
        //     }
        // }

        // -------------------------------------------------------------------------------
        // static void Main() {
        //     Random dice = new Random();

        //     int roll1 = dice.Next(1, 7);
        //     int roll2 = dice.Next(1, 7);
        //     int roll3 = dice.Next(1, 7);

        //     int total = roll1 + roll2 + roll3;
        //     Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        //     if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
        //         if ((roll1 == roll2) && (roll2 == roll3)) {
        //             Console.WriteLine("You rolled triples!  +6 bonus to total!");
        //             total += 6; 
        //         } else {
        //             Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        //             total += 2;
        //         }
        //     }
        // }        

        // static void Main() {
            /*
            This code reverses a message, counts the number of times 
            a particular character appears, then prints the results
            to the console window.
            */

            // string originalMessage = "The quick brown fox jumps over the lazy dog.";

            // char[] message = originalMessage.ToCharArray();
            // Array.Reverse(message);

            // int letterCount = 0;

            // foreach (char letter in message)
            // {
            //     if (letter == 'o')
            //     {
            //         letterCount++;
            //     }
            // }

            // string newMessage = new String(message);

            // Console.WriteLine(newMessage);
            // Console.WriteLine($"'o' appears {letterCount} times.");
            // }  

        // -------------------------------------------------------------------------------
            // static void Main() {
            //     // initialize variables - graded assignments 
            //     int currentAssignments = 5;

            //     int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            //     int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            //     int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            //     int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            //     int sophiaSum = 0;

            //     decimal sophiaScore;

            //     sophiaScore = (decimal)sophiaSum / currentAssignments;

            //     Console.WriteLine("Student\t\tGrade\n");
            //     Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

            //     Console.WriteLine("Press the Enter key to continue");
            //     Console.ReadLine();
            // }      


            // static void Main() {
            //     // initialize variables - graded assignments 
            //     int currentAssignments = 5;

            //     int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            //     int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            //     int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            //     int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            //     // Student names
            //     string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};

            //     foreach (string name in studentNames)
            //     {
            //         if (name == "Sophia")
            //         {
            //             int sophiaSum = 0;
            //             decimal sophiaScore;

            //             foreach (int score in sophiaScores)
            //             {
            //                 // add the exam score to the sum
            //                 sophiaSum += score;
            //             }

            //             sophiaScore = (decimal)(sophiaSum) / currentAssignments;

            //             Console.WriteLine("Student\t\tGrade\n");
            //             Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
            //         }
            //     }

            //     Console.WriteLine("Press the Enter key to continue");
            //     Console.ReadLine();
            // }

            // static void Main() {
            //     // initialize variables - graded assignments 
            //     int currentAssignments = 5;

            //     int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            //     int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            //     int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            //     int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            //     // Student names
            //     string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            //     int[] studentScores = new int[10];

            //     // Write the Report Header to the console
            //     Console.WriteLine("Student\t\tGrade\n");

            //     foreach (string name in studentNames)
            //     {
            //         string currentStudent = name;

            //         if (currentStudent == "Sophia")
            //             studentScores = sophiaScores;

            //         else if (currentStudent == "Andrew")
            //             studentScores = andrewScores;

            //         else if (currentStudent == "Emma")
            //             studentScores = emmaScores;

            //         else if (currentStudent == "Logan")
            //             studentScores = loganScores;

            //         // initialize/reset the sum of scored assignments
            //         int sumAssignmentScores = 0;

            //         // initialize/reset the calculated average of exam + extra credit scores
            //         decimal currentStudentGrade = 0;

            //         foreach (int score in studentScores)
            //         {
            //             // add the exam score to the sum
            //             sumAssignmentScores += score;
            //         }

            //         currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

            //         Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
            //     }
            // }

            static void Main() {
                // initialize variables - graded assignments
                int currentAssignments = 5;

                int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
                int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
                int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
                int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

                // Student names
                string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

                int[] studentScores = new int[10];

                string currentStudentLetterGrade = "";

                // Display the Report Header
                Console.WriteLine("Student\t\tGrade\n");

                foreach (string name in studentNames)
                {
                    string currentStudent = name;

                    if (currentStudent == "Sophia")
                        // assign Sophia's scores to the studentScores array 
                        studentScores = sophiaScores;

                    else if (currentStudent == "Andrew")
                        // assign Andrew's scores to the studentScores array 
                        studentScores = andrewScores;

                    else if (currentStudent == "Emma")
                        // assign Emma's scores to the studentScores array 
                        studentScores = emmaScores;

                    else if (currentStudent == "Logan")
                        // assign Logan's scores to the studentScores array 
                        studentScores = loganScores;

                    // initialize/reset the sum of scored assignments
                    int sumAssignmentScores = 0;

                    // initialize/reset the calculated average of exam + extra credit scores
                    decimal currentStudentGrade = 0;

                    foreach (int score in studentScores)
                    {
                        // add the exam score to the sum
                        sumAssignmentScores += score;
                    }

                    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

                    if (currentStudentGrade >= 97)
                        currentStudentLetterGrade = "A+";

                    else if (currentStudentGrade >= 93)
                        currentStudentLetterGrade = "A";

                    else if (currentStudentGrade >= 90)
                        currentStudentLetterGrade = "A-";

                    else if (currentStudentGrade >= 87)
                        currentStudentLetterGrade = "B+";

                    else if (currentStudentGrade >= 83)
                        currentStudentLetterGrade = "B";

                    else if (currentStudentGrade >= 80)
                        currentStudentLetterGrade = "B-";

                    else if (currentStudentGrade >= 77)
                        currentStudentLetterGrade = "C+";

                    else if (currentStudentGrade >= 73)
                        currentStudentLetterGrade = "C";

                    else if (currentStudentGrade >= 70)
                        currentStudentLetterGrade = "C-";

                    else if (currentStudentGrade >= 67)
                        currentStudentLetterGrade = "D+";

                    else if (currentStudentGrade >= 63)
                        currentStudentLetterGrade = "D";

                    else if (currentStudentGrade >= 60)
                        currentStudentLetterGrade = "D-";

                    else
                        currentStudentLetterGrade = "F";

                    Console.WriteLine($"{name}\t\t{currentStudentGrade}\t?");
                }

                Console.WriteLine("Press the Enter key to continue");
                Console.ReadLine();
            }

            // static void Main() {
            
            // }
        }
}
