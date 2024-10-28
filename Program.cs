namespace BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
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

            Console.WriteLine(logger.GetReport());
            Console.WriteLine(loggerForBankAccount.GetReport());

            BankAccount account1 = new BankAccount("0001", 5.00M, person, loggerForBankAccount);

            Console.WriteLine(logger.GetReport());
            Console.WriteLine(loggerForBankAccount.GetReport());

            Person person2 = new Person();

            BankAccount account2 = new BankAccount("0002", 1.00M, person2, loggerForBankAccount);

            Console.WriteLine(loggerForBankAccount.GetReport());


        }
    }
}
