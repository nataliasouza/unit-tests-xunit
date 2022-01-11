using Demo.Enums;
using System;
using System.Collections.Generic;

namespace Demo
{
    public class Employee : People
    {
        public double Salary { get; private set; }
        public ProfessionalLevel ProfessionalLevel { get; private set; }
        public IList<string> Skills { get; set; }

        public Employee(string name, double salary)
        {
            Name = string.IsNullOrEmpty(name) ? "NomeDaPessoa" : name;
            SetSalary(salary);
            SetSkills();
        }      

        public void SetSalary(double salary)
        {
            if(salary < 1000) throw new Exception("Salário inferior ao permitido");

            Salary = salary;
            if (salary <= 2000) ProfessionalLevel = ProfessionalLevel.Estagiario;
            else if (salary > 2200 && salary <= 5000) ProfessionalLevel = ProfessionalLevel.Junior;
            else if (salary > 5200 && salary <= 8000) ProfessionalLevel = ProfessionalLevel.Pleno;
            else if (salary >= 8200) ProfessionalLevel = ProfessionalLevel.Senior;
        }

        private void SetSkills()
        {
            var skillsBasics = new List<string>()
            {
                "Lógica de Programação",
                "Programação Orientada a Objetos"
            };

            Skills = skillsBasics;

            switch (ProfessionalLevel)
            {
                case ProfessionalLevel.Estagiario:
                    Skills.Add("Lógica de Programação");
                    Skills.Add("Básico C#");
                    break;

                case ProfessionalLevel.Junior:
                    Skills.Add("Lógica de Programação");
                    Skills.Add("C# Completo");
                    Skills.Add("Asp.Net Core");
                    Skills.Add("SQL e NoSQL");
                    Skills.Add("GIT");
                    Skills.Add("Testes Unitários");
                    break;

                case ProfessionalLevel.Pleno:
                    Skills.Add("Lógica de Programação");
                    Skills.Add("C# Completo");
                    Skills.Add("Asp.Net Core");
                    Skills.Add("SQL e NoSQL");
                    Skills.Add("GIT");
                    Skills.Add("Testes Unitários");
                    Skills.Add("Testes Integrados");
                    Skills.Add("Microsservices");
                    break;

                case ProfessionalLevel.Senior:
                    Skills.Add("Lógica de Programação");
                    Skills.Add("C# Completo");
                    Skills.Add("Asp.Net Core");
                    Skills.Add("SQL e NoSQL");
                    Skills.Add("GIT");
                    Skills.Add("Testes Unitários");
                    Skills.Add("Testes Integrados");
                    Skills.Add("Testes Automatizados");
                    Skills.Add("Microsservices");
                    Skills.Add("AWS");
                    break;
            }
        }
    }
}
