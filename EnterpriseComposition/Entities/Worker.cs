﻿using System;
using EnterpriseComposition.Entities.Enums;
using System.Collections.Generic;

namespace EnterpriseComposition.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        //propriedade que representa que o trabalhador tem varios contratos

        public Worker( ) { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            //não inclui contracts no construtor pois ele tem varias entradas, por isso não recebe no inicio
        }

        public void AddContract(HourContract contract){
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract){
            Contracts.Remove(contract);
        }

        public double Income(int year, int month){
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts){
                if(contract.Date.Year == year && contract.Date.Month == month){
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
