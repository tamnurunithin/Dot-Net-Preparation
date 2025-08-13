✅Example:

using System;
class Program {
    static void CheckAge(int age) {
        if (age < 18) {
            throw new ArgumentException("Age must be 18 or older.");
        }
        Console.WriteLine("Access granted.");
    }
    static void Main() {
        try {
            CheckAge(15);
        }
        catch (ArgumentException ex) {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
