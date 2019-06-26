using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsABGN.UI.User_Controls
{
    public partial class WordCloudControl : UserControl
    {
        public WordCloudControl()
        {
            InitializeComponent();
        }

        public void FillCloud(string words)
        {
            ////var wordList = words.Trim().Substring(1, words.Length - 4).Replace("(", "").Split(')').ToList();
            ////wordList.Reverse();

            //var cloud = ;
            //for(int i=0; i < wordList.Count; i++)
            //{
            //    if (wordList[i] == "]")
            //        continue;
            //    if(wordList[i].ElementAt(0) == ',')
            //    {
            //        wordList[i] = wordList[i].Substring(1);
            //    }
            //    wordList[i] = wordList[i].Replace(",", " ");
            //    cloud += wordList[i] + "\r\n";
            //}

            var wordListTmp = words.Trim().Substring(1, words.Length - 4).Replace("(", "").Replace("), ", "|").Replace(")","").Split('|');

            foreach (var word in wordListTmp.Reverse())
            {
                var NewWord = word.Replace(", ", "      ");
                Label wordLabel = new Label();
                wordLabel.Width = 200;
                //wordLabel.폰트
                wordLabel.Text = NewWord;
                flpWordCloudList.Controls.Add(wordLabel);
            }

            //For Test
            //MessageBox.Show(words.Trim().Substring(1, words.Length - 4).Replace("(", "").Replace("), ", "|"));
        }

        public void EmptyWords()
        {
            flpWordCloudList.Controls.Clear();
        }
    }
}
