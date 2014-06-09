using System;
using System.Collections.Generic;
using System.Text;
using TK.BaseLib.Animation;
using System.ComponentModel;

namespace TK.GraphComponents.Animation
{
    public class ActionTunnel
    {
        public ActionTunnel(TK_Action inAction)
        {
            _action = inAction;

            _name = _action.Name;
            _category = _action.Category;
        }

        TK_Action _action = null;

        #region Properties

        [Browsable(false)]
        public TK_Action Action
        {
            get
            {
                return _action;
            }
        }

        string _name = "";
        public string ActionName
        {
            get { return _name; }
            set { _name = value; }
        }

        string _category = "";
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        [Browsable(false)]
        public bool Modified
        {
            get
            {
                return _name != _action.Name ||
                    _category != _action.Category;
            }
        #endregion

        }

        public void ValidateModifications()
        {
            _action.Name = _name;
            _action.Category = _category;
        }
    }
}
