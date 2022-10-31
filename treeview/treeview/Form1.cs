using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.Nodes.Add("GCUF");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.Nodes[0].Nodes.Add("Physical Sciences");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Computer Science");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Information Technology");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Software Engineerning");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Data Science");

            treeView1.Nodes[0].Nodes.Add("Life Sciences");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Botnay");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Zology");
            treeView1.Nodes[0].Nodes.Add("Zology");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Bio Chemistry");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Pharmacutical Sciences");
        }
    }
}
