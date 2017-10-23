using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    class ReportSheetCell
    {
        private int id;
        private int row;
        private int column;
        private String content;

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
        /*
        public int Id { get => id; set => id = value; }
        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }
        public string Content { get => content; set => content = value; }
         * */
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
    }
}
