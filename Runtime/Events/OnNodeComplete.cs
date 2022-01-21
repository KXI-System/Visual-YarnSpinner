using Unity.VisualScripting;

namespace VisualYarnSpinner
{
    [UnitTitle("On Node Complete")]
    [UnitCategory("Events\\YarnSpinner Dialogue View")]
    public class OnNodeComplete : EventUnit<NodeCompleteArgs>
    {
        [DoNotSerialize]
        [PortLabelHidden]
        public ValueInput DialogueViewSource;

        [DoNotSerialize]
        public ValueOutput NodeName;

        protected override bool register => true;

        public override EventHook GetHook(GraphReference reference)
        {
            return new EventHook(YSEventHooks.OnNodeComplete);
        }

        protected override void Definition()
        {
            base.Definition();

            DialogueViewSource = ValueInput<VisualRunOptions>(nameof(VisualRunOptions));
            NodeName = ValueOutput<string>("Next Node");
        }

        protected override bool ShouldTrigger(Flow flow, NodeCompleteArgs args)
        {
            return flow.GetValue<VisualRunLine>(DialogueViewSource) == args.dialogueView;
        }

        protected override void AssignArguments(Flow flow, NodeCompleteArgs args)
        {
            flow.SetValue(NodeName, args.nextNode);
        }
    }
}
