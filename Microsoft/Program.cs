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

            //     string currentStudentLetterGrade = "";

            //     // Display the Report Header
            //     Console.WriteLine("Student\t\tGrade\n");

            //     foreach (string name in studentNames)
            //     {
            //         string currentStudent = name;

            //         if (currentStudent == "Sophia")
            //             // assign Sophia's scores to the studentScores array 
            //             studentScores = sophiaScores;

            //         else if (currentStudent == "Andrew")
            //             // assign Andrew's scores to the studentScores array 
            //             studentScores = andrewScores;

            //         else if (currentStudent == "Emma")
            //             // assign Emma's scores to the studentScores array 
            //             studentScores = emmaScores;

            //         else if (currentStudent == "Logan")
            //             // assign Logan's scores to the studentScores array 
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

            //         if (currentStudentGrade >= 97)
            //             currentStudentLetterGrade = "A+";

            //         else if (currentStudentGrade >= 93)
            //             currentStudentLetterGrade = "A";

            //         else if (currentStudentGrade >= 90)
            //             currentStudentLetterGrade = "A-";

            //         else if (currentStudentGrade >= 87)
            //             currentStudentLetterGrade = "B+";

            //         else if (currentStudentGrade >= 83)
            //             currentStudentLetterGrade = "B";

            //         else if (currentStudentGrade >= 80)
            //             currentStudentLetterGrade = "B-";

            //         else if (currentStudentGrade >= 77)
            //             currentStudentLetterGrade = "C+";

            //         else if (currentStudentGrade >= 73)
            //             currentStudentLetterGrade = "C";

            //         else if (currentStudentGrade >= 70)
            //             currentStudentLetterGrade = "C-";

            //         else if (currentStudentGrade >= 67)
            //             currentStudentLetterGrade = "D+";

            //         else if (currentStudentGrade >= 63)
            //             currentStudentLetterGrade = "D";

            //         else if (currentStudentGrade >= 60)
            //             currentStudentLetterGrade = "D-";

            //         else
            //             currentStudentLetterGrade = "F";

            //         Console.WriteLine($"{name}\t\t{currentStudentGrade}\t?");
            //     }

            //     Console.WriteLine("Press the Enter key to continue");
            //     Console.ReadLine();
            // }

            // static void Main() {
            // // initialize variables - graded assignments
            //     int examAssignments = 5;

            //     int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            //     int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            //     int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            //     int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

            //     // Student names
            //     string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            //     int[] studentScores = new int[10];

            //     string currentStudentLetterGrade = "";

            //     // Write the Report Header to the console
            //     Console.WriteLine("Student\t\tGrade\n");

            //     foreach (string name in studentNames)
            //     {
            //         string currentStudent = name;

            //         if (currentStudent == "Sophia")
            //         studentScores = sophiaScores;

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

            //         // initialize/reset a counter for the number of assignment 
            //         int gradedAssignments = 0;

            //         // loop through the scores array and complete calculations for currentStudent
            //         foreach (int score in studentScores)
            //         {
            //             // increment the assignment counter
            //             gradedAssignments += 1;

            //             if (gradedAssignments <= examAssignments)
            //                 // add the exam score to the sum
            //                 sumAssignmentScores += score;

            //             else
            //                 // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            //                 sumAssignmentScores += score / 10;
            //         }

            //         currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

            //         if (currentStudentGrade >= 97)
            //             currentStudentLetterGrade = "A+";

            //         else if (currentStudentGrade >= 93)
            //             currentStudentLetterGrade = "A";

            //         else if (currentStudentGrade >= 90)
            //             currentStudentLetterGrade = "A-";

            //         else if (currentStudentGrade >= 87)
            //             currentStudentLetterGrade = "B+";

            //         else if (currentStudentGrade >= 83)
            //             currentStudentLetterGrade = "B";

            //         else if (currentStudentGrade >= 80)
            //             currentStudentLetterGrade = "B-";

            //         else if (currentStudentGrade >= 77)
            //             currentStudentLetterGrade = "C+";

            //         else if (currentStudentGrade >= 73)
            //             currentStudentLetterGrade = "C";

            //         else if (currentStudentGrade >= 70)
            //             currentStudentLetterGrade = "C-";

            //         else if (currentStudentGrade >= 67)
            //             currentStudentLetterGrade = "D+";

            //         else if (currentStudentGrade >= 63)
            //             currentStudentLetterGrade = "D";

            //         else if (currentStudentGrade >= 60)
            //             currentStudentLetterGrade = "D-";

            //         else
            //             currentStudentLetterGrade = "F";

            //         //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
            //         Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            //     }

            //     // required for running in VS Code (keeps the Output windows open to view results)
            //     Console.WriteLine("\n\rPress the Enter key to continue");
            //     Console.ReadLine();
            // }
            
            // static void Main() {
            //     string permission = "Admin|Manager";
            //     int level = 20;

            //     if (permission.Contains("Admin"))
            //     {
            //         if (level > 55)
            //         {
            //             Console.WriteLine("Welcome, Super Admin user.");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Welcome, Admin user.");
            //         }
            //     }
            //     else if (permission.Contains("Manager"))
            //     {
            //         if (level >= 20)
            //         {
            //             Console.WriteLine("Contact an Admin for access.");
            //         }
            //         else
            //         {
            //             Console.WriteLine("You do not have sufficient privileges.");
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine("You do not have sufficient privileges.");
            //     }
            // }

            // static void Main() {
            //     int employeeLevel = 400;
            //     string employeeName = "John Smith";

            //     string title = "";

            //     switch (employeeLevel)
            //     {
            //         case 100:
            //             title = "Junior Associate";
            //             break;
            //         case 200:
            //             title = "Senior Associate";
            //             break;
            //         case 300:
            //             title = "Manager";
            //             break;
            //         case 400:
            //             title = "Senior Manager";
            //             break;
            //         default:
            //             title = "Associate";
            //             break;
            //     }

            //     Console.WriteLine($"{employeeName}, {title}");
            // }

            // static void Main() {
            // // SKU = Stock Keeping Unit
            //     string sku = "01-MN-L";

            //     string[] product = sku.Split('-');

            //     string type = "";
            //     string color = "";
            //     string size = "";

            //     switch (product[0])
            //     {
            //         case "01":
            //             type = "Sweat shirt";
            //             break;
            //         case "02":
            //             type = "T-Shirt";
            //             break;
            //         case "03":
            //             type = "Sweat pants";
            //             break;
            //         default:
            //             type = "Other";
            //             break;
            //     }

            //     switch (product[1])
            //     {
            //         case "BL":
            //             color = "Black";
            //             break;
            //         case "MN":
            //             color = "Maroon";
            //             break;
            //         default:
            //             color = "White";
            //             break;
            //     }

            //     switch (product[2])
            //     {
            //         case "S":
            //             size = "Small";
            //             break;
            //         case "M":
            //             size = "Medium";
            //             break;
            //         case "L":
            //             size = "Large";
            //             break;
            //         default:
            //             size = "One Size Fits All";
            //             break;
            //     }

            //     Console.WriteLine($"Product: {size} {color} {type}");
            // }

            // static void Main() {
            //     Random random = new Random();
            //     int current = 0;

            //     do
            //     {
            //         current = random.Next(1, 11);
            //         Console.WriteLine(current);
            //     } while (current != 7);
            // }

            // static void Main() {
            //     int value1 = 12;
            //     decimal value2 = 6.2m;
            //     float value3 = 4.3f;

            //     // The Convert class is best for converting the fractional decimal numbers into whole integer numbers
            //     // Convert.ToInt32() rounds up the way you would expect.
            //     int result1 = Convert.ToInt32((decimal)value1 / value2);
            //     Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            //     decimal result2 = value2 / (decimal)value3;
            //     Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            //     float result3 = value3 / value1;
            //     Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
            // }

            // static void Main() {
            //     string[] pallets = { "B14", "A11", "B12", "A13" };
            //     Console.WriteLine("");

            //     Console.WriteLine($"Before: {pallets[0]}");
            //     Array.Clear(pallets, 0, 2);
            //     Console.WriteLine($"After: {pallets[0]}");

            //     Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //     foreach (var pallet in pallets)
            //     {
            //         Console.WriteLine($"-- {pallet}");
            //     }
            // }


            // static void Main() {
            //     string[] pallets = { "B14", "A11", "B12", "A13" };
            //     Console.WriteLine("");

            //     Array.Clear(pallets, 0, 2);
            //     Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //     foreach (var pallet in pallets)
            //     {
            //         Console.WriteLine($"-- {pallet}");
            //     }

            //     Console.WriteLine("");
            //     Array.Resize(ref pallets, 6);
            //     Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            //     pallets[4] = "C01";
            //     pallets[5] = "C02";

            //     foreach (var pallet in pallets)
            //     {
            //         Console.WriteLine($"-- {pallet}");
            //     }

            //     Console.WriteLine("");
            //     Array.Resize(ref pallets, 3);
            //     Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            //     foreach (var pallet in pallets)
            //     {
            //         Console.WriteLine($"-- {pallet}");
            //     }
            // }

            // static void Main() {
            //     string pangram = "The quick brown fox jumps over the lazy dog";

            //     // Step 1
            //     string[] message = pangram.Split(' ');

            //     //Step 2
            //     string[] newMessage = new string[message.Length];

            //     // Step 3
            //     for (int i = 0; i < message.Length; i++)
            //     {
            //         char[] letters = message[i].ToCharArray();
            //         Array.Reverse(letters);
            //         newMessage[i] = new string(letters);
            //     }

            //     //Step 4
            //     string result = String.Join(" ", newMessage);
            //     Console.WriteLine(result);
            // }

            // static void Main() {
            //     int invoiceNumber = 1201;
            //     decimal productShares = 25.4568m;
            //     decimal subtotal = 2750.00m;
            //     decimal taxPercentage = .15825m;
            //     decimal total = 3185.19m;

            //     Console.WriteLine($"Invoice Number: {invoiceNumber}");
            //     Console.WriteLine($"   Shares: {productShares:N3} Product");
            //     Console.WriteLine($"     Sub Total: {subtotal:C}");
            //     Console.WriteLine($"           Tax: {taxPercentage:P2}");
            //     Console.WriteLine($"     Total Billed: {total:C}");
            // }

            // static void Main() {
            //     string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            //     // The IndexOfAny() helper method requires a char array of characters. 
            //     // You want to look for:

            //     char[] openSymbols = { '[', '{', '(' };

            //     // You'll use a slightly different technique for iterating through 
            //     // the characters in the string. This time, use the closing 
            //     // position of the previous iteration as the starting index for the 
            //     //next open symbol. So, you need to initialize the closingPosition 
            //     // variable to zero:

            // int closingPosition = 0;

            // while (true)
            //     {
            //         int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            //         if (openingPosition == -1) break;

            //         string currentSymbol = message.Substring(openingPosition, 1);

            //         // Now  find the matching closing symbol
            //         char matchingSymbol = ' ';

            //         switch (currentSymbol)
            //         {
            //             case "[":
            //                 matchingSymbol = ']';
            //                 break;
            //             case "{":
            //                 matchingSymbol = '}';
            //                 break;
            //             case "(":
            //                 matchingSymbol = ')';
            //                 break;
            //         }

            //         // To find the closingPosition, use an overload of the IndexOf method to specify 
            //         // that the search for the matchingSymbol should start at the openingPosition in the string. 

            //         openingPosition += 1;
            //         closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            //         // Finally, use the techniques you've already learned to display the sub-string:

            //         int length = closingPosition - openingPosition;
            //         Console.WriteLine(message.Substring(openingPosition, length));
            //     }
            // }


            // static void Main() {
            //     const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            //     string quantity = "";
            //     string output = "";

            //     // Your work here

            //     // Extract the "quantity"
            //     const string openSpan = "<span>";
            //     const string closeSpan = "</span>";

            //     int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
            //     int quantityEnd= input.IndexOf(closeSpan);
            //     int quantityLength = quantityEnd - quantityStart;
            //     quantity = input.Substring(quantityStart, quantityLength);
            //     quantity = $"Quantity: {quantity}";

            //     // Set output to input, replacing the trademark symbol with the registered trademark symbol
            //     const string tradeSymbol = "&trade;";
            //     const string regSymbol = "&reg;";
            //     output = input.Replace(tradeSymbol, regSymbol);

            //     // Remove the opening <div> tag
            //     const string openDiv = "<div>";
            //     int divStart = output.IndexOf(openDiv);
            //     output = output.Remove(divStart, openDiv.Length);

            //     // Remove the closing </div> tag and add "Output:" to the beginning
            //     const string closeDiv = "</div>";
            //     int divCloseStart = output.IndexOf(closeDiv);
            //     output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

            //     Console.WriteLine(quantity);
            //     Console.WriteLine(output);
            // }


            // static void Main() {
            //     case "1":
            //     // list all pet info
            //     for (int i = 0; i < maxPets; i++)
            //     {
            //         if (ourAnimals[i, 0] != "ID #: ")
            //         {
            //             Console.WriteLine();
            //             for (int j = 0; j < 7; j++) // increased exit condition
            //             {
            //                 Console.WriteLine(ourAnimals[i, j]);
            //             }
            //         }
            //     }
            // }


            // static void Main() {
            //    using System;

            //     int[] times = {800, 1200, 1600, 2000};
            //     int diff = 0;

            //     Console.WriteLine("Enter current GMT");
            //     int currentGMT = Convert.ToInt32(Console.ReadLine());

            //     Console.WriteLine("Current Medicine Schedule:");

            //     /* Format and display medicine times */
            //     foreach (int val in times)
            //     {
            //         string time = val.ToString();
            //         int len = time.Length;

            //         if (len >= 3)
            //         {
            //             time = time.Insert(len - 2, ":");
            //         }
            //         else if (len == 2)
            //         {
            //             time = time.Insert(0, "0:");
            //         }
            //         else
            //         {
            //             time = time.Insert(0, "0:0");
            //         }

            //         Console.Write($"{time} ");
            //     }

            //     Console.WriteLine();

            //     Console.WriteLine("Enter new GMT");
            //     int newGMT = Convert.ToInt32(Console.ReadLine());

            //     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            //     {
            //         Console.WriteLine("Invalid GMT");
            //     }
            //     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
            //     {
            //         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

            //         /* Adjust the times by adding the difference, keeping the value within 24 hours */
            //         for (int i = 0; i < times.Length; i++) 
            //         {
            //             times[i] = ((times[i] + diff)) % 2400;
            //         }
            //     } 
            //     else 
            //     {
            //         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

            //         /* Adjust the times by adding the difference, keeping the value within 24 hours */
            //         for (int i = 0; i < times.Length; i++) 
            //         {
            //             times[i] = ((times[i] + diff)) % 2400;
            //         }
            //     }

            //     Console.WriteLine("New Medicine Schedule:");

            //     /* Format and display medicine times */
            //     foreach (int val in times)
            //     {
            //         string time = val.ToString();
            //         int len = time.Length;

            //         if (len >= 3)
            //         {
            //             time = time.Insert(len - 2, ":");
            //         }
            //         else if (len == 2)
            //         {
            //             time = time.Insert(0, "0:");
            //         }
            //         else
            //         {
            //             time = time.Insert(0, "0:0");
            //         }

            //         Console.Write($"{time} ");
            //     }

            //     Console.WriteLine();
            // }


            // static void Main() {
            //    string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
            //     string[] address;
            //     bool validLength = false;
            //     bool validZeroes = false;
            //     bool validRange = false;

            //     foreach (string ip in ipv4Input) 
            //     {
            //         address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

            //         ValidateLength(); 
            //         ValidateZeroes(); 
            //         ValidateRange();

            //         if (validLength && validZeroes && validRange) 
            //         {
            //             Console.WriteLine($"{ip} is a valid IPv4 address");
            //         } 
            //         else 
            //         {
            //             Console.WriteLine($"{ip} is an invalid IPv4 address");
            //         }
            //     }

            //     void ValidateLength() 
            //     {
            //         validLength = address.Length == 4;
            //     };

            //     void ValidateZeroes() 
            //     {
            //         foreach (string number in address) 
            //         {
            //             if (number.Length > 1 && number.StartsWith("0")) 
            //             {
            //                 validZeroes = false;
            //                 return;
            //             }
            //         }

            //         validZeroes = true;
            //     }

            //     void ValidateRange() 
            //     {
            //         foreach (string number in address) 
            //         {
            //             int value = int.Parse(number);
            //             if (value < 0 || value > 255) 
            //             {
            //                 validRange = false;
            //                 return;
            //             }
            //         }
            //         validRange = true;
            //     }
            // }


            // static void Main() {
            //    string[,] corporate = 
            //     {
            //         {"Robert", "Bavin"}, {"Simon", "Bright"},
            //         {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            //         {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            //     };

            //     string[,] external = 
            //     {
            //         {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            //         {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            //     };

            //     string externalDomain = "hayworth.com";

            //     for (int i = 0; i < corporate.GetLength(0); i++) 
            //     {
            //         // display internal email addresses
            //     }

            //     for (int i = 0; i < external.GetLength(0); i++) 
            //     {
            //         // display external email addresses
            //     }
            // }


            // static void Main() {
            //     double total = 0;
            //     double minimumSpend = 30.00;

            //     double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
            //     double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

            //     for (int i = 0; i < items.Length; i++)
            //     {
            //         total += GetDiscountedPrice(i);
            //     }

            //     total -= TotalMeetsMinimum() ? 5.00 : 0.00;

            //     Console.WriteLine($"Total: ${FormatDecimal(total)}");

            //     double GetDiscountedPrice(int itemIndex)
            //     {
            //         return items[itemIndex] * (1 - discounts[itemIndex]);
            //     }

            //     bool TotalMeetsMinimum()
            //     {
            //         return total >= minimumSpend;
            //     }

            //     string FormatDecimal(double input)
            //     {
            //         return input.ToString().Substring(0, 5);
            //     }
            // }


            // static void Main() {
            //     int target = 30;
            //     int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
            //     int[,] result = TwoCoins(coins, target);

            //     if (result.Length == 0) 
            //     {
            //         Console.WriteLine("No two coins make change");
            //     } 
            //     else 
            //     {
            //         Console.WriteLine("Change found at positions:");
            //         for (int i = 0; i < result.GetLength(0); i++) 
            //         {
            //             if (result[i,0] == -1) 
            //             {
            //                 break;
            //             }
            //             Console.WriteLine($"{result[i,0]},{result[i,1]}");
            //         }
            //     }

            //     int[,] TwoCoins(int[] coins, int target) 
            //     {
            //         int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
            //         int count = 0;

            //         for (int curr = 0; curr < coins.Length; curr++) 
            //         {
            //             for (int next = curr + 1; next < coins.Length; next++) 
            //             {    
            //                 if (coins[curr] + coins[next] == target) 
            //                 {
            //                     result[count, 0] = curr;
            //                     result[count, 1] = next;
            //                     count++;
            //                 }
            //                 if (count == result.GetLength(0)) 
            //                 {
            //                     return result;
            //                 }
            //             }
            //         }
            //         return (count == 0) ? new int[0,0] : result;
            //     }
            // }

            // static void Main() {
            //    Random random = new Random();

            //     Console.WriteLine("Would you like to play? (Y/N)");
            //     if (ShouldPlay()) 
            //     {
            //         PlayGame();
            //     }

            //     bool ShouldPlay() 
            //     {
            //         string response = Console.ReadLine();
            //         return response.ToLower().Equals("y");
            //     }

            //     void PlayGame() 
            //     {
            //         var play = true;

            //         while (play) {
            //             var target = GetTarget();
            //             var roll = RollDice();

            //             Console.WriteLine($"Roll a number greater than {target} to win!");
            //             Console.WriteLine($"You rolled a {roll}");
            //             Console.WriteLine(WinOrLose(roll, target));
            //             Console.WriteLine("\nPlay again? (Y/N)");

            //             play = ShouldPlay();
            //         }
            //     }

            //     int GetTarget() 
            //     {
            //         return random.Next(1, 6);
            //     }

            //     int RollDice() 
            //     {
            //         return random.Next(1, 7);
            //     }

            //     string WinOrLose(int roll, int target) 
            //     {
            //         if (roll > target) 
            //         {
            //             return "You win!";
            //         }
            //         return "You lose!";
            //     }
            // }

            // static void Main() {
            //     using System;

            //     string[] pettingZoo = 
            //     {
            //         "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
            //         "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
            //         "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            //     };

            //     RandomizeAnimals();
            //     string[,] group = AssignGroup();
            //     Console.WriteLine("School A");
            //     // PrintGroup(group);

            //     void RandomizeAnimals() 
            //     {
            //         Random random = new Random();

            //         for (int i = 0; i < pettingZoo.Length; i++) 
            //         {
            //             int r = random.Next(i, pettingZoo.Length);

            //             string temp = pettingZoo[r];
            //             pettingZoo[r] = pettingZoo[i];
            //             pettingZoo[i] = temp;
            //         }
            //     }

            //     string[,] AssignGroup(int groups = 6) 
            //     {
            //         string[,] result = new string[groups, pettingZoo.Length/groups];
            //         int start = 0;

            //         for (int i = 0; i < groups; i++) 
            //         {
            //             for (int j = 0; j < result.GetLength(1); j++) 
            //             {
            //                 result[i,j] = pettingZoo[start++];
            //             }
            //         }

            //         return result;
            //     }
            // }

            // static void Main() {
            //    using System;

            //     string[] pettingZoo = 
            //     {
            //         "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
            //         "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
            //         "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            //     };

            //     PlanSchoolVisit("School A");
            //     PlanSchoolVisit("School B", 3);
            //     PlanSchoolVisit("School C", 2);

            //     void PlanSchoolVisit(string schoolName, int groups = 6) 
            //     {
            //         RandomizeAnimals(); 
            //         string[,] group1 = AssignGroup(groups);
            //         Console.WriteLine(schoolName);
            //         PrintGroup(group1);
            //     }

            //     void RandomizeAnimals() 
            //     {
            //         Random random = new Random();

            //         for (int i = 0; i < pettingZoo.Length; i++) 
            //         {
            //             int r = random.Next(i, pettingZoo.Length);

            //             string temp = pettingZoo[r];
            //             pettingZoo[r] = pettingZoo[i];
            //             pettingZoo[i] = temp;
            //         }
            //     }

            //     string[,] AssignGroup(int groups = 6) 
            //     {
            //         string[,] result = new string[groups, pettingZoo.Length/groups];
            //         int start = 0;

            //         for (int i = 0; i < groups; i++) 
            //         {
            //             for (int j = 0; j < result.GetLength(1); j++) 
            //             {
            //                 result[i,j] = pettingZoo[start++];
            //             }
            //         }

            //         return result;
            //     }

            //     void PrintGroup(string[,] groups) 
            //     {
            //         for (int i = 0; i < groups.GetLength(0); i++) 
            //         {
            //             Console.Write($"Group {i + 1}: ");
            //             for (int j = 0; j < groups.GetLength(1); j++) 
            //             {
            //                 Console.Write($"{groups[i,j]}  ");
            //             }
            //             Console.WriteLine();
            //         }
            //     }
            // }

            // static void Main() {
            //    /* 
            //     This code uses a names array and corresponding methods to display
            //     greeting messages
            //     */

            //     string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

            //     string messageText = "";

            //     foreach (string name in names)
            //     {
            //         if (name == "Sophia")
            //             messageText = SophiaMessage();
            //         else if (name == "Andrew")
            //             messageText = AndrewMessage();
            //         else if (name == "AllGreetings")
            //             messageText = SophiaMessage();
            //             messageText = messageText + "\n\r" + AndrewMessage();

            //         Console.WriteLine(messageText + "\n\r");
            //     }

            //     bool pauseCode = true;
            //     while (pauseCode == true);

            //     static string SophiaMessage()
            //     {
            //         return "Hello, my name is Sophia.";
            //     }

            //     static string AndrewMessage()
            //     {
            //         return "Hi, my name is Andrew. Good to meet you.";
            //     }
            // }

            // static void Main() {
            //    /* 
            //     This code uses a names array and corresponding methods to display
            //     greeting messages
            //     */

            //     string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

            //     string messageText = "";

            //     foreach (string name in names)
            //     {
            //         if (name == "Sophia")
            //             messageText = SophiaMessage();
            //         else if (name == "Andrew")
            //             messageText = AndrewMessage();
            //         else if (name == "AllGreetings")
            //             messageText = SophiaMessage();
            //             messageText = messageText + "\n\r" + AndrewMessage();

            //         Console.WriteLine(messageText + "\n\r");
            //     }

            //     bool pauseCode = true;
            //     while (pauseCode == true);

            //     static string SophiaMessage()
            //     {
            //         return "Hello, my name is Sophia.";
            //     }

            //     static string AndrewMessage()
            //     {
            //         return "Hi, my name is Andrew. Good to meet you.";
            //     }
            // }

            // static void Main() {
            //     string? readResult;
            //     int startIndex = 0;
            //     bool goodEntry = false;

            //     int[] numbers = { 1, 2, 3, 4, 5 };

            //     // Display the array to the console.
            //     Console.Clear();
            //     Console.Write("\n\rThe 'numbers' array contains: { ");
            //     foreach (int number in numbers)
            //     {
            //         Console.Write($"{number} ");
            //     }

            //     // To calculate a sum of array elements, 
            //     //  prompt the user for the starting element number.
            //     Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
            //     while (goodEntry == false)
            //     {
            //         readResult = Console.ReadLine();
            //         goodEntry = int.TryParse(readResult, out startIndex);

            //         if (startIndex > 5)
            //         {
            //             goodEntry = false;
            //             Console.WriteLine("\n\rEnter an integer value between 1 and 5");
            //         }
            //     }

            //     // Display the sum and then pause.
            //     Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");

            //     Console.WriteLine("press Enter to exit");
            //     readResult = Console.ReadLine();

            //     // This method returns the sum of elements n through 5
            //     static int SumValues(int[] numbers, int n)
            //     {
            //         int sum = 0;
            //         for (int i = n; i < numbers.Length; i++)
            //         {
            //             sum += numbers[i];
            //         }
            //         return sum;
            //     }
            // }

            // static void Main() {
            //    try
            //     {
            //         Process1();
            //     }
            //     catch
            //     {
            //         Console.WriteLine("An exception has occurred");
            //     }

            //     Console.WriteLine("Exit program");

            //     static void Process1()
            //     {
            //         WriteMessage();
            //     }

            //     static void WriteMessage()
            //     {
            //         double float1 = 3000.0;
            //         double float2 = 0.0;
            //         int number1 = 3000;
            //         int number2 = 0;

            //         Console.WriteLine(float1 / float2);
            //         Console.WriteLine(number1 / number2);
            //     }
            // }

            // static void Main() {
            //    try
            //     {
            //         int num1 = int.MaxValue;
            //         int num2 = int.MaxValue;
            //         int result = num1 + num2;
            //         Console.WriteLine("Result: " + result);

            //         string str = null;
            //         int length = str.Length;
            //         Console.WriteLine("String Length: " + length);

            //         int[] numbers = new int[5];
            //         numbers[5] = 10;
            //         Console.WriteLine("Number at index 5: " + numbers[5]);

            //         int num3 = 10;
            //         int num4 = 0;
            //         int result2 = num3 / num4;
            //         Console.WriteLine("Result: " + result2);
            //     }
            //     catch (OverflowException ex)
            //     {
            //         Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
            //     }
            //     catch (NullReferenceException ex)
            //     {
            //         Console.WriteLine("Error: The reference is null." + ex.Message);
            //     }
            //     catch (IndexOutOfRangeException ex)
            //     {
            //         Console.WriteLine("Error: Index out of range." + ex.Message);
            //     }
            //     catch (DivideByZeroException ex)
            //     {
            //         Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
            //     }

            //     Console.WriteLine("Exiting program.");
            // }


            // static void Main() {
            //     checked
            //         {
            //             try
            //             {
            //                 int num1 = int.MaxValue;
            //                 int num2 = int.MaxValue;
            //                 int result = num1 + num2;
            //                 Console.WriteLine("Result: " + result);
            //             }
            //             catch (OverflowException ex)
            //             {
            //                 Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
            //             }
            //         }

            //         try
            //         {
            //             string? str = null;
            //             int length = str.Length;
            //             Console.WriteLine("String Length: " + length);
            //         }
            //         catch (NullReferenceException ex)
            //         {
            //             Console.WriteLine("Error: The reference is null. " + ex.Message);
            //         }

            //         try
            //         {
            //             int[] numbers = new int[5];
            //             numbers[5] = 10;
            //             Console.WriteLine("Number at index 5: " + numbers[5]);
            //         }
            //         catch (IndexOutOfRangeException ex)
            //         {
            //             Console.WriteLine("Error: Index out of range. " + ex.Message);
            //         }

            //         try
            //         {
            //             int num3 = 10;
            //             int num4 = 0;
            //             int result2 = num3 / num4;
            //             Console.WriteLine("Result: " + result2);
            //         }
            //         catch (DivideByZeroException ex)
            //         {
            //             Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
            //         }

            //         Console.WriteLine("Exiting program.");
            // }


            // static void Main() {
            //     try
            //     {
            //         OperatingProcedure1();
            //     }
            //     catch (Exception ex)
            //     {
            //         Console.WriteLine(ex.Message);
            //         Console.WriteLine("Exiting application.");
            //     }

            //     static void OperatingProcedure1()
            //     {
            //         string[][] userEnteredValues = new string[][]
            //         {
            //             new string[] { "1", "two", "3"},
            //             new string[] { "0", "1", "2"}
            //         };

            //         foreach(string[] userEntries in userEnteredValues)
            //         {
            //             try
            //             {
            //                 BusinessProcess1(userEntries);
            //             }
            //             catch (Exception ex)
            //             {
            //                 if (ex.StackTrace.Contains("BusinessProcess1"))
            //                 {
            //                     if (ex is FormatException)
            //                     {
            //                         Console.WriteLine(ex.Message);
            //                         Console.WriteLine("Corrective action taken in OperatingProcedure1");
            //                     }
            //                     else if (ex is DivideByZeroException)
            //                     {
            //                         Console.WriteLine(ex.Message);
            //                         Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

            //                         // re-throw the original exception
            //                         throw;
            //                     }
            //                     else
            //                     {
            //                         // create a new exception object that wraps the original exception
            //                         throw new ApplicationException("An error occurred - ", ex);
            //                     }
            //                 }
            //             }

            //         }
            //     }

            //     static void BusinessProcess1(String[] userEntries)
            //     {
            //         int valueEntered;

            //         foreach (string userValue in userEntries)
            //         {
            //             try
            //             {
            //                 valueEntered = int.Parse(userValue);

            //                 checked
            //                 {
            //                     int calculatedValue = 4 / valueEntered;
            //                 }
            //             }
            //             catch (FormatException)
            //             {
            //                 FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            //                 throw invalidFormatException;
            //             }
            //             catch (DivideByZeroException)
            //             {
            //                 DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            //                 throw unexpectedDivideByZeroException;

            //             }
            //         }
            //     }
            // }

            static void Main() {
                string[][] userEnteredValues = new string[][]
                {
                            new string[] { "1", "2", "3"},
                            new string[] { "1", "two", "3"},
                            new string[] { "0", "1", "2"}
                };

                try
                {
                    Workflow1(userEnteredValues);
                    Console.WriteLine("'Workflow1' completed successfully.");

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("An error occurred during 'Workflow1'.");
                    Console.WriteLine(ex.Message);
                }

                static void Workflow1(string[][] userEnteredValues)
                {
                    foreach (string[] userEntries in userEnteredValues)
                    {
                        try
                        {
                            Process1(userEntries);
                            Console.WriteLine("'Process1' completed successfully.");
                            Console.WriteLine();
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("'Process1' encountered an issue, process aborted.");
                            Console.WriteLine(ex.Message);
                            Console.WriteLine();
                        }
                    }
                }

                static void Process1(String[] userEntries)
                {
                    int valueEntered;

                    foreach (string userValue in userEntries)
                    {
                        bool integerFormat = int.TryParse(userValue, out valueEntered);

                        if (integerFormat == true)
                        {
                            if (valueEntered != 0)
                            {
                                checked
                                {
                                    int calculatedValue = 4 / valueEntered;
                                }
                            }
                            else
                            {
                                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
                            }
                        }
                        else
                        {
                            throw new FormatException("Invalid data. User input values must be valid integers.");
                        }
                    }
                }
            }

        }
}
