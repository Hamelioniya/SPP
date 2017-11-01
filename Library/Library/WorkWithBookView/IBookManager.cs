using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface IBookManager
    {
        string[] CreateListOfBooks(IBDManager fileReader);
    }
}
