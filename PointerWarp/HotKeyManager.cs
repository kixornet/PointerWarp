using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// based on:
// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.nativewindow?view=netcore-3.1
// https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-registerhotkey
// https://stackoverflow.com/questions/2450373/set-global-hotkeys-using-c-sharp

namespace PointerWarp
{
	public class HotKeyManager : NativeWindow
	{
		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		public event EventHandler<EventArgs> hotKeyListener;

		public HotKeyManager()
		{
			this.CreateHandle(new CreateParams());
		}

		protected override void WndProc(ref Message msg)
		{
			int WM_HOTKEY = 0x0312;
			if (msg.Msg == WM_HOTKEY)
			{
				if (hotKeyListener != null)
					hotKeyListener(this, new EventArgs());
			}
			base.WndProc(ref msg);
		}


		public void registerHotKey(Modifier mod, Keys key)
		{
			if (!RegisterHotKey(this.Handle, 0, (uint)mod, (uint)key))
				throw new Exception("Unable to register hotkey.");
		}
	}

	public enum Modifier : uint
	{
		None    = 0,
		Alt     = 1,
		Control = 2,
		Shift   = 4,
		Windows = 8
	}
}
