using Unity.VisualScripting;

namespace VisualYarnSpinner
{
    [UnitTitle("On Dismiss Line")]
    [UnitCategory("Events\\YarnSpinner Dialogue View")]
    public class OnDismissLine : EventUnit<VisualDismissComplete>
    {
        [DoNotSerialize]
        public ValueInput DialogueViewSource;

        protected override bool register => true;

        public override EventHook GetHook(GraphReference reference)
        {
            return new EventHook(YSEventHooks.OnDismissLine);
        }

        protected override void Definition()
        {
            base.Definition();
            DialogueViewSource = ValueInput<VisualDismissComplete>(nameof(VisualDismissComplete));
        }

        protected override bool ShouldTrigger(Flow flow, VisualDismissComplete args)
        {
            return flow.GetValue<VisualDismissComplete>(DialogueViewSource) == args;
        }

        protected override void AssignArguments(Flow flow, VisualDismissComplete view)
        {
            flow.SetValue(DialogueViewSource, view);
        }
    }
}
