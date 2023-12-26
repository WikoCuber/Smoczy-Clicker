namespace SC_Scripts.Scripts_Helpers
{
    public partial class ScriptsUtilities
    {
        //Takes screenshot
        public static Bitmap CaptureFromScreen()
        {
            Bitmap captureBitmap = new(Screen.PrimaryScreen!.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

            Graphics captureGraphics = Graphics.FromImage(captureBitmap);

            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size); //Take screenshot
            captureGraphics.Dispose();

            return captureBitmap;
        }

        //Gets color from bitmap at specific coordinates
        public static Color GetColorFromBitmap(Point coordinates, Bitmap bitmap) =>
            bitmap.GetPixel(coordinates.X, coordinates.Y);
    }
}
