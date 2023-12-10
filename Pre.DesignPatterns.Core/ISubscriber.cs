using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.DesignPatterns.Core
{
    public interface ISubscriber
    {
        public void Update(ISubject subject, Episode episode);
    }
}
