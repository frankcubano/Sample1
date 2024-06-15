namespace Sample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FAuth authForm = new FAuth();
            authForm.ShowDialog(); // Mostrar FAuth de manera modal
        }
    }
}
