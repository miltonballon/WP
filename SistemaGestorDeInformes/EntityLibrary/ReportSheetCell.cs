using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class ReportSheetCell
    {
        private int id;
        private int row;
        private int column;
        private String content;
        private String styles;

        public ReportSheetCell(int id, int row, int column, string content)
        {
            this.id = id;
            this.row = row;
            this.column = column;
            this.content = content;
            this.styles = "";
            Broker();
        }

        public ReportSheetCell(int id, int row, int column, string content, string styles)
        {
            this.id = id;
            this.row = row;
            this.column = column;
            this.content = content;
            this.styles = styles;
        }

        public ReportSheetCell(int row, int column, string content)
        {
            this.row = row;
            this.column = column;
            this.content = content;
            this.styles = "";
            Broker();
        }
         public ReportSheetCell(int row, int column, string content,String styles)
         {
            this.row = row;
            this.column = column;
            this.content = content;
            this.styles = styles;
         }

        private void Broker()
        {
            String[] token = content.Split('\n');
            for (int i = 1; i < token.Length; i++)
            {
                AddGeneric(token[i]);
            }
            content = token[0];
        }

        private void AddGeneric(String input)
        {
            if (styles.Equals(""))
            {
                styles = input;
            }
            else
            {
                styles += "," + input;
            }
        }
         public int Id
         {
            get { return id; }
            set { id = value; }
         }
         public int Row
         {
            get { return row; }
            set { row = value; }
         }

         public int Column
         {
            get { return column; }
            set { column = value; }
         }
         public string Content
         {
             get { return content; }
             set { content = value; }
         }

        public string Styles
        {
            get { return styles; }
            set { styles = value; }
        }

        public void AddBold()
        {
            if (styles.Equals(""))
            {
                styles = "b";
            }
            else
            {
                styles+= ",b";
            }
        }
        public void WidthForCell(int width)
        {
            if (styles.Equals(""))
            {
                styles = "w"+width;
            }
            else
            {
                styles += ",w" + width;
            }
        }
        public void HeigthForCell(int heigth)
        {
            if (styles.Equals(""))
            {
                styles = "h" + heigth;
            }
            else
            {
                styles += ",h" + heigth;
            }
        }
        public void CenterText()
        {
            if (styles.Equals(""))
            {
                styles = "c";
            }
            else
            {
                styles += ",c";
            }
        }
        public void mergeHorizontally(int number)
        {
            if (styles.Equals(""))
            {
                styles = "m" + number;
            }
            else
            {
                styles += ",m" + number;
            }
        }
        public void mergeVertically(int number)
        {
            if (styles.Equals(""))
            {
                styles = "v" + number;

            }
            else
            {
                styles += ",v" + number;
            }
        }

        public void TopBorder()
        {
            if (styles.Equals(""))
            {
                styles = "t";

            }
            else
            {
                styles += ",t";
            }
        }

        public void BottomBorder()
        {
            if (styles.Equals(""))
            {
                styles = "d";

            }
            else
            {
                styles += ",d";
            }
        }

        public void LeftBorder()
        {
            if (styles.Equals(""))
            {
                styles = "l";

            }
            else
            {
                styles += ",l";
            }
        }

        public void RightBorder()
        {
            if (styles.Equals(""))
            {
                styles = "r";

            }
            else
            {
                styles += ",r";
            }
        }

        public void FullBordered()
        {
            if (styles.Equals(""))
            {
                styles = "f";

            }
            else
            {
                styles += ",f";
            }
        }

        public void TopBorderDot()
        {
            if (styles.Equals(""))
            {
                styles = "q";

            }
            else
            {
                styles += ",q";
            }
        }

        public void BottomBorderDot()
        {
            if (styles.Equals(""))
            {
                styles = "o";

            }
            else
            {
                styles += ",o";
            }
        }

        public void LeftBorderDot()
        {
            if (styles.Equals(""))
            {
                styles = "h";

            }
            else
            {
                styles += ",h";
            }
        }

        public void RightBorderDot()
        {
            if (styles.Equals(""))
            {
                styles = "k";

            }
            else
            {
                styles += ",k";
            }
        }

        public void FullBorderedDot()
        {
            if (styles.Equals(""))
            {
                styles = "y";

            }
            else
            {
                styles += ",y";
            }
        }
    }
}
