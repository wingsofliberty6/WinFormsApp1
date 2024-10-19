using System;

class UserRegistration
{
    static void Main()
    {
        Console.WriteLine("User Registration");

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        // Simulate registration by storing email and password
        // In a real application, you should hash and salt the password before storage.
        Console.WriteLine("Registration successful!");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine("Password: ********"); // For security reasons, don't display the password.
    }
}
