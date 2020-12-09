using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.Entities
{
    public class SCM_Calendar
    {
        public int IdCalendar { set; get; }
        public DateTime Date { set; get; }
        public string Descreiption { set; get; }
        public int WeekNo { set; get; }

    }
}
