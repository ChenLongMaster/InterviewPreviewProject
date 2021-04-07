using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace InterveiwPreview
{
    class MonotonicArray
    {
        public bool IsMonotonic(int[] A)
        {
            int store = 0;
            for(int i = 0; i <= A.Length - 2; i++)
            {
                var a = A[i].CompareTo(A[i + 1]);
                if(a != 0)
                {
                    if(a != store && store != 0)
                    {
                        return false;
                    }
                    store = a;
                }
            }
            return true;
        }
    }
}
