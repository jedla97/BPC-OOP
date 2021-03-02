using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv04
{
    public class StringStatistics
    {
        public StringStatistics(string text)
        {
            this.Text = text;
        }
        public string Text { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
