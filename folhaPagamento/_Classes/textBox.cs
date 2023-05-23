using folhaPagamento.Properties;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class CustomTextBox : TextBox
{
    private string placeholderText;
    private bool isPassword;
    private bool isPasswordVisible;
    private Button showHideButton;

    public CustomTextBox()
    {
        placeholderText = "Digite aqui...";
        isPassword = false;
        isPasswordVisible = false;

        showHideButton = new Button();
        showHideButton.Size = new Size(64, Height - 5);
        showHideButton.Location = new Point(Width - showHideButton.Width - 2, -1);
        showHideButton.FlatStyle = FlatStyle.Flat;
        showHideButton.FlatAppearance.BorderSize = 0;
        showHideButton.TabStop = false;
        showHideButton.BackgroundImageLayout = ImageLayout.Stretch;
        showHideButton.Image = Resources.eye_open;
        showHideButton.Cursor = Cursors.Hand;






        showHideButton.Click += ShowHideButton_Click;
        Controls.Add(showHideButton);

        TextChanged += CustomTextBox_TextChanged;
        GotFocus += CustomTextBox_GotFocus;
        LostFocus += CustomTextBox_LostFocus;
    }

    public string PlaceholderText
    {
        get { return placeholderText; }
        set
        {
            placeholderText = value;
            Refresh();
        }
    }

    public bool IsPassword
    {
        get { return isPassword; }
        set
        {
            isPassword = value;
            Refresh();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (string.IsNullOrEmpty(Text) && !Focused)
        {
            using (var brush = new SolidBrush(Color.Gray))
            {
                e.Graphics.DrawString(placeholderText, Font, brush, new Point(0, 0));
            }
        }
    }

    private void ShowHideButton_Click(object sender, EventArgs e)
    {
        isPasswordVisible = !isPasswordVisible;
        UseSystemPasswordChar = !isPasswordVisible;
        showHideButton.Image = isPasswordVisible ? Resources.eye_close : Resources.eye_open; // Substitua pelas imagens corretas
    }

    private void CustomTextBox_TextChanged(object sender, EventArgs e)
    {
        Refresh();
    }

    private void CustomTextBox_GotFocus(object sender, EventArgs e)
    {
        Refresh();
    }

    private void CustomTextBox_LostFocus(object sender, EventArgs e)
    {
        Refresh();
    }
}
