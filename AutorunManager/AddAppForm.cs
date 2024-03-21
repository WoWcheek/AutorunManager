namespace AutorunManager
{
    public partial class AddAppForm : Form
    {
        public AppItemUC? App { get; private set; }
        public string? FilePath { get; set; }

        public AddAppForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Enter app name!", "Adding app to autorun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (FilePath is null)
            {
                MessageBox.Show("Provide path to app .exe file!", "Adding app to autorun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Icon? icon = File.Exists(FilePath) ? Icon.ExtractAssociatedIcon(FilePath) : null;
            App = new AppItemUC(textBox1.Text, icon);

            MessageBox.Show($"{App.AppName} was added to autorun!", "Adding app to autorun", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Text = string.Empty;
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                }
            }
        }
    }
}
