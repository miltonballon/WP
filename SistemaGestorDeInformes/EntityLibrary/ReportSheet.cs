using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class ReportSheet
    {
        private int id;
        private String type;
        private List<ReportSheetCell> cells;

        public ReportSheet(int id, string type, List<ReportSheetCell> cells)
        {
            this.id = id;
            this.type = type;
            this.cells = cells;
        }

        public ReportSheet(string type, List<ReportSheetCell> cells)
        {
            this.type = type;
            this.cells = cells;
        }
        /*
        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        internal List<ReportSheetCell> Cells { get => cells; set => cells = value; }
         * */
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public List<ReportSheetCell> Cells
        {
            get { return cells; }
            set { cells = value; }
        }
    }
}
