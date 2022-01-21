using System;
using Unity.VisualScripting;

namespace VisualYarnSpinner
{
    [UnitTitle("DR On Command")]
    [UnitCategory("Events/YarnSpinner Dialogue Runner")]
    public class OnDRCommand : GameObjectEventUnit<string>
    {
        [DoNotSerialize]
        public ValueOutput output;

        protected override string hookName => YSEventHooks.OnDRCommand;
        public override Type MessageListenerType => typeof(DROnCommandMessageListener);

        protected override void Definition()
        {
            base.Definition();

            output = ValueOutput<string>("Command Text");
        }

        protected override void AssignArguments(Flow flow, string args)
        {
            flow.SetValue(output, args);
        }
    }
}
