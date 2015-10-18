using System.Numerics;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Microsoft.Graphics.Canvas.UI.Xaml;

namespace IoTCanvas
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Canvas_Draw(CanvasControl sender, CanvasDrawEventArgs args)
        {
            var a = new Vector2(10, 10);
            var b = new Vector2(100, 100);

            args.DrawingSession.DrawLine(a, b, Colors.Yellow);
        }
    }
}
