using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace myOCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //cannot find 'K','O', '0'
        Dictionary<int, char> direct = new Dictionary<int, char>()
        {
           {28146,'1'}, {47557,'2'},{44616,'3'},{45190,'4'},{43216,'5'},{42926,'6'},{26290,'7'},{76136,'8'},{40420,'9'},
            {39744,'A'},{43226,'B'},{46524,'C'},{46534,'D'},{48984,'E'},{21222,'F'},{47224,'G'},
            {36570,'H'},{23148,'I'},{45360,'J'},{66378,'L'},{47320,'M'},{77168,'N'},{26518,'P'},
            {47472,'Q'},{38960,'R'},{43316,'S'},{8332,'T'},{57234,'U'},{61924,'V'},{95880,'W'},
            {72664,'X'},{43640,'Y'},{48398,'Z'}
        };

        private void button1_Click(object sender, EventArgs e)
        {
             this.openFileDialog.ShowDialog();
             if (openFileDialog.FileName == "") return;
             richTextBox1.Clear();

             Image currPic = Image.FromFile(openFileDialog.FileName);
             Bitmap currBm = new Bitmap(openFileDialog.FileName);
             orgPictureBox.Image = Image.FromFile(openFileDialog.FileName); ;
         
            Thread n = (new Thread(() => {
                bool lastBlack = false;
                int hashVal = 0;
                int pos = 0;
                int lastX = 0;
                pictureBox.Image = (new Bitmap(currPic));
                Graphics tmpG = Graphics.FromImage(pictureBox.Image);
                for (int i = 0; i < currPic.Size.Width-1; i++)
                {
                    this.Invoke(new Action(() => { tmpG.DrawLine(Pens.Red, new Point(i, 0), new Point(i, currPic.Size.Height)); pictureBox.Image = (new Bitmap(currPic)); }));
                    this.Refresh();
                    bool blackCheck = false;
                    int currYLineHash = 0;
                    for (int y = 0,lastY = 0; y < currPic.Size.Height; y++)
                    {
                        if ((currBm.GetPixel(i, y).ToArgb()) != -1)
                        {
                            if (!blackCheck) this.Invoke(new Action(() => { Graphics.FromImage(currPic).DrawLine(Pens.Blue, new Point(i, 0), new Point(i, currPic.Size.Height)); }));
                            blackCheck = true;
                            currYLineHash += y * ((lastY - y < 1 ? y - lastY : lastY - y) * (i - lastX));
                            lastY = y;
                        }
                        else if (blackCheck)//發現黑色後遇到y
                        {
                            currYLineHash += (i-lastX);
                        }
                       
                    }
                    

                    if (lastBlack && (!blackCheck))
                    {
                        pos++;
                        string tmpName = "labelAnser" + pos.ToString();
                       
                        if (direct.ContainsKey(hashVal))
                        {
                            (this.Controls.Find(tmpName, true)[0] as Label).Text = "" + direct[hashVal];
                            this.Invoke(new Action(() => { this.richTextBox1.Text += "end at X = " + i + "\n第" + pos + "個字符 = " + direct[hashVal] + "\n\n"; }));
                        }
                        else
                        {
                            (this.Controls.Find(tmpName, true)[0] as Label).Text = "?";
                            this.Invoke(new Action(() => { this.richTextBox1.Text += "end at X = " + i + "\n第" + pos + "個字符Hash = {" + hashVal + "\n\n"; }));
                            //this.Invoke(new Action(() => { this.richTextBox1.Text +="{" + hashVal + ",''}\n\n"; }));
                       
                        }
                    
                    }
                    else if ((!lastBlack) && (blackCheck))
                    {
                        hashVal = 0;
                        lastX = i;
                        this.Invoke(new Action(() => { this.richTextBox1.Text += "start at X = " + i + "\n"; }));
                    }else if (blackCheck&&blackCheck)
                    {
                        hashVal += currYLineHash;
                    }
                    lastBlack = (blackCheck);
                  
                }

            }));

            n.IsBackground = true;
            n.Start();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            Form.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
