using System;
using System.Collections;
using System.Collections.Generic;

namespace Day13
{
    public class QueueEnumerator<T> : IEnumerator<T>
    {
        private Queue<T> sourceQueue;
        private Queue<T>.QueueElement currentQueueElement;

        public QueueEnumerator(Queue<T> queue) => sourceQueue = queue;

        public T Current => currentQueueElement.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {            
        }

        public bool MoveNext()
        {
            if (currentQueueElement == null)
            {
                currentQueueElement = sourceQueue.First;
            }
            else
            {
                currentQueueElement = currentQueueElement.Next;
            }

            if (currentQueueElement != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
