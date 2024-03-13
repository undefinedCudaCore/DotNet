using OOP_Task_04.BankAndAccount;
using OOP_Task_04.Cars;
using OOP_Task_04.Person;

namespace OOP_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 4.1.------------------------
            //Car car1 = new Car();

            //car1.Make = "Dodge";
            //car1.Model = "Journey";


            //Wheels continentalR16 = new Wheels("Continental", 16, 55, 205);

            //for (int i = 0; i < 4; i++)
            //{
            //    car1.Wheels.Add(continentalR16);
            //}

            //Car.RunEngine(car1);

            //ShowIsCarEngineOn(car1);

            //Exercise 4.2.------------------------
            Person1 person1 = new Person1();

            person1.Name = "Test";
            person1.Age = 30;
            person1.MyAddress.City = "Kaunas";
            person1.MyAddress.Street = "Kauno g. 12";

            //Console.WriteLine($"My name is {person1.Name}, " +
            //    $"I'm {person1.Age} years old. I am living in city called " +
            //    $"{person1.MyAddress.City} on {person1.MyAddress.Street} street.");

            //Exercise 4.3.------------------------
            Bank swedbank = new Bank();

            OpenBankAccount(swedbank, "Arvydas  Sabonis", 50000.98);
            OpenBankAccount(swedbank, "Tomas Leilas", 60000.98);
            OpenBankAccount(swedbank, "Virginijus Vilkas", 59990.98);

            foreach (var account in swedbank.Accounts)
            {
                Console.WriteLine(account.AccountHolder + " " + account.Balance);
            }


        }

        //Exercise 4.1.------------------------
        public static void ShowIsCarEngineOn(Car car)
        {
            Console.WriteLine(car.Make);
            Console.WriteLine(car.Model);
            Console.WriteLine("Engine is " + car.Engine.EngineIsOn);
        }

        //Exercise 4.3.------------------------
        public static Bank OpenBankAccount(Bank bank, string bankHoldersName, double balance)
        {
            Account account = new Account();
            account.AccountHolder = bankHoldersName;
            account.Balance = balance;
            bank.Accounts.Add(account);

            return bank;
        }
    }
}
