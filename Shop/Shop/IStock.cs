using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public interface IStock
    {
        string filePath { get; set; }
        string AddItem<T>(T currentItem);
        string DeleteItem<T>(T currentItem);
        List<T> GetListOfItems<T>();
    }
}
