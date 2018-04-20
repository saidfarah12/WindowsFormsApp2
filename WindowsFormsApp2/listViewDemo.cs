using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
            private void form1_Load(object sender, EventArgs e)
            {
                listView.View = View.Details;
                listView.Width = 550;

                ListViewItem item1 = new ListViewItem("joe");

                item1.SubItems.Add("555-555-5678");
                item1.SubItems.Add("a@b.com");
                item1.SubItems.Add("programming");

                ListViewItem item2 = new ListViewItem("Jill");
                item2.SubItems.Add("555-555-5678");
                item2.SubItems.Add("a@b.com");
                item2.SubItems.Add("programming");


                ListViewItem item3 = new ListViewItem("Jill");
                item3.SubItems.Add("555-555-5678");
                item3.SubItems.Add("a@b.com");
                item3.SubItems.Add("programming");
                // Create columns for the items and subitems.
                // width of -2 indicates auto-size.
                listView.Columns.Add("name ", -2, HorizontalAlignment.Left);
                listView.Columns.Add("phone ", -2, HorizontalAlignment.Left);
                listView.Columns.Add("email ", -2, HorizontalAlignment.Left);
                listView.Columns.Add("program ", -2, HorizontalAlignment.Left);

                listView.Items.AddRange(new ListViewItem[] { item1, item2, item3, });
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            listView.View = View.Details;
            listView.Width = 550;

            ListViewItem item1 = new ListViewItem("joe");

            item1.SubItems.Add("555-555-5678");
            item1.SubItems.Add("a@b.com");
            item1.SubItems.Add("programming");

            ListViewItem item2 = new ListViewItem("Jill");
            item2.SubItems.Add("555-555-5678");
            item2.SubItems.Add("a@b.com");
            item2.SubItems.Add("programming");


            ListViewItem item3 = new ListViewItem("Jill");
            item3.SubItems.Add("555-555-5678");
            item3.SubItems.Add("a@b.com");
            item3.SubItems.Add("programming");
            // Create columns for the items and subitems.
            // width of -2 indicates auto-size.
            listView.Columns.Add("name ", -2, HorizontalAlignment.Left);
            listView.Columns.Add("phone ", -2, HorizontalAlignment.Left);
            listView.Columns.Add("email ", -2, HorizontalAlignment.Left);
            listView.Columns.Add("program ", -2, HorizontalAlignment.Left);

            listView.Items.AddRange(new ListViewItem[] { item1, item2, item3, });
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

       private void printbutton_Click(object sender, EventArgs e)
            {
            MessageBox.Show("in click");
                if (listView.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView.SelectedItems[0];
                    outputlabel.Text = item.SubItems[0].Text;
                    outputlabel.Text += "/n" + item.SubItems[1].Text;
                    outputlabel.Text += "/n" + item.SubItems[2].Text;
                }
                else
                {
                    outputlabel.Text = string.Empty;
                }
            }

        private void Quitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printbutton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("in click");
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];
                outputlabel.Text = item.SubItems[0].Text;
                outputlabel.Text += "/n" + item.SubItems[1].Text;
                outputlabel.Text += "/n" + item.SubItems[2].Text;
            }
            else
            {
                outputlabel.Text = string.Empty;
            }

        }
    }
    }
    

