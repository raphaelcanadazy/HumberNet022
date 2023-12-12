using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Program<T> where T: struct // 1.constrains the class based on value types
    {
        // 2.contains a private generic collection
        private List<T> _list;

        public Program()
        {
            _list = new List<T>();
        }

        // 3.add items to the private collection
        public void Add(T item) => _list.Add(item);

        // 4.return an item from the list. eg. input a number
        public T GetItem(int index) => _list[index];

        // 5.return a sorted collection with the items in descending order
        public List<T> DescendSort()
        {
            var results = _list;
            results.Sort();
            results.Reverse();
            return results;
        }
    }
}
