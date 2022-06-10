using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;

namespace SplitSumming
{
    public class SummingFactory : IComponentFactory
    {
        public string ComponentName => "Individual Split Summing v" + Version.ToString();
        
        public string Description => "Separate split times ";
        
        public ComponentCategory Category => ComponentCategory.Information;
        public IComponent Create(LiveSplitState state) { return new SumComponent(state); }
        public string UpdateName => ComponentName;
        public string UpdateURL => "https://raw.githubusercontent.com/skewbmaster/SADXSplitter/master/";
        public string XMLURL => UpdateURL + "Components/Updates.xml";
        public Version Version => Version.Parse("1.0.0");
    }
}