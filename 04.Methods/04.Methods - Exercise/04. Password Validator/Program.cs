using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool checkPasswordLenght = CheckPasswordLenght(password);
            bool checkPasswordLettersAndDigits = CheckPasswordLettersAndDigits(password);
            bool checkPasswordDigits = CheckPasswordDigits(password);
            if (checkPasswordLettersAndDigits && checkPasswordLenght && checkPasswordDigits)
            {
                Console.WriteLine("Password is valid");
            }
            if (!checkPasswordLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!checkPasswordLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!checkPasswordDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }
        static bool CheckPasswordLenght(string password)
        {
            bool flag = true;

            if (password.Length < 6 || password.Length > 10)
            {
                flag = false;
                return flag;

            }
            else
            {
                return flag;
            }


        }
        static bool CheckPasswordLettersAndDigits(string password)
        {
            bool flag = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'A' && password[i] <= 'Z' || password[i] >= 'a' && password[i] <= 'z' || password[i] >= '0' && password[i] <= '9')
                {
                    continue;
                }
                else
                {
                    flag = false;
                    return flag;
                }
            }
            return flag;

        }
        static bool CheckPasswordDigits(string password)
        {
            bool flag = true;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    counter++;
                }
            }
            if (counter < 2)
            {
                flag = false;

            }
            return flag;

        }

    }
}
