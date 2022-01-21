using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    public class VisualNodeComplete : DialogueViewBase
    {
        private Action nodeComplete;

        private void TriggerFinishAction()
        {
            if (nodeComplete == null)
            {
                Debug.LogWarning("We reached Trigger Node On Complete when the Dialogue View wasn't expecting to, are you using the node in the wrong place?");
                return;
            }

            nodeComplete();
            nodeComplete = null;
        }

        public override void NodeComplete(string nextNode, Action onComplete)
        {
            EventBus.Trigger(YSEventHooks.OnNodeComplete, this);
            nodeComplete = onComplete;
        }
    }
}
