using System;
using System.Collections.Generic;  // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<double>> gradeBook = new Dictionary<string, List<double>>();
            bool broWantsToExit = false;
            bool userInputValid = false;
            do
            {
                Console.WriteLine("Bro do you want to exit? (y/n)");
                string input = Console.ReadLine();
                
                string[] acceptableYResponses = 
                [
                    "y", "yes", "yeah", "yes I do", "indeed", "indeed I do", "yes bro"
                ];

                foreach (string response in acceptableYResponses)
                {
                    if (input == response)
                    {
                        broWantsToExit = true;
                        userInputValid = true;
                        return;
                    }
                }
                
                string[] acceptableNResponses =
                [
                    "n", "no", "no I don't", "nah", "no bro", "nah bro"
                ];

                foreach (string response in acceptableNResponses)
                {
                    if (input == response)
                    {
                        broWantsToExit = false;
                        userInputValid = true;
                        break;
                    }
                    
                    userInputValid = false;
                }
                
                //split
                
                if (!userInputValid)
                {
                    Console.WriteLine("Please enter a valid response");
                }
                else if (userInputValid)
                {
                    if (input.Contains("bro"))
                    {
                        Console.WriteLine("Wicked bro");
                    }
                    Console.WriteLine("Enter Student name: ");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("Enter grade: ");
                    
                    double grade = 0.00;
                    List<double> studentGrades = new List<double>();
                    try
                    {
                        string UsertypedInput = "";
                        while (UsertypedInput != "end")
                        {
                            Console.WriteLine("Enter student grade or type end to exit");
                            UsertypedInput = Console.ReadLine();
                            if (UsertypedInput == "end")
                            {
                                break;
                            }
                            grade = double.Parse(UsertypedInput);
                            studentGrades.Add(grade);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid grade");
                        continue;
                    }
                    
                    gradeBook[studentName] = studentGrades;
                    Console.Clear();
                }
                
            } while (!broWantsToExit);

            foreach (KeyValuePair<string, List<double>> grade in gradeBook)
            {
                Console.WriteLine(grade.Key + " has a average grade of:");
                double sum = 0.00;
                foreach (double gradeValue in grade.Value)
                {
                    sum += gradeValue;
                }
                Console.WriteLine(sum/grade.Value.Count);
                
            }
            
            Dictionary<string, int> personInfo   = new Dictionary<string, int>();

            // Add some people and their zip codes
            //
            // dictionaryName[key] = value;
            //
            // dictionaryName.Add(key, value) 

            personInfo["Frank"]  = 85339;
            personInfo["Kirk"]   = 48009;
            personInfo["Spock"] = 15658;
            personInfo["Bones"]   = 49116;

            personInfo.Add("Jenna", 85339);

            // Specifying a key that already exists in the Dictionary
            // When using [], the entry for the key is update
            personInfo["Frank"] = 44143;

            // Specifying a key that already exists in the Dictionary
            // when using .Add() an exception is thrown if key already exists
            // So to avoid this and still use .Add() check to see if teh key already
            //       exists in Dictionary and only do teh .Add if it is not
            // if the key value is NOT in the dictionary...
            if (!personInfo.ContainsKey("Frank"))
            {
                personInfo.Add("Frank", 06082);  // Add it
            }
            else // If key IS already in the Dictionary
            {
                personInfo["Frank"] = 06082;    // Update its value
            }

            Console.WriteLine("Kirk lives in: " + personInfo["Kirk"]);

            Console.Write("Whose zip code do you want? ");
            string name = Console.ReadLine();

            try
            {
                Console.WriteLine(name + " lives in: " + personInfo[name]);
            }
            catch (KeyNotFoundException exceptionInfo)
            {
                Console.WriteLine("Error looking for: " + name);
                Console.WriteLine(exceptionInfo.Message);
            }

            // If you want to walkthrough teh entire Dictionary with a foreach
            //    You need to get all the keys in the Dictionary
            //
            // use the KeyValuePair object in the foreach
            //
            // KeyValuePair<key-type, value-type> name-for-dictionary-entry

            foreach (KeyValuePair<string, int> anEntry in personInfo)
            {
                Console.WriteLine(anEntry.Key + " lives in zip code " + anEntry.Value);
            }
                 
            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}
