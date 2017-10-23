using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    class Report
    {
        private int id;
        private String name;
        private DateTime date;
        private List<ReportSheet> sheets;

        public Report(int id, string name, DateTime date, List<ReportSheet> sheets)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.sheets = sheets;
        }

        public Report(string name, DateTime date, List<ReportSheet> sheets)
        {
            this.name = name;
            this.date = date;
            this.sheets = sheets;
        }
/*
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        internal List<ReportSheet> Sheets { get => sheets; set => sheets = value; }
 * 
 * */
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        internal List<ReportSheet> Sheets
        {
            get { return sheets; }
            set { sheets = value; }
        }

    }
}
