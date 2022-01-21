using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    [UnitTitle("On Run Line")]
    [UnitCategory("Events\\YarnSpinner Dialogue View")]
    public class OnRunLine : EventUnit<RunLineArgs>
    {
        [DoNotSerialize]
        [PortLabelHidden]
        public ValueInput DialogueViewSource;

        //[DoNotSerialize]
        //public ValueOutput DialogueViewRef;

        [DoNotSerialize]
        public ValueOutput LocalisedLine { get; private set; }

        [DoNotSerialize]
        public ValueOutput Text { get; private set; }

        [DoNotSerialize]
        public ValueOutput Character { get; private set; }

        [DoNotSerialize]
        public ValueOutput TextNoChar { get; private set; }

        protected override bool register => true;

        public override EventHook GetHook(GraphReference reference)
        {
            return new EventHook(YSEventHooks.OnRunLine);
        }

        protected override void Definition()
        {
            base.Definition();

            DialogueViewSource = ValueInput<VisualRunLine>(nameof(VisualRunLine));

            //DialogueViewRef = ValueOutput<VisualScriptView>("Dialogue View");
            LocalisedLine = ValueOutput<LocalizedLine>("Localised Line");
            Text = ValueOutput<string>("Text");
            Character = ValueOutput<string>("Character Name");
            TextNoChar = ValueOutput<string>("Text no Character Name");
        }

        protected override bool ShouldTrigger(Flow flow, RunLineArgs args)
        {
            return flow.GetValue<VisualRunLine>(DialogueViewSource) == args.dialogueView;
        }

        protected override void AssignArguments(Flow flow, RunLineArgs args)
        {
            //flow.SetValue(DialogueViewRef, args.dialogueView);

            flow.SetValue(LocalisedLine, args.localizedLine);
            flow.SetValue(Text, args.localizedLine.Text.Text);
            flow.SetValue(Character, args.localizedLine.CharacterName);
            flow.SetValue(TextNoChar, args.localizedLine.TextWithoutCharacterName.Text);
        }
    }
}
