using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.DesignPatterns.Core
{
    public class Podcast : ISubject
    {
        public ICollection<Episode> Episodes { get; }

        private ICollection<ISubscriber> subscribers;
        public Podcast(string title)
        {
            Title = title;
            Episodes = new List<Episode>();
            subscribers = new List<ISubscriber>();
        }

        public Podcast(string title, ICollection<Person> subscribers) : this(title)
        {
            this.subscribers = new List<ISubscriber>(subscribers);
        }
            
        public string Title { get; }

        public void AddEpisode(Episode episode)
        {
            Episodes.Add(episode);
            Notify(episode);
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Notify()
        {
            Notify(null);
        }

        public void Notify(Episode episode)
        {
            subscribers.ToList().ForEach(subscriber => subscriber.Update(this, episode));
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
    }
}
