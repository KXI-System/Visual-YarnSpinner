using Unity.VisualScripting;

namespace VisualYarnSpinner
{
    [UnitTitle("On Dialogue Complete")]
    [UnitCategory("Events\\YarnSpinner Dialogue View")]
    public class OnDialogueComplete : EventUnit<EmptyEventArgs>
    {
        protected override bool register => true;

        public override EventHook GetHook(GraphReference reference)
        {
            return new EventHook(YSEventHooks.OnDialogueComplete);
        }
    }
}
