namespace windows_form_first_app;

public partial class Form1 : Form
{

    private Label Name;
    private Label Password;
    private Label ConfirmPassword;

    private TextBox textName;
    private TextBox textPassword;
    private TextBox textConfirmPassword;

    private Button registerButton;

    private PictureBox iconUser;
    public Form1()
    {
        InitializeComponent();
        addLabels();

        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.WindowState = FormWindowState.Normal;
    }

    private void addLabels()
    {
        Name = new Label
        {
            Text = "Nombre o Apodo:",
            Location = new System.Drawing.Point(10,40),
            AutoSize = true,
            Font = new System.Drawing.Font("Arial", 16)
        };

        Password = new Label
        {
            Text = "Contraseña: ",
            Location = new System.Drawing.Point(10, 40*3),
            AutoSize = true,
            Font = new System.Drawing.Font("Arial",16)
        };

        ConfirmPassword = new Label
        {
            Text = "Confirmar Contraseña: ",
            Location = new System.Drawing.Point(10, 40*5),
            AutoSize = true,
            Font = new System.Drawing.Font("Arial",16)
        };

        textName = new TextBox
        {
            Location = new System.Drawing.Point(20,80),
            Size = new System.Drawing.Size(200,30)
        };

        textPassword = new TextBox
        {
            Location = new System.Drawing.Point(20,160),
            Size = new System.Drawing.Size(200, 30)
        };

        textConfirmPassword = new TextBox
        {
            Location = new System.Drawing.Point(20,(40*6)),
            Size = new System.Drawing.Size(200, 30)
        };

        iconUser = new PictureBox
        {
            Size = new Size(300,300),
            Location = new System.Drawing.Point(210, 0),
            SizeMode = PictureBoxSizeMode.Zoom
        };

        registerButton = new Button 
        {
            Text = "Registrarse",
            Location = new System.Drawing.Point(70,270),
            Size = new System.Drawing.Size(100,40)
        };

        if (File.Exists("images/user.png"))
        {
            iconUser.Image = Image.FromFile("images/user.png");
        }
        else
        {
            MessageBox.Show("Image file not found: images/user.png", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        registerButton.Click += new EventHandler(Button_register);

        this.Controls.Add(Name);
        this.Controls.Add(Password);
        this.Controls.Add(textName);
        this.Controls.Add(ConfirmPassword);
        this.Controls.Add(textPassword);
        this.Controls.Add(textConfirmPassword);
        this.Controls.Add(iconUser);
        this.Controls.Add(registerButton);

        
    }

    private void Button_register(object sender, EventArgs e)
    {
        MessageBox.Show("Has sido registrado");
        this.Controls.Remove(iconUser);
        Name.Text = "Nombre de usuario";
        this.Controls.Remove(ConfirmPassword);
        this.Controls.Remove(textConfirmPassword);

        CenteredLabel();
    }

    private void CenteredLabel()
    {
        int Xcenter = (this.ClientSize.Width - Name.Width) / 2;

        Name.Location = new Point(Xcenter, 40);
        Password.Location = new Point(Xcenter+40, 120);

        textName.Location = new Point(Xcenter, 80);
        textPassword.Location = new Point(Xcenter, 160);

        registerButton.Location = new Point(Xcenter+50, 200);

    }
}
