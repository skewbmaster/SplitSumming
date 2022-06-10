using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.ComponentUtil;
using LiveSplit.Model;
using LiveSplit.Options;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace SplitSumming
{
    public class SumComponent : LogicComponent
    {
        private SummingSettings Settings { get; set; }
        public LiveSplitState state;

        public SumComponent(LiveSplitState state)
        {
            Settings = new SummingSettings();
            this.state = state;
        }
        
        public override Control GetSettingsControl(LayoutMode mode)
        {
            return Settings;
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public override void SetSettings(XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        public override string ComponentName => "SplitSumming";

        public override void Dispose()
        {
        }
        
        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) { }
    }
}