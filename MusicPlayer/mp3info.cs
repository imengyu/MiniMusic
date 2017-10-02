using MusicPlayer.Shell;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace MusicPlayer
{
    public struct Mp3Info
    {
        public string identify;//TAG，三个字节     
        public string Title;//歌曲名,30个字节     
        public string Artist;//歌手名,30个字节     
        public string Album;//所属唱片,30个字节      
        public string Year;//年,4个字符     
        public string Comment;//注释,28个字节      
        public string MusicLength;
        public char reserved1;//保留位，一个字节        
        public char reserved2;//保留位，一个字节        
        public char reserved3;//保留位，一个字节     
    }
    /// 

    /// mp3类
    /// 

    public static class MP3Info
    {

        public static Mp3Info GetMp3Info(string file)
        {
            if(File.Exists(file))
            {
                return getMp3Info(file);
            }
            return new Mp3Info();
        }
        private static byte[] getLast128(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            Stream stream = fs;
            stream.Seek(-128, SeekOrigin.End);
            const int seekPos = 128;
            int rl = 0;
            byte[] Info = new byte[seekPos];
            rl = stream.Read(Info, 0, seekPos);
            fs.Close();
            stream.Close();
            return Info;
        }
        //再对上面返回的字节数组分段取出，并保存到Mp3Info结构中返回:   
        private static Mp3Info getMp3Info(string file)
        {
            byte[] Info = getLast128(file);
            Mp3Info mp3Info = new Mp3Info();

            FileInfo fInfo = new FileInfo(Path.GetFileName(file));
            ShellClass sh = new ShellClass();
            Folder dir = sh.NameSpace(Path.GetDirectoryName(file));
            FolderItem item = dir.ParseName(Path.GetFileName(file));
            mp3Info.MusicLength = Regex.Match(dir.GetDetailsOf(item, -1), "\\d:\\d{2}:\\d{2}").Value;//获取歌曲时间

            //TimeToString(TimeSpan.FromMilliseconds(GetAMRFileDuration(file)));
            string str = null;
            int i;
            int position = 0;//循环的起始值     
            int currentIndex = 0;//Info的当前索引值     
            //获取TAG标识(数组前3个)     
            for (i = currentIndex; i < currentIndex + 3; i++)
            {
                str = str + (char)Info[i];
                position++;
            }
            currentIndex = position;
            mp3Info.identify = str;
            //获取歌名（数组3-32）     
            str = null;
            byte[] bytTitle = new byte[30];//将歌名部分读到一个单独的数组中     
            int j = 0;
            for (i = currentIndex; i < currentIndex + 30; i++)
            {
                bytTitle[j] = Info[i];
                position++;
                j++;
            }
            currentIndex = position;
            mp3Info.Title = byteToString(bytTitle);
            //获取歌手名（数组33-62）     
            str = null;
            j = 0;
            byte[] bytArtist = new byte[30];//将歌手名部分读到一个单独的数组中     
            for (i = currentIndex; i < currentIndex + 30; i++)
            {
                bytArtist[j] = Info[i];
                position++;
                j++;
            }
            currentIndex = position;
            mp3Info.Artist = byteToString(bytArtist);
            //获取唱片名（数组63-92）     
            str = null;
            j = 0;
            byte[] bytAlbum = new byte[30];//将唱片名部分读到一个单独的数组中     
            for (i = currentIndex; i < currentIndex + 30; i++)
            {
                bytAlbum[j] = Info[i];
                position++;
                j++;
            }
            currentIndex = position;
            mp3Info.Album = byteToString(bytAlbum);
            //获取年 （数组93-96）    
            str = null;
            j = 0;
            byte[] bytYear = new byte[4];//将年部分读到一个单独的数组中     
            for (i = currentIndex; i < currentIndex + 4; i++)
            {
                bytYear[j] = Info[i];
                position++;
                j++;
            }
            currentIndex = position;
            mp3Info.Year = byteToString(bytYear);
            //获取注释（数组97-124）     
            str = null;
            j = 0;
            byte[] bytComment = new byte[28];//将注释部分读到一个单独的数组中     
            for (i = currentIndex; i < currentIndex + 25; i++)
            {
                bytComment[j] = Info[i];
                position++;
                j++;
            }
            currentIndex = position;
            mp3Info.Comment = byteToString(bytComment);
            //以下获取保留位（数组125-127）     
            mp3Info.reserved1 = (char)Info[++position];
            mp3Info.reserved2 = (char)Info[++position];
            mp3Info.reserved3 = (char)Info[++position];
            return mp3Info;
        }
        //上面程序用到下面的方法：     
        ///   


        ///   将字节数组转换成字符串    
        ///   

        ///   字节数组     
        ///   返回转换后的字符串     
        private static string byteToString(byte[] b)
        {
            Encoding enc = Encoding.GetEncoding("GB2312");
            string str = enc.GetString(b);
            str = str.Substring(0, str.IndexOf('\0') >= 0 ? str.IndexOf('\0') : str.Length);//去掉无用字符     
            return str;
        }

        private static string TimeToString(TimeSpan span)
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
        private static long GetAMRFileDuration(string fileName)
        {
            long duration = 0;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            {
                byte[] packed_size = new byte[16] { 12, 13, 15, 17, 19, 20, 26, 31, 5, 0, 0, 0, 0, 0, 0, 0 };
                int pos = 0;
                pos += 6;
                long lenth = fs.Length;
                byte[] toc = new byte[1];
                int framecount = 0;
                byte ft;
                while (pos < lenth)
                {
                    fs.Seek(pos, SeekOrigin.Begin);
                    if (1 != fs.Read(toc, 0, 1))
                    {
                        duration = lenth > 0 ? ((lenth - 6) / 650) : 0;
                        fs.Close();
                        break;
                    }
                    ft = (byte)((toc[0] / 8) & 0x0F);
                    pos += packed_size[ft] + 1;
                    framecount++;
                }
                duration = framecount * 20 / 1000;
            }
            fs.Close();
            return duration;
        }
    }
}
