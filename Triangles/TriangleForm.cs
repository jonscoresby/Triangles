namespace Triangles
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }


        // The following code was taken from
        // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.keypress?view=windowsdesktop-7.0
        // and modified to allow a decimal point

        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;


        // Handle the KeyDown event to determine the type of character entered into the control.
        private void TextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            AngleMeasurementsLabel.Text = ((TextBox)sender).Text;
            // Initialize the flag to false.
            nonNumberEntered = false;
           
            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace
                    if (e.KeyCode != Keys.Back)
                    {
                        // Determine if keystroke is a '.' and if one has already been used or not
                        if (!((e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod) && !((TextBox)sender).Text.Contains('.')))
                        {
                            // A non-numerical keystroke was pressed.
                            // Set the flag to true and evaluate in KeyPress event.
                            nonNumberEntered = true;
                        }
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void ProcessInput(object sender, EventArgs e)
        {
            if (SideLengthA.Text == "" || SideLengthB.Text == "" || SideLengthC.Text == "")
            {
                OutputLabel.Text = "Enter side lengths";
            }
            else if(double.TryParse(SideLengthA.Text,out double a) && double.TryParse(SideLengthB.Text, out double b) && double.TryParse(SideLengthC.Text, out double c))
            {
                Triangle triangle = new(a, b, c);
                OutputLabel.Text = triangle.ToString();
            }
            else
            {
                OutputLabel.Text = "One or more provided numbers is invalid";
            }

            
        }
    }
}