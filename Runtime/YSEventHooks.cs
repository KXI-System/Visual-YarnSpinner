namespace VisualYarnSpinner
{
    public static class YSEventHooks
    {
        // Dialogue View Commands
        public const string OnDialogueStarted = "DialogueStarted";

        public const string OnRunLine = "RunLine";
        public const string OnLineStatusChanged = "LineStatusChanged";
        public const string OnDismissLine = "DismissLine";
        public const string OnRunOptions = "RunOptions";
        public const string OnNodeComplete = "NodeComplete";
        public const string OnDialogueComplete = "DialogueComplete";

        // Dialogue Runner Commands
        public const string OnDRNodeStart = "OnDRNodeStart";

        public const string OnDRNodeComplete = "OnDRNodeComplete";
        public const string OnDRDialogueComplete = "OnDRDialogueComplete";
        public const string OnDRCommand = "OnDRCommand";
    }
}
