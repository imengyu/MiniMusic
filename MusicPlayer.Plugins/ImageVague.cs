using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;


namespace MusicPlayer.Plugins
{
    public static class ImageVague
    {
 

        /// <summary>
        /// 图像模糊化
        /// </summary>
        /// <param name="bitmap">原始图像</param>
        /// <returns>模糊化后的图像</returns>
        public static Bitmap Blur(Bitmap bitmap)
        {
            if (bitmap == null)
            {
                return null;
            }
            int width = bitmap.Width;
            int height = bitmap.Height;
            try
            {
                Bitmap bmpReturn = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                BitmapData srcBits = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                BitmapData targetBits = bmpReturn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                unsafe
                {
                    byte* pSrcBits = (byte*)srcBits.Scan0.ToPointer();
                    byte* pTargetBits = (byte*)targetBits.Scan0.ToPointer();
                    int stride = srcBits.Stride;
                    byte* pTemp;
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                            {
                                //最边上的像素不处理
                                pTargetBits[0] = pSrcBits[0];
                                pTargetBits[1] = pSrcBits[1];
                                pTargetBits[2] = pSrcBits[2];
                            }
                            else
                            {
                                //取周围9点的值
                                int r1, r2, r3, r4, r5, r6, r7, r8, r9;
                                int g1, g2, g3, g4, g5, g6, g7, g8, g9;
                                int b1, b2, b3, b4, b5, b6, b7, b8, b9;
                                float fR, fG, fB;
                                //左上
                                pTemp = pSrcBits - stride - 3;
                                r1 = pTemp[2];
                                g1 = pTemp[1];
                                b1 = pTemp[0];
                                //正上
                                pTemp = pSrcBits - stride;
                                r2 = pTemp[2];
                                g2 = pTemp[1];
                                b2 = pTemp[0];
                                //右上
                                pTemp = pSrcBits - stride + 3;
                                r3 = pTemp[2];
                                g3 = pTemp[1];
                                b3 = pTemp[0];
                                //左侧
                                pTemp = pSrcBits - 3;
                                r4 = pTemp[2];
                                g4 = pTemp[1];
                                b4 = pTemp[0];
                                //右侧
                                pTemp = pSrcBits + 3;
                                r5 = pTemp[2];
                                g5 = pTemp[1];
                                b5 = pTemp[0];
                                //右下
                                pTemp = pSrcBits + stride - 3;
                                r6 = pTemp[2];
                                g6 = pTemp[1];
                                b6 = pTemp[0];
                                //正下
                                pTemp = pSrcBits + stride;
                                r7 = pTemp[2];
                                g7 = pTemp[1];
                                b7 = pTemp[0];
                                //右下
                                pTemp = pSrcBits + stride + 3;
                                r8 = pTemp[2];
                                g8 = pTemp[1];
                                b8 = pTemp[0];
                                //自己
                                pTemp = pSrcBits;
                                r9 = pTemp[2];
                                g9 = pTemp[1];
                                b9 = pTemp[0];
                                fR = (float)(r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9);
                                fG = (float)(g1 + g2 + g3 + g4 + g5 + g6 + g7 + g8 + g9);
                                fB = (float)(b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9);
                                fR /= 9;
                                fG /= 9;
                                fB /= 9;
                                pTargetBits[0] = (byte)fB;
                                pTargetBits[1] = (byte)fG;
                                pTargetBits[2] = (byte)fR;
                            }
                            pSrcBits += 3;
                            pTargetBits += 3;
                        }
                        pSrcBits += srcBits.Stride - width * 3;
                        pTargetBits += srcBits.Stride - width * 3;
                    }
                }
                bitmap.UnlockBits(srcBits);
                bmpReturn.UnlockBits(targetBits);
                return bmpReturn;
            }
            catch
            {
                return null;
            }
        }



        private static Guid BlurEffectGuid = new Guid("{633C80A4-1843-482B-9EF2-BE2834C5FDD4}");
        private static Guid UsmSharpenEffectGuid = new Guid("{63CBF3EE-C526-402C-8F71-62C540BF5142}");

        [StructLayout(LayoutKind.Sequential)]
        private struct BlurParameters
        {
            internal float Radius;
            internal bool ExpandEdges;
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct SharpenParams
        {
            internal float Radius;
            internal float Amount;
        }
        internal enum PaletteType               // GDI+1.1还可以针对一副图像获取某种特殊的调色
        {
            PaletteTypeCustom = 0,
            PaletteTypeOptimal = 1,
            PaletteTypeFixedBW = 2,
            PaletteTypeFixedHalftone8 = 3,
            PaletteTypeFixedHalftone27 = 4,
            PaletteTypeFixedHalftone64 = 5,
            PaletteTypeFixedHalftone125 = 6,
            PaletteTypeFixedHalftone216 = 7,
            PaletteTypeFixedHalftone252 = 8,
            PaletteTypeFixedHalftone256 = 9
        };
        internal enum DitherType                    // 这个主要用于将真彩色图像转换为索引图像，并尽量减低颜色损失
        {
            DitherTypeNone = 0,
            DitherTypeSolid = 1,
            DitherTypeOrdered4x4 = 2,
            DitherTypeOrdered8x8 = 3,
            DitherTypeOrdered16x16 = 4,
            DitherTypeOrdered91x91 = 5,
            DitherTypeSpiral4x4 = 6,
            DitherTypeSpiral8x8 = 7,
            DitherTypeDualSpiral4x4 = 8,
            DitherTypeDualSpiral8x8 = 9,
            DitherTypeErrorDiffusion = 10
        }


        [DllImport("gdiplus.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int GdipCreateEffect(Guid guid, out IntPtr effect);

        [DllImport("gdiplus.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int GdipDeleteEffect(IntPtr effect);

        [DllImport("gdiplus.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int GdipGetEffectParameterSize(IntPtr effect, out uint size);

        [DllImport("gdiplus.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int GdipSetEffectParameters(IntPtr effect, IntPtr parameters, uint size);

        [DllImport("gdiplus.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int GdipGetEffectParameters(IntPtr effect, ref uint size, IntPtr parameters);

        [DllImport("gdiplus.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int GdipBitmapApplyEffect(IntPtr bitmap, IntPtr effect, ref Rectangle rectOfInterest, bool useAuxData, IntPtr auxData, int auxDataSize);

        [DllImport("gdiplus.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int GdipBitmapCreateApplyEffect(ref IntPtr SrcBitmap, int numInputs, IntPtr effect, ref Rectangle rectOfInterest, ref Rectangle outputRect, out IntPtr outputBitmap, bool useAuxData, IntPtr auxData, int auxDataSize);


        // 这个函数我在C#下已经调用成功
        [DllImport("gdiplus.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int GdipInitializePalette(IntPtr palette, int palettetype, int optimalColors, int useTransparentColor, int bitmap);

        // 该函数一致不成功，不过我在VB6下调用很简单，也很成功，主要是结构体的问题。
        [DllImport("gdiplus.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int GdipBitmapConvertFormat(IntPtr bitmap, int pixelFormat, int dithertype, int palettetype, IntPtr palette, float alphaThresholdPercent);

        /// <summary>
        /// 获取对象的私有字段的值，感谢Aaron Lee Murgatroyd
        /// </summary>
        /// <typeparam name="TResult">字段的类型</typeparam>
        /// <param name="obj">要从其中获取字段值的对象</param>
        /// <param name="fieldName">字段的名称.</param>
        /// <returns>字段的值</returns>
        /// <exception cref="System.InvalidOperationException">无法找到该字段.</exception>
        /// 
        internal static IntPtr GetPrivateField(object obj, string fieldName)
        {
            if (obj == null) return default(IntPtr);
            Type ltType = obj.GetType();
            FieldInfo lfiFieldInfo = ltType.GetField(fieldName, System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (lfiFieldInfo != null)
                return (IntPtr)lfiFieldInfo.GetValue(obj);
            else
                throw new InvalidOperationException(string.Format("Instance field '{0}' could not be located in object of type '{1}'.", fieldName, obj.GetType().FullName));
        }

        public static IntPtr NativeHandle(Bitmap Bmp)
        {
            return GetPrivateField(Bmp, "nativeImage");
            /*  用Reflector反编译System.Drawing.Dll可以看到Image类有如下的私有字段
                internal IntPtr nativeImage;
                private byte[] rawData;
                private object userData;
                然后还有一个 SetNativeImage函数
                internal void SetNativeImage(IntPtr handle)
                {
                    if (handle == IntPtr.Zero)
                    {
                        throw new ArgumentException(SR.GetString("NativeHandle0"), "handle");
                    }
                    this.nativeImage = handle;
                }
                这里在看看FromFile等等函数，其实也就是调用一些例如GdipLoadImageFromFile之类的GDIP函数，并把返回的GDIP图像句柄
                通过调用SetNativeImage赋值给变量nativeImage，因此如果我们能获得该值，就可以调用VS2010暂时还没有封装的GDIP函数
                进行相关处理了，并且由于.NET肯定已经初始化过了GDI+，我们也就无需在调用GdipStartup初始化他了。
             */
        }

        /// <summary>
        /// 对图像进行高斯模糊,参考：http://msdn.microsoft.com/en-us/library/ms534057(v=vs.85).aspx
        /// </summary>
        /// <param name="Rect">需要模糊的区域，会对该值进行边界的修正并返回.</param>
        /// <param name="Radius">指定高斯卷积核的半径，有效范围[0，255],半径越大，图像变得越模糊.</param>
        /// <param name="ExpandEdge">指定是否对边界进行扩展，设置为True，在边缘处可获得较为柔和的效果. </param>

        public static Bitmap GaussianBlur(Bitmap Bmp, ref Rectangle Rect, float Radius = 10, bool ExpandEdge = false)
        {
            int Result;
            IntPtr BlurEffect;
            BlurParameters BlurPara;
            if ((Radius < 0) || (Radius > 255))
            {
                throw new ArgumentOutOfRangeException("半径必须在[0,255]范围内");
            }
            BlurPara.Radius = Radius;
            BlurPara.ExpandEdges = ExpandEdge;
            Result = GdipCreateEffect(BlurEffectGuid, out BlurEffect);
            if (Result == 0)
            {
                IntPtr Handle = Marshal.AllocHGlobal(Marshal.SizeOf(BlurPara));
                Marshal.StructureToPtr(BlurPara, Handle, true);
                GdipSetEffectParameters(BlurEffect, Handle, (uint)Marshal.SizeOf(BlurPara));
                GdipBitmapApplyEffect(NativeHandle(Bmp), BlurEffect, ref Rect, false, IntPtr.Zero, 0);
                // 使用GdipBitmapCreateApplyEffect函数可以不改变原始的图像，而把模糊的结果写入到一个新的图像中
                GdipDeleteEffect(BlurEffect);
                Marshal.FreeHGlobal(Handle);

                return Bmp;
            }
            else
            {
                throw new ExternalException("不支持的GDI+版本，必须为GDI+1.1及以上版本，且操作系统要求为Win Vista及之后版本.");
            }
        }


        /// <summary>
        /// 对图像进行锐化,参考：http://msdn.microsoft.com/en-us/library/ms534073(v=vs.85).aspx
        /// </summary>
        /// <param name="Rect">需要锐化的区域，会对该值进行边界的修正并返回.</param>
        /// <param name="Radius">指定高斯卷积核的半径，有效范围[0，255],因为这个锐化算法是以高斯模糊为基础的，所以他的速度肯定比高斯模糊妈妈</param>
        /// <param name="ExpandEdge">指定锐化的程度，0表示不锐化。有效范围[0,255]. </param>
        /// 
        public static void UsmSharpen(Bitmap Bmp, ref Rectangle Rect, float Radius = 10, float Amount = 50f)
        {
            int Result;
            IntPtr UnSharpMaskEffect;
            SharpenParams sharpenParams;
            if ((Radius < 0) || (Radius > 255))
            {
                throw new ArgumentOutOfRangeException("参数Radius必须在[0,255]范围内");
            }
            if ((Amount < 0) || (Amount > 100))
            {
                throw new ArgumentOutOfRangeException("参数Amount必须在[0,255]范围内");
            }
            sharpenParams.Radius = Radius;
            sharpenParams.Amount = Amount;
            Result = GdipCreateEffect(UsmSharpenEffectGuid, out UnSharpMaskEffect);
            if (Result == 0)
            {
                IntPtr Handle = Marshal.AllocHGlobal(Marshal.SizeOf(sharpenParams));
                Marshal.StructureToPtr(sharpenParams, Handle, true);
                GdipSetEffectParameters(UnSharpMaskEffect, Handle, (uint)Marshal.SizeOf(sharpenParams));
                GdipBitmapApplyEffect(NativeHandle(Bmp), UnSharpMaskEffect, ref Rect, false, IntPtr.Zero, 0);
                GdipDeleteEffect(UnSharpMaskEffect);
                Marshal.FreeHGlobal(Handle);
            }
            else
            {
                throw new ExternalException("不支持的GDI+版本，必须为GDI+1.1及以上版本，且操作系统要求为Win Vista及之后版本.");
            }
        }
    }
}
