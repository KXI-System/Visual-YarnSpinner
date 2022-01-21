using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    [UnitTitle("Get Story String Variable")]
    [UnitCategory("YarnSpinner")]
    public class TryGetString : Unit
    {
        [DoNotSerialize]
        [PortLabelHidden]
        public ControlInput input;

        [DoNotSerialize]
        [PortLabelHidden]
        public ControlOutput output;

        [DoNotSerialize]
        public ControlOutput noOutput;

        [DoNotSerialize]
        public ValueInput VariableValue;

        [DoNotSerialize]
        public ValueInput MemoryStorage;

        [DoNotSerialize]
        public ValueOutput ValueOut;

        private string result;

        protected override void Definition()
        {
            input = ControlInput("input", (flow) =>
            {
                VariableStorageBehaviour varStorage = flow.GetValue<VariableStorageBehaviour>(MemoryStorage);
                string varName = flow.GetValue<string>(VariableValue);

                bool status = varStorage.TryGetValue<string>(varName, out result);

                return status ? output : noOutput;
            });

            noOutput = ControlOutput("Not Exist");
            output = ControlOutput("Exists");

            VariableValue = ValueInput<string>("Variable Name", "$");
            MemoryStorage = ValueInput<VariableStorageBehaviour>("Variable Storage");

            ValueOut = ValueOutput<string>("Value", (flow) => { return result; });

            Requirement(VariableValue, input);
            Succession(input, output);
            Assignment(input, ValueOut);
        }
    }
}
