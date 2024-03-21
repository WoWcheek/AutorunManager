using Microsoft.Win32;

namespace AutorunManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeAppItems();
        }

        private void InitializeAppItems()
        {
            using (RegistryKey? autorunKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\"))
            {
                if (autorunKey is null) return;


                List<AppItemUC> items = new List<AppItemUC>();
                autorunKey.GetValueNames().ToList().ForEach(name =>
                {
                    string? exeFilePath = autorunKey.GetValue(name)?.ToString();
                    if (exeFilePath is not null)
                    {
                        exeFilePath = ExtractDirectExePath(exeFilePath);
                        Icon? appIcon = File.Exists(exeFilePath) ? Icon.ExtractAssociatedIcon(exeFilePath) : null;
                        items.Add(new AppItemUC(name, appIcon));
                    }
                });
                RenderAppItems(items);
            }
        }

        private string ExtractDirectExePath(string str)
        {
            int startIndex = str.IndexOf(":") - 1;
            int lastIndex = str.IndexOf(".exe") + ".exe".Length;
            if (startIndex == -1 || lastIndex == -1) return string.Empty;

            return str.Substring(startIndex, lastIndex).Replace("\"", string.Empty).Replace("\\\\", "\\");
        }

        private void RenderAppItems(List<AppItemUC> items)
        {
            const int margin = 20;
            int y = margin;

            panel1.Controls.Clear();
            foreach (AppItemUC item in items)
            {
                item.Location = new Point(margin, y);
                panel1.Controls.Add(item);
                y += item.Height + margin;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (RegistryKey? autorunKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true))
            {
                if (autorunKey is null) return;

                foreach (AppItemUC item in panel1.Controls)
                    if (item.IsChecked)
                        autorunKey.DeleteValue(item.AppName);
            }
            InitializeAppItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddAppForm addForm = new AddAppForm();
            addForm.ShowDialog();

            AppItemUC? appUC = addForm.App;
            string? appPath = addForm.FilePath;
            if (appUC is null || appPath is null) return;

            RegistryKey? key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
            if (key is null) return;
            key.SetValue(appUC.AppName, appPath);

            InitializeAppItems();
        }
    }
}
