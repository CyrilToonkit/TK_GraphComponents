using System;
using System.Collections.Generic;
using System.Text;

namespace TK.GraphComponents
{
    public interface IDroppableCollection
    {
        List<DraggableTB> MapItems
        {
            get;
            set;
        }

        void RemoveItem(string TBText);

        void AddItem(string TBText);
    }
}