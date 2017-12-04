using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Stock : IStock
    {
        public string filePath { get; set; }

        public Stock(string filePath)
        {
            this.filePath = filePath;
        }

        public string AddItem<T>(T currentItem)
        {
            List<T> itemsList = Serializator.InitializeList<T>(filePath);

            foreach (T item in itemsList)
                if (currentItem.Equals(item))
                    return "Уже существует!";

            itemsList.Add(currentItem);
            Serializator.SerializeList(itemsList, filePath);

            return "Добавление выполнено успешно!";
        }

        public string DeleteItem<T>(T currentItem)
        {
            List<T> itemsList = Serializator.InitializeList<T>(filePath);

            foreach (T item in itemsList)
            {
                if (currentItem.Equals(item))
                {
                    itemsList.Remove(currentItem);
                    break;
                }
                if(itemsList.IndexOf(item) == itemsList.Count - 1)
                    return "Не существует!";
            }

            Serializator.SerializeList(itemsList, filePath);

            return "Удаление выполнено успешно!";
        }

        public List<T> GetListOfItems<T>()
        {
            return Serializator.InitializeList<T>(filePath);
        }
    }
}
