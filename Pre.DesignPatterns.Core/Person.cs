using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.DesignPatterns.Core
{
    public class Person : ISubscriber
    {
        public string Name { get; set; }

        public void Update(ISubject subject, Episode episode)
        {
            SendMessage(episode);
        }

        private void SendMessage(Episode episode)
        {
            Console.WriteLine($"A new episode was added: {episode.Name}");
        }
    }
}
