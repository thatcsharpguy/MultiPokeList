using CoreGraphics;
using Foundation;
using UIKit;

namespace MultiPokeListView.iOS.Controls
{

    public enum CheckState
    {
        Unchecked,
        Checked,
        Unknown
    }

    public enum CheckAlignment
    {
        Right,
        Left,
        Center
    }


    [Register("CheckView")]
    public class CheckView : UIView
    {
        public const float kBoxSize = 0.875f;
        public const float kCheckHorizontalExtention = 0.125f;
        public const float kCheckVerticalExtension = 0.125f;
        public const float kCheckIndent = 0.125f;
        public const float kCheckRaise = 0.1875f;
        public const float kCheckSize = 0.8125f;
        public const float kCheckBoxSpacing = 0.3125f;
        public const float kM13CheckboxMaxFontSize = 100.0f;

        public M13Checkbox Checkbox { get; set; }

        public bool IsSelected { get; set; }

        public CheckView(CGRect frame)
            : base(frame)
        {
            
        }

        public override void Draw(CGRect rect)
        {
            //// General Declarations
            CGColorSpace colorSpace = CGColorSpace.CreateDeviceRGB();
            CGContext context = UIGraphics.GetCurrentContext();

            // Set area
            CGRect boxRect = new CGRect(Checkbox.StrokeWidth, 
                                 (Frame.Size.Height * kCheckVerticalExtension), 
                                 (Frame.Size.Height * kBoxSize) - Checkbox.StrokeWidth, 
                                 (Frame.Size.Height * kBoxSize) - Checkbox.StrokeWidth);

            UIColor fillColor = null;
            UIColor strokeColor = null;
            UIColor checkColor = null;

            if (Checkbox.CheckState == CheckState.Unchecked)
            {
                fillColor = Checkbox.UncheckedColor;
            }
            else
            {
                fillColor = Checkbox.TintColor;
            }

            System.nfloat r, g, b, a;
            if (IsSelected)
            {
                fillColor.GetRGBA(out r, out g, out b, out a);
            }

            if (!Checkbox.Enabled)
            {
                fillColor.GetRGBA(out r, out g, out b, out a);   
                fillColor = UIColor.FromRGBA(r + new System.nfloat(0.2),
                    g + new System.nfloat(0.2), 
                    b + new System.nfloat(0.2), 
                    a);
                Checkbox.StrokeColor.GetRGBA(out r, out g, out b, out a);      
                strokeColor = UIColor.FromRGBA(r + new System.nfloat(0.2),
                    g + new System.nfloat(0.2), 
                    b + new System.nfloat(0.2), 
                    a);
                Checkbox.CheckColor.GetRGBA(out r, out g, out b, out a);      
                checkColor = UIColor.FromRGBA(r + new System.nfloat(0.2),
                    g + new System.nfloat(0.2), 
                    b + new System.nfloat(0.2), 
                    a);
            }
            else
            {
                strokeColor = Checkbox.StrokeColor;
                checkColor = Checkbox.StrokeColor;
            }


            // Draw (flat)
            // missing chunk of code https://github.com/Marxon13/M13Checkbox/blob/master/Classes/M13Checkbox.m
            UIBezierPath boxPath = UIBezierPath.FromRoundedRect(boxRect, Checkbox.Radius);
            fillColor.SetFill();
            boxPath.Fill();
            strokeColor.SetStroke();
            boxPath.LineWidth = Checkbox.StrokeWidth;
            boxPath.Stroke();


            switch (Checkbox.CheckState)
            {
                case CheckState.Unchecked:
                    break;
                case CheckState.Checked:
                    checkColor.SetFill();
                    Checkbox.DefaultShape.Fill();
                    break;
                case CheckState.Unknown:
                    var rct = new CGRect(
                                  Checkbox.StrokeWidth + ((boxRect.Size.Width - (0.5 * Frame.Size.Height)) * 0.5), 
                                  (Frame.Size.Height * .5) - ((0.09375 * Frame.Size.Height) * .5),
                                  0.5 * Frame.Size.Height,
                                  0.1875 * Frame.Size.Height);
                    UIBezierPath mixedPath = UIBezierPath.FromRoundedRect(rct, (System.nfloat)(0.09375 * Frame.Size.Height));
                    checkColor.SetFill();
                    mixedPath.Fill();
                    break;

            }

            colorSpace.Dispose();
        }
    }

}