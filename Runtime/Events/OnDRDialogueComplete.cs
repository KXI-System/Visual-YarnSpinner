using System;
using Unity.VisualScripting;

namespace VisualYarnSpinner
{
    [UnitTitle("DR On Dialogue Complete")]
    [UnitCategory("Events/YarnSpinner Dialogue Runner")]
    public class OnDRDialogueComplete : GameObjectEventUnit<EmptyEventArgs>
    {
        protected override string hookName => YSEventHooks.OnDRNodeStart;
        public override Type MessageListenerType => typeof(DROnNodeStartMessageListener);
    }
}
