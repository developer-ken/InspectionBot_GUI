using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Threading;

namespace InspectionBot_GUI
{
    public struct SiteItem
    {
        public double Position;
        public double Duration;
    }

    public partial class Form1 : Form
    {
        double TotalLen = 1;
        Dictionary<SiteItem, Label> ItemList = new Dictionary<SiteItem, Label>();
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        public void RegenerateMarkers()
        {
            new Thread(new ThreadStart(() =>
            {
                Thread.Sleep(50);
            rgen_mk_retry:
                try
                {
                    foreach (KeyValuePair<SiteItem, Label> item in ItemList)
                    {
                        int x = (int)(
                            item.Key.Position
                            //* 100
                            * ((double)((numberpos_full.Location.X + numberpos_full.Width / 2)
                            - (numberpos_zero.Location.X + numberpos_zero.Width / 2))
                            / TotalLen)
                            + numberpos_zero.Location.X + numberpos_zero.Width / 2
                            );
                        x -= item.Value.Width / 2;
                        int y = numberpos_zero.Location.Y;
                        item.Value.Location = new Point(x, y);
                        item.Value.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
                        item.Value.BringToFront();
                        item.Value.AutoSize = true;
                        //item.Value.BackColor = cam_IR.BackColor;
                    }
                }
                catch
                {
                    goto rgen_mk_retry;
                }
            })).Start();
        }

        public void RegenerateListbox()
        {
            preposlist.BeginUpdate();
            preposlist.Items.Clear();
            preposlist.Items.Add("位置\t停留时间");
            foreach (KeyValuePair<SiteItem, Label> item in ItemList)
            {
                preposlist.Items.Add(item.Key.Position + "\t" + item.Key.Duration);
            }
            preposlist.EndUpdate();
        }

        private void trackBar1_MouseEnter(object sender, EventArgs e)
        {
            trackBar1.Enabled = false;
        }

        private void trackBar1_MouseLeave(object sender, EventArgs e)
        {
            trackBar1.Enabled = true;
        }

        private void trackBar1_MouseMove(object sender, MouseEventArgs e)
        {
            trackBar1.Enabled = false;
        }

        private void label21_LocationChanged(object sender, EventArgs e)
        {
            RegenerateMarkers();
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void savepreset_Click(object sender, EventArgs e)
        {
            Label lb = new Label();
            lb.Text = "↑";
            splitContainer2.Panel1.Controls.Add(lb);
            ItemList.Add(
                new SiteItem { Duration = (double)presetduration.Value, Position = (double)presetpos.Value },
                lb);
            RegenerateListbox();
            RegenerateMarkers();
        }

        private void delpreset_Click(object sender, EventArgs e)
        {
            if (preposlist.SelectedIndex == 0) return;
            try
            {
                string selected = preposlist.SelectedItem.ToString();
                var data = selected.Split('\t');
                SiteItem dt = new SiteItem();

                foreach (var item in ItemList)
                {
                    if (
                        item.Key.Position == double.Parse(data[0]) &&
                        item.Key.Duration == double.Parse(data[1]))
                    {
                        dt = item.Key;
                        splitContainer2.Panel1.Controls.Remove(item.Value);
                        break;
                    }
                }

                if (ItemList.ContainsKey(dt))
                {
                    ItemList.Remove(dt);
                }

                RegenerateListbox();
                RegenerateMarkers();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manualGoBackward.Enabled = false;
            manualGoForward.Enabled = false;
            manualSpeed.Enabled = false;
            startmov.Enabled = false;
            stopmov.Enabled = true;
            savepreset.Enabled = false;
            delpreset.Enabled = false;
        }

        private void stopmov_Click(object sender, EventArgs e)
        {
            manualGoBackward.Enabled = true;
            manualGoForward.Enabled = true;
            manualSpeed.Enabled = true;
            startmov.Enabled = true;
            stopmov.Enabled = false;
            savepreset.Enabled = true;
            delpreset.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 设置SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
            manualSpeed.Maximum = settings.speedlimit.Value;
            trackBar1.Maximum = (int)(settings.travel.Value * 100);
            presetpos.Maximum = settings.travel.Value;
            TotalLen = (double)settings.travel.Value;
        }

        private void 状态检测CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StatusCheck().ShowDialog();
        }
    }
}
