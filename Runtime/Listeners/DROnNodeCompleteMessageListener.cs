using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    [UnityEngine.AddComponentMenu("")]
    public class DROnNodeCompleteMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<DialogueRunner>()?.onNodeComplete
                ?.AddListener((val) => EventBus.Trigger(YSEventHooks.OnDRDialogueComplete, gameObject, val));
        }
    }
}
