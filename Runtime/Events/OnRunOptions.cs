using System.Collections.Generic;
using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    [UnitTitle("On Run Options")]
    [UnitCategory("Events\\YarnSpinner Dialogue View")]
    public class OnRunOptions : EventUnit<RunOptionsArgs>
    {
        [DoNotSerialize]
        [PortLabelHidden]
        public ValueInput DialogueViewSource;

        [DoNotSerialize]
        public ValueOutput DialogueOptionList;

        protected override bool register => true;

        public override EventHook GetHook(GraphReference reference)
        {
            return new EventHook(YSEventHooks.OnRunOptions);
        }

        protected override void Definition()
        {
            base.Definition();

            DialogueViewSource = ValueInput<VisualRunOptions>(nameof(VisualRunOptions));
            DialogueOptionList = ValueOutput<List<DialogueOption>>("Dialogue Options");
        }

        protected override bool ShouldTrigger(Flow flow, RunOptionsArgs args)
        {
            return flow.GetValue<VisualRunLine>(DialogueViewSource) == args.dialogueView;
        }

        protected override void AssignArguments(Flow flow, RunOptionsArgs args)
        {
            flow.SetValue(DialogueOptionList, args);
        }
    }
}
