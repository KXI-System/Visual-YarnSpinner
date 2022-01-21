using System;
using UnityEngine;
using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    public class VisualEventsView : DialogueViewBase
    {
        public override void DialogueStarted()
        {
            EventBus.Trigger(YSEventHooks.OnDialogueStarted);
        }

        public override void OnLineStatusChanged(LocalizedLine dialogueLine)
        {
            EventBus.Trigger(YSEventHooks.OnLineStatusChanged, dialogueLine);
        }

        public override void DialogueComplete()
        {
            EventBus.Trigger(YSEventHooks.OnDialogueComplete);
        }
    }
}
