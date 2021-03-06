//Public Domain
//Original version written by Paul Aspinall.

using System;
using System.Drawing;

using SdlDotNet.Core;
using SdlDotNet.Graphics;
using SdlDotNet.Input;

namespace SdlDotNetExamples.SmallDemos
{
    /// <summary>
    /// 
    /// </summary>
    public class Template
    {
        /// <summary>
        /// 
        /// </summary>
        [STAThread]
        public static void Run()
        {
            Template game = new Template();
            game.Go();
        }

        /// <summary>
        /// 
        /// </summary>
        public Template()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public void Go()
        {
            Video.SetVideoMode(800, 600);
            this.AddHandlers();
            Events.Run();
        }

        private void AddHandlers()
        {
            Events.Quit += new EventHandler<QuitEventArgs>(this.Events_Quit);
            Events.Tick += new EventHandler<TickEventArgs>(this.Events_Tick);
        }

        private void RemoveHandlers()
        {
            Events.Quit -= new EventHandler<QuitEventArgs>(this.Events_Quit);
            Events.Tick -= new EventHandler<TickEventArgs>(this.Events_Tick);
        }

        private void Events_Tick(object sender, TickEventArgs e)
        {
            Video.Screen.Fill(System.Drawing.Color.Blue);
            Video.Screen.Update();
        }

        private void Events_Quit(object sender, QuitEventArgs e)
        {
            RemoveHandlers();
            Events.QuitApplication();
        }

        /// <summary>
        /// For purposes of the demo browser only.
        /// </summary>
        public static string Title
        {
            get
            {
                return "Template: Used as a very basic template for new SdlDotNet apps.";
            }
        }
    }
}