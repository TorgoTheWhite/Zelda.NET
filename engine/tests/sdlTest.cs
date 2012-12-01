using System;
using System.Drawing;
using SdlDotNet.Graphics;
using SdlDotNet.Core;
namespace engine.tests
{
    public class sdlTest
    {
        private static Surface m_VideoScreen;
        private static Surface m_Background;
        private static Surface m_Foreground;
        private static Point m_ForegroundPosition;

        public static void Main(string[] args)
        {
            m_VideoScreen = Video.SetVideoMode(320, 240, 32, false, false, false, true);

            LoadImages();

            Events.Quit += new EventHandler<QuitEventArgs>(ApplicationQuitEventHandler);
            Events.Tick += new EventHandler<TickEventArgs>(ApplicationTickEventHandler);
            Events.Run();
        }

        private static void LoadImages() {
            m_Background = (new Surface(@"D:\dev\1.png")).Convert(m_VideoScreen, true, false);
            m_Foreground = (new Surface(@"D:\dev\2.png")).Convert(m_VideoScreen, true, false);
            m_Foreground.Transparent = true;
            m_Foreground.TransparentColor = Color.FromArgb(255, 0, 255);
            m_ForegroundPosition = new Point(m_VideoScreen.Width / 2 - m_Foreground.Width / 2,
                                              m_VideoScreen.Height / 2 - m_Foreground.Height / 2);
        }

        private static void ApplicationTickEventHandler(object sender, TickEventArgs args)
        {
            m_VideoScreen.Blit(m_Background);
            m_VideoScreen.Blit(m_Foreground, m_ForegroundPosition);
            m_VideoScreen.Update();
        }

        private static void ApplicationQuitEventHandler(object sender, QuitEventArgs args)
        {
            Events.QuitApplication();
        }
    }


    /*
    using System;
    using SdlDotNet.Graphics;
    using SdlDotNet.Core;

    public class game
    {
        public static void Main(string[] args)
        {
            Video.SetVideoMode(800, 600, 32, false, false, false, true);
            Events.Run();
        }
        private static void ApplicationQuitEventHandler(object sender, QuitEventArgs args)
        {
            Events.QuitApplication();
        }
    }
    //*/



    /*
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using SdlDotNet.Graphics;
    using SdlDotNet.Core;

    namespace engine
    {
        static class Program {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main() {
                Video.SetVideoMode(320, 240, 32, false, false, false, true);
                Events.Run();

            }
        }
    }
    //*/

};