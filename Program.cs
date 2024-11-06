using BankAccount.Data;
using System;
using System.IO;
namespace BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool didItBreak = false;

            do
            {
                try
                {
                    Console.WriteLine("Provide me a number between 1 - 10");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if(number < 1 || number > 10)
                    {
                        throw new System.IndexOutOfRangeException();
                    }
                    didItBreak = false;

                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("It looks like you didn't enter a number, will you please try again! ");
                    didItBreak = true;
                }
                catch (System.IndexOutOfRangeException ex)
                { 
                    Console.WriteLine("It looks like you gave me a number less then 1 or greater then 10! ");
                    didItBreak = true;
                }
                catch(Exception ex)
                {
                    //some error
                }

            } while (didItBreak);

            
            

      

            /*
            Logger logger = new Logger();
            Logger loggerForBankAccount = new Logger();

            logger.Log("Start of Bank Account Program!");

            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("What is your date of birth? (MM-DD-YYYY) ");
            string dob = Console.ReadLine();

            logger.Log($"User entered {firstName} and {lastName} and {dob}");

            Person person = new Person(firstName, lastName, dob);

            BankAccount account1 = new BankAccount("0001", 5.00M, person, loggerForBankAccount);

                string path = $@"C:\Users\desjardinsm\source\repos\BankAccount\{account1.AccountHolder.LastName}_{account1.AccountNumber}.txt";

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(account1.AccountNumber);
                        sw.WriteLine(account1.Balance);
                        sw.WriteLine(account1.AccountHolder.FirstName);
                        sw.WriteLine(account1.AccountHolder.LastName);
                        sw.WriteLine(account1.AccountHolder.DOB.Month);
                        sw.WriteLine(account1.AccountHolder.DOB.Day);
                        sw.WriteLine(account1.AccountHolder.DOB.Year);

                    }//it will automattically, close and kill the stream.

                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(path, true))
                    {
                        sw.WriteLine(account1.AccountNumber);
                        sw.WriteLine(account1.Balance);
                        sw.WriteLine(account1.AccountHolder.FirstName);
                        sw.WriteLine(account1.AccountHolder.LastName);
                        sw.WriteLine(account1.AccountHolder.DOB.Month);
                        sw.WriteLine(account1.AccountHolder.DOB.Day);
                        sw.WriteLine(account1.AccountHolder.DOB.Year);
                    }
                }
            */
        }
    }
}
