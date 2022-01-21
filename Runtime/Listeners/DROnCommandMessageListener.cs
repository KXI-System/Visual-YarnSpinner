using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    [UnityEngine.AddComponentMenu("")]
    public class DROnCommandMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<DialogueRunner>()?.onCommand
                ?.AddListener((val) => EventBus.Trigger(YSEventHooks.OnDRCommand, gameObject, val));
        }
    }
}
