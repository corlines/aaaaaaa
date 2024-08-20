using System;
using System.Windows.Forms;

namespace FormSytle
{
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp();
            form.Width = 400;
            form.MouseDown += new MouseEventHandler(form_MouseDown);
        }
    }
    
}