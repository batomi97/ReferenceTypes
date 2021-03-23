using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryHW
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _arrayKey;
        TValue[] _arrayValue;

        TKey[] _tempKey;
        TValue[] _tempValue;

        public MyDictionary()
        {
            _arrayKey = new TKey[0];
            _arrayValue = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempKey = _arrayKey;
            _tempValue = _arrayValue;

            _arrayKey = new TKey[_arrayKey.Length + 1];
            _arrayValue = new TValue[_arrayValue.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _arrayKey[i] = _tempKey[i];
                _arrayValue[i] = _tempValue[i];
            }

            _arrayKey[_arrayKey.Length - 1] = key;
            _arrayValue[_arrayValue.Length - 1] = value;
        }

        public int Count
        {
            get { return _arrayKey.Length; }
        }

        public TValue[] Values
        {
            get { return _arrayValue; }
        }

        public TKey[] Keys
        {
            get { return _arrayKey; }
        }
    }
}
