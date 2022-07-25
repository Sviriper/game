using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class ListExecuteObject : IEnumerable, IEnumerator
    {
        private IExecute[] _interactiveObject;
        private int _index = -1;

        public object Current => _interactiveObject[_index];
        public int Length => _interactiveObject.Length;
        public IExecute this[int curr]
        {
            get => _interactiveObject[curr];
            private set => _interactiveObject[curr] = value;
        }
        public ListExecuteObject()
        {

        }

        public void AddExecuteObject(IExecute execute)
        {
            if (_interactiveObject == null)
            {
                _interactiveObject = new[] { execute };
                return;
            }
            Array.Resize(ref _interactiveObject, Length + 1);
            _interactiveObject[_index - 1] = execute;
        }

        public bool MoveNext()
        {
            if (_index == Length - 1)
            {
                return false;
            }
            _index++;
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return (IEnumerator<int>)this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}