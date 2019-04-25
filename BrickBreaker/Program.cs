using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BrickBreaker
{
    static class Program
    {
        //Declares a file system path
        public static string FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\Brick Breaker";//Thayen with all Directory code
        public static string ResourcePath = $@"{FilePath}\Resources";
        public static string AudioPath = $@"{ResourcePath}\Sounds";
        public static string LevelPath = $@"{FilePath}\Levels";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //If the game's file system does not exist, create it
            if (!Directory.Exists(FilePath))
                Directory.CreateDirectory(FilePath);

            if(!Directory.Exists(ResourcePath))
                Directory.CreateDirectory(ResourcePath);

            if (!Directory.Exists(LevelPath))
                Directory.CreateDirectory(LevelPath);

            if (!Directory.Exists(AudioPath))
                Directory.CreateDirectory(AudioPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
