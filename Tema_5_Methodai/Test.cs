using System;

namespace Tema_5_Methodai
{
    public class Test
    {
        private void PrivateSayHello(string name) 
        {
            Console.WriteLine($"Hello {name}");
        }

        public void SayHelloPublic(string name) 
        {
            Console.WriteLine($"Hello {name}");
        }

        public void SayHelloByUsingPrivate(string name) 
        {
            PrivateSayHello(name);
        }
    }
}
