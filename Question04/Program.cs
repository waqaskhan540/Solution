using System;

namespace Question04
{
    class Program
    {
        static void Main(string[] args)
        {
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa
            alexa.Configure(x =>
            {
                x.GreetingMessage = " Hello {OwnerName}, I 'm at your service";
                x.OwnerName = "Bob Marley";
            });

            
            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I&#39;m at your service
            Console.WriteLine(" press any key to exit...");
            Console.ReadKey();
        }
    }

    public class Alexa
    {
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }
        public void Configure(Action<Alexa> config)
        {
            config.Invoke(this);
        }

        public string Talk()
        {
            if (string.IsNullOrWhiteSpace(OwnerName))
                return "Hello, I am Alexa.";

            return GreetingMessage.Replace("{OwnerName}", OwnerName);
        }
    }
}
