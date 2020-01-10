using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Word_List
{
    public partial class Form1 : Form
    {
        List<String[]> word = new List<String[]>();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Personal Dictionary";
            wordList.View = View.Details;
            wordList.FullRowSelect = true;
            wordList.Columns.Add("Word", 100);
            wordList.Columns.Add("Meaning", 500);
            loadWord();
            updatewordList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void writeDB()
        {
            string fullPath = @"D:\WordDB.db";
            String[] finalTextFile = new String[word.Count];
            int i = 0;
            foreach (String[] str in word)
            {
                finalTextFile[i] = str[0] + ";" + str[1];
                i++;
            }
            File.WriteAllLines(fullPath, finalTextFile);
        }

        private void loadWord()
        {
            String location = @"D:\WordDB.db";
            if (File.Exists(location))
            {
                String[] lines = File.ReadAllLines(location);
                foreach (String strWord in lines)
                {
                    String[] wrd = new String[2];
                    String t = "";
                    int arrno = 0;
                    for (int i = 0; i < strWord.Length; i++)
                    {
                        char ch = strWord[i];
                        if (ch == ';')
                        {
                            wrd[arrno] = t;
                            t = "";
                            arrno++;
                        }
                        else
                        {
                            t = t + ch;
                        }
                    }
                    wrd[arrno] = t;
                    word.Add(wrd);
                }
            }
            else
            {
                MessageBox.Show("No Word DataBase Found at \n" + location, "Database Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updatewordList()
        {
            clearColumn();
            for (int i = 0; i < word.Count; i++)
            {
                String[] row = new String[2];
                row = word[i];
                ListViewItem item = new ListViewItem(row);
                wordList.Items.Add(item);
            }
        }

        private void clearColumn()
        {
            wordList.Items.Clear();
        }

        private void sort()
        {
            for (int i = 0; i < word.Count-1; i++)
            {
                for (int j = i; j < word.Count; j++)
                {
                    String[] arrs1 = new String[2];
                    String[] arrs2 = new String[2];
                    arrs1 = word[i];
                    arrs2 = word[j];
                    if (arrs1[0].CompareTo(arrs2[0]) > 0)
                    {
                        word[i] = arrs2;
                        word[j] = arrs1;
                    }
                }
            }
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            if (addWordTB.Text != "" && addMeaningTB.Text != "")
            {
                String[] row = { addWordTB.Text, addMeaningTB.Text };
                word.Add(row);
                sort();
                writeDB();
                updatewordList();
                addWordTB.Text = "";
                addMeaningTB.Text = "";
            }
            else if (addWordTB.Text == "" && addMeaningTB.Text != "")
            {
                MessageBox.Show("Cannot Add the Word Meaning as \nThe Word Box is Empty", "Cannot add the Word", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addMeaningTB.Text == "" && addWordTB.Text != "")
            {
                MessageBox.Show("Cannot Add the Word Meaning as \nThe Meaning Box is Empty", "Cannot add the Word", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cannot Add the Word Meaning as \nThe Word and Meaning Boxes are Empty", "Cannot add the Word", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addWordTB_TextChanged(object sender, EventArgs e)
        {
            if (addWordTB.Text != "")
            {
                wordDisplay.Text = addWordTB.Text;
            }
            else
            {
                wordDisplay.Text="---";
            }
        }

        private void addMeaningTB_TextChanged(object sender, EventArgs e)
        {

        }
        private int search(String s)
        {
            int no = -1;
            for (int i = 0; i < word.Count; i++)
            {
                String[] wd = new String[3];
                wd = word[i];
                if (s == wd[0].ToLower())
                {
                    no = i;
                    break;
                }
            }
            return no;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int i = search(searchWordTB.Text.ToLower());
            if (i == -1)
            {
                MessageBox.Show("\""+searchWordTB.Text+"\" not Found in the Word List", "Search result", MessageBoxButtons.OK);
            }
            else
            {
                String[] arr = new String[3];
                arr=word[i];
                MessageBox.Show("Word Found at position number " + i+"\n\""+arr[0]+"\" Means "+arr[1], "Search result", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
