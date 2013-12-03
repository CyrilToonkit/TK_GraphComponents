using System;
using System.Collections.Generic;
using System.Text;

namespace TK.GraphComponents.Animation
{
    class ActionSorter : IComparer<ActionCtrl>
    {
        public Fields Field = Fields.Name;

        /// <summary> 
        /// constructor to set the sort column and sort order. 
        /// </summary> 
        /// <param name="strMemberName"></param> 
        /// <param name="sortingOrder"></param> 
        public ActionSorter(Fields inField)
        {
            Field = inField;
        }

        public int Compare(ActionCtrl Action1, ActionCtrl Action2)
        {
            switch (Field)
            {
                case Fields.Date:
                    return Action1.Action.Birth.CompareTo(Action2.Action.Birth);
                case Fields.Type:
                    return Action1.Action.Type.CompareTo(Action2.Action.Type);
                case Fields.Length:
                    return Action1.Action.Duration.CompareTo(Action2.Action.Duration);
                case Fields.User:
                    return Action1.Action.CreatorName.CompareTo(Action2.Action.CreatorName);
            }

            return Action1.Action.Name.CompareTo(Action2.Action.Name);
        }
    } 

}
