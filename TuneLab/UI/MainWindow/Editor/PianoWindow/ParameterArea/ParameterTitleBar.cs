using Avalonia.Media;
using System;
using TuneLab.GUI.Components;
using TuneLab.Utils;

namespace TuneLab.UI;

internal class ParameterTitleBar : MovableComponent
{
    public new event Action<double>? Moved;

    public ParameterTitleBar()
    {
        base.Moved.Subscribe(p => Moved?.Invoke(p.Y));
    }

    public override void Render(DrawingContext context)
    {
        context.FillRectangle(new Color(255, 169, 196, 118).ToBrush(), this.Rect());
    }
}
