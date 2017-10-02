using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace MusicPlayer
{
    public partial class AutoDocker : Component
    {
        private Form dockedForm;
        private bool IsOrg;
        private Rectangle lastBoard;
        public FormDockHideStatus formDockHideStatus = FormDockHideStatus.ShowNormally;
        internal DockHideType dockHideType;
        private System.Windows.Forms.Timer CheckPosTimer;
        private bool showOnce = false;
        private IContainer components = null;
        private Padding pvalue = new Padding(4);
        public AutoDocker()
        {
            this.InitializeComponent();
        }
        public AutoDocker(IContainer container)
        {
            container.Add(this);
            this.InitializeComponent();
        }
        public void Initialize(Form needDockedForm)
        {
            this.dockedForm = needDockedForm;
            bool flag = this.dockedForm != null;
            if (flag)
            {
                this.dockedForm.LocationChanged += new EventHandler(this.dockedForm_LocationChanged);
                this.dockedForm.SizeChanged += new EventHandler(this._form_SizeChanged);
                this.CheckPosTimer.Start();
            }
        }
        public void Initialize(Form needDockedForm, Padding value)
        {
            this.dockedForm = needDockedForm;
            bool flag = this.dockedForm != null;
            if (flag)
            {
                this.dockedForm.LocationChanged += new EventHandler(this.dockedForm_LocationChanged);
                this.dockedForm.SizeChanged += new EventHandler(this._form_SizeChanged);
                this.CheckPosTimer.Start();
            }
            pvalue = value;
        }
        public void UnInitialize(Form needUNDockedForm)
        {
            this.dockedForm = needUNDockedForm;
            this.dockedForm.LocationChanged -= new EventHandler(this.dockedForm_LocationChanged);
            this.dockedForm.SizeChanged -= new EventHandler(this._form_SizeChanged);
            this.CheckPosTimer.Stop();
        }
        private void CheckPosTimer_Tick(object sender, EventArgs e)
        {
            bool designMode = base.DesignMode;
            if (!designMode)
            {
                bool flag = this.dockedForm == null || !this.IsOrg;
                if (!flag)
                {
                    bool flag2 = this.dockedForm.Bounds.Contains(Cursor.Position);
                    if (flag2)
                    {
                        this.showOnce = false;
                    }
                    bool flag3 = this.showOnce;
                    if (flag3)
                    {
                        bool flag4 = this.dockHideType == DockHideType.Top;
                        if (flag4)
                        {
                            while (this.dockedForm.Top < 0)
                            {
                                this.dockedForm.Top = this.dockedForm.Top + 10;
                                Thread.Sleep(10);
                            }
                        }
                        else
                        {
                            bool flag5 = this.dockHideType == DockHideType.Right;
                            if (flag5)
                            {
                                while (this.dockedForm.Left > Screen.PrimaryScreen.Bounds.Width - this.dockedForm.Width)
                                {
                                    this.dockedForm.Location = new Point(this.dockedForm.Width - 10, this.dockedForm.Location.Y);
                                    Thread.Sleep(10);
                                }
                            }
                            else
                            {
                                bool flag6 = this.dockHideType == DockHideType.Left;
                                if (flag6)
                                {
                                    this.dockedForm.Location = new Point(0, this.dockedForm.Location.Y);
                                }
                            }
                        }
                        this.dockedForm.Size = new Size(this.lastBoard.Width, this.lastBoard.Height);
                    }
                    else
                    {
                        bool flag7 = this.dockedForm.Bounds.Contains(Cursor.Position);
                        if (flag7)
                        {
                            bool flag8 = this.dockHideType != DockHideType.Top;
                            if (flag8)
                            {
                                bool flag9 = this.dockHideType != DockHideType.Left;
                                if (flag9)
                                {
                                    bool flag10 = this.dockHideType != DockHideType.Right;
                                    if (!flag10)
                                    {
                                        bool flag11 = this.formDockHideStatus == FormDockHideStatus.Hide;
                                        if (flag11)
                                        {
                                            while (this.dockedForm.Left > Screen.PrimaryScreen.Bounds.Width - this.dockedForm.Width)
                                            {
                                                this.dockedForm.Left = this.dockedForm.Left - 10;
                                                Thread.Sleep(10);
                                            }
                                            this.dockedForm.Left = Screen.PrimaryScreen.Bounds.Width - this.dockedForm.Width;
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag12 = this.formDockHideStatus == FormDockHideStatus.Hide;
                                    if (flag12)
                                    {
                                        this.dockedForm.Location = new Point(0, this.dockedForm.Location.Y);
                                    }
                                }
                            }
                            else
                            {
                                bool flag13 = this.formDockHideStatus == FormDockHideStatus.Hide;
                                if (flag13)
                                {
                                    while (this.dockedForm.Top < 0)
                                    {
                                        this.dockedForm.Top = this.dockedForm.Top + 10;
                                        Thread.Sleep(10);
                                    }
                                    this.dockedForm.Top = 0;
                                }
                            }
                        }
                        else
                        {
                            switch (this.dockHideType)
                            {
                                case DockHideType.None:
                                    {
                                        bool flag14 = this.IsOrg && this.formDockHideStatus == FormDockHideStatus.ShowNormally && (this.dockedForm.Bounds.Width != this.lastBoard.Width || this.dockedForm.Bounds.Height != this.lastBoard.Height);
                                        if (flag14)
                                        {
                                            this.dockedForm.Size = new Size(this.lastBoard.Width, this.lastBoard.Height);
                                        }
                                        break;
                                    }
                                case DockHideType.Top:
                                    while (this.dockedForm.Top > (this.dockedForm.Height - pvalue.Top) * -1)
                                    {
                                        this.dockedForm.Top = this.dockedForm.Top - 10;
                                        Thread.Sleep(10);
                                    }
                                    this.dockedForm.Location = new Point(this.dockedForm.Location.X, (this.dockedForm.Height - pvalue.Top) * -1);
                                    break;
                                case DockHideType.Left:
                                    this.dockedForm.Location = new Point(-1 * (this.dockedForm.Width - pvalue.Left), this.dockedForm.Location.Y);
                                    break;
                                default:
                                    {
                                        bool flag15 = this.dockHideType != DockHideType.Right;
                                        if (!flag15)
                                        {
                                            while (this.dockedForm.Left < Screen.PrimaryScreen.Bounds.Width - pvalue.Right)
                                            {
                                                this.dockedForm.Left = this.dockedForm.Left + 10;
                                                Thread.Sleep(10);
                                            }
                                            this.dockedForm.Location = new Point(Screen.PrimaryScreen.Bounds.Width - pvalue.Right, this.dockedForm.Location.Y);
                                        }
                                        break;
                                    }
                            }
                        }
                    }
                }
            }
        }
        private void dockedForm_LocationChanged(object sender, EventArgs e)
        {
            this.ComputeDockHideType();
            bool flag = !this.IsOrg;
            if (flag)
            {
                this.lastBoard = this.dockedForm.Bounds;
                this.IsOrg = true;
            }
        }
        private void ComputeDockHideType()
        {
            bool flag = this.dockedForm.Top <= 0;
            if (flag)
            {
                this.dockHideType = DockHideType.Top;
                bool flag2 = this.dockedForm.Bounds.Contains(Cursor.Position);
                if (flag2)
                {
                    this.formDockHideStatus = FormDockHideStatus.ReadyToHide;
                }
                else
                {
                    this.formDockHideStatus = FormDockHideStatus.Hide;
                }
            }
            else
            {
                bool flag3 = this.dockedForm.Left <= 0;
                if (flag3)
                {
                    this.dockHideType = DockHideType.Left;
                    bool flag4 = this.dockedForm.Bounds.Contains(Cursor.Position);
                    if (flag4)
                    {
                        this.formDockHideStatus = FormDockHideStatus.ReadyToHide;
                    }
                    else
                    {
                        this.formDockHideStatus = FormDockHideStatus.Hide;
                    }
                }
                else
                {
                    bool flag5 = this.dockedForm.Left < Screen.PrimaryScreen.Bounds.Width - this.dockedForm.Width;
                    if (flag5)
                    {
                        this.dockHideType = DockHideType.None;
                        this.formDockHideStatus = FormDockHideStatus.ShowNormally;
                    }
                    else
                    {
                        this.dockHideType = DockHideType.Right;
                        bool flag6 = this.dockedForm.Bounds.Contains(Cursor.Position);
                        if (flag6)
                        {
                            this.formDockHideStatus = FormDockHideStatus.ReadyToHide;
                        }
                        else
                        {
                            this.formDockHideStatus = FormDockHideStatus.Hide;
                        }
                    }
                }
            }
        }
        private void _form_SizeChanged(object sender, EventArgs e)
        {
            bool flag = this.IsOrg && this.formDockHideStatus == FormDockHideStatus.ShowNormally;
            if (flag)
            {
                this.lastBoard = this.dockedForm.Bounds;
            }
        }
        public void ShowOnce()
        {
            this.showOnce = true;
            this.formDockHideStatus = FormDockHideStatus.ShowNormally;
        }
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new Container();
            this.CheckPosTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckPosTimer.Enabled = true;
            this.CheckPosTimer.Interval = 300;
            this.CheckPosTimer.Tick += new EventHandler(this.CheckPosTimer_Tick);
        }
    }
    public enum FormDockHideStatus
    {
        Hide,
        ReadyToHide,
        ShowNormally
    }
    public enum DockHideType
    {
        None,
        Top,
        Left,
        Right
    }
}
