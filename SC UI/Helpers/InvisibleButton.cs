namespace SC_UI.Helpers
{
    public class InvisibleButton : Button
    {
        public InvisibleButton()
        {
            SetStyle(ControlStyles.Selectable, false);
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            BackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            UseVisualStyleBackColor = true;
        }
    }
}
