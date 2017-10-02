using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;


using System.Text;

using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace MusicPlayer.Plugins
{
    [Designer(typeof(ButtonDesigner))]
    public partial class Button : Control, IButtonControl
    {          
        /// <summary>
        /// 初始化 MBorser.Utils.Button 的新实例.
        /// </summary>
        public Button()
        {
            SetStyle(ControlStyles.UserPaint, true);  
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲      
            Paint += ImageButton_Paint;
        }
       
        #region Public Method 
       
        [Description("设置按钮禁用时的图像"), DefaultValue(null)]
        public Image DisableImage
        {
            get { return disimg; }
            set { disimg = value; if (dis) Refresh(); }
        }
        [Description("设置按钮的图像"), DefaultValue(null)]
        public Image NormalImage
        {
            get { return norimg; }
            set { norimg = value; Refresh(); }
        }
        [Description("设置鼠标悬浮于按钮上时的图像"), DefaultValue(null)]
        public Image HoverImage
        {
            get { return hovimg; }
            set { hovimg = value; if (enter) Refresh(); }
        }
        [Description("设置鼠标在按钮上时按下的图像"), DefaultValue(null)]
        public Image PressImage
        {
            get { return donimg; }
            set { donimg = value; if (down) Refresh(); }
        } 
        /*
        [Description("指示是否启用该控件"), DefaultValue(true)]
        public new bool Enabled
        {
            get { return !dis; }
            set
            {
                if (value)
                {
                    dis = false;
                    Refresh();
                }
                else
                {
                    dis = true;
                    Refresh();
                }
                base.Enabled = value;
            }
        }
        */
        [Description("指示按钮调整图片的方式"), DefaultValue(ButtonImageMode.Normal)]
        public ButtonImageMode SizeMode
        {
            get { return mod; }
            set
            {
                mod = value;
                if (mod == ButtonImageMode.AutoSize)
                {
                    if (norimg != null)
                        Size = norimg.Size;
                    base.SetStyle(ControlStyles.FixedWidth | ControlStyles.FixedHeight, true);
                    Refresh();
                }
                else
                {
                    base.SetStyle(ControlStyles.FixedWidth | ControlStyles.FixedHeight, false);
                    Refresh();
                }

            }
        }
        [Description("设置显示在按钮上的文字"), DefaultValue("")]
        public new string Text
        {
            get { return text; }
            set
            {
                base.Text = value;
                text = value; Refresh();
            }
        }
        [Description("设置显示在按钮上的文字的颜色")]
        public new Color ForeColor
        {
            get { return forecolor; }
            set
            {
                base.ForeColor = value;
                forecolor = value; Refresh();
            }
        }
        [Description("设置显按钮九宫切图数值")]
        public Padding Palace
        {
            get { return palaceix; }
            set { palaceix = value; Refresh(); }
        }
        [Description("设置按钮的返回值"), DefaultValue(DialogResult.None)]
        public DialogResult DialogResult
        {
            get
            {
                return _DialogResult;
            }
            set
            {
                if (Enum.IsDefined(typeof(DialogResult), value))
                {
                    _DialogResult = value;
                }
            }
        }
        public void NotifyDefault(bool value)
        {
            if (_isDefault != value)
            {
                _isDefault = value;
            }
        }
        public void PerformClick()
        {
            base.OnClick(EventArgs.Empty);
        }
        #endregion      

        #region Others Defined

        /// <summary>
        /// 指定 Button 的图像绘画模式
        /// </summary>
        public enum ButtonImageMode
        {
            /// <summary>
            /// 调整 Buttom 大小，使其等于所包含的图像大小。
            /// </summary>
            AutoSize,
            /// <summary>
            /// 图像被置于 Buttom 的左上角。如果图像比包含它的 Buttom 大，则该图像将被剪裁掉。
            /// </summary>
            Normal,
            /// <summary>
            /// Buttom 中的图像被拉伸或收缩，以适合 Buttom 的大小。
            /// </summary>
            StretchImage,
            /// <summary>
            /// 图像大小按其原有的大小比例被增加或减小。
            /// </summary>
            Zoom,
            /// <summary>
            /// 如果图像比包含它的 Buttom 大，则该图像将使用九宫切图以保证图像不会被拉伸。
            /// </summary>
            Palace,
        }
        #endregion

        #region Private Variable

        private Color forecolor = Color.Black;
        private bool dis = false;
        private bool enter = false;
        private bool down = false;
        private Padding palaceix = new Padding(5, 5, 5, 5);
        private Image ico = null;
        private Image disimg = null;
        private Image norimg = null;
        private Image hovimg = null;
        private Image donimg = null;
        private ButtonImageMode mod = ButtonImageMode.Normal;
        private string text = "";
        private DialogResult _DialogResult;
        private bool _isDefault = false;

        #endregion

        #region Private Method
        private void ImageButton_Paint(object sender, PaintEventArgs e)
        {
            Bitmap b = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics g = Graphics.FromImage(b);
            g.FillRectangle(new SolidBrush(BackColor), new RectangleF(0, 0, Width, Height));

            if (!Enabled)
            {
                ImageButton_DrawImage(disimg, g);
                if (text != "")
                {
                    SizeF size = g.MeasureString(text, Font);
                    if (size.Width > Width)
                        size.Width = Width;
                    g.DrawString(text, Font, new SolidBrush(Color.Gray), new Point((int)(Width / 2 - size.Width / 2), (int)(Height / 2 - size.Height / 2)));
                    g.Dispose();
                    b.Dispose();
                }
            }
            else
            {
                if (enter)
                {
                    if (down)
                        ImageButton_DrawImage(donimg, g);
                    else
                    {
                        ImageButton_DrawImage(hovimg, g);
                    }
                }
                else
                {
                    ImageButton_DrawImage(norimg, g);
                }

                if (text != "")
                {
                    SizeF size = g.MeasureString(text, Font);
                    if (size.Width > Width)
                        size.Width = Width;
                    g.DrawString(text, Font, new SolidBrush(forecolor), new Point((int)(Width / 2 - size.Width / 2), (int)(Height / 2 - size.Height / 2)));
                }
                g.Dispose();
                e.Graphics.DrawImageUnscaled(b, 0, 0);
                b.Dispose();
            }
        }
        private void ImageButton_DrawImage(Image i, Graphics g)
        {            
            try
            {
                if (i != null)
                {
                    if (mod == ButtonImageMode.AutoSize)
                    {
                        if (Size != i.Size)
                            Size = i.Size;
                        g.DrawImage(i, 0, 0, norimg.Size.Width, norimg.Size.Height);
                    }
                    else if (mod == ButtonImageMode.Normal)
                        g.DrawImage(i, 0, 0, norimg.Size.Width, norimg.Size.Height);
                    else if (mod == ButtonImageMode.StretchImage)
                        g.DrawImage(i, 0, 0, Width, Height);
                    else if (mod == ButtonImageMode.Zoom)
                    {
                        if (Width < Height)
                            g.DrawImage(i, Height / 2 - Width / 2, 0, Width, Width);
                        else
                            g.DrawImage(i, Width / 2 - Height / 2, 0, Height, Height);
                    }
                    else if (mod == ButtonImageMode.Palace)
                    {
                        if (i.Width > palaceix.Left + palaceix.Right && i.Height > palaceix.Bottom + palaceix.Top)
                        {
                            Rectangle rect = ClientRectangle;
                            g.DrawImage(i, new Rectangle(rect.X, rect.Y, palaceix.Left, palaceix.Top), new Rectangle(0, 0, palaceix.Left, palaceix.Top), GraphicsUnit.Pixel);//↖
                            g.DrawImage(i, new Rectangle(rect.Right - palaceix.Right, rect.Y, palaceix.Right, palaceix.Top), new Rectangle(i.Width - palaceix.Right, 0, palaceix.Right, palaceix.Top), GraphicsUnit.Pixel);//↗
                            g.DrawImage(i, new Rectangle(rect.X, rect.Bottom - palaceix.Bottom, palaceix.Left, palaceix.Bottom), new Rectangle(0, i.Height - palaceix.Bottom, palaceix.Left, palaceix.Bottom), GraphicsUnit.Pixel);//↘
                            g.DrawImage(i, new Rectangle(rect.Right - palaceix.Right, rect.Bottom - palaceix.Bottom, palaceix.Right, palaceix.Bottom), new Rectangle(i.Width - palaceix.Right, i.Height - palaceix.Bottom, palaceix.Right, palaceix.Bottom), GraphicsUnit.Pixel);//↙
                                                                                                                                                                                                                                                                                 //四边
                            g.DrawImage(i, new Rectangle(rect.X + palaceix.Left, 0, rect.Width - palaceix.Left - palaceix.Right, palaceix.Top), new Rectangle(palaceix.Left, 0, i.Width - palaceix.Left - palaceix.Right, palaceix.Top), GraphicsUnit.Pixel);//↑


                            g.DrawImage(i, new Rectangle(rect.X + palaceix.Left, rect.Height - palaceix.Bottom, rect.Width - palaceix.Left - palaceix.Right, palaceix.Bottom), new Rectangle(palaceix.Left, i.Height - palaceix.Bottom, i.Width - palaceix.Left - palaceix.Right, palaceix.Bottom), GraphicsUnit.Pixel);//↓


                            g.DrawImage(i, new Rectangle(0, palaceix.Top, palaceix.Left, rect.Height - palaceix.Top - palaceix.Bottom), new Rectangle(0, palaceix.Top, palaceix.Left, i.Height - palaceix.Top - palaceix.Bottom), GraphicsUnit.Pixel);//←
                            g.DrawImage(i, new Rectangle(rect.Right - palaceix.Right, palaceix.Top, palaceix.Right, rect.Height - palaceix.Bottom - palaceix.Top), new Rectangle(i.Width - palaceix.Right, palaceix.Top, palaceix.Right, i.Height - palaceix.Top - palaceix.Bottom), GraphicsUnit.Pixel);//→
                                                                                                                                                                                                                                                                                                         //中间
                            g.DrawImage(i, new Rectangle(rect.X + palaceix.Left, rect.Y + palaceix.Top, rect.Width - palaceix.Left - palaceix.Right, rect.Height - palaceix.Top - palaceix.Bottom), new Rectangle(palaceix.Left, palaceix.Top, i.Width - palaceix.Left - palaceix.Right, i.Height - palaceix.Top - palaceix.Bottom), GraphicsUnit.Pixel);
                        }
                        else
                            g.DrawImage(i, 0, 0, Width, Height);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message + "\n错误详细信息：\n" + ee.ToString(), "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        protected override void OnTextChanged(EventArgs e)
        {           
            base.OnTextChanged(e);
            Refresh();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!DesignMode)
            {
                enter = true;
                Refresh();
            }
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (!DesignMode)
            {
                enter = false;
                Refresh();
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!DesignMode)
            {
                enter = true;
                down = true;
                Refresh();
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (!DesignMode)
            {
                enter = true;
                down = false;
                Refresh();
            }
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        protected override void OnEnabledChanged(EventArgs e)
        {
            if (Enabled)
                dis = false;
            else
                dis = true;
            base.OnEnabledChanged(e);
        }

        #endregion
    }

    #region Desginer 
    /// <summary>
    /// 自定义控件设计器类
    /// </summary>
    public class ButtonDesigner : ControlDesigner
    {
        public ButtonDesigner()
        {
        }
        private DesignerActionListCollection _actionLists;
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (this._actionLists == null)
                {
                    this._actionLists = new DesignerActionListCollection();
                    this._actionLists.Add(new ButtonActionList(this));
                }
                return this._actionLists;
            }
        }
        public override SelectionRules SelectionRules
        {
            get
            {
                SelectionRules selectionRules = SelectionRules.None;
                object component = base.Component;
                PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(base.Component)["SizeMode"];
                if (propertyDescriptor != null && (Button.ButtonImageMode)propertyDescriptor.GetValue(component) != Button.ButtonImageMode.AutoSize)
                {
                    selectionRules = SelectionRules.TopSizeable | SelectionRules.BottomSizeable | SelectionRules.LeftSizeable | SelectionRules.RightSizeable | SelectionRules.Moveable | SelectionRules.Visible;
                }
                else if (propertyDescriptor != null)
                {
                    selectionRules = SelectionRules.Moveable | SelectionRules.Visible;
                }
                return selectionRules;
            }
        }
    }
    internal class ButtonActionList : DesignerActionList
    {
        private ButtonDesigner _designer;
        public Button.ButtonImageMode SizeMode
        {
            get
            {
                return ((Button)base.Component).SizeMode;
            }
            set
            {
                TypeDescriptor.GetProperties(base.Component)["SizeMode"].SetValue(base.Component, value);
            }
        }
        public Image NormalImage
        {
            get
            {
                return ((Button)base.Component).NormalImage;
            }
            set
            {
                TypeDescriptor.GetProperties(base.Component)["NormalImage"].SetValue(base.Component, value);
            }
        }
        public Image HoverImage
        {
            get
            {
                return ((Button)base.Component).HoverImage;
            }
            set
            {
                TypeDescriptor.GetProperties(base.Component)["HoverImage"].SetValue(base.Component, value);
            }
        }
        public Image PressImage
        {
            get
            {
                return ((Button)base.Component).PressImage;
            }
            set
            {
                TypeDescriptor.GetProperties(base.Component)["PressImage"].SetValue(base.Component, value);
            }
        }
        public Image DisableImage
        {
            get
            {
                return ((Button)base.Component).DisableImage;
            }
            set
            {
                TypeDescriptor.GetProperties(base.Component)["DisableImage"].SetValue(base.Component, value);
            }
        }
        public ButtonActionList(ButtonDesigner designer) : base(designer.Component)
        {
            this._designer = designer;
        }
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            return new DesignerActionItemCollection
            {
                new DesignerActionPropertyItem("SizeMode", "按钮大小模式:", "PropertiesCategoryName", "更改 ImageButton 中的图像缩放模式"),
                new DesignerActionTextItem("设置图像按钮不同的图像:","PropertiesCategoryName"),
                new DesignerActionPropertyItem("NormalImage", "按钮正常时图片:", "PropertiesCategoryName", "更改 ImageButton 的按钮正常时的图片"),
                new DesignerActionPropertyItem("HoverImage", "鼠标悬浮时图片:", "PropertiesCategoryName", "更改 ImageButton 的鼠标悬浮时图片"),
                new DesignerActionPropertyItem("PressImage", "鼠标按下时图片:", "PropertiesCategoryName", "更改 ImageButton 的鼠标按下时图片"),
                new DesignerActionPropertyItem("DisableImage", "按钮禁用时图片:", "PropertiesCategoryName", "更改 ImageButton 的按钮禁用时图片"),
            };
        }
    }
    #endregion
}
