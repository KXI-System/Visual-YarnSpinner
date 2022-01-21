using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    public class VisualDismissComplete : DialogueViewBase
    {
        private Action dismissalComplete;

        public void TriggerFinishAction()
        {
            if (dismissalComplete == null)
            {
                Debug.LogWarning("We reached Trigger Dismissal Complete when the Dialogue View wasn't expecting to, are you using the node in the wrong place?");
                return;
            }

            dismissalComplete();
            dismissalComplete = null;
        }

        public override void DismissLine(Action onDismissalComplete)
        {
            EventBus.Trigger(YSEventHooks.OnDismissLine);
            dismissalComplete = onDismissalComplete;
        }
    }
}
