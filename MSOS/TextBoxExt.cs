using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateSystem
{
    class TextBoxExt : TextBox
    {
        new public void AppendText(string text)
        {
            if (Text.Length == MaxLength)
                return;
            base.AppendText(Text.Length + text.Length > MaxLength
                                ? text.Substring(0, (MaxLength - Text.Length))
                                : text);
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = !string.IsNullOrEmpty(value) && value.Length > MaxLength
                                ? value.Substring(0, MaxLength)
                                : value;
            }
        }

        // Clearing top X lines with high performance
        public void ClearTopLines(int count)
        {
            if (count <= 0)
                return;
            if (!Multiline)
            {
                Clear();
                return;
            }

            var txt = Text;
            var cursor = 0;
            var brkCount = 0;

            while (brkCount < count)
            {
                int brkLength;
                var ixOf = txt.IndexOfBreak(cursor, out brkLength);
                if (ixOf < 0)
                {
                    Clear();
                    return;
                }
                cursor = ixOf + brkLength;
                brkCount++;
            }
            Text = txt.Substring(cursor);
        }
    }

    public static class StringExt
    {
        public static int IndexOfBreak(this string str, out int length)
        {
            return IndexOfBreak(str, 0, out length);
        }

        public static int IndexOfBreak(this string str, int startIndex, out int length)
        {
            if (string.IsNullOrEmpty(str))
            {
                length = 0;
                return -1;
            }
            var ub = str.Length - 1;
            if (startIndex > ub)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (var i = startIndex; i <= ub; i++)
            {
                int intchr = str[i];
                switch (intchr)
                {
                    case 0x0D:
                        length = i < ub && str[i + 1] == 0x0A ? 2 : 1;
                        return i;
                    case 0x0A:
                        length = 1;
                        return i;
                }
            }
            length = 0;
            return -1;
        }
    }
}