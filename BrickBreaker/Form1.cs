using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The Game's Soundplayer.
        /// Note that remember that playSoundFrom and preloadSound will save lines of code when used
        /// </summary>
        public static SoundPlayer SoundPlayer = new SoundPlayer();
        public static GameScreen currentGame;
        public Form1()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(Program.FilePath);//Set the program to put files in the created directory
        }

        /// <summary>
        /// Gets a .wav file from the file path and plays it
        /// </summary>
        /// <param name="filePath"></param>
        public static void playSoundFrom(string filePath)
        {
            if (File.Exists(filePath))
            {
                SoundPlayer.SoundLocation = filePath;
                SoundPlayer.PlaySync();
            }
            else
                throw new Exception("Could not find the required file");
        }

        /// <summary>
        /// Gets the .wav file from specified location and loads it into the soundplayer
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool preloadSound(string filePath)
        {
            if(File.Exists(filePath))
            {
                SoundPlayer.SoundLocation = filePath;
                SoundPlayer.Load();
                return true;
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            //Center the control
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            //ms.Size = new Size(this.Width, this.Height);
        }

        public void ChangeScreen(UserControl current, UserControl next)
        {
            //f is set to the form that the current control is on
            Controls.Remove(current);

            //centres the control on the screen
            next.Location = new Point((Width - next.Width) / 2, (Height - next.Height) / 2);

            Controls.Add(next);
            next.Focus();
        }
    }
}
