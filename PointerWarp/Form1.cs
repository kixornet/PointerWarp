using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointerWarp
{
	public partial class Form1 : Form
	{
		private WarpManager warpManager;
		private HotKeyManager hotKeyManager;
		private long lastHotKeyTime;
		private const float WARP_RANGE_DEFAULT = 90.0f;
		private const string WARP_BUTTON_TEXT_GO = "Engage";
		private const string WARP_BUTTON_TEXT_STOP = "Stop";

		public Form1()
		{
			InitializeComponent();

			warpManager = new WarpManager();
			hotKeyManager = new HotKeyManager();
			hotKeyManager.hotKeyListener += new EventHandler<EventArgs>(globalHotKey_Pressed);
			hotKeyManager.registerHotKey(Modifier.Shift, Keys.Back);
			button_warpToggle.Text = WARP_BUTTON_TEXT_GO;
			float warpRange = WARP_RANGE_DEFAULT;
			textBox_warpRange.Text = warpRange.ToString("0");
			this.TopMost = checkBox_onTop.Checked;
		}

		private void button_warpToggle_Click(object sender, EventArgs e)
		{
			toggleWarpButtonText();
			updateWarpRange();
			warpManager.toggle(Screen.FromControl(this));
		}

		private void toggleWarpButtonText()
		{
			if (button_warpToggle.Text == WARP_BUTTON_TEXT_GO)
				button_warpToggle.Text = WARP_BUTTON_TEXT_STOP;
			else
				button_warpToggle.Text = WARP_BUTTON_TEXT_GO;
		}

		private void textBox_warpRange_TextChanged(object sender, EventArgs e)
		{
			updateWarpRange();
		}

		private void globalHotKey_Pressed(object sender, EventArgs e)
		{
			long now = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
			int delay = 500;
			if (now - lastHotKeyTime < delay)
				button_warpToggle_Click(sender, e);
			else
				lastHotKeyTime = now;
		}

		private void updateWarpRange()
		{
			float range;
			float.TryParse(textBox_warpRange.Text, out range);
			warpManager.setRange(range / 100.0f);
		}

		private void checkBox_onTop_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = checkBox_onTop.Checked;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			checkBox_onTop_CheckedChanged(sender, e);
		}
	}
}
