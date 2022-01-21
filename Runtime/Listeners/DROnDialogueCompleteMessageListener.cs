using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    [UnityEngine.AddComponentMenu("")]
    public class DROnDialogueCompleteMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<DialogueRunner>()?.onDialogueComplete
                ?.AddListener(() => EventBus.Trigger(YSEventHooks.OnDialogueComplete, gameObject));
        }
    }
}