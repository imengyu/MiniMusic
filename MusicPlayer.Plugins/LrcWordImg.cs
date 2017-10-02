using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Text;


namespace MusicPlayer.Plugins
{
    static class LrcWordImg
    {
        static Color _BorderColor = Color.FromArgb(224, 224, 224);
        static Bitmap image;
        static Graphics g;
        static public Bitmap DrawImageFormString(string word, Color[] colorback,bool shadow=false,int fontsize=24, string fontname = "微软雅黑",FontStyle fontstyle = FontStyle.Regular)
        {
            fontSize = fontsize;
            fontStyle = fontstyle;
            fontName = fontname;
            try
            {
                brushBaseUp = colorback[0];
                brushBaseDown = colorback[1];

                image = new Bitmap((int)GetWordSize(word).Width, (int)GetWordSize(word).Height);
                backImage = new Bitmap((int)GetWordSize(word).Width, (int)GetWordSize(word).Height);
                g = Graphics.FromImage(image);
                //g.SmoothingMode = SmoothingMode.AntiAlias;             

                brushBase = new LinearGradientBrush(new Point(0, 0), new Point(0, Convert.ToInt32(GetWordSize(word).Height)), Color.FromArgb((int)(stringOpacity * 2.55), brushBaseUp), Color.FromArgb((int)(stringOpacity * 2.55), brushBaseDown));

                Graphics gb = Graphics.FromImage(backImage);

                Bitmap imageshadow = new Bitmap((int)GetWordSize(word).Width, (int)GetWordSize(word).Height);
                if (shadow)
                {
                    Graphics gbs = Graphics.FromImage(imageshadow);
                    HatchBrush brushsh = new HatchBrush(HatchStyle.Percent50, Color.Black);
                    path.Reset();
                    path.AddString(word, new FontFamily(fontName), (int)fontStyle, fontSize, new Point(2, 1), StringFormat.GenericDefault);
                    gbs.SmoothingMode = SmoothingMode.AntiAlias;
                    gbs.DrawPath(new Pen(Color.FromArgb((int)(stringOpacity * 1.5), Color.Black), 2), path);
                    gbs.FillPath(brushsh, path);
                }

                path.Reset();
                path.AddString(word, new FontFamily(fontName), (int)fontStyle, fontSize, new Point(0, 0), StringFormat.GenericDefault);

                gb.DrawImage(imageshadow, new Point(0, 0));
                gb.SmoothingMode = SmoothingMode.AntiAlias;
                gb.DrawPath(new Pen(Color.FromArgb((int)(stringOpacity * 1.5), Color.Black), 2), path);
                gb.FillPath(brushBase, path);


                Graphics gbi = Graphics.FromImage(image);
                gbi.DrawImage(backImage, new Point(0, 0));

                return image;
            }
            catch (Exception ee)
            {
                return null;
                throw ee;
            }
        }

        static public Bitmap DrawImageFormStringW(string word, Color colorback, int fontsize = 24, string fontname = "微软雅黑", FontStyle fontstyle = FontStyle.Regular)
        {
            fontSize = fontsize;
            fontStyle = fontstyle;
            fontName = fontname;
            try
            {
                brushBaseUp = colorback;        
                brushBase = new LinearGradientBrush(new Point(0, 0), new Point(0, Convert.ToInt32(GetWordSize(word).Height)), Color.FromArgb((int)(stringOpacity * 2.55), brushBaseUp), Color.FromArgb((int)(stringOpacity * 2.55), brushBaseUp));
                Graphics gb = Graphics.FromImage(image);                
                path.Reset();
                path.AddString(word, new FontFamily(fontName), (int)fontStyle, fontSize, new Point(0, 0), StringFormat.GenericDefault);
                gb.SmoothingMode = SmoothingMode.AntiAlias;
                gb.DrawPath(new Pen(Color.FromArgb((int)(stringOpacity * 1.5), Color.Black), 2), path);
                gb.FillPath(brushBase, path);
                return image;
            }
            catch (Exception ee)
            {
                return null;
                throw ee;
            }
        }

        static Bitmap backImage;//底部图片
        static LinearGradientBrush brushBase;//文字渐变背景色
        static Color brushBaseUp;
        static Color brushBaseDown;
        static string fontName = "微软雅黑";
        static int stringOpacity = 100;//文字不透明度0-100
        static FontStyle fontStyle = FontStyle.Bold;//字体类型
        static int fontSize = 24;//歌词字体大小以像素为单位

        /// <summary>
        /// 文字不透明度0-100
        /// </summary>
        public static int StringOpacity
        {
            get { return stringOpacity; }
            set { stringOpacity = value; }
        }
        public static string FontName
        {
            get { return fontName; }
            set { fontName = value; }
        }
        
        public static FontStyle FontStyle
        {
            get { return fontStyle; }
            set { fontStyle = value; }
        }
       
        public static int FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }
        static GraphicsPath path = new GraphicsPath();//文字路径

        /// <summary>
        ///获取歌词宽度和高度
        /// </summary>
        static public SizeF GetWordSize(string word)
        {
            Font drawFont = new Font(fontName, fontSize, fontStyle, GraphicsUnit.Pixel);
            SizeF size = Graphics.FromImage(new Bitmap(1, 1)).MeasureString(word, drawFont);
            return size;
        }
    }
}
