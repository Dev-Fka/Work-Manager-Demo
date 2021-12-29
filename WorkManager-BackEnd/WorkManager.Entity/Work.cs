using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkManager.Entity
{
    public class Work
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isMonthly { get; set; }
        public bool isWeekly { get; set; }
        public bool isDaily { get; set; }
        public bool isSucceeded { get; set; }
        [Column(TypeName = "date")]
        public DateTime addedTime { get; set; }

        public Work()
        {
            this.addedTime = DateTime.Now;
        }

    }
}