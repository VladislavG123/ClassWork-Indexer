using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexPraactick
{
    public class ManualIndexex
    {
        private int[] _data;
        private int _size;
        private int _firstIndex;

        public ManualIndexex(int arraySize, int firstIndex)
        {
            _size = arraySize;
            _firstIndex = firstIndex;
            _data = new int[_size];
        }

        public int this[int index]
        {
            get { return _data[index - _firstIndex]; }
            set { _data[index - _firstIndex] = value; }
        }
    }
}
