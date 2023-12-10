using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.DesignPatterns.Core
{
    public class Person
    {
        public string Name { get; set; }

        private void SendMessage(Episode episode)
        {
            Console.WriteLine($"A new episode was added: {episode.Name}");
        }
    }
}
