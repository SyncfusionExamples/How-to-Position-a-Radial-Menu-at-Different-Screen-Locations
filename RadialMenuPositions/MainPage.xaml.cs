namespace RadialMenuPositions
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private const double EdgeInset = 120;

        private void OnPositionChanged(object? sender, EventArgs e)
        {
            if (PositionPicker.SelectedItem is not string)
            {
                return;
            }

            UpdateRadialMenuPosition();
        }

        private void OnLayoutRootSizeChanged(object? sender, EventArgs e)
        {
            UpdateRadialMenuPosition();
        }

        private void UpdateRadialMenuPosition()
        {
            double width = MenuContainer.Width;
            double height = MenuContainer.Height;

            // The container has not completed its initial layout.
            if (width <= 0 || height <= 0)
            {
                return;
            }

            double horizontalInset = Math.Min(EdgeInset, width / 2);
            double verticalInset = Math.Min(EdgeInset, height / 2);

            double left = horizontalInset;
            double right = width - horizontalInset;

            double top = verticalInset;
            double bottom = height - verticalInset;

            double centerX = width / 2;
            double centerY = height / 2;

            string selectedPosition = PositionPicker.SelectedItem as string ?? "Center";

            RadialMenu.Point = selectedPosition switch
            {
                "Top Left" => new Point(left, top),

                "Top Right" => new Point(right, top),

                "Bottom Left" => new Point(left, bottom),

                "Bottom Right" => new Point(right, bottom),

                _ => new Point(centerX, centerY)
            };
        }

    }
}
