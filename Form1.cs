using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;

namespace ScreenDiscord
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        string fileContent = null;
        string filePath = null;
        public Form1()
        {
            InitializeComponent();


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                    //Process.Start(Convert.ToString(filePath));
                    //Cursor.Position = new Point(280, 700);
                    //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 250, 800, 0, 0);
                    //System.Threading.Thread.Sleep(500);
                    //Cursor.Position = new Point(280, 700);
                    //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 250, 800, 0, 0);
                    //System.Threading.Thread.Sleep(500);
                    //Cursor.Position = new Point(250, 800);
                    //System.Threading.Thread.Sleep(1000);
                    //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 250, 800, 0, 0);
                    //Cursor.Position = new Point(740, 340);
                    //System.Threading.Thread.Sleep(500);
                    //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 740, 340, 0, 0);
                    //Cursor.Position = new Point(850, 450);
                    //System.Threading.Thread.Sleep(500);
                    //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 740, 340, 0, 0);
                    //Cursor.Position = new Point(900, 690);
                    //System.Threading.Thread.Sleep(500);
                    //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 740, 340, 0, 0);
                    var Procs = Process.GetProcessesByName("osk");
                    if (Procs.Length == 0)
                    {
                        Process.Start(Convert.ToString(filePath));
                        Cursor.Position = new Point(280, 700 );
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 250, 800, 0, 0);
                        System.Threading.Thread.Sleep(500);
                        Cursor.Position = new Point(280 , 700 );
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 250, 800, 0, 0);
                        System.Threading.Thread.Sleep(500);
                        Cursor.Position = new Point(250 , 800 );
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 250, 800, 0, 0);
                        Cursor.Position = new Point(740 , 340 );
                        System.Threading.Thread.Sleep(500);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 740, 340, 0, 0);
                        Cursor.Position = new Point(850 , 450 );
                        System.Threading.Thread.Sleep(500);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 740, 340, 0, 0);
                        Cursor.Position = new Point(900 , 690);
                        System.Threading.Thread.Sleep(500);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 740, 340, 0, 0);
                    }
                
            }
            catch
            {
                MessageBox.Show(Convert.ToString("Fail"));
            }
            //MessageBox.Show(Convert.ToString(processExists));
            

        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                    Process.Start(Convert.ToString(filePath));
                    Cursor.Position = new Point(280, 700);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 250, 800, 0, 0);
                    System.Threading.Thread.Sleep(500);
                    Cursor.Position = new Point(280, 700);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 250, 800, 0, 0);
                    System.Threading.Thread.Sleep(500);
                    Cursor.Position = new Point(250, 800);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 250, 800, 0, 0);
                    Cursor.Position = new Point(740, 340);
                    System.Threading.Thread.Sleep(500);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 740, 340, 0, 0);
                    Cursor.Position = new Point(650, 450);
                    System.Threading.Thread.Sleep(500);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 740, 340, 0, 0);
                    Cursor.Position = new Point(900, 690);
                    System.Threading.Thread.Sleep(500);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 740, 340, 0, 0);

            }
            catch
            {
                MessageBox.Show(Convert.ToString("Fail"));
            }
            //MessageBox.Show(Convert.ToString(processExists));

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\" + Convert.ToString(userName).Split('\\')[1] + "\\AppData\\Local\\Discord";
                //MessageBox.Show("C:\\Users\\" + Convert.ToString(userName).Split('\\')[1] + "\\AppData\\Local\\Discord");
                openFileDialog.Filter = "Discord(Discord.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
          
            }
        }
    }
}
