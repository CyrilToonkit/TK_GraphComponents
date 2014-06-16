using System;
using System.Collections.Generic;
using System.Text;

namespace TK.GraphComponents.Animation
{
    class ActionsEditor
    {
        List<ActionTunnel> _actions = new List<ActionTunnel>();
        public List<ActionTunnel> Actions
        {
            get { return _actions; }
        }

        public List<ActionTunnel> SetActions(List<ActionCtrl> inActionsCtrls)
        {
            _actions.Clear();

            foreach (ActionCtrl ctrl in inActionsCtrls)
            {
                _actions.Add(new ActionTunnel(ctrl.Action));
            }

            return _actions;
        }

        public bool IsReady
        {
            get { return _actions.Count > 0; }
        }

        public bool IsModified
        {
            get
            {
                foreach (ActionTunnel act in _actions)
                {
                    if (act.Modified)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public void ValidateModifications()
        {
            foreach (ActionTunnel act in _actions)
            {
                act.ValidateModifications();
            }
        }
    }
}
