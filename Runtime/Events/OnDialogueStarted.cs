using Unity.VisualScripting;

namespace VisualYarnSpinner
{
    [UnitTitle("On Dialogue Started")]
    [UnitCategory("Events\\YarnSpinner Dialogue View")]
    public class OnDialogueStarted : EventUnit<EmptyEventArgs>
    {
        protected override bool register => true;

        public override EventHook GetHook(GraphReference reference)
        {
            return new EventHook(YSEventHooks.OnDialogueStarted);
        }
    }
}
