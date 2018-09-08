using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpDrill22
{
    class Program
    {
        static void Main()
        {
            
            const string messageTwoPart1 = "Hello there, my name";
            const string messageTwoPart2 = " is Samir Mayfield";
            
            var messageDisplayTwo = new MessageBuilder(messageTwoPart1, messageTwoPart2);
           
            messageDisplayTwo.DisplayMessage();
            Console.ReadLine();
        }
    }
    class MessageBuilder
    {
        public MessageBuilder(string oneMessage) : this(oneMessage, "") { }
        public MessageBuilder(string oneMessage, string secondMessage)
        {
            FullMessage = oneMessage + secondMessage;
        }
        public string FullMessage { get; set; }
        public void DisplayMessage()
        {
            Console.WriteLine(FullMessage);
        }
    }
}