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
        private String tittle;
        private List<ReportSheetCell> cells;

        public ReportSheet(int id, string type, string tittle, List<ReportSheetCell> cells)
        {
            this.id = id;
            this.type = type;
            this.cells = cells;
            this.tittle = tittle;
        }

        public ReportSheet(string type, string tittle, List<ReportSheetCell> cells)
        {
            this.type = type;
            this.cells = cells;
            this.tittle = tittle;
        }

        public ReportSheet(int id, string type, string tittle)
        {
            this.id = id;
            this.type = type;
            this.cells = new List<ReportSheetCell>();
            this.tittle = tittle;
        }

        public ReportSheet(string type, string tittle)
        {
            this.type = type;
            this.cells = new List<ReportSheetCell>();
            this.tittle = tittle;
        }

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
        public string Tittle
        {
            get { return tittle; }
            set { tittle = value; }
        }
        public List<ReportSheetCell> Cells
        {
            get { return cells; }
            set { cells = value; }
        }
    }
}
