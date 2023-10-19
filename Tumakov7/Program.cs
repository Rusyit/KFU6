using System;

namespace Tumakov7
{
    class Bank1
    {

        private int accNumber;
        private int accBalance;
        private Account bankAccType;

        public enum Account
        {
            Текущий_счет,
            Сберегательный_счет
        }

        public int AccountNumber
        {
            get
            {
                return accNumber;
            }
            set
            {
                accNumber = value;
            }
        }

        public int AccountBalance
        {
            get
            {
                return accBalance;
            }
            set
            {
                accBalance = value;
            }
        }

        public Account BankAccountType
        {
            get
            {
                return bankAccType;
            }
            set
            {
                bankAccType = value;
            }
        }

        public Bank1(int accountNumber, int accountBalance, Account bankAccountType)
        {
            this.accNumber = accountNumber;
            this.accBalance = accountBalance;
            this.bankAccType = bankAccountType;
        }
    }

    class Bank2
    {
        private static int numberOfBankAccounts = 0;
        private int accNumber;
        private int accBalance;
        private AccType bankAccType;

        public enum AccType
        {
            Текущий_счет,
            Сберегательный_счет
        }

        public int AccNumber
        {
            get
            {
                return accNumber;
            }
        }

        public int AccBalance
        {
            get
            {
                return accBalance;
            }
            set
            {
                accBalance = value;
            }
        }

        public AccType BankAccType
        {
            get
            {
                return bankAccType;
            }
            set
            {
                bankAccType = value;
            }
        }

        private void ChangeNumberOfBankAccounts()
        {
            numberOfBankAccounts++;
        }

        public Bank2(int accBalance, AccType bankAccType)
        {
            accNumber = numberOfBankAccounts;
            this.accBalance = accBalance;
            this.bankAccType = bankAccType;
            ChangeNumberOfBankAccounts();
        }
    }

    class Bank3
    {
        public enum AccType
        {
            Текущий_счет,
            Сберегательный_счет
        }

        private static int numberOfBankAccounts = 0;
        private int accNumber;
        private int accBalance;
        private AccType bankAccType;

        public int AccNumber
        {
            get
            {
                return accNumber;
            }
        }

        public int AccBalance
        {
            get
            {
                return accBalance;
            }
        }

        public AccType BankAccType
        {
            get
            {
                return bankAccType;
            }
            set
            {
                bankAccType = value;
            }
        }

        private void ChangeNumberOfBankAccounts()
        {
            numberOfBankAccounts++;
        }

        public bool MoreMoney(int a)
        {
            if (accBalance - a > 0)
            {
                accBalance -= a;
                return true;
            }

            return false;
        }

        public void PutMoney(int d)
        {
            accBalance += d;
        }

        public Bank3(AccType bankAccType)
        {
            accNumber = numberOfBankAccounts;
            accBalance = 0;
            this.bankAccType = bankAccType;
            ChangeNumberOfBankAccounts();
        }
    }

    class Building
    {
        private static int numOfBuilds = 0;
        private int buildNum;
        private int numOfpodezd;
        private int numFloors;
        private int buildHeight;
        private int numOfkv;

        public int BuildNum
        {
            get
            {
                return buildNum;
            }
        }

        public int BuildHeight
        {
            get
            {
                return buildHeight;
            }
            set
            {
                buildHeight = value;
            }
        }

        public int NumFloors
        {
            get
            {
                return numFloors;
            }
            set
            {
                numFloors = value;
            }
        }

        public int NumOfkv
        {
            get
            {
                return numOfkv;

            }
            set
            {
                numOfkv = value;
            }
        }

        public int NumOfpodezd
        {
            get
            {
                return numOfpodezd;
            }
            set
            {
                numOfpodezd = value;
            }
        }

        public double Calculation1()
        {
            return (double)buildHeight / numFloors;
        }

        public int Calculation2()
        {
            return NumOfkv / NumOfpodezd;
        }

        public int Calculation3()
        {
            return NumOfkv / NumOfpodezd / numFloors;
        }

        private void NumBuilding()
        {
            numOfBuilds++;
        }

        public Building(int buildingHeight, int numberOfFloors, int numberOfApartments, int numberOfEntrances)
        {
            this.buildHeight = buildingHeight;
            this.numFloors = numberOfFloors;
            this.numOfkv = numberOfApartments;
            this.numOfpodezd = numberOfEntrances;
            buildNum = numOfBuilds;
            NumBuilding();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // УПРАЖЕНИЕ 7.1. 
            Console.WriteLine("\nУПРАЖНЕНИЕ 7.1.\n");

            try
            {
                Bank1 BankAcc1 = new Bank1(1, 1, Bank1.Account.Текущий_счет);

                Console.WriteLine("Введите номер счета:");
                BankAcc1.AccountNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целочисленный баланс счета:");
                BankAcc1.AccountBalance = Convert.ToInt32(Console.ReadLine());
                BankAcc1.BankAccountType = Bank1.Account.Текущий_счет;

                Console.WriteLine($"{BankAcc1.BankAccountType} под номером {BankAcc1.AccountNumber} содержит {BankAcc1.AccountBalance:F1} рублей");

            }

            catch (FormatException)
            {
                Console.WriteLine("Неправильный формат введенных данных");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Неправильный ввод, слишком большое число");
            }

            //УПРАЖНЕНИЕ 7.2.
            Console.WriteLine("\nУПРАЖНЕНИЕ 7.2.\n");

            try
            {
                Bank2 BankAcc2 = new Bank2(12345, Bank2.AccType.Текущий_счет);
                Bank2 BankAcc3 = new Bank2(123456789, Bank2.AccType.Сберегательный_счет);

                Console.WriteLine("Введите целочисленный баланс счета:");
                BankAcc2.AccBalance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целочисленный баланс второго счета:");
                BankAcc3.AccBalance = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{BankAcc2.BankAccType} под номером {BankAcc2.AccNumber:D7} содержит {BankAcc2.AccBalance:F1} рублей");
                Console.WriteLine($"{BankAcc3.BankAccType} под номером {BankAcc3.AccNumber:D7} содержит {BankAcc3.AccBalance:F1} рублей");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильный формат введенных данных");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Неправильный ввод, слишком большое число");
            }

            // УПРАЖЕНИЕ 7.3.
            Console.WriteLine("\nУПРАЖНЕНИЕ 7.3.\n");

            try
            {
                bool c;
                Bank3 BankAcc4 = new Bank3(Bank3.AccType.Текущий_счет);

                Console.WriteLine($"{BankAcc4.BankAccType} под номером {BankAcc4.AccNumber:D7} содержит {BankAcc4.AccBalance:F1} рублей");

                Console.WriteLine("\nБанковский счет после пополнения:");
                BankAcc4.PutMoney(100000);
                Console.WriteLine($"{BankAcc4.BankAccType} под номером {BankAcc4.AccNumber:D7} содержит {BankAcc4.AccBalance:F1} рублей");

                Console.WriteLine("\nВведите сумму которую хотите снять:");
                c = BankAcc4.MoreMoney(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("\nБанковский счет после снятия:");

                if (!c)
                {
                    Console.WriteLine("Сумма, которую вы хотите снять больше, чем сумма, которая находится на счете");
                }

                Console.WriteLine($"{BankAcc4.BankAccType} под номером {BankAcc4.AccNumber:D7} содержит {BankAcc4.AccBalance:F1} рублей");
            }

            catch (FormatException)
            {
                Console.WriteLine("Неправильный формат введенных данных");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Неправильный ввод, слишком большое число");
            }

            // УПРАЖНЕНИЕ 7.1.(1) Для подсчета здания
            Console.WriteLine("УПРАЖНЕНИЕ 7.1.(1)\n");

            Building building = new Building(800, 20, 800, 40);

            Console.WriteLine($"Здание номер {building.BuildNum:D2} высотой {building.BuildHeight} (м), имеет {building.NumFloors} этажей, {building.NumOfpodezd} подъезов и {building.NumOfkv} квартир\n");

            Console.WriteLine($"Высота одного этажа равна {building.Calculation1()}");
            Console.WriteLine($"Колличество квартир в одном подъезде равно {building.Calculation2()}");
            Console.WriteLine($"Колличество квартир на одном этаже равно {building.Calculation3()}");
        }
    }
}



