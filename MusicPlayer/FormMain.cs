using LayeredSkin.DirectUI;
using Microsoft.VisualBasic;
using MusicPlayer.MyLayeredSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Un4seen.Bass;

namespace MusicPlayer
{
    public partial class FormMain : LayeredSkin.Forms.LayeredForm
    {
        public int stream = 0;
        public FormMain(string file = "")
        {
            InitializeComponent();
            OpenCommand = file;
            LoadCompent();
            CheckForIllegalCrossThreadCalls = false;
            
        }

        #region PrintError
        private void pl_tip_container_MouseEnter(object sender, EventArgs e)
        {
            tipTimer.Stop();
        }
        private void pl_tip_container_MouseLeave(object sender, EventArgs e)
        {
            tipTimer.Start();
        }
        private void PrintInfo(string title,string msg="", int showtime = 8000)
        {
            if(Visible)
            {
                pl_tip_container.BackColor = Color.FromArgb(160, Color.SkyBlue);
                pb_info_icon.BackgroundImage = Properties.Resources.BlueBarInfo;
                lb_info_title.Text = title;
                if (msg != "")
                {
                    lb_info_text.Text = msg;
                    pl_tip_container.Height = 86;
                    pl_tip_container.Top = Height - pl_tip_container.Height;
                }
                else
                {
                    lb_info_text.Text = msg;
                    if (title.Length > 25)
                    {
                        pl_tip_container.Height = 70;
                        pl_tip_container.Top = Height - pl_tip_container.Height;
                    }
                    else
                    {
                        pl_tip_container.Height = 63;
                        pl_tip_container.Top = Height - pl_tip_container.Height;
                    }
                }
                if (showtime != -1)
                {
                    tipTimer.Interval = showtime; 
                    tipTimer.Start();
                }
                pl_tip_container.Show();
            }
            else
            {

            }
        }
        private void PrintError(string title, string msg = "",int errorlev=0, int showtime = 8000)
        {
            if (Visible)
            {            
                if (errorlev == 0)
                {
                    pb_info_icon.BackgroundImage = Properties.Resources.BlueBarWarning;
                    pl_tip_container.BackColor = Color.FromArgb(200, Color.OrangeRed);
                }
                else if (errorlev == 1)
                {
                    pb_info_icon.BackgroundImage = Properties.Resources.BlueBarError;
                    pl_tip_container.BackColor = Color.FromArgb(100, Color.Red);
                }
                lb_info_title.Text = title;
                if (msg != "")
                {
                    lb_info_text.Text = msg;
                    pl_tip_container.Height = 80;
                    pl_tip_container.Top = Height - pl_tip_container.Height;
                }
                else
                {
                    lb_info_text.Text = msg;                    
                    if(title.Length>25)
                    {
                        pl_tip_container.Height = 70;
                        pl_tip_container.Top = Height - pl_tip_container.Height;
                    }
                    else
                    {
                        pl_tip_container.Height = 63;
                        pl_tip_container.Top = Height - pl_tip_container.Height;
                    }                      
                }
                if (showtime != -1)
                {
                    tipTimer.Interval = showtime; 
                    tipTimer.Start();
                }
                pl_tip_container.Show();
            }
            else
            {

            }
        }
        private void PrintMsg(string title, string msg = "", int showtime = 8000)
        {
            if (Visible)
            {
                pl_tip_container.BackColor = Color.FromArgb(150, Color.LawnGreen);
                pb_info_icon.BackgroundImage = Properties.Resources.BlueBarOk;
                lb_info_title.Text = title;
                if (msg != "")
                {
                    lb_info_text.Text = msg;
                    pl_tip_container.Height = 86;
                    pl_tip_container.Top = Height - pl_tip_container.Height;
                }
                else
                {
                    lb_info_text.Text = msg;
                    if (title.Length > 25)
                    {
                        pl_tip_container.Height = 70;
                        pl_tip_container.Top = Height - pl_tip_container.Height;
                    }
                    else
                    {
                        pl_tip_container.Height = 63;
                        pl_tip_container.Top = Height - pl_tip_container.Height;
                    }
                }
                if (showtime != -1)
                {
                    tipTimer.Interval = showtime; 
                    tipTimer.Start();
                }
                pl_tip_container.Show();
            }
            else
            {

            }
        }
        #endregion

        #region Global variable
        public Bitmap Alboum
        {
            get { return abmpx; }
        }
        FormMini minifm = null;
        private bool playingcache = false;
        private bool playmidi = false;
        private bool mini = false;
        private bool playingmidi
        {
            get { return playmidi; }
            set
            {
                playmidi = value;
                if (playmidi)
                    btn_loadmidifont.Visible = true;
                else
                    btn_loadmidifont.Visible = false;
            }
        }
        private int midifont = 0;
        private Un4seen.Bass.AddOn.Midi.BASS_MIDI_FONT midifontz = new Un4seen.Bass.AddOn.Midi.BASS_MIDI_FONT();
        private int plugin1 = 0;
        private int plugin3 = 0;
        private int plugin4 = 0;
        private int plugin2 = 0;
        private int plugin5 = 0;
        private int plugin6 = 0;
        private bool rsizeing = false;
        private string OpenCommand = "";
        private bool Mini = false;
        private bool loadok = false;
        private bool aformfile = false;
        private Bitmap abmpx = null;
        private Bitmap abmpxb = null;
        private Bitmap tr = null;
        private bool exit = false;
        private bool Moveing = false;
        private Point MovePoint = new Point();
        private bool tarking = false;
        private bool started = false;
        private bool loaderror = false;
        private bool fadeIng = false;
        private bool fmloaded = false;
        private bool fadeIn = false;
        private float[] fft = new float[512];
        private float fadeVol = 0;
        private bool playingShowl = true;
        private bool lkerr = false;
        private bool settingfilemissing = false;
        private bool listfilemissing = false;
        private string rightclickitem = "";
        private string rightclickitemlist = "";
        private string deffont = "";

        #endregion

        #region Settings       

        public bool AutoPlay = false;
        public bool IsTop = false;
        public bool ExitWhenClose = false;
        public bool EnableSt = true;
        public bool EnableSearch = true;
        public bool Enableq = false;
        public bool EnablePlugins = true;
        public int Transparency = 60;
        public string BackImg = "N/A";
        public Color BackCl = Color.FromArgb(0, 0, 0);
        public PlayMod PlayerMod = PlayMod.listloop;
        public string AutoPlayName = "";
        public int SaveHeight = 485;
        public Point Pos = new Point();
        public Point MiniPos = new Point();
        public bool LrcDoubleLine = false;
        public bool ExitArsk = true;

        #region Methods
        private void LoadSettings()
        {
            string a = Application.StartupPath + @"\data\MusicPlayer.cfg";

            if (!File.Exists(a))
            {
                settingfilemissing = true;
                AutoPlayName = "NUL";
                SaveSettings(true);
            }
            else
            {
                FileStream fs = new FileStream(a, FileMode.Open);
                byte[] arrBufRed = new byte[Convert.ToInt32(fs.Length) - 4];
                byte[] len = new byte[4];
                fs.Read(len, 0, 4);
                fs.Read(arrBufRed, 0, Convert.ToInt32(fs.Length) - 4);
                fs.Close();
                fs.Dispose();

                int destlen = BitConverter.ToInt32(len, 0);
                byte[] arrBufDst = new byte[destlen];
                Win32.uncompress(arrBufDst, ref destlen, arrBufRed, arrBufRed.Length);

                MemoryStream srl = new MemoryStream(arrBufDst);
                StreamReader sr = new StreamReader(srl);
                int count = 0;
                string res = sr.ReadLine();
                while (!string.IsNullOrEmpty(res))
                {
                    if (count == 0)
                    {
                        if (res == "")
                        {
                            StartPosition = FormStartPosition.CenterScreen;
                        }
                        else
                        {
                            string[] s = res.Split(new char[] { '#' });
                            pl_bg.Refresh();
                            Left = int.Parse(s[0]);
                            Top = int.Parse(s[1]);
                            if (Left < 0)
                                Left = Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2;
                            if (Top < 0)
                                Top = Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2;
                            s = null;
                        }
                    }
                    else if (count == 1)
                    {
                        tkb_sound.Value = Convert.ToDouble(int.Parse(res)) / 100;
                    }
                    else if (count == 2)
                    {
                        if (res == "0")
                            AutoPlay = false;
                        else if (res == "1")
                            AutoPlay = true;
                    }
                    else if (count == 3)
                    {
                        if (res == "0")
                            PlayerMod = PlayMod.listloop;
                        else if (res == "1")
                            PlayerMod = PlayMod.list;
                        else if (res == "2")
                            PlayerMod = PlayMod.loop;
                        else if (res == "3")
                            PlayerMod = PlayMod.one;
                        else if (res == "4")
                            PlayerMod = PlayMod.random;
                    }
                    else if (count == 4)
                    {
                        if (res == "1")
                        {
                            ExitWhenClose = true;
                        }
                        else if (res == "0")
                        {
                            ExitWhenClose = false;
                        }
                    }
                    else if (count == 5)
                    {
                        if (res == "1")
                        {
                            IsTop = true;
                        }
                        else if (res == "0")
                        {
                            IsTop = false;
                        }
                    }
                    else if (count == 6)
                    {
                        if (res == "1")
                        {
                            EnableSt = true;
                        }
                        else if (res == "0")
                        {
                            EnableSt = false;
                        }
                    }
                    else if (count == 7)
                    {
                        if (res == "1")
                        {
                            EnableSearch = true;
                        }
                        else if (res == "0")
                        {
                            EnableSearch = false;
                        }
                    }
                    else if (count == 8)
                    {
                        if (res == "1")
                        {
                            Enableq = true;
                        }
                        else if (res == "0")
                        {
                            Enableq = false;
                        }
                    }
                    else if (count == 9)
                    {
                        if (res == "1")
                        {
                            EnablePlugins = true;
                        }
                        else if (res == "0")
                        {
                            EnablePlugins = false;
                        }
                    }
                    else if (count == 10)
                    {
                        Transparency = int.Parse(res);
                    }
                    else if (count == 11)
                    {
                        if (res != "N/A")
                        {
                            if (File.Exists(res))
                                BackGroundSkin = res;
                        }
                    }
                    else if (count == 12)
                    {
                        string[] s = res.Split(new char[] { '#' });
                        BackCl = Color.FromArgb(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]));
                    }
                    else if (count == 13)
                    {
                        AutoPlayName = res;
                    }
                    else if (count == 14)
                    {
                        SaveHeight = int.Parse(res);
                        if (SaveHeight < 485)
                            SaveHeight = 485;
                    }
                    else if (count == 15)
                    {
                        if (res == "1")
                        {
                            LrcDoubleLine = true;
                        }
                        else if (res == "0")
                        {
                            LrcDoubleLine = false;
                        }
                    }
                    else if (count == 16)
                    {
                        if (res == "1")
                        {
                            ExitArsk = true;
                        }
                        else if (res == "0")
                        {
                            ExitArsk = false;
                        }
                    }
                    else if (count == 17)
                    {
                        if (res != "")
                        {
                            string[] s = res.Split(new char[] { '#' });
                            MiniPos = new Point(int.Parse(s[0]), int.Parse(s[1]));
                            s = null;
                        }
                    }


                    res = sr.ReadLine();
                    count++;
                }
                sr.Close();
                sr.Dispose();
                sr = null;
                res = null;
                srl.Close();
                srl.Dispose();
            }

            GC.Collect();

            ApplySettings();

            LoadLists();

            loadok = true;


            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void ApplySettings()
        {
            BackColor = Color.FromArgb(Transparency, BackCl);          
            TopMost = IsTop;
            btn_top.Checked = IsTop;
            if(PlayerMod== PlayMod.one)
            {
                btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_one;
                btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_one;
                btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_one;
            }
            else if(PlayerMod== PlayMod.list)
            {
                btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_list;
                btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_list;
                btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_list;
            }
            else if (PlayerMod == PlayMod.listloop)
            {
                btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_listloop;
                btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_listloop;
                btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_listloop;
            }
            else if (PlayerMod == PlayMod.loop)
            {
                btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_loop;
                btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_loop;
                btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_loop;
            }
            else if (PlayerMod == PlayMod.random)
            {
                btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_random;
                btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_random;
                btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_random;
            }
            minifm.Location = MiniPos;  
        }
        private void SaveSettings(bool a=false)
        {
            if (a)
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + @"\data\MusicPlayer.cfg", false);
                sw.WriteLine(Pos.X.ToString() + "#" + Pos.Y.ToString());
                sw.WriteLine((tkb_sound.Value * 100).ToString("0"));
                if (AutoPlay)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                if (PlayerMod == PlayMod.listloop)
                    sw.WriteLine("0");
                else if (PlayerMod == PlayMod.list)
                    sw.WriteLine("1");
                else if (PlayerMod == PlayMod.loop)
                    sw.WriteLine("2");
                else if (PlayerMod == PlayMod.one)
                    sw.WriteLine("3");
                else if (PlayerMod == PlayMod.random)
                    sw.WriteLine("4");

                if (ExitWhenClose)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");

                if (IsTop)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");

                if (EnableSt)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");

                if (EnableSearch)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");

                if (Enableq)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                if (EnablePlugins)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                sw.WriteLine(Transparency.ToString());
                sw.WriteLine(BackImg);
                sw.WriteLine(BackCl.R + "#" + BackCl.G + "#" + BackCl.B);
                sw.WriteLine(AutoPlayName);
                sw.WriteLine(SaveHeight);
                if (LrcDoubleLine)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                if (ExitArsk)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                sw.WriteLine(MiniPos.X + "#" + MiniPos.Y);
                sw.Close();
                sw.Dispose();

                FileStream mst=new FileStream(Application.StartupPath + @"\data\MusicPlayer.cfg", FileMode.Open);
                byte[] arrBufSrc = new byte[mst.Length];
                mst.Read(arrBufSrc, 0, (int)mst.Length);
                mst.Close();
                mst.Dispose();
                mst = null;
                int pDstLen = arrBufSrc.Length;
                byte[] arrBufDst = new byte[arrBufSrc.Length];
                Win32.compress(arrBufDst, ref pDstLen, arrBufSrc, arrBufSrc.Length);
                FileStream fr = new FileStream(Application.StartupPath + @"\data\MusicPlayer.cfg", FileMode.Create);
                byte[] len = BitConverter.GetBytes(arrBufSrc.Length);
                fr.Write(len, 0, 4);
                fr.Write(arrBufDst, 0, pDstLen);
                fr.Close();
                fr.Dispose();
                arrBufSrc = null;
                len = null;
                arrBufDst = null;
  
            }
            else
            {
                //Thread.Sleep(1000);
                Bass.BASS_ChannelStop(stream);
                Bass.BASS_StreamFree(stream);

                StreamWriter sw = new StreamWriter(Application.StartupPath + @"\data\MusicPlayer.cfg", false);
                sw.WriteLine(Pos.X.ToString() + "#" + Pos.Y.ToString());
                sw.WriteLine((tkb_sound.Value * 100).ToString("0"));
                if (AutoPlay)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                if (PlayerMod == PlayMod.listloop)
                    sw.WriteLine("0");
                else if (PlayerMod == PlayMod.list)
                    sw.WriteLine("1");
                else if (PlayerMod == PlayMod.loop)
                    sw.WriteLine("2");
                else if (PlayerMod == PlayMod.one)
                    sw.WriteLine("3");
                else if (PlayerMod == PlayMod.random)
                    sw.WriteLine("4");

                if (ExitWhenClose)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");

                if (IsTop)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                if (EnableSt)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");

                if (EnableSearch)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");

                if (Enableq)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                if (EnablePlugins)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                sw.WriteLine(Transparency.ToString());
                sw.WriteLine(BackImg);
                sw.WriteLine(BackCl.R + "#" + BackCl.G + "#" + BackCl.B);
                sw.WriteLine(AutoPlayName);
                sw.WriteLine(SaveHeight);
                if (LrcDoubleLine)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                if (ExitArsk)
                    sw.WriteLine("1");
                else
                    sw.WriteLine("0");
                sw.WriteLine(MiniPos.X + "#" + MiniPos.Y);
                sw.Close();
                sw.Dispose();

                FileStream mst = new FileStream(Application.StartupPath + @"\data\MusicPlayer.cfg", FileMode.Open);
                byte[] arrBufSrc = new byte[mst.Length];
                mst.Read(arrBufSrc, 0, (int)mst.Length);
                mst.Close();
                mst.Dispose();
                mst = null;
                int pDstLen = arrBufSrc.Length;
                byte[] arrBufDst = new byte[arrBufSrc.Length];
                Win32.compress(arrBufDst, ref pDstLen, arrBufSrc, arrBufSrc.Length);
                FileStream fr = new FileStream(Application.StartupPath + @"\data\MusicPlayer.cfg", FileMode.Create);
                byte[] len = BitConverter.GetBytes(arrBufSrc.Length);
                fr.Write(len, 0, 4);
                fr.Write(arrBufDst, 0, pDstLen);
                fr.Close();
                fr.Dispose();
                arrBufSrc = null;
                len = null;
                arrBufDst = null;


                SaveLists();
            }
        }
        private void LoadLists()
        {
            if (!File.Exists(Application.StartupPath + @"\data\MusicPlayer.xml"))
            {
                listfilemissing = true;
                XmlDocument doc1 = new XmlDocument();
                XmlElement root0 = doc1.CreateElement("Lists");
                doc1.AppendChild(root0);
                XmlElement group = doc1.CreateElement("Group");
                group.SetAttribute("name", "默认列表");
                root0.AppendChild(group);
                XmlElement group2 = doc1.CreateElement("Group");
                group2.SetAttribute("name", "我喜欢");
                root0.AppendChild(group2);
                doc1.Save(Application.StartupPath + @"\data\MusicPlayer.xml");
            }

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Application.StartupPath + @"\data\MusicPlayer.xml");
                XmlElement root = doc.DocumentElement;
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    string a = root.ChildNodes[i].Attributes["name"].InnerText;
                    musicList1.AddList(a);
                    for (int i1 = 0; i1 < root.ChildNodes[i].ChildNodes.Count; i1++)
                    {
                        musicList1.AddItem(root.ChildNodes[i].ChildNodes[i1].Attributes[0].InnerText, a, true);
                    }
                }
            }
            catch (Exception ee)
            {
                Program.WriteLog(ee.Message, DateTime.Now.ToString(), ee.ToString());
                MessageBox.Show("列表文件已经损坏。<Error 04>.\n 请重新启动迷你音乐。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ReDefList();
            }
            if (musicList1.Groups.Count < 2)
            {
                MessageBox.Show("列表文件已经损坏。<Error 02>.\n 请重新启动迷你音乐。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ReDefList();
            }
            else
            {
                if (musicList1.Groups[0].Name != "默认列表" || musicList1.Groups[1].Name != "我喜欢")
                {
                    MessageBox.Show("列表文件已经损坏。<Error 01>.\n 请重新启动迷你音乐。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ReDefList();
                }
            }

  
        }
        private void SaveLists()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Lists");
            doc.AppendChild(root);
            for (int i = 0; i < musicList1.Groups.Count; i++)
            {
                XmlElement group = doc.CreateElement("Item");
                group.SetAttribute("name", musicList1.Groups[i].Name);

                for (int i1 = 0; i1 < musicList1.Groups[i].musics.Count; i1++)
                {
                    XmlElement item = doc.CreateElement("Item");
                    if (musicList1.Groups[i].musics[i1].IsOnline)
                    {
                        item.SetAttribute("file", musicList1.Groups[i].musics[i1].URL);
                        item.SetAttribute("tag", "Internet");
                        item.SetAttribute("art", musicList1.Groups[i].musics[i1].Singer);
                        item.SetAttribute("length", musicList1.Groups[i].musics[i1].Length);
                        item.SetAttribute("alb", musicList1.Groups[i].musics[i1].Album);
                        item.SetAttribute("musictext", musicList1.Groups[i].musics[i1].Text);
                        item.SetAttribute("hash", musicList1.Groups[i].musics[i1].Hash);
                        item.SetAttribute("downloaded", musicList1.Groups[i].musics[i1].Downed);
                    }
                    else
                    {
                        item.SetAttribute("file", musicList1.Groups[i].musics[i1].Path);
                        item.SetAttribute("tag", "File");
                    }
                    group.AppendChild(item);
                }
                root.AppendChild(group);
            }
            doc.Save(Application.StartupPath + @"\data\MusicPlayer.xml");
        }

        #region SaveListsMethod
        private void ReDefList()
        {
            XmlDocument doc1 = new XmlDocument();
            XmlElement root0 = doc1.CreateElement("Lists");
            doc1.AppendChild(root0);
            XmlElement group = doc1.CreateElement("Group");
            group.SetAttribute("name", "默认列表");
            root0.AppendChild(group);
            XmlElement group2 = doc1.CreateElement("Group");
            group2.SetAttribute("name", "我喜欢");
            root0.AppendChild(group2);
            doc1.Save(Application.StartupPath + @"\data\MusicPlayer.xml");
            Process.GetCurrentProcess().Kill();
        }
        #endregion

        #endregion

        #endregion

        #region LoadUI

        #region DUI

        #region DuiControl
        DuiButton btn_up = new DuiButton();
        DuiButton btn_next = new DuiButton();
        DuiButton btn_playmod = new DuiButton();
        DuiButton btn_lrc = new DuiButton();
        DuiButton btn_openfile = new DuiButton();
        DuiButton btn_list = new DuiButton();
        DuiButton btn_skin = new DuiButton();
        DuiButton btn_settings = new DuiButton();
        DuiButton btn_min = new DuiButton();
        DuiButton btn_close = new DuiButton();
        DuiButton btn_loadmidifont = new DuiButton();
        DuiButton btn_tip_close = new DuiButton();

        DuiCheckButton btn_playpause = new DuiCheckButton();
        DuiCheckButton btn_top = new DuiCheckButton();

        DuiLabel lb_playing = new DuiLabel();
        DuiLabel lb_playtime = new DuiLabel();
        DuiLabel lb_playmod_text = new DuiLabel();
        DuiLabel lb_info_title = new DuiLabel();
        DuiLabel lb_info_text = new DuiLabel();

        DuiBaseControl lb_playingbg = new DuiBaseControl();
        DuiBaseControl pl_playmod = new DuiBaseControl();
        DuiBaseControl sp_pt = new DuiBaseControl();
        DuiBaseControl pb_info_icon = new DuiBaseControl();

        DuiTextButton btn_playmod_listlop = new DuiTextButton();
        DuiTextButton btn_playmod_list = new DuiTextButton();
        DuiTextButton btn_playmod_lop = new DuiTextButton();
        DuiTextButton btn_playmod_one = new DuiTextButton();
        DuiTextButton btn_playmod_random = new DuiTextButton();
        #endregion

        private void LoadDui()
        {
            btn_up.Location = new Point(12, 15);
            btn_next.Location = new Point(75, 15);
            btn_lrc.Location = new Point(148, 21);
            btn_playmod.Location = new Point(176,20);
            btn_playmod.Size = new Size(20, 20);
            btn_openfile.Location = new Point(234, 23);
            btn_list.Location = new Point(209, 23);
            btn_top.Location = new Point(294, 21);
            btn_skin.Location = new Point(317, 19);
            btn_settings.Location = new Point(338, 15);
            btn_min.Location = new Point(360, 18);
            btn_close.Location = new Point(385, 18);
            lb_playingbg.Location = new Point(12, 61);
            lb_playing.Location = new Point(0, 0);
            lb_playtime.Location = new Point(313, 61);
            btn_playpause.Location = new Point(42, 13);
            btn_playpause.Size = new Size(34, 34);
            lb_playmod_text.Size = new Size(100, 25);
            lb_playmod_text.Location = new Point(12, 18);
            btn_playmod_one.Location = new Point(10, 45);
            btn_playmod_list.Location = new Point(10, 75);
            btn_playmod_listlop.Location = new Point(10, 105);
            btn_playmod_lop.Location = new Point(10, 135);
            btn_playmod_random.Location = new Point(10, 165);
            sp_pt.Location = new Point(25, 48);
            sp_pt.Size = new Size(18, 10);
            btn_loadmidifont.Location = new Point(300, 39);
            pb_info_icon.Location = new Point(20, 6);
            pb_info_icon.Size = new Size(16,16);
            lb_info_title.Location = new Point(37, 1);
            lb_info_title.Size = new Size(340, 50);
            lb_info_text.Size = new Size(340, 45);
            lb_info_text.Location = new Point(37, 25);
            btn_tip_close.Location = new Point(380, 5);

            btn_up.NormalImage = Properties.Resources.btn_up_n;
            btn_up.HoverImage = Properties.Resources.btn_up_h;
            btn_up.PressedImage = Properties.Resources.btn_up_p;
            btn_next.NormalImage = Properties.Resources.btn_next_n;
            btn_next.HoverImage = Properties.Resources.btn_next_h;
            btn_next.PressedImage = Properties.Resources.btn_next_p;
            btn_openfile.NormalImage = Properties.Resources.btn_add_n;
            btn_openfile.HoverImage = Properties.Resources.btn_add_h;
            btn_openfile.PressedImage = Properties.Resources.btn_add_p;
            btn_list.NormalImage = Properties.Resources.btn_list_n;
            btn_list.HoverImage = Properties.Resources.btn_list_h;
            btn_list.PressedImage = Properties.Resources.btn_list_p;
            btn_lrc.NormalImage = Properties.Resources.btn_lrc_p;
            btn_lrc.HoverImage = Properties.Resources.btn_lrc_h;
            btn_lrc.PressedImage = Properties.Resources.btn_lrc_p;
            btn_skin.NormalImage = Properties.Resources.btn_skn_n;
            btn_skin.HoverImage = Properties.Resources.btn_skn_h;
            btn_skin.PressedImage = Properties.Resources.btn_skn_p;
            btn_settings.NormalImage = Properties.Resources.btn_set_n;
            btn_settings.HoverImage = Properties.Resources.btn_set_h;
            btn_settings.PressedImage = Properties.Resources.btn_set_p;
            btn_min.NormalImage = Properties.Resources.btn_min_n;
            btn_min.HoverImage = Properties.Resources.btn_min_h;
            btn_min.PressedImage = Properties.Resources.btn_min_p;
            btn_close.NormalImage = Properties.Resources.btn_close_b_n;
            btn_close.HoverImage = Properties.Resources.btn_close_b_h;
            btn_close.PressedImage = Properties.Resources.btn_close_b_p;
            btn_playpause.CheckedNorImg = Properties.Resources.btn_pause_n;
            btn_playpause.CheckedHovImg = Properties.Resources.btn_pause_h;
            btn_playpause.CheckedPreImg = Properties.Resources.btn_pause_p;
            btn_playpause.UnCheckedNorImg = Properties.Resources.btn_play_n;
            btn_playpause.UnCheckedHovImg = Properties.Resources.btn_play_h;
            btn_playpause.UnCheckedPreImg = Properties.Resources.btn_play_p;
            btn_top.CheckedNorImg = Properties.Resources.btn_untop_n;
            btn_top.CheckedHovImg = Properties.Resources.btn_untop_h;
            btn_top.CheckedPreImg = Properties.Resources.btn_untop_p;
            btn_top.UnCheckedNorImg = Properties.Resources.btn_top_n;
            btn_top.UnCheckedHovImg = Properties.Resources.btn_top_h;
            btn_top.UnCheckedPreImg = Properties.Resources.btn_top_p;
            btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_listloop;
            btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_listloop;
            btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_listloop;
            btn_playmod_listlop.NormalImage = Properties.Resources.btn_playmod_big_n_listloop;
            btn_playmod_listlop.HoverImage = Properties.Resources.btn_playmod_big_h_listloop;
            btn_playmod_one.NormalImage = Properties.Resources.btn_playmod_big_n_one;
            btn_playmod_one.HoverImage = Properties.Resources.btn_playmod_big_h_one;
            btn_playmod_lop.NormalImage = Properties.Resources.btn_playmod_big_n_loop;
            btn_playmod_lop.HoverImage = Properties.Resources.btn_playmod_big_h_loop;
            btn_playmod_list.NormalImage = Properties.Resources.btn_playmod_big_n_list;
            btn_playmod_list.HoverImage = Properties.Resources.btn_playmod_big_h_list;
            btn_playmod_random.NormalImage = Properties.Resources.btn_playmod_big_n_random;
            btn_playmod_random.HoverImage = Properties.Resources.btn_playmod_big_h_random;
            btn_loadmidifont.NormalImage = Properties.Resources.btn_custom_font_n;
            btn_loadmidifont.HoverImage = Properties.Resources.btn_custom_font_h;
            btn_loadmidifont.PressedImage = Properties.Resources.btn_custom_font_p;
            btn_tip_close.NormalImage = Properties.Resources.btn_close_n;
            btn_tip_close.HoverImage = Properties.Resources.btn_close_h;
            btn_tip_close.PressedImage = Properties.Resources.btn_close_b_p;
            sp_pt.BackgroundImage = Properties.Resources.pt;

            btn_top.CheckOnClick = true;
            btn_top.Size = btn_top.CheckedNorImg.Size;
            lb_playingbg.Size = new Size(300, 30);
            lb_playing.AutoSize = true;
            lb_playing.ForeColor = Color.White;
            lb_playing.Text = "让音乐快乐你的生活！";
            lb_playing.Font = new Font("微软雅黑", 9f);
            lb_playing.Size = new Size(180, 30);
            lb_playing.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            lb_playtime.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            lb_playtime.Size = new Size(85, 17);
            lb_playtime.ForeColor = Color.White;
            lb_playtime.Text = "00:00/00:00";
            lb_playtime.Font = new Font("微软雅黑", 9f);
            lb_playtime.TextAlign = ContentAlignment.TopRight;
            lb_playmod_text.Text = "设置播放模式";
            lb_playmod_text.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            lb_playmod_text.Font = new Font("微软雅黑", 10.5f);
            lb_playmod_text.ForeColor = Color.White;

            lb_info_title.Text = "";
            lb_info_title.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            lb_info_title.Font = new Font("微软雅黑", 12f);
            lb_info_title.ForeColor = Color.White;
            lb_info_text.Text = "";
            lb_info_text.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            lb_info_text.Font = new Font("微软雅黑", 9f);
            lb_info_text.ForeColor = Color.White;

            btn_playmod_one.Text = "单曲播放";
            btn_playmod_lop.Text = "单曲循环";
            btn_playmod_listlop.Text = "列表循环";
            btn_playmod_list.Text = "列表播放";
            btn_playmod_random.Text = "随机播放";
            btn_playmod_one.Tag = "one";
            btn_playmod_lop.Tag = "lop";
            btn_playmod_listlop.Tag = "listlop";
            btn_playmod_list.Tag = "list";
            btn_playmod_random.Tag = "random";
            pb_intro.BackColor = Color.FromArgb(200, 0, 0, 0);
            btn_loadmidifont.Visible = false;

            btn_min.MouseClick += Btn_min_MouseClick;
            btn_close.MouseClick += Btn_close_MouseClick;
            btn_list.MouseClick += Btn_list_MouseClick;
            btn_skin.MouseClick += Btn_skin_MouseClick;
            btn_top.MouseClick += Btn_top_MouseClick;
            btn_lrc.MouseClick += Btn_lrc_MouseClick;
            btn_playpause.MouseClick += Btn_playpause_MouseClick;
            btn_openfile.MouseClick += Btn_openfile_MouseClick;
            btn_next.MouseClick += Btn_next_MouseClick;
            btn_up.MouseClick += Btn_up_MouseClick;
            btn_playmod.MouseClick += Btn_playmod_MouseClick;
            btn_playmod_one.MouseClick += Lb_playmod_MouseClick;
            btn_playmod_listlop.MouseClick += Lb_playmod_MouseClick;
            btn_playmod_lop.MouseClick += Lb_playmod_MouseClick;
            btn_playmod_list.MouseClick += Lb_playmod_MouseClick;
            btn_playmod_random.MouseClick += Lb_playmod_MouseClick;
            btn_settings.MouseClick += Btn_settings_MouseClick;
            btn_loadmidifont.MouseClick += Btn_loadmidifont_MouseClick;
            btn_tip_close.MouseClick += Btn_info_close_MouseClick;

            lb_playingbg.Controls.Add(lb_playing);            

            pl_bg.DUIControls.Add(btn_up);
            pl_bg.DUIControls.Add(btn_next);
            pl_bg.DUIControls.Add(btn_settings);
            pl_bg.DUIControls.Add(btn_min);
            pl_bg.DUIControls.Add(btn_close);
            pl_bg.DUIControls.Add(btn_skin);
            pl_bg.DUIControls.Add(lb_playingbg);
            pl_bg.DUIControls.Add(btn_playmod);
            pl_bg.DUIControls.Add(lb_playtime);            
            pl_bg.DUIControls.Add(btn_playpause);
            pl_bg.DUIControls.Add(btn_list);
            pl_bg.DUIControls.Add(btn_openfile);
            pl_bg.DUIControls.Add(btn_lrc);
            pl_bg.DUIControls.Add(btn_top);
            pl_bg.DUIControls.Add(btn_loadmidifont);

            pl_tip_container.DUIControls.Add(btn_tip_close);
            pl_tip_container.DUIControls.Add(pb_info_icon);
            pl_tip_container.DUIControls.Add(lb_info_text);
            pl_tip_container.DUIControls.Add(lb_info_title);

            #region Tooltip
            btn_up.MouseEnter += Btn_up_MouseEnter;
            btn_next.MouseEnter += Btn_up_MouseEnter;
            btn_playmod.MouseEnter += Btn_up_MouseEnter;
            btn_lrc.MouseEnter += Btn_up_MouseEnter;
            btn_openfile.MouseEnter += Btn_up_MouseEnter;
            btn_list.MouseEnter += Btn_up_MouseEnter;
            btn_skin.MouseEnter += Btn_up_MouseEnter;
            btn_settings.MouseEnter += Btn_up_MouseEnter;
            btn_min.MouseEnter += Btn_up_MouseEnter;
            btn_playpause.MouseEnter += Btn_up_MouseEnter;
            btn_top.MouseEnter += Btn_up_MouseEnter;
            btn_loadmidifont.MouseEnter += Btn_up_MouseEnter;

            btn_loadmidifont.MouseLeave += Btn_up_MouseLeave;
            btn_top.MouseLeave += Btn_up_MouseLeave;
            btn_playpause.MouseLeave += Btn_up_MouseLeave;
            btn_up.MouseLeave += Btn_up_MouseLeave; 
            btn_next.MouseLeave += Btn_up_MouseLeave;
            btn_playmod.MouseLeave += Btn_up_MouseLeave;
            btn_lrc.MouseLeave += Btn_up_MouseLeave;
            btn_openfile.MouseLeave += Btn_up_MouseLeave;
            btn_list.MouseLeave += Btn_up_MouseLeave;
            btn_skin.MouseLeave += Btn_up_MouseLeave;
            btn_settings.MouseLeave += Btn_up_MouseLeave;
            btn_min.MouseLeave += Btn_up_MouseLeave;

            btn_up.Tag = "上一首";
            btn_next.Tag = "下一首";
            btn_playmod.Tag = "设置播放模式";
            btn_lrc.Tag = "显示/隐藏歌词";
            btn_openfile.Tag = "打开音乐";
            btn_list.Tag = "显示/隐藏列表";
            btn_skin.Tag = "皮肤";
            btn_settings.Tag = "主菜单";
            btn_min.Tag = "最小化";
            btn_playpause.Tag = "播放";
            btn_top.Tag = "固定在最前端";
            btn_loadmidifont.Tag = "正在播放MIDI音乐，您可以使用自己喜爱的音色库，单击添加。";
            #endregion

            #region PlayMod

            pl_playmodbg.DUIControls.Add(lb_playmod_text);
            pl_playmodbg.DUIControls.Add(btn_playmod_one);
            pl_playmodbg.DUIControls.Add(btn_playmod_listlop);
            pl_playmodbg.DUIControls.Add(btn_playmod_lop);
            pl_playmodbg.DUIControls.Add(btn_playmod_list);
            pl_playmodbg.DUIControls.Add(btn_playmod_random);
            #endregion
        }

        #endregion

        #region Compent

        #region Menu
        private Plugin.ContextMenu contextMenu1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private Plugin.ContextMenu contextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 本地音乐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本地音乐文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 默认列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我喜欢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 选择其他列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem 打开文件位置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem 格式转换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 铃声制作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在线搜索ToolStripMenuItem;
        private Plugin.ContextMenu contextMenuList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem 本地音乐ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 本地音乐文件夹ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 排序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        #endregion

        #region Timers
        private System.Windows.Forms.Timer timerintro = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerTime = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerText = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerPlaying = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer fadeTimer2 = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer tipTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer inTimer = new System.Windows.Forms.Timer();
        #endregion

        private void LoadCompent()
        {
            LoadDui();

            this.contextMenu1 = new MusicPlayer.Plugin.ContextMenu();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem = new MusicPlayer.Plugin.ContextMenu();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.本地音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本地音乐文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.默认列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我喜欢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.选择其他列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.格式转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.铃声制作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在线搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuList = new MusicPlayer.Plugin.ContextMenu();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.本地音乐ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.本地音乐文件夹ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.contextMenu1.SuspendLayout();
            this.contextMenuItem.SuspendLayout();
            this.contextMenuList.SuspendLayout();

            this.contextMenu1.BackColor = System.Drawing.Color.White;
            this.contextMenu1.ForeColor = System.Drawing.Color.Black;
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.testToolStripMenuItem});
            this.contextMenu1.Name = "contextMenu1";
            this.contextMenu1.Size = new System.Drawing.Size(101, 48);
            this.退出ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            this.testToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            this.contextMenuItem.BackColor = System.Drawing.Color.White;
            this.contextMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contextMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripMenuItem6,
            this.打开文件位置ToolStripMenuItem,
            this.toolStripSeparator6,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator1,
            this.toolStripMenuItem7,
            this.在线搜索ToolStripMenuItem});
            this.contextMenuItem.Name = "contextMenu1";
            this.contextMenuItem.Size = new System.Drawing.Size(173, 220);
            this.contextMenuItem.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuItem_Closing);
            this.contextMenuItem.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuItem_Opening);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem1.Text = "播放音乐";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.本地音乐ToolStripMenuItem,
            this.本地音乐文件夹ToolStripMenuItem});
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem5.Text = "添加歌曲到此列表";
            this.本地音乐ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.本地音乐ToolStripMenuItem.Name = "本地音乐ToolStripMenuItem";
            this.本地音乐ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.本地音乐ToolStripMenuItem.Text = "本地音乐";
            this.本地音乐ToolStripMenuItem.Click += new System.EventHandler(this.本地音乐ToolStripMenuItem_Click);
            this.本地音乐文件夹ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.本地音乐文件夹ToolStripMenuItem.Name = "本地音乐文件夹ToolStripMenuItem";
            this.本地音乐文件夹ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.本地音乐文件夹ToolStripMenuItem.Text = "本地音乐文件夹";
            this.本地音乐文件夹ToolStripMenuItem.Click += new System.EventHandler(this.本地音乐文件夹ToolStripMenuItem_Click);
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.默认列表ToolStripMenuItem,
            this.我喜欢ToolStripMenuItem,
            this.toolStripSeparator3,
            this.选择其他列表ToolStripMenuItem});
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem4.Text = "插入到列表";
            this.默认列表ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.默认列表ToolStripMenuItem.Name = "默认列表ToolStripMenuItem";
            this.默认列表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.默认列表ToolStripMenuItem.Text = "默认列表";
            this.默认列表ToolStripMenuItem.Click += new System.EventHandler(this.默认列表ToolStripMenuItem_Click);
            this.我喜欢ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.我喜欢ToolStripMenuItem.Name = "我喜欢ToolStripMenuItem";
            this.我喜欢ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.我喜欢ToolStripMenuItem.Text = "我喜欢";
            this.我喜欢ToolStripMenuItem.Click += new System.EventHandler(this.我喜欢ToolStripMenuItem_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            this.选择其他列表ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.选择其他列表ToolStripMenuItem.Name = "选择其他列表ToolStripMenuItem";
            this.选择其他列表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.选择其他列表ToolStripMenuItem.Text = "选择其他列表";
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem6.Text = "歌曲信息";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            this.打开文件位置ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.打开文件位置ToolStripMenuItem.Name = "打开文件位置ToolStripMenuItem";
            this.打开文件位置ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.打开文件位置ToolStripMenuItem.Text = "打开文件位置";
            this.打开文件位置ToolStripMenuItem.Click += new System.EventHandler(this.打开文件位置ToolStripMenuItem_Click);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(169, 6);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem2.Text = "删除";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem3.Text = "删除（包括文件）";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.格式转换ToolStripMenuItem,
            this.铃声制作ToolStripMenuItem});
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem7.Text = "小工具";
            this.格式转换ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.格式转换ToolStripMenuItem.Name = "格式转换ToolStripMenuItem";
            this.格式转换ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.格式转换ToolStripMenuItem.Text = "格式转换";
            this.铃声制作ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.铃声制作ToolStripMenuItem.Name = "铃声制作ToolStripMenuItem";
            this.铃声制作ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.铃声制作ToolStripMenuItem.Text = "铃声制作";
            this.在线搜索ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.在线搜索ToolStripMenuItem.Name = "在线搜索ToolStripMenuItem";
            this.在线搜索ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.在线搜索ToolStripMenuItem.Text = "在线搜索";
            this.contextMenuList.BackColor = System.Drawing.Color.White;
            this.contextMenuList.ForeColor = System.Drawing.Color.Black;
            this.contextMenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripSeparator5,
            this.toolStripMenuItem9,
            this.排序ToolStripMenuItem,
            this.清空列表ToolStripMenuItem,
            this.删除列表ToolStripMenuItem,
            this.重命名ToolStripMenuItem});
            this.contextMenuList.Name = "contextMenu1";
            this.contextMenuList.Size = new System.Drawing.Size(125, 142);
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem8.Text = "新建列表";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(121, 6);
            this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.本地音乐ToolStripMenuItem1,
            this.本地音乐文件夹ToolStripMenuItem1});
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem9.Text = "添加歌曲";
            this.本地音乐ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.本地音乐ToolStripMenuItem1.Name = "本地音乐ToolStripMenuItem1";
            this.本地音乐ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.本地音乐ToolStripMenuItem1.Text = "本地音乐";
            this.本地音乐ToolStripMenuItem1.Click += new System.EventHandler(this.本地音乐ToolStripMenuItem_Click);
            this.本地音乐文件夹ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.本地音乐文件夹ToolStripMenuItem1.Name = "本地音乐文件夹ToolStripMenuItem1";
            this.本地音乐文件夹ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.本地音乐文件夹ToolStripMenuItem1.Text = "本地音乐文件夹";
            this.本地音乐文件夹ToolStripMenuItem1.Click += new System.EventHandler(this.本地音乐文件夹ToolStripMenuItem_Click);
            this.排序ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.排序ToolStripMenuItem.Name = "排序ToolStripMenuItem";
            this.排序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.排序ToolStripMenuItem.Text = "排序";
            this.清空列表ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem";
            this.清空列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空列表ToolStripMenuItem.Text = "清空列表";
            this.清空列表ToolStripMenuItem.Click += new System.EventHandler(this.清空列表ToolStripMenuItem_Click);
            this.删除列表ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.删除列表ToolStripMenuItem.Name = "删除列表ToolStripMenuItem";
            this.删除列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除列表ToolStripMenuItem.Text = "删除列表";
            this.删除列表ToolStripMenuItem.Click += new System.EventHandler(this.删除列表ToolStripMenuItem_Click);
            this.重命名ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new Size(124, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            重命名ToolStripMenuItem.Click += 重命名ToolStripMenuItem_Click;
            timerintro.Interval = 2000;
            timerintro.Tick += timerintro_Tick;
            timerTime.Interval = 500;
            timerTime.Tick += timerTime_Tick;
            timerText.Interval = 1000;
            timerText.Tick += timerText_Tick;
            timerPlaying.Interval = 200;
            timerPlaying.Tick += timerPlaying_Tick;
            timer1.Interval = 625;
            timer1.Tick += timer1_Tick;
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Interval = 50;
            fadeTimer2.Tick += FadeTimer2_Tick; ;
            fadeTimer2.Interval = 625;
            tipTimer.Interval = 80000;
            tipTimer.Tick += TipTimer_Tick;
            inTimer.Interval = 500;
            inTimer.Tick += InTimer_Tick;

            this.contextMenu1.ResumeLayout(false);
            this.contextMenuItem.ResumeLayout(false);
            this.contextMenuList.ResumeLayout(false);
        }
        #endregion

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            minifm = new FormMini(this);
            autoDocker1.Initialize(this);
            plugin1 = Bass.BASS_PluginLoad(Application.StartupPath + @"\codecs\dcbass\bass_aac.dll");
            plugin2 = Bass.BASS_PluginLoad(Application.StartupPath + @"\codecs\dcbass\bass_flac.dll");
            plugin3 = Bass.BASS_PluginLoad(Application.StartupPath + @"\codecs\dcbass\bass_wma.dll");
            plugin4 = Bass.BASS_PluginLoad(Application.StartupPath + @"\codecs\dcbass\bass_midi.dll");
            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_CPSPEAKERS, Handle))
            {
                MessageBox.Show("初始化播放模块错误\n程序即将退出", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            Thread t = new Thread(LoadSettings);
            t.Start();

            timerintro.Start();

            pl_bg.BackgroundImageLayout = ImageLayout.Stretch;

            #region WindowHandle
            int winHandler = Win32.FindWindow(null, Text);
            StreamWriter sr = new StreamWriter(Application.StartupPath + "\\data\\MusicPlayer.dat", false);
            sr.WriteLine(winHandler.ToString());
            sr.Close();
            #endregion

            GC.Collect();
            pb_drawbar.BackColor = Color.FromArgb(20, 255, 255, 255);
            pb_drawbar.BringToFront();
            eqloading();

            scorllbar.Show();
            scorllbar.BackColor = Color.FromArgb(100, 200, 200, 200);
            musicList1.Height = Height - musicList1.Top - 19;
            pl_bg.Height = Height - pl_bg.Top;
            pl_bg.Name = "DuiContainer";
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitWhenClose || exit)
            {
                e.Cancel = false;
                minifm.Close();
                Pos = Location;
                Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_HIDE | Win32.AW_SLIDE);
                Bass.BASS_PluginFree(plugin1); //Bass.BASS_PluginFree(plugin6);
                Bass.BASS_PluginFree(plugin2); //Bass.BASS_PluginFree(plugin5);
                Bass.BASS_PluginFree(plugin3); Bass.BASS_PluginFree(plugin4);
                SaveSettings();               
            }
            else
            {
                e.Cancel = true;
                if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_HIDE))
                {
                    //Win32.AnimateWindow(this.Handle, 300, Win32.AW_BLEND | Win32.AW_ACTIVATE);
                    Win32.ShowWindow(Handle, 5);
                    Win32.ShowWindow(Handle, 0);
                }
            }
        }

        #region MoveWindow
        protected override void OnResize(EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                autoDocker1.Initialize(this);
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                autoDocker1.UnInitialize(this);
            }
        }
        private void pl_bg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Moveing = true;
                MovePoint = PointToClient(MousePosition);
            }
        }
        private void pl_bg_MouseMove(object sender, MouseEventArgs e)
        {
            if (Moveing)
            {
                if (Top >= -5 && Left >= -5 && Top + Height <= Screen.PrimaryScreen.Bounds.Height && Left + Width <= Screen.PrimaryScreen.Bounds.Width + 5)
                    Location = new Point(MousePosition.X - MovePoint.X, MousePosition.Y - MovePoint.Y);
                else
                {
                    if (Top < -5)
                        Top = -5;
                    if (Left < -5)
                        Left = -5;
                    if (Top + Height > Screen.PrimaryScreen.Bounds.Height)
                        Top = Screen.PrimaryScreen.Bounds.Height - Height;
                    if (Left + Width > Screen.PrimaryScreen.Bounds.Width + 5)
                        Left = Screen.PrimaryScreen.Bounds.Width + 5 - Width;
                    MovePoint = PointToClient(MousePosition);
                }
            }
        }
        private void pl_bg_MouseUp(object sender, MouseEventArgs e)
        {
            Moveing = false;
        }

        #endregion

        #region Form message

        #region Messages
        const int WM_COMMAND = 0x0111;
        const int WM_DWMSENDICONICTHUMBNAIL = 0x0323;
        const int WM_DWMSENDICONICLIVEPREVIEWBITMAP = 0x0326;
        int WM_TASKBARBUTTONCREATED = 0x0000;
        #endregion

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WinMessageUntil.WM_COPYDATA:
                    string str = WinMessageUntil.Receive(ref m);
                    Reload(str);
                    break;           
                default:
                    base.WndProc(ref m);
                    break;
            }
        }       
        void Reload(string str)
        {
            if (str.Contains("#"))
            {
                string[] str1 = str.Split(new char[] { '#' });
                if (str1[0] == "reopen")
                {
                    Show();
                    if (WindowState != FormWindowState.Normal)
                        WindowState = FormWindowState.Normal;
                    Win32.SetForegroundWindow(Handle);
                }
                else if (str1[0] == "music")
                {
                    Show();
                    Win32.SetForegroundWindow(Handle);
                    if (File.Exists(str1[1]))
                        openfile(str1[1]);
                }
            }
            else if (str == "exit")
            {
                BASSActive b = Bass.BASS_ChannelIsActive(stream);
                if (b == BASSActive.BASS_ACTIVE_PLAYING)
                {
                    playpause(false, false, true);
                    timer1.Start();
                }
                else
                {
                    exit = true;
                    Close();
                }
            }
            else if (str == "show")
            {
                Win32.ShowWindow(Handle, 4);
                if (WindowState != FormWindowState.Normal)
                    WindowState = FormWindowState.Normal;
                Win32.SetForegroundWindow(Handle);
            }
            else if (str == "eq")
            {
                FormEq f = new FormEq(this);
                f.ShowDialog(this);
                f.Dispose();
                f = null;
                GC.Collect();
            }
            else if (str == "closemini")
            {
                Show();
                mini = false;
            }
            else if (str == "mini")
            {
                Hide();
                mini = true;
                minifm.Show();
            }
            else if (str == "addfile")
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "音乐文件|*.mp3;*.wav;*.mid;*.m4a;*.ogg;*.flac;*.cd;*ra|所有文件|*.*";
                op.Title = "打开音乐（可多选）";
                op.Multiselect = true;
                if (op.ShowDialog(this) == DialogResult.OK)
                {
                    if (op.FileName.Length == 1)
                        openfile(op.FileName);
                    else
                    {
                        for (int i = 0; i < op.FileNames.Length; i++)
                        {
                            musicList1.AddItem(op.FileNames[i], musicList1.OpenedList,true);
                        }
                    }
                }
                op.Dispose();
                GC.Collect();
            }
            else if (str == "addfolder")
            {
                Plugins.FolderBrowserDialog f = new Plugins.FolderBrowserDialog();
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    FormProgress fp = new FormProgress();
                    fp.Value = 0;
                    fp.Show();
                    List<string> t = GetFiles(new DirectoryInfo(f.DirectoryPath), "*.mp3");
                    for (int i = 0; i < t.Count; i++)
                    {
                        fp.Value = (double)i / (double)t.Count;
                        fp.File = t[i];
                        musicList1.AddItem(t[i], musicList1.OpenedList, true);
                    }
                    fp.Close();
                    PrintMsg("成功添加" + t.Count + "首音乐！", "", 8000);
                    t = null;
                    fp.Dispose();
                    fp = null;
                }
                f.Dispose();
                f = null;
                GC.Collect();
            }
            else if (str == "about")
            {
                FormAbout f = new FormAbout();
                f.ShowDialog(this);
                f.Dispose();
                f = null;
                GC.Collect();
            }
            else if (str == "setting")
            {
                FormSetting fs = new FormSetting(this);
                fs.ShowDialog(this);
                fs.Dispose();
                fs = null;
                GC.Collect();
            }
        }       
        #endregion

        #region Form Events

        public string Itext1 = "";
        public string Itext2 = "";
        public string Itime = "";
        public event EventHandler OnMusicChanged;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);  
        }
        private void InTimer_Tick(object sender, EventArgs e)
        {
            inTimer.Stop();          
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | 0x00020000;
                return cp;
            }
        }
        public string BackGroundSkin
        {
            get { return BackImg; }
            set
            {
                BackImg = value; 
                if (value != "N/A")
                {
                    Image ix = Image.FromFile(value); Rectangle a = new Rectangle(new Point(), ix.Size); pl_bg.BackgroundImage = Plugins.ImageVague.GaussianBlur(new Bitmap(ix), ref a, 20, false);
                }
                else
                {
                    pl_bg.BackgroundImage = null;
                }
            }
        }
        private void FormMain_Shown(object sender, EventArgs e)
        {
        }
        public override void UpdateLayeredWindow(Bitmap b)
        {
            tr = b;
            base.UpdateLayeredWindow(b);
        }
        public override void UpdateLayeredWindow(Bitmap b,double op)
        {
            tr = b;
            base.UpdateLayeredWindow(b, op);
        }
        #endregion

        #region Control Events

        #region Controls
        
        private void TipTimer_Tick(object sender, EventArgs e)
        {
            pl_tip_container.Hide();
            tipTimer.Stop();
        }
        private void pb_drawbar_MouseDown(object sender, MouseEventArgs e)
        {
            rsizeing = true;
        }
        private void pb_drawbar_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.SizeNS;
            if (rsizeing)
            {
                if (Height >= 485)
                {
                    if (MousePosition.Y - Top > 485)
                    {
                        this.Height = MousePosition.Y - Top; pl_bg.Height = Height;
                        musicList1.Height = Height - musicList1.Top - 26;
                        SaveHeight = this.Height;
                        musicList1.RefreshList();
                    }
                }
                else
                {
                    this.Height = 485; pl_bg.Height = Height;
                    musicList1.Height = Height - musicList1.Top - 26;
                    SaveHeight = 485;
                    musicList1.RefreshList();
                }
            }
        }
        private void pb_drawbar_MouseUp(object sender, MouseEventArgs e)
        {
            rsizeing = false;
        }
        private void pb_drawbar_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.SizeNS;
        }
        private void pb_drawbar_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
        private void Btn_up_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(this);
        }
        private void Btn_up_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show(((DuiBaseControl)sender).Tag.ToString(), this, PointToClient(MousePosition).X, PointToClient(MousePosition).Y + 23, 2000);
        }
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormSetting f = new FormSetting();
            //FormKg f = new FormKg();
            //f.Show();
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                FormNotifyMenucs f = new FormNotifyMenucs(this);
                f.Show();
                f.Location = new Point(MousePosition.X - f.Width, MousePosition.Y - f.Height);
            }
        }
        public static List<string> GetFiles(DirectoryInfo directory, string pattern)
        {
            List<string> result = new List<string>();
            if (directory.Exists || pattern.Trim() != string.Empty)
            {
                try
                {
                    foreach (FileInfo info in directory.GetFiles(pattern))
                    {
                        result.Add(info.FullName.ToString());
                    }
                }
                catch { }
                foreach (DirectoryInfo info in directory.GetDirectories())
                {
                    GetFiles(info, pattern);
                }
            }
            return result;
        }
        private void id3(string file)
        {
            try
            {
                ID3.ID3Info info = new ID3.ID3Info(file, true);
                Image b = null;

                foreach (ID3.ID3v2Frames.BinaryFrames.AttachedPictureFrame AP in info.ID3v2Info.AttachedPictureFrames.Items)
                {
                    if (AP.Data != null)
                        b = Image.FromStream(AP.Data);//添加到PicturBOX内
                }

                if (b != null)
                {
                    musicList1.SetIsPlayingAb(file, b);
                    abmpx = new Bitmap(b);
                }
                
            }
            catch { }
            GC.Collect();
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!mini)
            {
                if (!Win32.IsWindowVisible(Handle))
                {
                    Random r = new Random();
                    int ii = r.Next(0, 4);
                    if (ii == 0)
                        Win32.AnimateWindow(Handle, 300, Win32.AW_HOR_POSITIVE | Win32.AW_SLIDE | Win32.AW_ACTIVATE);
                    else if (ii == 1)
                        Win32.AnimateWindow(Handle, 300, Win32.AW_HOR_NEGATIVE | Win32.AW_SLIDE | Win32.AW_ACTIVATE);
                    else if (ii == 3)
                        Win32.AnimateWindow(Handle, 300, Win32.AW_VER_NEGATIVE | Win32.AW_SLIDE | Win32.AW_ACTIVATE);
                    else if (ii == 2)
                        Win32.AnimateWindow(Handle, 300, Win32.AW_VER_POSITIVE | Win32.AW_SLIDE | Win32.AW_ACTIVATE);
                    else if (ii == 4)
                        Win32.AnimateWindow(Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE);

                    Win32.ShowWindow(Handle, 0); Win32.ShowWindow(Handle, 5);
                    Win32.SetForegroundWindow(Handle);
                    Thread.Sleep(500);
                    GC.Collect();
                }
            }
            else
            {

            }
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playpause(false, false, true);
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            exit = true;
            Close();
        }
        private void timerintro_Tick(object sender, EventArgs e)
        {
            if (loadok)
            {
                timerintro.Stop();
                pb_intro.Hide();
                if (OpenCommand != "")
                {
                    if (File.Exists(OpenCommand))
                    {
                        openfile(OpenCommand);
                    }
                }
                else if (AutoPlay)
                {
                    if (AutoPlayName != "NUL")
                        if (musicList1.IsInList(AutoPlayName))
                        {
                            openfile(AutoPlayName);
                        }
                }
                scorllbar.BringToFront();
                if (listfilemissing)
                    PrintError("无法读取列表文件，找不到列表文件", "列表文件已经丢失，您以前添加的音乐已经消失了。请确认您是否误删列表文件。");
                if (settingfilemissing)
                    PrintError("无法读取设置，找不到设置文件。所有设置已经恢复默认。", "");
                //lrcrfm.Show();
                Height = SaveHeight;
                this.Height = SaveHeight; pl_bg.Height = Height;
                musicList1.Height = Height - musicList1.Top - 26;
                GC.Collect();
            }
        }
        private void tkb_basic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tarking = true;
            }
        }
        private void tkb_basic_MouseUp(object sender, MouseEventArgs e)
        {
            tarking = false;
            BASSActive b = Bass.BASS_ChannelIsActive(stream);
            if (b == BASSActive.BASS_ACTIVE_PLAYING)
            {
                playpause(false, false, true);
                fadeTimer2.Start();
                timerTime.Stop();
            }
            else if (b == BASSActive.BASS_ACTIVE_PAUSED)
            {
                Bass.BASS_ChannelSetPosition(stream, tkb_basic.Value * Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream)));
                playpause(true);
            }
            else
            {
                tkb_basic.Value = 0;
            }
            //Bass.BASS_ChannelSetPosition(stream, tkb_basic.Value * Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream)));
        }
        private void musicList1_MouseEnter(object sender, EventArgs e)
        {
            musicList1.Select();
        }
        private void musicList1_DragDrop(object sender, DragEventArgs e)
        {
            Array list = ((System.Array)e.Data.GetData(DataFormats.FileDrop));
            string a = musicList1.OpenedList;
            if (list.Length > 1)
            {               
                if (a == "")
                    a = "默认列表";
                for (int i = 0; i < list.Length; i++)
                {
                    musicList1.AddItem(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(i).ToString(), a, true);
                }
            }
            else
            {
                musicList1.AddItem(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString(), a,  true);
            }
        }
        private void musicList1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }
        #endregion

        #region RollText
        private void timerText_Tick(object sender, EventArgs e)
        {

        }
        private void timerPlaying_Tick(object sender, EventArgs e)
        {
            if (playingShowl)
            {
                if (lb_playing.Left > 290 - lb_playing.Width)
                {
                    lb_playing.Left = lb_playing.Left - 2;
                }
                else
                {
                    lb_playing.Left = 290 - lb_playing.Width;
                    playingShowl = false;
                }
            }
            else
            {
                if (lb_playing.Left < 10)
                {
                    lb_playing.Left = lb_playing.Left + 2;
                }
                else
                {
                    lb_playing.Left = 10;
                    playingShowl = true;
                }
            }
        }
        #endregion

        #region Button Events      

        private void Btn_info_close_MouseClick(object sender, DuiMouseEventArgs e)
        {
            pl_tip_container.Visible = false;
        }
        private void Btn_loadmidifont_MouseClick(object sender, DuiMouseEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "音色库文件|*.sf2";
            op.Title = "打开音色库";
            if (op.ShowDialog() == DialogResult.OK)
            {
                midifont = Un4seen.Bass.AddOn.Midi.BassMidi.BASS_MIDI_FontInit(Application.StartupPath + "\\TimGM6mb.sf2");
                midifontz.bank = 0; midifontz.preset = -1; midifontz.font = midifont;
                Un4seen.Bass.AddOn.Midi.BASS_MIDI_FONT[] fx = { midifontz, };
                Un4seen.Bass.AddOn.Midi.BassMidi.BASS_MIDI_StreamSetFonts(stream, fx, 1);
                deffont = op.FileName;
            }            
            op.Dispose();
            GC.Collect();
        }
        private void Btn_settings_MouseClick(object sender, DuiMouseEventArgs e)
        {
            FormMainMenu f = new FormMainMenu();
            f.ShowW(MousePosition);
        }
        private void Lb_playmod_MouseClick(object sender, DuiMouseEventArgs e)
        {
            string b = ((DuiBaseControl)sender).Tag.ToString();
            if (b == "one")
            {
                btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_one;
                btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_one;
                btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_one;
                PlayerMod = PlayMod.one;
                pl_playmodbg.Hide();
            }
            else if (b == "listlop")
            {
                btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_listloop;
                btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_listloop;
                btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_listloop;
                PlayerMod = PlayMod.listloop;
            }
            else if (b == "list")
            {
                btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_list;
                btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_list;
                btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_list;
                PlayerMod = PlayMod.list;
            }
            else if (b == "lop")
            {
                btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_loop;
                btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_loop;
                btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_loop;
                PlayerMod = PlayMod.loop;
            }
            else if (b == "random")
            {
                btn_playmod.NormalImage = Properties.Resources.btn_playmod_big_n_random;
                btn_playmod.HoverImage = Properties.Resources.btn_playmod_big_h_random;
                btn_playmod.PressedImage = Properties.Resources.btn_playmod_big_p_random;
                PlayerMod = PlayMod.random;              
            }
            pl_playmodbg.Hide();
        }
        private void Btn_playmod_MouseClick(object sender, DuiMouseEventArgs e)
        {
            if(pl_playmodbg.Visible)
            {
                pl_playmodbg.Hide();
            }
            else
            {
                pl_playmodbg.Show();
            }
        }
        public void Btn_up_MouseClick(object sender, DuiMouseEventArgs e)
        {
            BASSActive b = Bass.BASS_ChannelIsActive(stream);
            if (b != BASSActive.BASS_ACTIVE_STOPPED)
            {
                DuiBaseControl a = musicList1.FindItemEx(musicList1.IsPlaying, musicList1.IsPlayingList);
                int d = musicList1.Items.IndexOf(a);
                string c = "";
                if (musicList1.Items[d - 1].Tag.ToString() != "List" && !musicList1.Items[d - 1].Name.Contains("list_"))
                    c = musicList1.Items[d - 1].Name;
                else
                {
                    int i1 = musicList1.Items.Count;
                    int i2 = int.Parse(((DuiLabel)musicList1.FindGroupEx(musicList1.IsPlayingList).FindControl("Count")[0]).Text.Replace("[", "").Replace("]", ""));
                    int i3 = int.Parse(musicList1.FindGroupEx(musicList1.IsPlayingList).FindControl("Count")[0].Tag.ToString());
                    int id = i2 + i3 - 1;
                    c = musicList1.Items[id].Name;

                }
                openfile(c,musicList1.IsPlayingList);
            }
        }
        public void Btn_next_MouseClick(object sender, DuiMouseEventArgs e)
        {
            BASSActive b = Bass.BASS_ChannelIsActive(stream);
            DuiBaseControl a = musicList1.FindItemEx(musicList1.IsPlaying, musicList1.IsPlayingList);
            int d = musicList1.Items.IndexOf(a);
            int i1 = musicList1.Items.Count;
            string c = "";
            if (d + 1 < musicList1.Items.Count)
            {
                if (musicList1.Items[d + 1] != null && musicList1.Items[d + 1].Tag.ToString() != "List" && !musicList1.Items[d + 1].Name.Contains("list_"))
                    c = musicList1.Items[d + 1].Name;
                else
                {
                    int i = int.Parse(musicList1.FindGroupEx(musicList1.IsPlayingList).FindControl("Count")[0].Tag.ToString());
                    c = musicList1.Items[i].Name;
                }
            }
            else
                c = musicList1.Items[int.Parse(musicList1.FindGroupEx(musicList1.IsPlayingList).FindControl("Count")[0].Tag.ToString())].Name;
            openfile(c, musicList1.IsPlayingList);
        }
        private void Btn_openfile_MouseClick(object sender, DuiMouseEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "音乐文件|*.mp3;*.wav;*.mid;*.m4a;*.ogg;*.flac;*.cd;*ra|所有文件|*.*";
            op.Title = "打开音乐（可多选）";
            op.Multiselect = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                if (op.FileNames.Length == 1)
                    openfile(op.FileName);
                else
                {
                    for (int i = 0; i < op.FileNames.Length; i++)
                    {
                        musicList1.AddItem(op.FileNames[i], musicList1.OpenedList, true);
                    }
                }               
            }
            op.Dispose();
            GC.Collect();
        }
        private void Btn_lrc_MouseClick(object sender, DuiMouseEventArgs e)
        {

        }
        private void Btn_top_MouseClick(object sender, DuiMouseEventArgs e)
        {
            if (btn_top.Checked)
            {
                TopMost = true;
                btn_top.Tag = "取消固定在最前端";
            }
            else
            {
                TopMost = false;
                btn_top.Tag = "固定在最前端";
            }
        }
        private void Btn_skin_MouseClick(object sender, DuiMouseEventArgs e)
        {
            FormSkin fsk = new FormSkin(this);
            fsk.Show();
            fsk.Location = new Point(Left + 65, 32 + Top);
        }
        private void Btn_list_MouseClick(object sender, DuiMouseEventArgs e)
        {
            if (Mini)
            {
                Mini = false;
                Height = SaveHeight;
                btn_top.Visible = true;
                btn_skin.Visible = true;
            }
            else
            {
                Mini = true;
                Height = musicList1.Top;
                btn_top.Visible = false;
                btn_skin.Visible = false;
            }
        }
        private void Btn_close_MouseClick(object sender, DuiMouseEventArgs e)
        {
            if (ExitArsk)
            {
                FormExitArsk far = new FormExitArsk(ExitWhenClose);
                far.ShowDialog();
                if (!far.Cancel)
                {
                    if (far.Exit)
                        ExitWhenClose = true;
                    else
                        ExitWhenClose = false;
                    ExitArsk = far.Save;
                    Close();
                }
                far.Dispose();
                far = null;
                GC.Collect();
            }
            else
                Close();
        }
        private void Btn_min_MouseClick(object sender, DuiMouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btn_soundsch_MouseEnter(object sender, EventArgs e)
        {
            pl_sound.Show();
        }
        private void pl_sound_MouseLeave(object sender, EventArgs e)
        {
            pl_sound.Hide();
        }
        public void Btn_playpause_MouseClick(object sender, DuiMouseEventArgs e)
        {
            BASSActive b = Bass.BASS_ChannelIsActive(stream);
            if (b == BASSActive.BASS_ACTIVE_PLAYING)
            {
                playpause(false);
                btn_playpause.Checked = false;
            }
            else if (b == BASSActive.BASS_ACTIVE_PAUSED)
            {
                playpause(true);
                btn_playpause.Checked = true;
            }
            else if (b == BASSActive.BASS_ACTIVE_STOPPED)
            {
                if (musicList1.Groups[0].musics.Count > 0)
                {
                    openfile(musicList1.Groups[0].musics[0]);
                    notifyIcon1.ShowBalloonTip(2000, "迷你音乐", "已经开始播放音乐", ToolTipIcon.Info);
                }
            }
        }
        private void tkb_sound_ValueChanged(object sender, EventArgs e)
        {
            if (tkb_sound.Value != 0)
            {
                btn_soundsch.Checked = false;
                Volume = (int)(tkb_sound.Value * 100);
            }
            else
            {
                btn_soundsch.Checked = true;                
                Volume = 0;
            }
        }
        public void btn_soundsch_Click(object sender, EventArgs e)
        {
            if (!btn_soundsch.Checked)
            {
                oldVolume = tkb_sound.Value;
                tkb_sound.Value = 0;
            }
            else
                tkb_sound.Value = oldVolume;
        }
        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (fadeIn)
            {
                if (fadeVol < 1f)
                {
                    fadeVol = fadeVol + 0.075f;
                    Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, fadeVol);
                }
                else
                {
                    fadeVol = 1f;
                    fadeTimer.Stop();
                    fadeIng = false;
                }
            }
            else
            {
                if (fadeVol > 0f)
                {
                    fadeVol = fadeVol - 0.075f;
                    Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, fadeVol);
                }
                else
                {
                    fadeVol = 0f;
                    fadeTimer.Stop();
                    fadeIng = false;
                    playpause(false, true);
                }
            }
        }
        private void FadeTimer2_Tick(object sender, EventArgs e)
        {
            fadeTimer2.Stop();
            timerTime.Start();
            Bass.BASS_ChannelSetPosition(stream, tkb_basic.Value * Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream)));
            playpause(true, false, true);
        }

        #endregion

        #region ScorllBar
        private void musicList1_RefreshListed(object sender, EventArgs e)
        {
            int allheight = 0;
            for (int i = 0; i < musicList1.Items.Count; i++)
            {
                if (musicList1.Items[i].Visible)
                    allheight = allheight + musicList1.Items[i].Height;
            }
            double pre = (double)musicList1.Height / (double)allheight;
            if (pre < 1)
            {
                if (musicList1.Visible)
                    scorllbar.Show();

                scorllbar.Height = (int)(pre * (double)musicList1.Height);
                scorllbar.Top = (int)(musicList1.Value * (musicList1.Height - scorllbar.Height)) + musicList1.Top;
            }
            else
            {
                scorllbar.Hide();
            }
        }
        private bool scorlling = false;
        private int mousetop = 0;
        private void scorllbar_MouseEnter(object sender, EventArgs e)
        {
            if (scorllbar.Top < musicList1.Top)
                scorllbar.Top = musicList1.Top + 2;
            if (scorllbar.Top > (musicList1.Top+musicList1.Height - scorllbar.Height))
                scorllbar.Top = (musicList1.Top + musicList1.Height - scorllbar.Height);
            scorllbar.BackColor = Color.FromArgb(170, 255, 255, 255);
        }
        private void scorllbar_MouseLeave(object sender, EventArgs e)
        {
            scorllbar.BackColor = Color.FromArgb(100, 205, 205, 205);
        }
        private void scorllbar_MouseUp(object sender, MouseEventArgs e)
        {
            mousetop = e.Y; scorlling = false;
            scorllbar.BackColor = Color.FromArgb(170, 255, 255, 255);
        }
        private void scorllbar_MouseDown(object sender, MouseEventArgs e)
        {
            mousetop = scorllbar.PointToClient(MousePosition).Y;
            scorlling = true;
            scorllbar.BackColor = Color.FromArgb(80, 55, 55, 55);
        }
        private void scorllbar_Move(object sender, EventArgs e)
        {
            if (scorlling)
            {
                musicList1.Value = (double)(scorllbar.Top - musicList1.Top) / (double)(musicList1.Height - scorllbar.Height);
            }
        }
        private void scorllbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (scorlling)
            {
                if (scorllbar.Top >= musicList1.Top && scorllbar.Top <= (musicList1.Top + musicList1.Height - scorllbar.Height))
                    scorllbar.Top = PointToClient(MousePosition).Y - mousetop;
            }
        }
        private void musicList1_ValueChanged(object sender, EventArgs e)
        {
            if (!scorlling)
                scorllbar.Top = (int)(musicList1.Value * (musicList1.Height - scorllbar.Height)) + musicList1.Top;
        }


        #endregion

        #endregion

        #region PlayModules

        #region Volume
        double oldVolume = 0;
        int volume = 50;
        [DefaultValue(50)]
        /// <summary>
        /// 获取或设置音量（0-100）
        /// </summary>
        public int Volume
        {
            get
            {
                volume = Bass.BASS_GetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM) / 100;
                return volume;
            }
            set
            {
                volume = value;
                Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, volume * 100);
            }
        }
        #endregion

        #region PlayMod
        public enum PlayMod
        {
            listloop,
            list,
            loop,
            one,
            random,
        }
        #endregion

        #region Fade

        private void FadeOut()
        {
            if(fadeIng)
            {
                fadeTimer.Stop();
            }
            fadeIng = true;
            fadeIn = false;
            fadeVol = 1f;
            fadeTimer.Start();
        }
        private void FadeIn()
        {
            if (fadeIng)
            {
                fadeTimer.Stop();
            }
            fadeIng = true;
            fadeIn = true;
            fadeVol = 0f;
            fadeTimer.Start();
        }
        #endregion

        #region EQ
        public int[] EQv = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] _fxEQ = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private void eqloading()
        {
            if (Enableq)
            {
                _fxEQ[0] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                _fxEQ[1] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                _fxEQ[2] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                _fxEQ[3] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                _fxEQ[4] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                _fxEQ[5] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                _fxEQ[6] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                _fxEQ[7] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                _fxEQ[8] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                _fxEQ[9] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                _fxEQ[10] = Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
            }
        }
        public void SetEQ(int band, float center, float eqvalue)
        {
            BASS_DX8_PARAMEQ eq = new BASS_DX8_PARAMEQ();
            if (Bass.BASS_FXGetParameters(_fxEQ[band], eq))
            {
                eq.fCenter = center;
                eq.fGain = eqvalue;
                Bass.BASS_FXSetParameters(_fxEQ[band], eq);
                EQv[band] = Convert.ToInt32(eqvalue);
            }
        }
        #endregion

        public void setpos(double pos)
        {
            Bass.BASS_ChannelSetPosition(stream, pos * Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream)));
        }
        public void playpause(bool play, bool callback = false, bool track = false)
        {
            if (play)
            {
                Bass.BASS_ChannelPlay(stream, false);
                if (!track)
                {
                    btn_playpause.Checked = true;
                    musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 1);
                }
                timerTime.Start();
                started = false;
                if (EnableSt)
                {
                    FadeIn();
                }
            }
            else
            {
                if (EnableSt && callback == false)
                {
                    FadeOut();
                }
                else
                {
                    Bass.BASS_ChannelPause(stream);
                    //timerTime.Stop();
                }
                if (!track)
                {
                    btn_playpause.Checked = false;
                    musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 2);
                }
            }
        }
        private void openfile(MusicList.MusicItem a)
        {
            openfile(a.Path, a.ParentName);
        }
        private void openmidmusic(string file, string listname = "")
        {
            if (playingcache)
            {
                Bass.BASS_ChannelStop(stream);
                Bass.BASS_StreamFree(stream);
                playingcache = false;
            }
            if (File.Exists(file))
            {
                playingmidi = true;
                btn_loadmidifont.Visible = true;
                abmpx = null;
                musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 0);
                Bass.BASS_ChannelStop(stream);
                Bass.BASS_StreamFree(stream);
                stream = Un4seen.Bass.AddOn.Midi.BassMidi.BASS_MIDI_StreamCreateFile(file, 0L, 0L, BASSFlag.BASS_SAMPLE_LOOP, 1);
                //stream = Bass.BASS_StreamCreateFile(file, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT);
                if (stream == 0)
                {
                    PrintError("无法打开该音乐", "可能是文件不支持或是文件损坏.", 0, -1);
                    if (!musicList1.IsInList(file, "默认列表"))
                    {
                        musicList1.AddItem(file, "默认列表", true);
                        musicList1.SetIsPlaying(file, "默认列表", -1);
                    }
                    else
                    {
                        musicList1.SetIsPlaying(file, "默认列表", -1);
                    }
                }
                else
                {

                    if (midifont == 0)
                    {
                        if (deffont == "")
                        {
                            midifont = Un4seen.Bass.AddOn.Midi.BassMidi.BASS_MIDI_FontInit(Application.StartupPath + "\\TimGM6mb.sf2");
                            midifontz.bank = 0; midifontz.preset = -1; midifontz.font = midifont;
                        }
                        else
                        {
                            if (File.Exists(deffont))
                            {
                                midifont = Un4seen.Bass.AddOn.Midi.BassMidi.BASS_MIDI_FontInit(deffont);
                                midifontz.bank = 0; midifontz.preset = -1; midifontz.font = midifont;
                            }
                            else
                            {
                                PrintError("您上次加载的音色库文件丢失,加载失败。");
                            }
                        }
                    }
                    Un4seen.Bass.AddOn.Midi.BASS_MIDI_FONT[] fx = { midifontz, };
                    Un4seen.Bass.AddOn.Midi.BassMidi.BASS_MIDI_StreamSetFonts(stream, fx, 1);

                    if (listname == "")
                    {
                        if (!musicList1.IsInList(file, "默认列表"))
                        {
                            musicList1.AddItem(file, "默认列表", true);
                            musicList1.SetIsPlaying(file, "默认列表", 1);
                        }
                        else
                        {
                            musicList1.SetIsPlaying(file, "默认列表", 1);
                        }
                    }
                    else
                        musicList1.SetIsPlaying(file, listname, 1);
                    btn_playpause.Checked = true;
                    string a = Path.GetFileNameWithoutExtension(file);
                    lb_playing.Text = a;
                    Text = a;
                    notifyIcon1.Text = "迷你音乐\n正在播放：" + a;

                    if (lb_playing.Width > 300)
                    {
                        timerPlaying.Start();
                        playingShowl = true;
                    }
                    else
                        timerPlaying.Stop();
                    lb_playing.Left = 12;
                    Bass.BASS_ChannelPlay(stream, true);

                    #region Album 
                    Random r = new Random();
                    int i = r.Next(0, 2);
                    if (i == 0)
                    {
                        musicList1.SetIsPlayingAb(musicList1.IsPlaying, Properties.Resources.aboum01, listname);
                    }
                    else if (i == 1)
                    {
                        musicList1.SetIsPlayingAb(musicList1.IsPlaying, Properties.Resources.aboum02, listname);
                    }
                    else if (i == 2)
                    {
                        musicList1.SetIsPlayingAb(musicList1.IsPlaying, Properties.Resources.aboum03, listname);
                    }

                    #endregion

                    timerTime.Start();
                    started = false;

                    if (Enableq)
                        eqloading();

                    AutoPlayName = file;


                    Itext1 = musicList1.FindItemByName(file, listname).Name;
                    Itext2 = musicList1.FindItemByName(file, listname).Singer;

                }
            }
        }
        private void openfile(string file, string listname = "")
        {
            if (playingcache)
            {
                Bass.BASS_ChannelStop(stream);
                Bass.BASS_StreamFree(stream);
                playingcache = false;
            }
            if (File.Exists(file))
            {
                if (Path.GetExtension(file.ToLower()) == ".mid" || Path.GetExtension(file.ToLower()) == ".midi")
                {
                    openmidmusic(file, listname);
                }
                else
                {
                    abmpx = null;
                    musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 0);
                    
                    Bass.BASS_ChannelStop(stream);
                    Bass.BASS_StreamFree(stream);
                    stream = Bass.BASS_StreamCreateFile(file, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT);
                    if (stream == 0)
                    {
                        if (!musicList1.IsInList(file, "默认列表"))
                        {
                            musicList1.AddItem(file, "默认列表", true);
                            musicList1.SetIsPlaying(file, "默认列表", -1);
                        }
                        else
                        {
                            musicList1.SetIsPlaying(file, "默认列表", -1);
                        }
                        PrintError("无法打开该音乐", "可能是文件不支持或是文件损坏.", 0, -1);
                    }
                    else
                    {
                        Bass.BASS_ChannelGetData(stream, fft, (int)BASSData.BASS_DATA_FFT1024);
                        if (listname == "")
                        {
                            if (!musicList1.IsInList(file, "默认列表"))
                            {
                                musicList1.AddItem(file, "默认列表", true);
                                musicList1.SetIsPlaying(file, "默认列表", 1);
                            }
                            else musicList1.SetIsPlaying(file, "默认列表", 1);
                        }
                        else musicList1.SetIsPlaying(file, listname, 1);
                        btn_playpause.Checked = true;
                        string a = Path.GetFileNameWithoutExtension(file);
                        lb_playing.Text = a;
                        Text = a;
                        notifyIcon1.Text = "迷你音乐\n正在播放：" + a;
                        if (lb_playing.Width > 300)
                        {
                            timerPlaying.Start();
                            playingShowl = true;
                        }
                        else
                            timerPlaying.Stop();
                        lb_playing.Left = 12;
                        Bass.BASS_ChannelPlay(stream, true);
                        id3(file);
                        timerTime.Start();
                        started = false;

                        if (Enableq)
                            eqloading();

                        AutoPlayName = file;
                    }
                }
                if (listname == "") listname = "默认列表";
                 Itext1 = musicList1.FindItemByName(file, listname).Name;
                Itext2 = musicList1.FindItemByName(file, listname).Singer;

            }
            else
            {
                PrintError("无法打开该音乐", "这个文件可能被劫持了(就在刚才),或者是灰到火星去了吧。。。", 0, 4000);
            }
        }

        #region ReackBar and Time
        private void timerTime_Tick(object sender, EventArgs e)
        {
            #region PlayingFile
            double thistime = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream));
            double alltime = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream));
            double bfb = thistime / alltime;
            if (!tarking)
                tkb_basic.Value = bfb;
            BASSActive b = Bass.BASS_ChannelIsActive(stream);
            if (b == BASSActive.BASS_ACTIVE_PLAYING)
            {
                lb_playtime.Text = TimeToString(TimeSpan.FromSeconds(thistime)) + "/" + TimeToString(TimeSpan.FromSeconds(alltime));
                Itime = lb_playtime.Text;
                if (!started)
                {
                    started = true;
                    btn_playpause.Checked = true;
                    btn_playpause.Tag = "暂停";
                    if (mini)
                    {
                        if (OnMusicChanged != null) OnMusicChanged(this, new EventArgs());
                    }
                }
            }
            else if (b == BASSActive.BASS_ACTIVE_STOPPED)
            {
                if (!exit)
                {
                    if (mini)
                        if (OnMusicChanged != null) OnMusicChanged(this, new EventArgs());

                    #region Stop And Play
                    Itime = "00:00/00;00";
                    btn_playpause.Tag = "播放";
                    timerTime.Stop();
                    if (PlayerMod == PlayMod.list)
                    {
                        DuiBaseControl a = musicList1.FindItemEx(musicList1.IsPlaying, musicList1.IsPlayingList);
                        int d = musicList1.Items.IndexOf(a);
                        string c = "";
                        if (musicList1.Items[d + 1].Tag.ToString() != "List" && !musicList1.Items[d + 1].Name.Contains("list_"))
                        {
                            c = musicList1.Items[d + 1].Name;
                            openfile(c, musicList1.IsPlayingList);
                        }
                        else
                        {
                            musicList1.SetIsPlayingAb(musicList1.IsPlaying, null);
                            musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 0);
                            timerPlaying.Stop();
                            backtostop();
                        }
                    }
                    else if (PlayerMod == PlayMod.listloop)
                    {
                        if (musicList1.FindGroup(musicList1.IsPlayingList).musics.Count >= 1)
                            Btn_next_MouseClick(null, null);
                        else
                        {
                            musicList1.SetIsPlayingAb(musicList1.IsPlaying, null);
                            musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 0);
                            timerPlaying.Stop();
                            backtostop();
                        }
                    }
                    else if (PlayerMod == PlayMod.loop)
                    {
                        if (musicList1.FindGroup(musicList1.IsPlayingList).musics.Count >= 1)
                            openfile(musicList1.IsPlaying, musicList1.IsPlayingList);
                        else
                        {
                            musicList1.SetIsPlayingAb(musicList1.IsPlaying, null);
                            musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 0);
                            timerPlaying.Stop();
                            backtostop();
                        }
                    }
                    else if (PlayerMod == PlayMod.random)
                    {
                        if (musicList1.FindGroup(musicList1.IsPlayingList).musics.Count >= 1)
                        {
                            Random r = new Random();
                            int i = r.Next(0, musicList1.Items.Count);
                            openfile(musicList1.Items[i].Name, musicList1.IsPlayingList);
                        }
                        else
                        {
                            musicList1.SetIsPlayingAb(musicList1.IsPlaying, null);
                            musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 0);
                            timerPlaying.Stop();
                            backtostop();
                        }
                    }
                    else if (PlayerMod == PlayMod.one)
                    {
                        musicList1.SetIsPlayingAb(musicList1.IsPlaying, null);
                        musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 0);
                        timerPlaying.Stop();
                        backtostop();
                    }
                    #endregion
                }
            }
            else if (b == BASSActive.BASS_ACTIVE_PAUSED)
            {
                musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 2);
                btn_playpause.Tag = "播放";
                if (mini)
                    if (OnMusicChanged != null) OnMusicChanged(this, new EventArgs());
                timerTime.Stop();
            }
            #endregion
        }
        private void backtostop()
        {
            lb_playing.Text = "音乐我的生活!";
            lb_playing.Left = 0;
            lb_playtime.Text = "00:00/00:00";
            tkb_basic.Value = 0;

            btn_playpause.Checked = false;
            notifyIcon1.Text = "迷你音乐，音乐我的生活!";
            Text = notifyIcon1.Text;
            if (mini)
            {
                Itext1 = "迷你音乐";
                Itext2 = "音乐我的生活!";
            }
        }
        private string TimeToString(TimeSpan span)
        {
            if (span.Hours != 0)
            {
                if (span.Hours == 0)
                {
                    return span.Minutes.ToString("00") + ":" +
                    span.Seconds.ToString("00");
                }
                else
                {
                    return span.Hours.ToString("00") + ":" +
                    span.Minutes.ToString("00") + ":" +
                    span.Seconds.ToString("00");
                }
            }
            else
            {
                return span.Minutes.ToString("00") + ":" + span.Seconds.ToString("00");
            }
        }
        #endregion

        private void musicList1_PauseMusic(object sender, EventArgs e)
        {
            playpause(false);
            musicList1.SetIsPlaying(musicList1.IsPlaying, musicList1.IsPlayingList, 2);
        }
        private void musicList1_PlayMusic(object sender, MusicList.MusicListArgs e)
        {
            if (e.JustPlay)
            {
                playpause(true);
                musicList1.SetIsPlaying(musicList1.IsPlaying, e.ListName, 3);
                btn_playpause.Checked = true;
            }
            else
            {
                openfile(e.MusicName, e.ListName);
            }
        }
        private void musicList1_StopMusic(object sender, EventArgs e)
        {
            Bass.BASS_ChannelStop(stream);
            Bass.BASS_StreamFree(stream);
        }
        #endregion

        #region Menu Events
        private void musicList1_ListMenuCilcked(object sender, MusicList.ClickArgs e)
        {
            if (e.ListName == "默认列表" || e.ListName == "我喜欢")
            {
                重命名ToolStripMenuItem.Enabled = false;
                删除列表ToolStripMenuItem.Enabled = false;
            }
            else
            {
                重命名ToolStripMenuItem.Enabled = true;
                删除列表ToolStripMenuItem.Enabled = true;
            }
            rightclickitemlist = e.ListName;
            contextMenuList.Show(MousePosition);
        }
        private void musicList1_ItemRightCilcked(object sender, MusicList.ClickArgs e)
        {
            if (musicList1.IsPlaying == e.Name)
            {
                BASSActive b = Bass.BASS_ChannelIsActive(stream);
                if (b == BASSActive.BASS_ACTIVE_PLAYING)
                    toolStripMenuItem1.Text = "暂停";
                else if (b == BASSActive.BASS_ACTIVE_PAUSED)
                    toolStripMenuItem1.Text = "播放";
            }
            else
                toolStripMenuItem1.Text = "播放音乐";
            rightclickitemlist = e.ListName;
            rightclickitem = e.Name;
            if (File.Exists(e.Name))
            {
                打开文件位置ToolStripMenuItem.Enabled = true;
                toolStripMenuItem3.Enabled = true;
            }
            else
            {
                打开文件位置ToolStripMenuItem.Enabled = false;
                toolStripMenuItem3.Enabled = false;
            }
            if (rightclickitemlist == "默认列表")
                默认列表ToolStripMenuItem.Enabled = false;
            else
                默认列表ToolStripMenuItem.Enabled = true;
            if (rightclickitemlist == "我喜欢")
                我喜欢ToolStripMenuItem.Enabled = false;
            else
                我喜欢ToolStripMenuItem.Enabled = true;
            contextMenuItem.Show(MousePosition);
        }
        private void 打开文件位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(rightclickitem))
                System.Diagnostics.Process.Start("explorer.exe", "/select," + rightclickitem);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_playpause_MouseClick(null, null);
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            musicList1.DeleteItem(rightclickitem, rightclickitemlist);
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                musicList1.DeleteItem(rightclickitem, rightclickitemlist);
                if(File.Exists(rightclickitem))
                    File.Delete(rightclickitem);
            }
        }
        private void 默认列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.AddItem(rightclickitem, "默认列表", true);
        }
        private void 我喜欢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.AddItem(rightclickitem, "我喜欢",  true);
        }
        private void ListsToolStripMenuItems_Click(object sender, EventArgs e)
        {
            musicList1.AddItem(rightclickitem, ((ToolStripMenuItem)sender).Text, true);
        }
        private void 本地音乐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "音乐文件|*.mp3;*.wav;*.mid;*.m4a;*.ogg;*.flac;*.cd;*ra|所有文件|*.*";
            op.Title = "添加音乐";
            op.Multiselect = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                if (op.FileNames.Length == 1)
                musicList1.AddItem(op.FileName, rightclickitemlist, true);
                else
                {
                    for (int i = 0; i < op.FileNames.Length; i++)
                    {
                        musicList1.AddItem(op.FileNames[i], rightclickitemlist , true);
                    }
                }
            }
            op.Dispose();
            GC.Collect();
        }
        private void 本地音乐文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plugins.FolderBrowserDialog f = new Plugins.FolderBrowserDialog();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                FormProgress fp = new FormProgress();
                fp.Value = 0;
                fp.Show();
                List<string> t = GetFiles(new DirectoryInfo(f.DirectoryPath), "*.mp3");
                for (int i = 0; i < t.Count; i++)
                {
                    fp.Value = (double)i / (double)t.Count;
                    fp.File = t[i];
                    musicList1.AddItem(t[i], rightclickitemlist, true);
                }
                fp.Close();
                PrintMsg("成功添加" + t.Count + "首音乐！", "", 8000);
                t = null;
                fp.Dispose();
                fp = null;
            }
            f.Dispose();
            GC.Collect();
        }
        private void contextMenuItem_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            选择其他列表ToolStripMenuItem.DropDownItems.Clear();
        }
        private void contextMenuItem_Opening(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < musicList1.Groups.Count; i++)
            {
                if (musicList1.Groups[i].Name != "我喜欢" && musicList1.Groups[i].Name != "默认列表")
                    if (rightclickitemlist != musicList1.Groups[i].Name)
                        选择其他列表ToolStripMenuItem.DropDownItems.Add(musicList1.Groups[i].Name, null, ListsToolStripMenuItems_Click);
                    else
                    {
                        ToolStripMenuItem m = new ToolStripMenuItem(musicList1.Groups[i].Name);
                        m.Enabled = false;
                        选择其他列表ToolStripMenuItem.DropDownItems.Add(m);
                    }
            }
        }
        private void 清空列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定清空列表：" + rightclickitemlist + "？此操作不可恢复。", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                musicList1.FindGroup(rightclickitemlist).musics.Clear();
                for (int i = musicList1.Items.Count - 1; i >= 0; i--)
                {
                    if (musicList1.Items[i].Tag.ToString() == rightclickitemlist)
                    {
                        musicList1.DeleteItem(musicList1.Items[i].Name, rightclickitemlist);
                    }
                }
            }
            musicList1.RefreshList();
        }
        private void 删除列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除该列表？此操作不可恢复。", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                musicList1.Items.Remove(musicList1.FindGroupEx(rightclickitemlist));
                musicList1.Groups.Remove(musicList1.FindGroup(rightclickitemlist));
                for (int i = musicList1.Items.Count - 1; i >= 0; i--)
                {
                    if (musicList1.Items[i].Tag.ToString() == rightclickitemlist)
                    {
                        musicList1.Items.Remove(musicList1.Items[i]);
                    }
                }
                musicList1.RefreshList();
            }
        }
        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.FindGroupEx(rightclickitemlist).FindControl("name")[0].Visible = false;
            musicList1.FindGroupEx(rightclickitemlist).FindControl("tb")[0].Visible = true;
            ((DuiTextBox)musicList1.FindGroupEx(rightclickitemlist).FindControl("tb")[0]).Text = rightclickitemlist;
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Menu.FormNewList f = new Menu.FormNewList();
            if(f.ShowDialog()== DialogResult.OK)
            {
                musicList1.AddList(f.ListName);
            }
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
