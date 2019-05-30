using System;
using EnterpriseComposition.Entities.Enums;

namespace EnterpriseComposition.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }


    }
}
