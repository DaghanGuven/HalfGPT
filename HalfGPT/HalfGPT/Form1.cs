using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HalfGPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = ">";
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.EndsWith("\n"))
            {
                string result = "i don't have an answer for that.";
                string msg = richTextBox1.Text.Split('ㅤ').Last().Replace("\n","").Replace(">","").ToLower();
                if (msg == "hi")
                {
                    Thread thread = new Thread(method);
                    void method()
                    {
                        new SoundPlayer(Properties.Resources.hello).Play();
                        Thread.Sleep(1000);
                        new SoundPlayer(Properties.Resources.blip).Play();
                    }
                    result = "hello";
                    thread.Start();
                }
                else if(msg=="how are you")
                {
                    Thread thread = new Thread(method);
                    void method()
                    {
                        new SoundPlayer(Properties.Resources.fine).Play();
                        Thread.Sleep(1000);
                        new SoundPlayer(Properties.Resources.you).Play();
                        Thread.Sleep(500);
                        new SoundPlayer(Properties.Resources.blip).Play();
                    }
                    result = "fine, you?";
                    thread.Start();
                }
                else if (msg == "bad" &&lastmsg=="how are you")
                {
                    Thread thread = new Thread(method);
                    void method()
                    {
                        new SoundPlayer(Properties.Resources.why).Play();
                        Thread.Sleep(500);
                        new SoundPlayer(Properties.Resources.blip).Play();
                    }
                    result = "why are you?";
                    thread.Start();
                }
                else if(msg=="what time is it")
                {
                    string h = DateTime.Now.Hour.ToString();
                    string m = DateTime.Now.Minute.ToString();
                    if (DateTime.Now.Hour.ToString().Length == 1) h = 0+DateTime.Now.Hour.ToString();
                    if(DateTime.Now.Minute.ToString().Length==1)m = 0+DateTime.Now.Minute.ToString();
                    richTextBox1.Text += "・" + h + ':' + m + "ㅤ\n>";
                    result = "";
                    Thread thread = new Thread(method);
                    thread.Start();
                    void method()
                        { 
                        if (m != "00")
                        {
                            if (m[0] == '1')
                            {
                                new SoundPlayer(Properties.Resources.ten).Play();
                            }
                            else if (m[0] == '2')
                            {
                                new SoundPlayer(Properties.Resources.twenty).Play();
                            }
                            else if (m[0] == '3')
                            {
                                new SoundPlayer(Properties.Resources.thirty).Play();
                            }
                            else if (m[0] == '4')
                            {
                                new SoundPlayer(Properties.Resources.fourty).Play();
                            }
                            else if (m[0] == '5')
                            {
                                new SoundPlayer(Properties.Resources.fifty).Play();
                            }
                            Thread.Sleep(1000);
                            /*******************************/
                            /*******************************/
                            /*******************************/
                            if (m[1] == '1')
                            {
                                new SoundPlayer(Properties.Resources.one).Play();
                                Thread.Sleep(1000);
                            }
                            else if (m[1] == '2')
                            {
                                new SoundPlayer(Properties.Resources.two).Play();
                                Thread.Sleep(1000);
                            }
                            else if (m[1] == '3')
                            {
                                new SoundPlayer(Properties.Resources.three).Play();
                                Thread.Sleep(1000);
                            }
                            else if (m[1] == '4')
                            {
                                new SoundPlayer(Properties.Resources.four).Play();
                                Thread.Sleep(1000);
                            }
                            else if (m[1] == '5')
                            {
                                new SoundPlayer(Properties.Resources.five).Play();
                                Thread.Sleep(1000);
                            }
                            else if (m[1] == '6')
                            {
                                new SoundPlayer(Properties.Resources.six).Play();
                                Thread.Sleep(1000);
                            }
                            else if (m[1] == '7')
                            {
                                new SoundPlayer(Properties.Resources.seven).Play();
                                Thread.Sleep(1000);
                            }
                            else if (m[1] == '8')
                            {
                                new SoundPlayer(Properties.Resources.eight).Play();
                                Thread.Sleep(1000);
                            }
                            else if (m[1] == '9')
                            {
                                new SoundPlayer(Properties.Resources.nine).Play();
                                Thread.Sleep(1000);
                            }
                            new SoundPlayer(Properties.Resources.past).Play();
                            Thread.Sleep(400);
                            if (h == "01")
                            {
                                new SoundPlayer(Properties.Resources.one).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "02")
                            {
                                new SoundPlayer(Properties.Resources.two).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "03")
                            {
                                new SoundPlayer(Properties.Resources.three).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "04")
                            {
                                new SoundPlayer(Properties.Resources.four).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "05")
                            {
                                new SoundPlayer(Properties.Resources.five).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "06")
                            {
                                new SoundPlayer(Properties.Resources.six).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "07")
                            {
                                new SoundPlayer(Properties.Resources.seven).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "08")
                            {
                                new SoundPlayer(Properties.Resources.eight).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "09")
                            {
                                new SoundPlayer(Properties.Resources.nine).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "10")
                            {
                                new SoundPlayer(Properties.Resources.ten).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "11")
                            {
                                new SoundPlayer(Properties.Resources.eleven).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            else if (h == "12")
                            {
                                new SoundPlayer(Properties.Resources.twelve).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            if (h == "13")
                            {
                                new SoundPlayer(Properties.Resources.one).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "14")
                            {
                                new SoundPlayer(Properties.Resources.two).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "15")
                            {
                                new SoundPlayer(Properties.Resources.three).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "16")
                            {
                                new SoundPlayer(Properties.Resources.four).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "17")
                            {
                                new SoundPlayer(Properties.Resources.five).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "18")
                            {
                                new SoundPlayer(Properties.Resources.six).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "19")
                            {
                                new SoundPlayer(Properties.Resources.seven).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "20")
                            {
                                new SoundPlayer(Properties.Resources.eight).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "21")
                            {
                                new SoundPlayer(Properties.Resources.nine).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "22")
                            {
                                new SoundPlayer(Properties.Resources.ten).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "23")
                            {
                                new SoundPlayer(Properties.Resources.eleven).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.pm).Play();
                            }
                            else if (h == "00")
                            {
                                new SoundPlayer(Properties.Resources.twelve).Play();
                                Thread.Sleep(1000);
                                new SoundPlayer(Properties.Resources.am).Play();
                            }
                            Thread.Sleep(1000);
                            new SoundPlayer(Properties.Resources.blip).Play();
                        } 
                    }
                    goto end;
                }
                richTextBox1.Text += "・" + result + "ㅤ\n>";
            end:
                lastmsg = msg;
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
            }
            
        }
        string lastmsg = "";
    }
}
