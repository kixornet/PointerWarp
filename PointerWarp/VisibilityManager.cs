using System;
using System.Runtime.InteropServices;

// https://stackoverflow.com/questions/10541014/hiding-system-cursor
// https://stackoverflow.com/questions/27112845/winapi-setsystemcursor-and-loadcursorfrom-how-to-set-default-cursor
// https://social.msdn.microsoft.com/Forums/vstudio/en-US/a0509265-02b4-47fa-b24f-d7601ec53407/urgent-i-cant-restore-the-default-arrow-pointer-back-after-i-change-it-to-other-type-pointer
// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.cursor.current
// https://docs.microsoft.com/en-us/dotnet/api/system.windows.input.mouse.overridecursor
// https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-copycursor
// https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-loadimagew
// https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-createcursor

namespace PointerWarp
{
	class VisibilityManager
	{
		[DllImport("user32.dll")]
		static extern IntPtr CreateCursor(IntPtr hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, byte[] pvANDPlane, byte[] pvXORPlane);
		[DllImport("user32.dll")]
		static extern bool SetSystemCursor(IntPtr hcur, uint id);

		private static uint OCR_APPSTARTING = 32650; //Standard arrow and small hourglass
		private static uint OCR_NORMAL = 32512; //Standard arrow
		private static uint OCR_CROSS = 32515; //Crosshair
		private static uint OCR_HAND = 32649; //Hand
		private static uint OCR_HELP = 32651; //Arrow and question mark
		private static uint OCR_IBEAM = 32513; //I-beam
		private static uint OCR_NO = 32648; //Slashed circle
		private static uint OCR_SIZEALL = 32646; //Four-pointed arrow pointing north, south, east, and west
		private static uint OCR_SIZENESW = 32643; //Double-pointed arrow pointing northeast and southwest
		private static uint OCR_SIZENS = 32645; //Double-pointed arrow pointing north and south
		private static uint OCR_SIZENWSE = 32642; //Double-pointed arrow pointing northwest and southeast
		private static uint OCR_SIZEWE = 32644; //Double-pointed arrow pointing west and east
		private static uint OCR_UP = 32516; //Vertical arrow
		private static uint OCR_WAIT = 32514; //

		private byte[] andBits;
		private byte[] xorBits;
		private uint[] cursorTypes = { OCR_APPSTARTING, OCR_NORMAL, OCR_CROSS, OCR_HAND, OCR_HELP, OCR_IBEAM, OCR_NO, OCR_SIZEALL, OCR_SIZENESW, OCR_SIZENS, OCR_SIZENWSE, OCR_SIZEWE, OCR_UP, OCR_WAIT };
		//TODO: Track old cursors: private IntPtr[] oldCursors;

		public VisibilityManager()
		{
			andBits = new byte[4 * 32];
			xorBits = new byte[4 * 32];

			for(int i=0; i<4*32; i++) //data for a transparent cursor
			{
				andBits[i] = 0xff;
				xorBits[i] = 0x00;
			}

			//TODO: Init old cursor array
		}

		public void removeCursors()
		{
			IntPtr cursor;
			foreach(uint type in cursorTypes)
			{
				//TODO: Copy old cursor for this type

				cursor = CreateCursor((IntPtr)0, 0, 0, 32, 32, andBits, xorBits);
				SetSystemCursor(cursor, type);
			}
		}

		public void restoreCursors()
		{
			//TODO: Restore the old cursors
		}
	}
}
