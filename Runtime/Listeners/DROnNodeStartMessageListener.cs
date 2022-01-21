using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    [UnityEngine.AddComponentMenu("")]
    public sealed class DROnNodeStartMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<DialogueRunner>()?.onNodeStart
                ?.AddListener((val) => EventBus.Trigger(YSEventHooks.OnDRNodeStart, gameObject, val));
        }
    }
}
