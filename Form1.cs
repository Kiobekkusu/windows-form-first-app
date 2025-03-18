namespace windows_form_first_app;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        addLabel();

        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.WindowState = FormWindowState.Normal;
    }

    private void addLabel()
    {
        Label Name = new Label()
        {
            Text = "Nombre o Apodo:",
            Location = new System.Drawing.Point(10,40),
            AutoSize = true,
            Font = new System.Drawing.Font("Arial", 16)
        };

        Label Password = new Label
        {
            Text = "Contraseña: ",
            Location = new System.Drawing.Point(10, 40*3),
            AutoSize = true,
            Font = new System.Drawing.Font("Arial",16)
        };

        Label ConfirmPassword = new Label
        {
            Text = "Confirmar Contraseña: ",
            Location = new System.Drawing.Point(10, 40*5),
            AutoSize = true,
            Font = new System.Drawing.Font("Arial",16)
        };

        TextBox textName = new TextBox
        {
            Location = new System.Drawing.Point(20,80),
            Size = new System.Drawing.Size(200,30)
        };

        TextBox textPassword = new TextBox
        {
            Location = new System.Drawing.Point(20,160),
            Size = new System.Drawing.Size(200, 30)
        };

        TextBox textConfirmPassword = new TextBox
        {
            Location = new System.Drawing.Point(20,(40*6)),
            Size = new System.Drawing.Size(200, 30)
        };

        PictureBox iconUser = new PictureBox
        {
            Size = new Size(300,300),
            Location = new System.Drawing.Point(210, 0),
            Image = Image.FromFile("images/user.png"),
            SizeMode = PictureBoxSizeMode.Zoom
        };

        this.Controls.Add(Name);
        this.Controls.Add(Password);
        this.Controls.Add(textName);
        this.Controls.Add(ConfirmPassword);
        this.Controls.Add(textPassword);
        this.Controls.Add(textConfirmPassword);
       
        this.Controls.Add(iconUser);
    }
}
