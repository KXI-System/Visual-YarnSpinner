using System.Collections.Generic;
using Unity.VisualScripting;
using Yarn.Unity;

namespace VisualYarnSpinner
{
    public struct RunOptionsArgs
    {
        public List<DialogueOption> dialogueOptions;
        public VisualRunOptions dialogueView;

        public RunOptionsArgs(List<DialogueOption> o, VisualRunOptions v)
        {
            dialogueOptions = o;
            dialogueView = v;
        }
    }

    public struct RunLineArgs
    {
        public LocalizedLine localizedLine;
        public VisualRunLine dialogueView;

        public RunLineArgs(LocalizedLine l, VisualRunLine v)
        {
            localizedLine = l;
            dialogueView = v;
        }
    }

    public struct NodeCompleteArgs
    {
        public string nextNode;
        public VisualNodeComplete dialogueView;

        public NodeCompleteArgs(string n, VisualNodeComplete v)
        {
            nextNode = n;
            dialogueView = v;
        }
    }
}
