using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv04
{
    public class StringStatistics
    {
        public string Text { get; set; }

        public StringStatistics(string text)
        {
            this.Text = text;
        }

        public int NumberOfWords()
        {
            char[] delimiterChars = { ' ', '\n' };
            int words = Text.Split(delimiterChars).Length;
            return words;
        }

        public int NumberOfRow()
        {
            int row = Text.Split('\n').Length;
            return row;
        }

        public int NumberOfSentences()
        {
            char[] delimiterChars = { '.', '?', '!' };
            char[] delimiterCharsReplace = { '\n', ' ', ',' };
            string text = Text.Replace("\n", "").Replace(" ", "");
            string[] row = text.Split(delimiterChars);
            int counter = 0;
            for (int i = 0; i < row.Length-2; i++)
            {
                if(i==0 && Char.IsUpper(row[i][0]))
                {
                    counter++;
                }
                if (Char.IsUpper(row[i+1][0]))
                {
                    counter++;
                }
            }
            return counter;
        }

        public override string ToString()
        {
            return this.Text;
        }

        //pocet slov, pocet radku, pocet vet, pole nejdelsich slov, pole nejkratsich slov,
        //pole nejcetnejsich slov, setridene pole slov dle abecedy, 
        
    }
}
