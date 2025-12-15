using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuneLab.Base.Structures;
using TuneLab.Extensions.Voices;

namespace TuneLab;

internal static class ConstantDefine
{
    public static readonly string PitchID = "Pitch";
    public static readonly string PitchName = "Pitch";
    public static readonly string PitchColor = "#C47676";
    public static readonly string VolumeID = "Volume";
    public static readonly string VibratoEnvelopeID = "VibratoEnvelope";
    public static readonly IReadOnlyOrderedMap<string, AutomationConfig> PreCommonAutomationConfigs = new OrderedMap<string, AutomationConfig>()
    {
        { VolumeID, new AutomationConfig("音量", 0, -12, +12, "#C4B576") }
    };
    public static readonly IReadOnlyOrderedMap<string, AutomationConfig> PostCommonAutomationConfigs = new OrderedMap<string, AutomationConfig>()
    {
        { VibratoEnvelopeID, new AutomationConfig("颤音", 1, 0, 2, "#76C479") }
    };
}
