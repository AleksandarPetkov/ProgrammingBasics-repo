using System;

class GuessThePassord
{
    static void Main()
    {
        string pass = Console.ReadLine();
        string secrets = "s3cr3t!P@ssw0rd" ;

        if (pass == secrets)
        {
            Console.WriteLine("Welcome");
            
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}

