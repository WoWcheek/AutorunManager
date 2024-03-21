namespace AutorunManager
{
    public partial class AppItemUC : UserControl
    {
        public string AppName { get; set; }
        public bool IsChecked { get; set; }

        public AppItemUC()
        {
            InitializeComponent();
            IsChecked = false;
        }

        public AppItemUC(string appName, Icon? icon) : this()
        {
            label1.Text = AppName = appName;
            pictureBox1.Image = icon?.ToBitmap();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) => IsChecked = checkBox1.Checked;
    }
}
