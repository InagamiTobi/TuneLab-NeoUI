using Avalonia.Media;

namespace TuneLab.GUI;

internal static class Style
{
    public static readonly Color TRANSPARENT = new(0, 0, 0, 0);
    public static readonly Color WHITE = new(255, 255, 255, 255);
    public static readonly Color LIGHT_WHITE = new(255, 220, 220, 220);
    public static readonly Color BLACK = new(255, 0, 0, 0);
    public static readonly Color TOOL_TIP_BACK = new(255, 118, 179, 196);
    public static readonly Color DARK = new(255, 25, 25, 25);
    public static readonly Color BACK = new(255, 50, 50, 50);
    public static readonly Color INTERFACE = new(255, 75, 75, 75);
    public static readonly Color LINE = new((int)(0.2 * 255), 196, 196, 196);
    public static readonly Color ITEM = new(255, 118, 137, 196);
    public static readonly Color HIGH_LIGHT = new(255, 118, 179, 196);
    public static readonly Color TEXT_NORMAL = new((int)(0.7 * 255), 255, 255, 255);
    public static readonly Color TEXT_LIGHT = new(255, 255, 255, 255);
    public static readonly Color WHITE_KEY = new(255, 50, 50, 50);
    public static readonly Color BLACK_KEY = new(255, 25, 25, 25);
    public static readonly Color BUTTON_PRIMARY = new(255, 118, 179, 196);
    public static readonly Color BUTTON_NORMAL = new(255, 196, 181, 118);
    public static readonly Color BUTTON_PRIMARY_HOVER = new(255, 118, 196, 160);
    public static readonly Color BUTTON_NORMAL_HOVER = new(255, 196, 137, 118);

    public static readonly Color AMP_NORMAL = new(255, 169, 196, 118);
    public static readonly Color AMP_DELAY = new((int)(0.5 * 255), 196, 118, 118);

    public static readonly string[] TRACK_COLORS =
    [
        "#d4a5a5",
        "#d4b2a5",
        "#d4d0a5",
        "#c4d4a5",
        "#a5d4a8",
        "#a5d4c4",
        "#a5c9d4",
        "#a5b8d4",
        "#a5a8d4",
        "#b8a5d4",
        "#d4a5c9",
        "#d4a5b8",
    ];

    public static Color DefaultTrackColor => Color.Parse(TRACK_COLORS[0]);

    public static string GetNewColor(int index)
    {
        return TRACK_COLORS[index % TRACK_COLORS.Length];
    }
}
