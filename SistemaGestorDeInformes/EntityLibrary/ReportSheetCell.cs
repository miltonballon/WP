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
        }

        public ReportSheetCell(int row, int column, string content)
        {
            this.row = row;
            this.column = column;
            this.content = content;
        }
        public ReportSheetCell(int row, int column, string content,String styles)
        {
            this.row = row;
            this.column = column;
            this.content = content;
            this.styles = styles;
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

        public string Style
        {
            get { return content; }
            set { content = value; }
        }
    }
}
