namespace SC_UI
{
    public class FormHelper
    {
        public class InvisibleButton : Button
        {
            //Set invisible style
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
}
