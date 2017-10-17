using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    public class OutputReception
    {
        private Reception reception;
        private string outputDate;
        private int total;
        public OutputReception()
        {
        }

        public OutputReception(Reception reception,string outputDate, int total)
        {
            this.reception = reception;

            this.outputDate = outputDate;
            this.total = total;
        }

        public Reception Reception
        {
            get { return reception; }
            set { reception = value; }
        }
        public string OutputDate
        {
            get { return outputDate; }
            set { outputDate = value; }
        }
        
        public int Total
        {
            get { return total; }
            set { total = value; }
        }

    }
}
