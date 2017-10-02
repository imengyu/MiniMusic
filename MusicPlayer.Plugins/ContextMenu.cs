using System;
using System.Collections.Generic;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace MusicPlayer.Plugin
{
    public class ContextMenu : System.Windows.Forms.ContextMenuStrip
    {
        public ContextMenu()
        {
            base.Renderer = new MenuRender();
        }
    }

    public class MenuRender : ToolStripProfessionalRenderer
    {
        ColorConfig colorconfig = new ColorConfig();//创建颜色配置类  

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);

        }
        /// <summary>  
        /// 渲染整个背景  
        /// </summary>  
        /// <param name="e"></param>  
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip is ToolStripDropDown)
            {
                e.ToolStrip.BackColor = Color.White;
                e.ToolStrip.ForeColor = Color.Black;
            }
            else
                base.OnRenderToolStripBackground(e);
        }
        /// <summary>  
        /// 渲染下拉左侧图标区域  
        /// </summary>  
        /// <param name="e"></param>  
        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            base.OnRenderImageMargin(e);
            e.Graphics.FillRectangle(Brushes.White, e.AffectedBounds);
        }
        /// <summary>  
        /// 渲染菜单项的背景  
        /// </summary>  
        /// <param name="e"></param>  
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.ToolStrip is MenuStrip)
            {
                if (e.Item.Enabled)
                {
                    //如果被选中或被按下  
                    if (e.Item.Selected || e.Item.Pressed)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(66, 133, 244)), new Rectangle(0, 0, e.Item.Width, e.Item.Height));
                        e.Item.ForeColor = Color.White;
                    }
                    else
                    {
                        e.Item.ForeColor = Color.Black;
                        base.OnRenderMenuItemBackground(e);
                    }
                }
            }
            else if (e.ToolStrip is ToolStripDropDown)
            {
                if (e.Item.Enabled)
                {
                    if (e.Item.Selected)
                    {
                        e.Item.ForeColor = Color.White;
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(66, 133, 244)), new Rectangle(0, 0, e.Item.Width, e.Item.Height));
                    }
                    else
                    {
                        e.Item.ForeColor = Color.Black;
                    }
                }
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
        /// <summary>  
        /// 渲染菜单项的分隔线  
        /// </summary>  
        /// <param name="e"></param>  
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.FromArgb(233, 233, 233)), 0, 2, e.Item.Width, 2);
        }
        /// <summary>  
        /// 渲染边框  
        /// </summary>  
        /// <param name="e"></param>  
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip is ToolStripDropDown)
            {
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(186, 186, 186)), new Rectangle(0, 0, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1));
            }
            else
            {
                base.OnRenderToolStripBorder(e);
            }
        }
        /// <summary>  
        /// 渲染箭头  
        /// </summary>  
        /// <param name="e"></param>  
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            if (e.Item.Selected)
                e.ArrowColor = Color.White;//设置为红色，当然还可以 画出各种形状  
            else
                e.ArrowColor = Color.Gray;
            base.OnRenderArrow(e);
        }
        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            base.OnRenderItemCheck(e);
            Rectangle r = new Rectangle(0, 0, e.ImageRectangle.Width + 10, e.Item.Height);
            Image i = null;
            if (e.Item.Selected)
            {
                i = MusicPlayer.Plugins.Properties.Resources.ichrome_cm_check_h;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(66, 133, 244)), r);
            }
            else
            {
                
                i = MusicPlayer.Plugins.Properties.Resources.ichrome_cm_check_n;
                e.Graphics.FillRectangle(Brushes.White, r);
            }
            e.Graphics.DrawImage(i, 5, e.Item.Height / 2 - i.Height / 2, i.Width, i.Height);
        }
    }
    public class ColorConfig
    {
        private Color _fontcolor = Color.White;
        /// <summary>  
        /// 菜单字体颜色  
        /// </summary>  
        public Color FontColor
        {
            get { return this._fontcolor; }
            set { this._fontcolor = value; }
        }
        private Color _marginstartcolor = Color.FromArgb(113, 113, 113);
        /// <summary>  
        /// 下拉菜单坐标图标区域开始颜色  
        /// </summary>  
        public Color MarginStartColor
        {
            get { return this._marginstartcolor; }
            set { this._marginstartcolor = value; }
        }
        private Color _marginendcolor = Color.FromArgb(58, 58, 58);
        /// <summary>  
        /// 下拉菜单坐标图标区域结束颜色  
        /// </summary>  
        public Color MarginEndColor
        {
            get { return this._marginendcolor; }
            set { this._marginendcolor = value; }
        }
        private Color _dropdownitembackcolor = Color.FromArgb(34, 34, 34);
        /// <summary>  
        /// 下拉项背景颜色  
        /// </summary>  
        public Color DropDownItemBackColor
        {
            get { return this._dropdownitembackcolor; }
            set { this._dropdownitembackcolor = value; }
        }
        private Color _dropdownitemstartcolor = Color.Orange;
        /// <summary>  
        /// 下拉项选中时开始颜色  
        /// </summary>  
        public Color DropDownItemStartColor
        {
            get { return this._dropdownitemstartcolor; }
            set { this._dropdownitemstartcolor = value; }
        }
        private Color _dorpdownitemendcolor = Color.FromArgb(160, 100, 20);
        /// <summary>  
        /// 下拉项选中时结束颜色  
        /// </summary>  
        public Color DropDownItemEndColor
        {
            get { return this._dorpdownitemendcolor; }
            set { this._dorpdownitemendcolor = value; }
        }
        private Color _menuitemstartcolor = Color.FromArgb(52, 106, 159);
        /// <summary>  
        /// 主菜单项选中时的开始颜色  
        /// </summary>  
        public Color MenuItemStartColor
        {
            get { return this._menuitemstartcolor; }
            set { this._menuitemstartcolor = value; }
        }
        private Color _menuitemendcolor = Color.FromArgb(73, 124, 174);
        /// <summary>  
        /// 主菜单项选中时的结束颜色  
        /// </summary>  
        public Color MenuItemEndColor
        {
            get { return this._menuitemendcolor; }
            set { this._menuitemendcolor = value; }
        }
        private Color _separatorcolor = Color.Gray;
        /// <summary>  
        /// 分割线颜色  
        /// </summary>  
        public Color SeparatorColor
        {
            get { return this._separatorcolor; }
            set { this._separatorcolor = value; }
        }
        private Color _mainmenubackcolor = Color.Black;
        /// <summary>  
        /// 主菜单背景色  
        /// </summary>  
        public Color MainMenuBackColor
        {
            get { return this._mainmenubackcolor; }
            set { this._mainmenubackcolor = value; }
        }
        private Color _mainmenustartcolor = Color.FromArgb(93, 93, 93);
        /// <summary>  
        /// 主菜单背景开始颜色  
        /// </summary>  
        public Color MainMenuStartColor
        {
            get { return this._mainmenustartcolor; }
            set { this._mainmenustartcolor = value; }
        }
        private Color _mainmenuendcolor = Color.FromArgb(34, 34, 34);
        /// <summary>  
        /// 主菜单背景结束颜色  
        /// </summary>  
        public Color MainMenuEndColor
        {
            get { return this._mainmenuendcolor; }
            set { this._mainmenuendcolor = value; }
        }
        private Color _dropdownborder = Color.FromArgb(40, 96, 151);
        /// <summary>  
        /// 下拉区域边框颜色  
        /// </summary>  
        public Color DropDownBorder
        {
            get { return this._dropdownborder; }
            set { this._dropdownborder = value; }
        }
    }
}
