using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models {
    public class Activity
        {
        public int Id { get;set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxPoints set; }
        public int MinPointsForGrade { get; set; }
        public int MinPointsFotrSignature { get; set; }
        public override string ToString() {
            return Name;
        }
    }
}
