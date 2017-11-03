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
                styles += ","+input;
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
                styles += ",w"+width;
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
                styles = "h" + number;
            }
            else
            {
                styles += ",h" + number;
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
    }
}
