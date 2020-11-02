using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectGeneratorProject.Classes
{
    class ObjectGenerator
    {
        public T GetNewObject<T>() where T: new()
        {
            return new T();
        }

        public T GetNewObject<T>(string str) where T : Animal
        {
            return (T)Activator.CreateInstance(typeof(T), str);
        }

        public List<T> GetNewObjects<T>(int amountOfObjects) where T : new()
        {
            List<T> objectList = new List<T>();

            for (int i = 0; i < amountOfObjects; i++)
            {
                objectList.Add(new T());
            }

            return objectList;
        }

        public List<T> GetNewObjects<T>(string[] names) where T : Animal
        {
            List<T> objectList = new List<T>();

            for (int i = 0; i < names.Length; i++)
            {
                objectList.Add((T)Activator.CreateInstance(typeof(T), names[i]));
            }

            return objectList;
        }
    }
}
