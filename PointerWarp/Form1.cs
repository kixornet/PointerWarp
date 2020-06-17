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
		private const float WARP_RANGE_DEFAULT = 90.0f;
		private const string WARP_BUTTON_TEXT_GO = "Engage";
		private const string WARP_BUTTON_TEXT_STOP = "Stop";

		public Form1()
		{
			InitializeComponent();

			warpManager = new WarpManager();
			button_warpToggle.Text = WARP_BUTTON_TEXT_GO;
			float warpRange = WARP_RANGE_DEFAULT;
			textBox_warpRange.Text = warpRange.ToString("0");
		}

		private void button_warpToggle_Click(object sender, EventArgs e)
		{
			toggleWarpButtonText();
			float range;
			float.TryParse(textBox_warpRange.Text, out range);
			warpManager.setRange(range/100.0f);
			warpManager.toggle(Screen.FromControl(this));
		}

		private void toggleWarpButtonText()
		{
			if (button_warpToggle.Text == WARP_BUTTON_TEXT_GO)
				button_warpToggle.Text = WARP_BUTTON_TEXT_STOP;
			else
				button_warpToggle.Text = WARP_BUTTON_TEXT_GO;
		}
	}
}
