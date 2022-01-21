using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    public class VisualRunLine : DialogueViewBase
    {
        private Action lineFinished;

        public void TriggerDialogueLineFinished()
        {
            if (lineFinished == null)
            {
                Debug.LogWarning("We reached Trigger Dialogue Line Finished when the Dialogue View wasn't expecting to, are you using the node in the wrong place?");
                return;
            }

            lineFinished();
            lineFinished = null;
        }

        public override void RunLine(LocalizedLine dialogueLine, Action onDialogueLineFinished)
        {
            lineFinished = onDialogueLineFinished;
            EventBus.Trigger(YSEventHooks.OnRunLine, new RunLineArgs(dialogueLine, this));
        }
    }
}
