using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    [UnitTitle("On Line Status Changed")]
    [UnitCategory("Events\\YarnSpinner Dialogue View")]
    public class OnLineStatusChanged : EventUnit<LocalizedLine>
    {
        [DoNotSerialize]
        public ValueOutput LineStatus;

        protected override bool register => true;

        protected override void Definition()
        {
            base.Definition();
            LineStatus = ValueOutput<LineStatus>("Line Status");
        }

        protected override void AssignArguments(Flow flow, LocalizedLine Line)
        {
            flow.SetValue(LineStatus, Line.Status);
        }
    }
}
