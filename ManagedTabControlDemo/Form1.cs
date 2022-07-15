using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTC;
namespace ManagedTabControlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (string tt in Enum.GetNames(typeof(MTCDrawStyle)))
            {
                comboBox1.Items.Add(tt);
            } 
            comboBox1.SelectedItem = "Normal";
        }
        private int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            MTCTabPage page = new MTCTabPage("Test tab page " + index, "");
            page.DrawType = MTCTabPageDrawType.TextAndImage;
            page.ImageIndex = index % 3;
            index++;
            managedTabControl1.TabPages.Add(page);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MTCTabPage page = new MTCTabPage("Test tab page with TrackBar control " + index, "");
            page.Panel = new Panel();
            TrackBar bar = new TrackBar();
            page.Panel.Controls.Add(bar);
            bar.Dock = DockStyle.Top;
            index++;
            managedTabControl1.TabPages.Add(page);
        }

        private void managedTabControl2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(MTCTabPage)))
            {
               // IMTCTabPage pg = new MTCTabPage(((MTCTabPage)e.Data.GetData(typeof(MTCTabPage))).Text,
               //     ((MTCTabPage)e.Data.GetData(typeof(MTCTabPage))).ID);
                //managedTabControl2.TabPages.Add(pg);
            }
        }

        private void managedTabControl2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void managedTabControl2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MTCTabPage page = new MTCTabPage("Test tab page with RichTextBox control " + index, "");
            page.Panel = new Panel();
            RichTextBox box = new RichTextBox();
            page.Panel.Controls.Add(box);
            box.Dock = DockStyle.Fill;
            index++;
            managedTabControl1.TabPages.Add(page);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            managedTabControl1.TabPages.Clear();
            index = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            managedTabControl1.CloseBoxOnEachPageVisible = checkBox2.Checked;
            managedTabControl1.Invalidate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            managedTabControl1.CloseBoxAlwaysVisible = checkBox1.Checked;
            managedTabControl1.Invalidate();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            managedTabControl1.DrawTabPageHighlight = checkBox3.Checked;
            managedTabControl1.Invalidate();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            managedTabControl1.ShowTabPageToolTip = checkBox4.Checked;
            managedTabControl1.Invalidate();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            managedTabControl1.ShowTabPageToolTipAlways = checkBox5.Checked;
            managedTabControl1.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            managedTabControl1.DrawStyle = (MTCDrawStyle)Enum.Parse(typeof(MTCDrawStyle), comboBox1.SelectedItem.ToString());
            managedTabControl1.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog dial = new ColorDialog();
            dial.Color = managedTabControl1.TabPageColor;
            if (dial.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                managedTabControl1.TabPageColor = button5.BackColor = dial.Color;
                managedTabControl1.Invalidate();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog dial = new ColorDialog();
            dial.Color = managedTabControl1.TabPageHighlightedColor;
            if (dial.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                managedTabControl1.TabPageHighlightedColor = button6.BackColor = dial.Color;
                managedTabControl1.Invalidate();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog dial = new ColorDialog();
            dial.Color = managedTabControl1.TabPageSelectedColor;
            if (dial.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                managedTabControl1.TabPageSelectedColor = button7.BackColor = dial.Color;
                managedTabControl1.Invalidate();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ColorDialog dial = new ColorDialog();
            dial.Color = managedTabControl1.TabPageSplitColor;
            if (dial.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                managedTabControl1.TabPageSplitColor = button8.BackColor = dial.Color;
                managedTabControl1.Invalidate();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_About frm = new Form_About();
            frm.ShowDialog(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ColorDialog dial = new ColorDialog();
            dial.Color = managedTabControl1.ForeColor;
            if (dial.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                managedTabControl1.ForeColor = button9.BackColor = dial.Color;
                managedTabControl1.Invalidate();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            managedTabControl1.AutoSelectAddedTabPageAfterAddingIt = checkBox6.Checked;
            managedTabControl1.Invalidate();
        }
    }
}
