using System.Collections.Generic;

namespace Logic.Utilities
{
    public abstract class Publisher
    {
        private List<Subscriber> subscribers;

        protected Publisher() 
        { 
        }

        public void Notify()
        {
            if(subscribers == null)
            {
                return;
            }
            foreach (var subscriber in subscribers)
            {
                subscriber.Update();
            }
        }

        public void AddSubscriber(Subscriber subscriber)
        {
            if(subscribers == null)
            {
                subscribers = new List<Subscriber>();
            }
            subscribers.Add(subscriber);
        }
        
    }
}
