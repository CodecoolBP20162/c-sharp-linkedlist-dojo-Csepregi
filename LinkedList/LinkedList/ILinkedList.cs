using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public interface ILinkedList
    {

        int Length
        {
            get;
            set;
        }

        Boolean IsEmpty
        {
            get;
        }

        void Add();

        void Insert();

        void Remove();
    }
}
