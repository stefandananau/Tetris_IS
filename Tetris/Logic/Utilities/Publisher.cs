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
