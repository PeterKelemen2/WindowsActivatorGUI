namespace WindowsActivatorGUI;

using static Utils;

public partial class Form1 : Form
{
    Font labelFont = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
    Font buttonFont = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular);

    public Form1()
    {
        InitializeComponent();
        InitializeControls();
    }

    private void InitializeControls()
    {
        PlaceLabel(0, 30, "Windows Activator");
        PlaceButton(50, 80, "Home", Home);
        // PlaceButton(50,100,"Button2", Click1);
        // PlaceButton(50,150,"Button3", Click1);
        // PlaceButton(50,200,"Button4", Click1);
    }

    // Event handler for the button click event
    private void MyButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Button Clicked!");
    }


    private void PlaceButton(int x, int y, string text, EventHandler Click1)
    {
        Button button = new Button();
        button.Text = text;
        button.Location = new System.Drawing.Point(x, y);
        button.Click += Click1;

        button.Height = 30;
        button.BackColor = Color.FromArgb(255, 51, 51, 51);
        button.ForeColor = Color.White;
        button.Font = buttonFont;

        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = Color.FromArgb(255, 59, 115, 124);
        button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 31, 31, 31);
        button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 70, 82, 101);

        this.Controls.Add(button);
    }

    private void PlaceLabel(int xOffset, int yOffset, string text)
    {
        Label label = new Label();

        label.Text = text;
        label.AutoSize = true;

        label.Font = labelFont;

        int centerX = (this.ClientSize.Width - label.PreferredSize.Width) / 2;
        int centerY = (this.ClientSize.Height - label.Height) / 2;

        label.Location = new System.Drawing.Point(xOffset + centerX, yOffset);

        this.Controls.Add(label);
    }
}