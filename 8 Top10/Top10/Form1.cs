using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top10
{
    public partial class Form1 : Form
    {
        // создать ассоциативный массив для хранения глосов
        Dictionary<string, int> dictTop10 = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // заполнить список всех футболистов
            StreamReader sr = new StreamReader("allPlayers.txt");
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                listBoxAllPlayers.Items.Add(s);
            }
            sr.Close();
            // заполняем ассоциативный массив предыдущими голосами
            sr = new StreamReader("top10.txt");
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split();
                dictTop10[s[0]] = Convert.ToInt32(s[1]);
            }
            sr.Close();
        
        }

        private void buttonVoite_Click(object sender, EventArgs e)
        {
            listBoxBestPlayers.Items.Clear();
            listViewBest.Items.Clear();
            // обновить голоса
            foreach(var q in listBoxAllPlayers.SelectedItems)
            {
                  string str = q as string;
                  if (dictTop10.ContainsKey(str))
                        dictTop10[str]++;
                   else
                        dictTop10[str] = 1;
            }
            //listBoxBestPlayers.Items.Add();
            // вывести результаты голосования
            foreach (var d in dictTop10)
            {
                listBoxBestPlayers.Items.Add(d.Key + " " + d.Value);
                listViewBest.Items.Add(new ListViewItem(new string[]{d.Key, d.Value.ToString()}));
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("top10.txt");
            foreach (var d in dictTop10)
            {
                sw.WriteLine(d.Key + " " + d.Value);
            }
            sw.Close();
        }

        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                if (col == 0)
                {
                    returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                    ((ListViewItem)y).SubItems[col].Text);
                }
                else
                   
                    returnVal = - Convert.ToInt32(((ListViewItem)x).SubItems[col].Text).CompareTo(Convert.ToInt32(((ListViewItem)y).SubItems[col].Text));
                return returnVal;
            }
        }

        private void listViewBest_ColumnClick(object sender, ColumnClickEventArgs e)
        {
           // MessageBox.Show(e.Column.ToString());
            listViewBest.ListViewItemSorter = new ListViewItemComparer(e.Column);
            // Call the sort method to manually sort.
            listViewBest.Sort();
        }
    }
}
