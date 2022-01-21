using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    public class VisualRunOptions : DialogueViewBase
    {
        private Action<int> optionSelected;

        public void TriggerSelectOption(int optionID)
        {
            if (optionSelected == null)
            {
                Debug.LogWarning("Reached Trigger Select Option when the Dialogue View wasn't expecting to, are you using the node in the wrong place?");
                return;
            }
            else if (optionID < 0)
            {
                Debug.LogError("An invalid option ID of " + optionID + " was given");
                return;
            }

            optionSelected(optionID);
            optionSelected = null;
        }

        public override void RunOptions(DialogueOption[] dialogueOptions, Action<int> onOptionSelected)
        {
            optionSelected = onOptionSelected;
            EventBus.Trigger(YSEventHooks.OnRunOptions, new RunOptionsArgs(dialogueOptions.ToListPooled(), this));
        }
    }
}
