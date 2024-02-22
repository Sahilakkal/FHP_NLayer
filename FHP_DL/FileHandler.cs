using FHP_ValueObject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHP_DL
{
    public class FileHandler
    {
        private static string filePath = "C:\\Users\\sahil\\source\\repos\\FHP Application\\FHP Application\\bin\\Debug\\abcc.txt";

        public static void AddEmployeeInfoIntoFile(Employee employee)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Append)))
                {
                    writer.Write(employee.SerialNo);
                    writer.Write(employee.Prefix);
                    writer.Write(employee.FirstName);
                    writer.Write(employee.MiddleName);
                    writer.Write(employee.LastName);
                    writer.Write(employee.Education);
                    writer.Write(employee.JoiningDate.ToBinary());
                    writer.Write(employee.CurrentCompany);
                    writer.Write(employee.CurrentAddress);
                    writer.Write(employee.DOB.ToBinary());

                }
            }
            catch
            {
                throw;
            }


        }

        public static List<Employee> GetAllEmployee()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                if (File.Exists(filePath))
                {


                    using (BinaryReader reader = new BinaryReader(File.OpenRead(filePath)))
                    {
                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            // ----------- getting all the trainee from the file
                            Employee employee = new Employee();
                            employee.SerialNo = reader.ReadInt64();
                            employee.Prefix = reader.ReadString();
                            employee.FirstName = reader.ReadString();
                            employee.MiddleName = reader.ReadString();
                            employee.LastName = reader.ReadString();
                            employee.Education = reader.ReadByte();
                            employee.JoiningDate = DateTime.FromBinary(reader.ReadInt64());
                            employee.CurrentCompany = reader.ReadString();
                            employee.CurrentAddress = reader.ReadString();
                            employee.DOB = DateTime.FromBinary(reader.ReadInt64());

                            employees.Add(employee);
                        }
                    }
                }
                return employees;
            }
            catch
            {
                throw;
            }

        }
        public static void UpdateEntry(Employee employee)
        {
            List<Employee> employees = GetAllEmployee();
            Employee presentEmp = employees.Where(t => t.SerialNo == employee.SerialNo).FirstOrDefault();
            if (presentEmp != null)
            {
                presentEmp.Prefix = employee.Prefix;
                presentEmp.FirstName = employee.FirstName;
                presentEmp.MiddleName = employee.MiddleName;
                presentEmp.LastName = employee.LastName;
                presentEmp.Education = employee.Education;
                presentEmp.JoiningDate = employee.JoiningDate;
                presentEmp.CurrentCompany = employee.CurrentCompany;
                presentEmp.CurrentAddress = employee.CurrentAddress;
                presentEmp.DOB = employee.DOB;
            }
            File.Delete(filePath);
            foreach (Employee emp in employees)
            {
                AddEmployeeInfoIntoFile(emp);
            }
        }


    }
}
