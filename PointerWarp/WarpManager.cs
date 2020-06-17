using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PointerWarp
{
	class WarpManager
	{
		private bool running = false;
		private Screen currentScreen;
		private Thread thread;
		private float range = 2000.0f;

		public void toggle(Screen currentScreen)
		{
			if (running) stop();
			else start(currentScreen);
		}

		public void setRange(float range)
		{
			this.range = range;
		}

		public void start(Screen currentScreen)
		{
			if (running) return;
			running = true;

			this.currentScreen = currentScreen;
			ThreadStart ts = delegate { doWarp(); };
			thread = new Thread(ts);
			thread.Start();
		}

		public void stop()
		{
			if (!running) return;
			running = false;
			thread.Abort();
		}

		public void doWarp()
		{
			while(running)
			{
				Rectangle bounds = currentScreen.Bounds;
				Point center = new Point((bounds.Left + bounds.Right) / 2, (bounds.Top + bounds.Bottom) / 2);
				Point maxDis = new Point((int)(bounds.Width/2*range), (int)(bounds.Height/2*range));
				Point dis = new Point(Math.Abs(Cursor.Position.X - center.X), Math.Abs(Cursor.Position.Y - center.Y));
				if (dis.X > maxDis.X) Cursor.Position = new Point(center.X, Cursor.Position.Y);
				if (dis.Y > maxDis.Y) Cursor.Position = new Point(Cursor.Position.X, center.Y);

				Thread.Sleep(0);
			}
		}
	}
}
