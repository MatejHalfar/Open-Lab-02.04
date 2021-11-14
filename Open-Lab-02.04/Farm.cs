using System;

namespace Open_Lab_02._04
{
    class Farm
    {
        public int GetLegsCount(int slepice, int kravky, int prasatka)
        {
            return slepice * 2 + kravky * 4 + prasatka * 4;
        }
    }
}
