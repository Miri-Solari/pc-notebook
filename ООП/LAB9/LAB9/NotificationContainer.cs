using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9
{
    internal class NotificationContainer<T> where T : Notification, IComparable
    {
        List<T> _notifications = new List<T>();

        public void Add(T item)
        {
            _notifications.Add(item);
        }

        public T Get(int id)
        {
            return _notifications[id];
        }

        public bool CheckAvailability()
        {
            return _notifications.Count > 0;
        }
    }
}
