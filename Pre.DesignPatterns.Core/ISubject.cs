using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.DesignPatterns.Core
{
    public interface ISubject
    {
        public void AddSubscriber(ISubscriber subscriber);
        public void RemoveSubscriber(ISubscriber subscriber);
        public void Notify(Episode episode);    
    }
}
