using System;
using Unity.VisualScripting;

namespace VisualYarnSpinner
{
    [UnitTitle("DR On Node Start")]
    [UnitCategory("Events/YarnSpinner Dialogue Runner")]
    public sealed class OnDRNodeStart : GameObjectEventUnit<string>
    {
        [DoNotSerialize]
        public ValueOutput output;

        protected override string hookName => YSEventHooks.OnDRNodeStart;
        public override Type MessageListenerType => typeof(DROnNodeStartMessageListener);

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
