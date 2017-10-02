using ID3;
using LayeredSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Text;

namespace MusicPlayer.MyLayeredSkin
{
    public class MusicList : LayeredSkin.Controls.LayeredListBox
    {
        public MusicList()
        {
            DuiBaseControl b = new DuiBaseControl();
            b.Size = new Size(Width, 35);
            b.BackColor = Color.Transparent;
            DuiLabel l = new DuiLabel();
            l.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            l.Location = new Point(30, 8);
            l.AutoSize = true;
            l.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            l.ForeColor = Color.White;
            l.Text = "这个列表没有音乐哦\n您可以直接把音乐拖到这里来";
            l.Name = "name";
            b.Controls.Add(l);
            b.Name = "no";
            b.Visible = false;
            no = b;
            tx.Interval = 100;
            tx.Tick += Tx_Tick;
            t.Interval = 100;
            t.Tick += T_Tick;
            t1.Interval = 500;
            t1.Tick += T1_Tick;
            cs = new System.Windows.Forms.Cursor(Properties.Resources.music_move.GetHicon());
            MouseMove += MusicList_MouseMove;
        }
        private void T1_Tick(object sender, EventArgs e)
        {
            t1.Stop();
            Cursor = cs;
            moveing = true;
        }
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tx = new System.Windows.Forms.Timer();
        System.Windows.Forms.Cursor cs = null;
        DuiBaseControl no = null;        
        System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
        private void Btn_MouseClick(object sender, DuiMouseEventArgs e)
        {
            lm(new ClickArgs("", ((DuiBaseControl)sender).Tag.ToString()));
        }
        private void closeopenedlist()
        {
            foreach (DuiBaseControl ix in Items)
            {
                if (ix.Name.Replace("list_", "") == OpenedList)
                {
                    string a = ix.Name.Replace("list_", "");
                    ((DuiPictureBox)ix.FindControl("more")[0]).Image = Properties.Resources.btn_more_open;
                    ((DuiPictureBox)ix.FindControl("more")[0]).Tag = "Close";
                    for (int i = 0; i < Items.Count; i++)
                    {
                        if (Items[i].Tag != null)
                        {
                            if (Items[i].Tag.ToString() == a)
                                Items[i].Visible = false;
                        }                    
                    }                  
                }
            }
            OpenedList = "";   
        }
        private void More_MouseClick(object sender, DuiMouseEventArgs e)
        {
            if(((DuiBaseControl)sender).Tag.ToString() =="Close")
            {
                if (OpenedList != "")
                    closeopenedlist();
                ((DuiBaseControl)sender).Tag = "Open";
                ((DuiPictureBox)sender).Image = Properties.Resources.btn_more_close;
                int a = 0;
                for (int i = 0; i < Items.Count; i++)
                {
                    if (Items[i].Tag != null)
                    {
                        if (Items[i].Tag.ToString() == ((DuiBaseControl)((DuiPictureBox)sender).Parent).Name.Replace("list_", ""))
                        {
                            Items[i].Visible = true;
                            a = a + 1;
                        }
                    }
                }
                OpenedList = ((DuiBaseControl)((DuiPictureBox)sender).Parent).Name.Replace("list_", "");
            }
            else
            {
                if (OpenedList == ((DuiBaseControl)((DuiPictureBox)sender).Parent).Name.Replace("list_", ""))
                {
                    ((DuiBaseControl)sender).Tag = "Close";
                    ((DuiPictureBox)sender).Image = Properties.Resources.btn_more_open;
                    for (int i = 0; i < Items.Count; i++)
                    {
                        if (Items[i].Tag != null)
                        {
                            if (Items[i].Tag.ToString() == ((DuiBaseControl)((DuiPictureBox)sender).Parent).Name.Replace("list_", ""))
                                Items[i].Visible = false;
                        }
                    }
                    OpenedList = "";
                }
            }
            RefreshList();
        }
        private void B_MouseDoubleClick(object sender, DuiMouseEventArgs e)
        {
            More_MouseClick(((DuiBaseControl)sender).FindControl("more")[0], e);
        }       
        private void Btnplay_MouseDown(object sender, DuiMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (((DuiBaseControl)((DuiBaseControl)sender).Parent).Name == IsPlaying && ((DuiBaseControl)((DuiBaseControl)sender).Parent).Tag.ToString() == IsPlayingList)
                    playMusic(new MusicListArgs("", ((DuiBaseControl)sender).Tag.ToString(), true));
                else
                {
                    //System.Windows.Forms.MessageBox.Show(((DuiBaseControl)((DuiBaseControl)sender).Parent).Tag.ToString());
                    playMusic(new MusicListArgs(((DuiBaseControl)((DuiBaseControl)sender).Parent).Name, ((DuiBaseControl)((DuiBaseControl)sender).Parent).Tag.ToString(), false));
                }
            }
            tx.Stop();
            t1.Stop();
            moveing = false;
        }
        private void Btndel_MouseClick(object sender, DuiMouseEventArgs e)
        {
            t1.Stop();
            tx.Stop();
            moveing = false;
            
            string a = ((DuiBaseControl)((DuiBaseControl)sender).Parent).Name;
            string b = ((DuiBaseControl)((DuiBaseControl)sender).Parent).Tag.ToString();
            if (a == IsPlaying && b == IsPlayingList)
            {
                stopmusic();
            }
            foreach (MusicListItem iy in Groups)
            {
                if (iy.Name == b)
                {
                    for (int i=0;i< iy.musics.Count; i++)
                    {
                        if (iy.musics[i].Name == a || iy.musics[i].Hash == a || iy.musics[i].Path == a)                       
                            iy.musics.Remove(iy.musics[i]);                                        
                    }

                    int c = iy.musics.Count;
                    ((DuiLabel)FindGroupEx(b).FindControl("Count")[0]).Text = "[" + c.ToString() + "]";
                    FindGroupEx(b).FindControl("Count")[0].Tag = (Items.IndexOf(FindGroupEx(b)) + 1).ToString();
                }

            }
            

            Items.Remove(((DuiBaseControl)((DuiBaseControl)sender).Parent));
            RefreshList();

            t1.Stop();
            tx.Stop();
            moveing = false;
        }
        private void Btnpause_MouseClick(object sender, DuiMouseEventArgs e)
        {
            pauseMusic();
        }
        private void Btnplay_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("播放", FindForm(), MousePosition.X - FindForm().Left + 10, MousePosition.Y - FindForm().Top + 10, 3000);
        }
        private void Btndel_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("删除", FindForm(), MousePosition.X - FindForm().Left + 10, MousePosition.Y - FindForm().Top + 10, 3000);
        }
        private void Btnpause_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("暂停", FindForm(), MousePosition.X - FindForm().Left + 10, MousePosition.Y - FindForm().Top + 10, 3000);
        }
        private void Btnplay_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(FindForm());
        }
        private void Btndel_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(FindForm());
        }
        private void Btnpause_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(FindForm());
        }
        private void Tb_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                string a = ((DuiTextBox)sender).Text;
                ((DuiTextBox)sender).Visible = false;
                ((DuiBaseControl)((DuiTextBox)sender).Parent).FindControl("name")[0].Visible = true;
                FindGroup(((DuiLabel)((DuiBaseControl)((DuiTextBox)sender).Parent).FindControl("name")[0]).Text).Name = a;
                ((DuiLabel)((DuiBaseControl)((DuiTextBox)sender).Parent).FindControl("name")[0]).Text = a;
            }
        }
        private void Tb_FocusedChanged(object sender, EventArgs e)
        {
            if (((DuiTextBox)sender).Focused == false)
            {
                string a = ((DuiTextBox)sender).Text;
                ((DuiTextBox)sender).Visible = false;
                ((DuiBaseControl)((DuiTextBox)sender).Parent).FindControl("name")[0].Visible = true;
                FindGroup(((DuiLabel)((DuiBaseControl)((DuiTextBox)sender).Parent).FindControl("name")[0]).Text).Name = a;
                ((DuiLabel)((DuiBaseControl)((DuiTextBox)sender).Parent).FindControl("name")[0]).Text = a;
            }
        }
        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(this.FindForm());
        }
        private void Lbl_MouseEnter(object sender, EventArgs e)
        {
            if ((string)((DuiBaseControl)sender).Tag != "")
                toolTip1.Show((string)((DuiBaseControl)sender).Tag, this.FindForm(), MousePosition.X - this.FindForm().Left + 10, MousePosition.Y - this.FindForm().Top + 10, 3000);
        }
        private void Listx_MouseEnter(object sender, EventArgs e)
        {
            ((DuiBaseControl)sender).BackColor = Color.FromArgb(50, Color.White);
            if (((DuiBaseControl)sender).Name == IsPlaying && ((DuiBaseControl)sender).Tag.ToString() == IsPlayingList)
            {
                Un4seen.Bass.BASSActive b = Un4seen.Bass.Bass.BASS_ChannelIsActive(((FormMain)FindForm()).stream);
                if (b == Un4seen.Bass.BASSActive.BASS_ACTIVE_PLAYING)
                    ((DuiBaseControl)sender).FindControl("btnpause")[0].Visible = true;
                else if (b == Un4seen.Bass.BASSActive.BASS_ACTIVE_PAUSED)
                    ((DuiBaseControl)sender).FindControl("btnplay")[0].Visible = true;
            }
            else
                ((DuiBaseControl)sender).FindControl("btnplay")[0].Visible = true;
            ((DuiBaseControl)sender).FindControl("btndel")[0].Visible = true;
        }
        private void Listx_MouseLeave(object sender, EventArgs e)
        {
            if (((DuiBaseControl)sender).Name != IsPlaying && ((DuiBaseControl)sender).Name != IsSelect)
            {
                ((DuiBaseControl)sender).BackColor = Color.FromArgb(0, Color.White);
                ((DuiBaseControl)sender).FindControl("btndel")[0].Visible = false;
                ((DuiBaseControl)sender).FindControl("btnplay")[0].Visible = false;
            }
            else if (((DuiBaseControl)sender).Name == IsSelect && ((DuiBaseControl)sender).Name != IsPlaying)
            {
                ((DuiBaseControl)sender).FindControl("btndel")[0].Visible = false;
                ((DuiBaseControl)sender).FindControl("btnplay")[0].Visible = false;
                ((DuiBaseControl)sender).FindControl("btnpause")[0].Visible = false;
            }
        }
        private void Listx_MouseEnterLose(object sender, EventArgs e)
        {
            ((DuiBaseControl)sender).BackColor = Color.FromArgb(50, Color.White);
            ((DuiBaseControl)sender).FindControl("btndel")[0].Visible = true;
        }
        private void Listx_MouseLeaveLose(object sender, EventArgs e)
        {
            ((DuiBaseControl)sender).BackColor = Color.FromArgb(0, Color.White);
            ((DuiBaseControl)sender).FindControl("btndel")[0].Visible = false;
        }
        private void Listx_MouseDoubleClick(object sender, DuiMouseEventArgs e)
        {
            playMusic(new MusicListArgs(((DuiBaseControl)sender).Name, ((DuiBaseControl)sender).Tag.ToString(), false));
        }
        private void Listx_MouseClick(object sender, DuiMouseEventArgs e)
        {
            if (IsSelect != ((DuiBaseControl)sender).Name)
            {
                IsSelect = ((DuiBaseControl)sender).Name;
                for (int i = 0; i < Items.Count; i++)
                {
                    if (Items[i].Name != IsPlaying && Items[i].Name != IsSelect)
                        Items[i].BackColor = Color.Transparent;
                }
                ((DuiBaseControl)sender).BackColor = Color.FromArgb(100, 255, 255, 255);
            }
            else
            {
                if (((DuiBaseControl)sender).Name != IsPlaying && ((DuiBaseControl)sender).Name != IsSelect)
                    ((DuiBaseControl)sender).BackColor = Color.Transparent;
                IsSelect = "";
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ir(new ClickArgs(((DuiBaseControl)sender).Name, ((DuiBaseControl)sender).Tag.ToString()));
            }
        }
        private void Listx_MouseUp(object sender, DuiMouseEventArgs e)
        {
            t1.Stop();
            moveing = false;
            //moveto(((DuiBaseControl)sender), oldtop);
            //System.Windows.Forms.MessageBox.Show(movec.ToString());
            if (movec > 25 || movec < -25)
            {
                int b = (int)(((double)movec - 12) / 25);
                int c = Math.Abs((int)(((double)movec - 12) / 25));
                //System.Windows.Forms.MessageBox.Show(c.ToString());
                int d = (Items.IndexOf((DuiBaseControl)sender) + b + 1);
                //System.Windows.Forms.MessageBox.Show(d.ToString());
                if (d > 0 && d < Items.Count && c > 0)
                {
                    MusicListItem m = FindGroup(((DuiBaseControl)sender).Tag.ToString());
                    DuiBaseControl m2 = FindGroupEx(((DuiBaseControl)sender).Tag.ToString());
                    MusicItem m1 = null;
                    foreach (MusicItem ic in m.musics)
                    {
                        if (ic.Path == ((DuiBaseControl)sender).Name || ic.URL == ((DuiBaseControl)sender).Name)
                        {
                            m1 = ic;
                        }
                    }
                    int f = m.musics.IndexOf(m1) + b + 1;
                    //System.Windows.Forms.MessageBox.Show(m.musics.IndexOf(m1)+"\n"+b+"\n" + f.ToString());
                    if (f > 0 && f < m.musics.Count)
                    {
                        DuiBaseControl m0 = (DuiBaseControl)sender;
                        Items.Remove(m0);
                        Items.Insert(d, m0);
                        RefreshList();

                        m.musics.Remove(m1);
                        m.musics.Insert(f, m1);
                    }

                }
            }
            Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void Listx_MouseDown(object sender, DuiMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                t1.Stop();
                t1.Start();
            }
        }
        private void Listx_MouseMove(object sender, DuiMouseEventArgs e)
        {
            if (moveing)
            {
                Cursor = cs;
                movec = e.Y;
            }
            else
            {
                if (Cursor != System.Windows.Forms.Cursors.Default)
                    Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void moveto(DuiBaseControl s,int y)
        {
            moves = s;
               toy = y;
            if (s.Top>y)
            {
                downing = true;
                tx.Start();
            }           
            else
            {
                downing = false;
                tx.Start();
            }
        }
        private void Tx_Tick(object sender, EventArgs e)
        {
            if (moveing && Focused)
            {
                if (downing)
                {
                    if (moves.Top > toy)
                    {
                        moves.Top = moves.Top - 2;
                    }
                    else
                    {
                        moves.Top = toy;
                        tx.Stop();
                    }
                }
                else
                {
                    if (moves.Top < toy)
                    {
                        moves.Top = moves.Top + 2;
                    }
                    else
                    {
                        moves.Top = toy;
                        tx.Stop();
                    }
                }
            }
            else
            {
                tx.Stop();
                t1.Stop();
                moveing = false;
                Cursor = System.Windows.Forms.Cursors.Default;
            }
        }
        DuiBaseControl moves = null;
        bool moveing = false;
        bool uping = false;
        bool downing = false;
        int toy = 0;
        int oldtop = 0;
        int movec = 0;
        private void T_Tick(object sender, EventArgs e)
        {
            if(uping)
            {
                Value = Value - 0.02;
            }
            else
            {
                Value = Value + 0.02;
            }
        }

        private void MusicList_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (moveing)
                if (e.Y < 10)
                {
                    uping = true;
                    t.Start();
                }
                else if (e.Y > Height - 10)
                {
                    uping = false;
                    t.Start();
                }
                else
                {
                    t.Stop();
                }
        }
        public bool AddList(string name)
        {
            bool Searched = false;
            foreach (MusicListItem a in Groups)
            {
                if (a.Name == "list_" + name)
                {
                    Searched = true;
                }
                else
                {
                    Searched = false;
                }
            }
            if (!Searched)
            {
                DuiBaseControl b = new DuiBaseControl();
                b.Name = "list_" + name;
                b.Size = new Size(Width, 35);
                b.BackColor = Color.Transparent;
                b.Tag = "List";
                Borders b1 = new Borders(b);
                b1.BottomWidth = 1;
                b1.BottomColor = Color.FromArgb(50, 0, 0, 0);
                b.Borders = b1;
                DuiLabel l = new DuiLabel();
                l.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                l.Location = new Point(30, 8);
                l.AutoSize = true;
                l.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
                l.ForeColor = Color.White;
                l.Text = name;
                l.Name = "name";
                DuiLabel l2 = new DuiLabel();
                
                l2.Name = "Count";
                if (name == "我喜欢")
                    l2.Location = new Point(l.Width + 43, 11);
                else
                    l2.Location = new Point(l.Width + 25, 11);
                l2.AutoSize = true;
                l2.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                l2.Font = new Font("微软雅黑", 9F);
                l2.ForeColor = Color.White;
                l2.Text = "[列表无歌曲，可直接把歌曲拖到这里来哦]";
                l2.Tag = (Items.Count+1).ToString();
                DuiButton btn = new DuiButton();
                btn.Size = new Size(22, 22);
                btn.Location = new Point(b.Width - 35, 8);
                btn.NormalImage = Properties.Resources.btn_list_menu_n;
                btn.HoverImage = Properties.Resources.btn_list_menu_h;
                btn.PressedImage = Properties.Resources.btn_list_menu_p;
                btn.MouseClick += Btn_MouseClick;
                btn.Tag = name;
                DuiPictureBox ilike = new DuiPictureBox();
                if (name == "我喜欢")
                {
                    ilike.Size = new Size(22, 22);
                    ilike.Location = new Point(78, 8);
                    ilike.Image = Properties.Resources.btn_iliked_p;
                }
                btn.Tag = name;
                DuiPictureBox more = new DuiPictureBox();
                more.Size = new Size(23, 23);
                more.Location = new Point(10, 7);
                if (name == "默认列表")
                {
                    more.Image = Properties.Resources.btn_more_close;
                    more.Tag = "Open";
                }
                else
                {
                    more.Image = Properties.Resources.btn_more_open;
                    more.Tag = "Close";
                }
                more.MouseClick += More_MouseClick;

                more.Name = "more";

                DuiTextBox tb = new DuiTextBox();
                tb.Size = new Size(100, 22);
                tb.Location = new Point(31, 9);
                tb.Visible = false;
                tb.Name = "tb";
                tb.ForeColor = Color.White;
                tb.FocusedChanged += Tb_FocusedChanged;
                tb.KeyDown += Tb_KeyDown;
                tb.Font = new Font("微软雅黑", 9F);

                b.Controls.Add(tb);
                b.Controls.Add(btn);
                b.Controls.Add(l);
                b.Controls.Add(l2);
                b.Controls.Add(more);
                if (name == "我喜欢")
                    b.Controls.Add(ilike);
                b.MouseDoubleClick += B_MouseDoubleClick;

                Items.Add(b);
                RefreshList();

                MusicListItem m = new MusicListItem(name,new List<MusicItem>());
                Groups.Add(m);
            }

            GC.Collect();

            return !Searched;
        }
        public MusicItem AddItem(string name, string listname, bool b = false)
        {
            MusicItem se = null;
            bool Searched = false;
            foreach (MusicListItem iy in Groups)
            {
                if (iy.Name == listname)
                    Searched = true;
            }
            if (Searched)
            {
                if (IsInList(name, listname))
                {
                    return null;
                }
                else
                {
                    int a = 0;
                    for (int i = 0; i < Items.Count; i++)
                    {
                        if (Items[i].Tag != null)
                            if (Items[i].Tag.ToString() == listname)
                                a = a + 1;
                    }
                    DuiBaseControl ix = null;
                    foreach (DuiBaseControl ixx in Items)
                    {
                        if (ixx.Name.Replace("list_", "") == listname)
                        {
                            ix = ixx;
                        }
                    }
                    if (File.Exists(name))
                    {
                        #region 本地音乐
                        Mp3Info info = MP3Info.GetMp3Info(name);

                        string artists = info.Artist;
                        string album = info.Album;
                        string length = info.MusicLength;
                        string title = info.Title;
                        DuiLabel infoforsinger = new DuiLabel();
                        infoforsinger.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        infoforsinger.Size = new Size(140, 20);
                        if (artists != "")
                            infoforsinger.Text = "-" + artists;
                        infoforsinger.Location = new Point(160, 4);
                        infoforsinger.ForeColor = Color.FromArgb(220, 220, 220);
                        infoforsinger.Font = new Font("微软雅黑", 9F);
                        infoforsinger.Name = "infoforsinger";

                        DuiPictureBox albumpic = new DuiPictureBox();
                        albumpic.Size = new Size(50, 50);
                        albumpic.Location = new Point(5, 0);
                        albumpic.Name = "albumpic";
                        albumpic.BackgroundImage = Properties.Resources.default_album;
                        albumpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                        albumpic.Visible = false;

                        DuiLabel infoforTimer = new DuiLabel();
                        infoforTimer.Size = new Size(70, 20);
                        infoforTimer.Text = length;
                        infoforTimer.Location = new Point(350, 4);
                        infoforTimer.ForeColor = Color.FromArgb(255, 255, 255);
                        infoforTimer.Font = new Font("微软雅黑", 9F);
                        infoforTimer.Name = "infoforTimer";
                        infoforTimer.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;

                        DuiButton btnplay = new DuiButton();
                        btnplay.Size = new Size(20, 20);
                        btnplay.Location = new Point(295, 3);
                        btnplay.NormalImage = Properties.Resources.list_btn_play_normal;
                        btnplay.HoverImage = Properties.Resources.list_btn_play_hover;
                        btnplay.PressedImage = Properties.Resources.list_btn_play_press;
                        btnplay.MouseClick += Btnplay_MouseDown;
                        btnplay.MouseEnter += Btnplay_MouseEnter;
                        btnplay.MouseLeave += Btnplay_MouseLeave;
                        btnplay.Name = "btnplay";
                        btnplay.Tag = name;
                        btnplay.Visible = false;

                        DuiButton btnpause = new DuiButton();
                        btnpause.Size = new Size(20, 20);
                        btnpause.Location = new Point(295, 3);
                        btnpause.NormalImage = Properties.Resources.list_btn_pause_normal;
                        btnpause.HoverImage = Properties.Resources.list_btn_pause_hover;
                        btnpause.PressedImage = Properties.Resources.list_btn_pause_press;
                        btnpause.MouseClick += Btnpause_MouseClick;
                        btnpause.Name = "btnpause";
                        btnpause.Tag = name;
                        btnpause.MouseEnter += Btnpause_MouseEnter;
                        btnpause.MouseLeave += Btnpause_MouseLeave;
                        btnpause.Visible = false;

                        DuiButton btndel = new DuiButton();
                        btndel.Size = new Size(20, 20);
                        btndel.Location = new Point(317, 3);
                        btndel.NormalImage = Properties.Resources.btn_del_h;
                        btndel.HoverImage = Properties.Resources.btn_del_n;
                        btndel.PressedImage = Properties.Resources.btn_del_p;
                        btndel.MouseClick += Btndel_MouseClick;
                        btndel.MouseEnter += Btndel_MouseEnter;
                        btndel.MouseLeave += Btndel_MouseLeave;
                        btndel.Name = "btndel";
                        btndel.Tag = listname;
                        btndel.Visible = false;

                        DuiLabel lbl = new DuiLabel();
                        lbl.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        lbl.Size = new System.Drawing.Size(160, 17);
                        if (Path.GetFileNameWithoutExtension(name).Length > 14)
                        {
                            lbl.Text = Path.GetFileNameWithoutExtension(name).Remove(13).Insert(13, "...");
                            lbl.Tag = Path.GetFileNameWithoutExtension(name);
                            lbl.MouseEnter += Lbl_MouseEnter;
                            lbl.MouseLeave += Lbl_MouseLeave;
                        }
                        else
                        {
                            lbl.Text = Path.GetFileNameWithoutExtension(name);
                            lbl.Tag = Path.GetFileNameWithoutExtension(name);
                        }
                        lbl.Location = new Point(10, 4);
                        lbl.ForeColor = Color.FromArgb(255, 255, 255);
                        lbl.Font = new Font("微软雅黑", 9F);
                        lbl.Name = "lbl";
                        

                        DuiBaseControl listx = new DuiBaseControl();
                        listx.BackColor = Color.FromArgb(0, Color.Black);
                        listx.Width = Width;
                        listx.Height = 25;
                        listx.Controls.Add(lbl);
                        listx.Controls.Add(infoforsinger);
                        listx.Controls.Add(infoforTimer);
                        listx.Controls.Add(btndel);
                        listx.Controls.Add(btnplay);
                        listx.Controls.Add(btnpause);
                        listx.Controls.Add(albumpic);
                        listx.MouseDown += Listx_MouseDown;
                        listx.MouseUp += Listx_MouseUp;
                        listx.MouseMove += Listx_MouseMove;
                        listx.MouseEnter += Listx_MouseEnter;
                        listx.MouseLeave += Listx_MouseLeave;
                        listx.MouseDoubleClick += Listx_MouseDoubleClick;
                        listx.MouseClick += Listx_MouseClick;
                        listx.Name = name;
                        listx.Height = 25;
                        listx.Tag = listname;

                        if (!b)
                            Items.Add(listx);
                        else
                            Items.Insert(Items.IndexOf(ix) + a + 1, listx);

                        foreach (MusicListItem iy in Groups)
                        {
                            if (iy.Name == listname)
                            {
                                MusicItem m = new MusicItem();
                                m.Path = name;
                                m.IsOnline = false;
                                m.ParentName = listname;
                                if (title != "")
                                    m.Name = title;
                                else
                                    m.Name = lbl.Tag.ToString();
                                m.Singer = artists;
                                iy.musics.Add(m);
                            }
                        }

                        if (OpenedList == listname)
                            listx.Visible = true;
                        else
                            listx.Visible = false;

                        #endregion
                    }
                    else
                    {
                        #region 失效音乐

                        DuiLabel infoforTimer = new DuiLabel();
                        infoforTimer.Size = new Size(70, 20);
                        infoforTimer.Text = "文件失效";
                        infoforTimer.Location = new Point(350, 4);
                        infoforTimer.ForeColor = Color.Red;
                        infoforTimer.Font = new Font("微软雅黑", 9F);
                        infoforTimer.Name = "infoforTimer";
                        infoforTimer.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;

                        DuiButton btndel = new DuiButton();
                        btndel.Size = new Size(20, 20);
                        btndel.Location = new Point(317, 3);
                        btndel.NormalImage = Properties.Resources.btn_del_h;
                        btndel.HoverImage = Properties.Resources.btn_del_n;
                        btndel.PressedImage = Properties.Resources.btn_del_p;
                        btndel.MouseClick += Btndel_MouseClick;
                        btndel.MouseEnter += Btndel_MouseEnter;
                        btndel.MouseLeave += Btndel_MouseLeave;
                        btndel.Name = "btndel";
                        btndel.Tag = listname;
                        btndel.Visible = false;

                        DuiLabel lbl = new DuiLabel();
                        lbl.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        lbl.Size = new System.Drawing.Size(160, 20);
                        if (Path.GetFileNameWithoutExtension(name).Length > 14)
                        {
                            lbl.Text = Path.GetFileNameWithoutExtension(name).Remove(13).Insert(13, "...");
                            lbl.MouseEnter += Lbl_MouseEnter;
                        }
                        else
                        {
                            lbl.Text = Path.GetFileNameWithoutExtension(name);
                        }
                        lbl.Location = new Point(10, 4);
                        lbl.ForeColor = Color.Red;
                        lbl.Font = new Font("微软雅黑", 9F);
                        lbl.Name = "lbl";
                        lbl.Tag = Path.GetFileNameWithoutExtension(name);
                        lbl.MouseLeave += Lbl_MouseLeave;

                        DuiBaseControl listx = new DuiBaseControl();
                        listx.BackColor = Color.FromArgb(0, Color.Black);
                        listx.Width = Width;
                        listx.Height = 25;
                        listx.Controls.Add(lbl);
                        listx.Controls.Add(infoforTimer);
                        listx.Controls.Add(btndel);
                        listx.MouseMove += Listx_MouseMove;
                        listx.MouseDown += Listx_MouseDown;
                        listx.MouseUp += Listx_MouseUp;
                        listx.MouseEnter += Listx_MouseEnterLose;
                        listx.MouseLeave += Listx_MouseLeaveLose;
                        listx.Name = name;
                        listx.Height = 25;
                        listx.Tag = listname;

                        if (!b)
                            Items.Add(listx);
                        else
                            Items.Insert(Items.IndexOf(ix) + a + 1, listx);

                        foreach (MusicListItem iy in Groups)
                        {
                            if (iy.Name == listname)
                            {
                                MusicItem m = new MusicItem();
                                m.Path = name;
                                m.IsOnline = false;
                                 
                                iy.musics.Add(m);
                            }
                        }

                        if (OpenedList == listname)
                            listx.Visible = true;
                        else
                            listx.Visible = false;

                        #endregion
                    }
                    a = a + 1;
                    if (a == 0)
                        ((DuiLabel)ix.FindControl("Count")[0]).Text = "[这个列表没有歌曲，可以直接把歌曲拖到这里来哦]";
                    else
                        ((DuiLabel)ix.FindControl("Count")[0]).Text = "[" + a.ToString() + "]";
                    RefreshList();
                }
            }
            GC.Collect();
            return se;
        }



        public bool IsInList(string name, string listname="")
        {
            bool searched = false;
            if (listname == "")
            {
                foreach (DuiBaseControl ix in Items)
                {
                    if (ix.Name==name)
                    {
                        searched = true;
                    }
                }
            }
            else
            {               
                foreach (MusicListItem iy in Groups)
                {
                    if (iy.Name == listname)
                    {
                        foreach (MusicItem ix in iy.musics)
                        {
                            if (ix.Path == name || ix.URL == name)
                            {
                                searched = true;
                            }
                        }
                    }
                }                
            }
            return searched;         
        }
        public void SetIsPlaying(string name, string listname, int playing = 0)
        {
            if (IsInList(name))
            {
                foreach (DuiBaseControl b in InnerDuiControl.FindControl(name))
                {
                    if (b.Tag.ToString() == listname)
                    {
                        if (playing == -1)
                        {
                            ((DuiLabel)b.FindControl("infoforTimer")[0]).Text = "文件损坏";
                            ((DuiLabel)b.FindControl("lbl")[0]).ForeColor = Color.Red;
                        }
                        else if (playing == 1)
                        {
                            b.BackColor = Color.Transparent;
                            b.FindControl("albumpic")[0].Visible = true;
                            b.Height = 50;
                            b.FindControl("infoforsinger")[0].Location = new Point(60, 25);
                            DuiLabel lbl = (DuiLabel)b.FindControl("lbl")[0];
                            lbl.Location = new Point(65, 5);
                            lbl.Width = 230;
                            lbl.Text = lbl.Tag.ToString();
                            b.FindControl("btnpause")[0].Visible = true;
                            b.FindControl("btnplay")[0].Visible = false;
                            b.FindControl("btndel")[0].Visible = true;
                            b.BackColor = Color.FromArgb(50, Color.White);
                            IsPlayingText = b.FindControl("lbl")[0].Tag.ToString();
                            IsPlayingList = b.Tag.ToString();
                            IsPlaying = name;
                        }
                        else if (playing == 2)
                        {
                            b.FindControl("btnpause")[0].Visible = false;
                            b.FindControl("btnplay")[0].Visible = true;
                        }
                        else if (playing == 3)
                        {
                            b.FindControl("btnpause")[0].Visible = true;
                            b.FindControl("btnplay")[0].Visible = false;
                        }
                        else if (playing == 0)
                        {
                            b.BackColor = Color.Transparent;
                            b.FindControl("albumpic")[0].Visible = false;
                            b.Height = 25;
                            b.FindControl("infoforsinger")[0].Location = new Point(160, 4);
                            b.FindControl("lbl")[0].Location = new Point(10, 4);
                            DuiLabel lbl = (DuiLabel)b.FindControl("lbl")[0];
                            lbl.Width = 160;
                            if (lbl.Tag.ToString().Length > 14)
                                lbl.Text = lbl.Tag.ToString().Remove(13).Insert(13, "...");
                            else
                                lbl.Text = lbl.Tag.ToString();

                            b.FindControl("btnpause")[0].Visible = false;
                            b.FindControl("btnplay")[0].Visible = false;
                            b.FindControl("btndel")[0].Visible = false;
                            b.BackColor = Color.Transparent;
                            IsPlaying = "";
                            IsPlayingText = "";
                            IsPlayingList = b.Tag.ToString();
                        }
                        RefreshList();
                    }
                }
            }
        }
        public void SetIsPlayingAb(string name, Image i, string listname = "")
        {
            if (IsInList(name))
            {
                if (listname != "")
                    foreach (DuiBaseControl b in InnerDuiControl.FindControl(name))
                    {
                        //System.Windows.Forms.MessageBox.Show(b.Tag.ToString());
                        if (b.Tag.ToString() == listname)
                        {
                            ((DuiPictureBox)b.FindControl("albumpic")[0]).BackgroundImage = i;
                        }
                    }
                else
                {
                    DuiBaseControl b = InnerDuiControl.FindControl(name)[0];
                    ((DuiPictureBox)b.FindControl("albumpic")[0]).BackgroundImage = i;
                }
            }
        }
        public void DeleteItem(string name, string listname)
        {
            if (listname != "")
            {
                for(int i=0;i<Items.Count;i++)
                {
                    if (Items[i].Name == name && Items[i].Tag.ToString() == listname)
                    {
                        Btndel_MouseClick(Items[i].FindControl("btndel")[0], null);
                    }
                }               
            }
        }
        public void DeleteList(string name)
        {

        }
        public MusicItem FindItemByName(string a, string listname)
        {
            MusicListItem m = FindGroup(listname);
            MusicItem ix = null;
            foreach (MusicItem i1 in m.musics)
            {
                if (i1.Path == a || i1.URL == a)
                {
                    ix = i1;
                }
            }
            return ix;
        }
        public MusicItem FindItemByNameOnline(string a, string listname)
        {
            MusicListItem m = FindGroup(listname);
            MusicItem ix = null;
            foreach (MusicItem i1 in m.musics)
            {
                if (i1.Name == a)
                {
                    ix = i1;
                }
            }
            return ix;
        }
        public DuiBaseControl FindItem(string a)
        {
            DuiBaseControl ix = null;
            foreach (DuiBaseControl i1 in Items)
            {
                if (i1.Name == a)
                {
                    ix = i1;
                }
            }
            return ix;
        }
        public DuiBaseControl FindItemEx(string name,string listname)
        {
            DuiBaseControl ix = null;
            foreach (DuiBaseControl i1 in Items)
            {
                if (i1.Name == name && i1.Tag.ToString() == listname)
                {
                    ix = i1;
                }
            }
            return ix;
        }
        public DuiBaseControl FindItemExByText(string listname,string text)
        {
            DuiBaseControl ix = null;
            foreach (DuiBaseControl i1 in Items)
            {
                if (i1.Tag.ToString() == listname && ((DuiLabel)i1.FindControl("lbl")[0]).Tag.ToString() == text)
                {
                    ix = i1;
                }
            }
            return ix;
        }
        public MusicListItem FindGroup(string a)
        {
            for (int i = 0; i < Groups.Count; i++)
            {
                if (Groups[i].Name == a)
                {
                    return Groups[i];
                }
            }
            return null;
        }
        public DuiBaseControl FindGroupEx(string a)
        {
            DuiBaseControl ix = null;
            foreach (DuiBaseControl i in Items)
            {
                if (i.Name == a || i.Name == "list_" + a)
                {
                    ix = i;
                }
            }
            return ix;
        }

        /// <summary>
        /// 音乐项集合
        /// </summary>
        public class MusicItem
        {
            public MusicItem()
            {

            }

            public string Name = "";
            public string Path = "";
            public bool IsOnline = false;
            public string URL = "";
            public string ParentName = "";
            public string Album = "";
            public string Length = "";
            public string Singer = "";
            public string Text = "";
            public string Hash = "";
            public string Downed = "";
        }
        /// <summary>
        /// 列表集合
        /// </summary>
        public class MusicListItem
        {
            public MusicListItem(string name, List<MusicItem> musics1)
            {
                Name = name;
                OldName = name;
                musics = musics1;
            }

            public string Name = "";
            public string OldName = "";
            public List<MusicItem> musics;          
        }

        public string OpenedList = "默认列表";
        public string IsPlayingList = "";
        public string IsPlaying = "";
        public string IsPlayingText = "";
        public string IsSelect = "";
        //public int IsPlayingCount = 0;

        public List<MusicListItem> Groups = new List<MusicListItem>();

        public new void RefreshList()
        {
            re();
            base.RefreshList();
            
        }

        public class MusicListArgs : EventArgs
        {
            public MusicListArgs(string musicName, string listName, bool jp)
            {
                MusicName = musicName;
                JustPlay = jp;ListName = listName;
            }

            public string ListName = "";
            public string MusicName = "";
            public bool JustPlay = false;
        }
        public class ClickArgs : EventArgs
        {
            public ClickArgs(string name, string pname = "")
            {
                Name = name; ListName = pname;
            }

            public string Name = "";
            public string ListName = "";
            
        }

        public delegate void MusicControlEventHandle(object sender, MusicListArgs e);
        public delegate void MusicControlClickEventHandle(object sender, ClickArgs e);
        public event MusicControlEventHandle PlayMusic;
        public event EventHandler PauseMusic;
        public event EventHandler StopMusic;
        public event EventHandler RefreshListed;
        public event MusicControlClickEventHandle ItemRightCilcked;
        public event MusicControlClickEventHandle ItemDiwnloadCilcked;
        public event MusicControlClickEventHandle ListMenuCilcked;

        private void playMusic(MusicListArgs e)
        {
            if (PlayMusic != null)
                PlayMusic(this, e);
        }
        private void pauseMusic()
        {
            if (PauseMusic != null)
                PauseMusic(this, new EventArgs());
        }
        private void stopmusic()
        {
            if (StopMusic != null)
                StopMusic(this, new EventArgs());
        }
        private void re()
        {
            if (RefreshListed != null)
                RefreshListed(this, new EventArgs());
        }
        private void ir(ClickArgs e)
        {
            if (ItemRightCilcked != null)
                ItemRightCilcked(this, e);
        }
        private void lm(ClickArgs e)
        {
            if (ListMenuCilcked != null)
                ListMenuCilcked(this, e);
        }
    }
}
