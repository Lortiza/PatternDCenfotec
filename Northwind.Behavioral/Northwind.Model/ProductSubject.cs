using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Model
{
    public class ProductSubject : ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        Product p;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(p);
            }
        }

        public void PriceChange(Product p)
        {
            this.p = p;

            NotifyObservers();
        }
    }
}
