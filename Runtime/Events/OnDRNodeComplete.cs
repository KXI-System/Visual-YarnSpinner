using System;
using Unity.VisualScripting;

namespace VisualYarnSpinner
{
    [UnitTitle("DR On Node Complete")]
    [UnitCategory("Events/YarnSpinner Dialogue Runner")]
    public class OnDRNodeComplete : GameObjectEventUnit<string>
    {
        [DoNotSerialize]
        public ValueOutput output;

        protected override string hookName => YSEventHooks.OnDRNodeComplete;
        public override Type MessageListenerType => typeof(DROnNodeCompleteMessageListener);

        protected override void Definition()
        {
            base.Definition();

            output = ValueOutput<string>("Node Name");
        }

        protected override void AssignArguments(Flow flow, string args)
        {
            flow.SetValue(output, args);
        }
    }
}
