using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;

namespace XProtection;

public class GradientLabel : Label
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color Color1 { get; set; } = Color.FromArgb(50, 100, 200);

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color Color2 { get; set; } = Color.FromArgb(230, 130, 40);
    
    public GradientLabel()
    {
        DoubleBuffered = true;
        BackColor = Color.Transparent;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        e.Graphics.Clear(BackColor);

        using var brush = new LinearGradientBrush(
            ClientRectangle, Color1, Color2, LinearGradientMode.Horizontal);

        var sf = new StringFormat
        {
            Alignment = TextAlign switch
            {
                ContentAlignment.MiddleCenter => StringAlignment.Center,
                ContentAlignment.MiddleRight => StringAlignment.Far,
                ContentAlignment.TopRight => StringAlignment.Far,
                ContentAlignment.BottomRight => StringAlignment.Far,
                _ => StringAlignment.Near
            },
            LineAlignment = TextAlign switch
            {
                ContentAlignment.MiddleLeft or ContentAlignment.MiddleCenter or ContentAlignment.MiddleRight => StringAlignment.Center,
                ContentAlignment.BottomLeft or ContentAlignment.BottomCenter or ContentAlignment.BottomRight => StringAlignment.Far,
                _ => StringAlignment.Near
            }
        };

        e.Graphics.DrawString(Text, Font, brush, ClientRectangle, sf);
    }
}