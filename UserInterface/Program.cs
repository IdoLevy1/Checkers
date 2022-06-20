using System.Windows.Forms;

namespace UserInterface
{
    internal class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            GameManager manager = new GameManager();
            manager.Run();
        }
    }
}
