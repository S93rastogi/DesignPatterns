using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonPattern
    {
        private static SingletonPattern _singletonObject;
        public static SingletonPattern SingletonObject
        {
            get
            {
                if (_singletonObject != null) return _singletonObject;
                _singletonObject = new SingletonPattern();
                return _singletonObject;

            }
        }

        private SingletonPattern(){}

        public string Message { get; set; }
    }
    
}
