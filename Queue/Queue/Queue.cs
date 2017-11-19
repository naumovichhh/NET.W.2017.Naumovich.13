using System.Collections;
using System.Collections.Generic;

namespace Day13
{
    public class Queue<T> : IEnumerable<T>
    {
        private QueueElement first, last;

        public QueueElement First
        {
            get { return first; }
        }

        public QueueElement Last
        {
            get { return last; }
        }

        public bool IsEmpty
        {
            get
            {
                if (first == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Enqueue(T value)
        {
            var newQueueElement = new QueueElement(value, last);
            if (IsEmpty)
            {
                first = last = newQueueElement;
            }
            else
            {
                last.Next = newQueueElement;
                last = last.Next;
            }
        }

        public T Dequeue()
        {
            QueueElement retrieved = first;
            first = first.Next;
            if (first != null)
            {
                first.Prev = null;
            }
            else
            {
                last = null;
            }

            return retrieved.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class QueueElement
        {           
            public QueueElement(T value, QueueElement prev)
            {
                this.Value = value;
                this.Prev = prev;
            }

            public QueueElement Next
            {
                get; set;
            }

            public QueueElement Prev
            {
                get; set;
            }

            public T Value
            {
                get;
            }
        }
    }
}
