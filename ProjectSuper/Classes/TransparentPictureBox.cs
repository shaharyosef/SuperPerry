using System.Drawing;
using System.Windows.Forms;

public class TransparentPictureBox : PictureBox
{
    public TransparentPictureBox()
    {
        // Set the control style to enable transparency and reduce flickering
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.Opaque, true);
        SetStyle(ControlStyles.DoubleBuffer, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        // Set the control's background to transparent
        e.Graphics.Clear(Color.Transparent);

        // Draw the image with transparency
        if (Image != null)
        {
            e.Graphics.DrawImage(Image, new Point(0, 0));
        }
    }
}
