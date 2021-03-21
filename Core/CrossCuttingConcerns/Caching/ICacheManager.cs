using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key);  //cache de var mı yoksa veritabanından getirilir 
        void Remove(string key);  //cache den uçurma
        void RemoveByPattern(string pattern); //cacheden neyi uçuracağım hangi bilgiyi

    }
}
