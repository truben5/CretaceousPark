using CretaceousPark.Dinosaurs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Employees
{
    public class Employee
    {
        int id;
        int securityLevel;
        Dinosaur favoriteDino;
        int timesAttacked;
        

        public Employee(int employeeId,int employeeSecurityLevel, Dinosaur employeeFavDino)
        {
            id = employeeId;
            securityLevel = employeeSecurityLevel;
            favoriteDino = employeeFavDino;
            timesAttacked = 0;
        }
    }
}
