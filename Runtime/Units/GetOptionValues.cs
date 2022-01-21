using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    [UnitTitle("Get Simple Option Values")]
    [UnitCategory("YarnSpinner")]
    public class GetOptionValues : Unit
    {
        //[DoNotSerialize]
        //[PortLabelHidden]
        //public ControlInput input;

        //[DoNotSerialize]
        //[PortLabelHidden]
        //public ControlOutput output;

        [DoNotSerialize]
        public ValueInput DialogueOption;

        [DoNotSerialize]
        public ValueOutput DialogueText;

        [DoNotSerialize]
        public ValueOutput DialogueID;

        [DoNotSerialize]
        public ValueOutput isAvailable;

        protected override void Definition()
        {
            //input = ControlInput("input", (flow) =>
            //{
            //    return output;
            //});

            //output = ControlOutput("output");

            DialogueOption = ValueInput<DialogueOption>("Dialogue Option");

            DialogueText = ValueOutput<string>("Dialogue Text", (flow) =>
            {
                return flow.GetValue<DialogueOption>(DialogueOption).Line.Text.Text;
            });

            DialogueID = ValueOutput<int>("Option ID", (flow) =>
            {
                return flow.GetValue<DialogueOption>(DialogueOption).DialogueOptionID;
            });

            isAvailable = ValueOutput<bool>("is Available", (flow) =>
            {
                return flow.GetValue<DialogueOption>(DialogueOption).IsAvailable;
            });

            //Requirement(DialogueOption, input);
            //Succession(input, output);
        }
    }
}
