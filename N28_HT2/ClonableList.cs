using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT2
{
    public class ClonableList<TList> : List<TList>, ICloneable where TList : ICloneable
    {
        public object Clone()
        {
            ClonableList<TList> cloneList = new ClonableList<TList>();
            foreach (var item in this)
            {
                cloneList.Add((TList)item.Clone());
            }
            return cloneList;
        }

       
    }
}
