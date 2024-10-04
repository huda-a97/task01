using System;
using System.Reflection.Emit;
const string USERNAME = "huda";
const string PASSWORD = "1234";
string otp="";


Console.WriteLine("Welcome to the Simple Login System!");


while (true)
{
    Console.WriteLine("Enter your user name");
    string username = Console.ReadLine();
    Console.WriteLine("Enter your password");
    string password = Console.ReadLine();

    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
    {
        Console.WriteLine("Username or password cannot be empty.");
    }
    else
    {
        if (username != USERNAME || password != PASSWORD)
        {
            Console.WriteLine("Invalid username or password. Access denied.");
            Environment.Exit(0);
        }
        else
        {
            otp = genretOTP();
            Console.WriteLine($"The OTP = {otp}");
            Console.WriteLine("Enter the OTP code ");
            string userotp = Console.ReadLine().ToString();
            if (userotp != otp)
            {
                Console.WriteLine("Invalid OTP. Access denied.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Success! You are logged in.");
                Environment.Exit(0);
            }

        }
    }
}
string genretOTP()
{
    string otpnum = "";
    Random rand = new Random();
    for (int i = 0; i < 6; i++)
    {
        otpnum += rand.Next(0, 10).ToString();
    }
    return otpnum;
}