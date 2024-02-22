using FHP_DL;
using FHP_ValueObject;
using Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Resources.StaticResources;

namespace FHP_BL
{
    public class DataProcessing
    {
        public Employee employee;
        public List<Employee> employeesList;

        public DataProcessing()
        {
            this.employeesList = FileHandler.GetAllEmployee();

        }
        public DataProcessing(Employee employee)
        {
            this.employee = employee;
            this.employeesList = FileHandler.GetAllEmployee();
        }

        public bool SaveIntoFile(Employee employee)
        {
            if (isValid(employee))
            {
                if (employee.editMode == 1)
                {
                    FileHandler.AddEmployeeInfoIntoFile(employee);

                } // Adding a new Record

                else if (employee.editMode == 2)
                {
                    FileHandler.UpdateEntry(employee);
                } // Updating a present Record

                return true;

            } // if employee has valid details

            return false;
        }
        private bool isValid(Employee employee)
        {
            bool isValid = true;

            //--------------- Validating Empty fields--------------\\
            if (string.IsNullOrEmpty(employee.FirstName) || string.IsNullOrWhiteSpace(employee.FirstName))
            {
                isValid = false;
                employee.ValidationMessage = StaticResources.GetValidationMessageAsByte(ValidationMessage.FirstNameEmpty);
            }

            else if (string.IsNullOrEmpty(employee.CurrentCompany) || string.IsNullOrWhiteSpace(employee.CurrentCompany))
            {
                isValid = false;
                employee.ValidationMessage = StaticResources.GetValidationMessageAsByte(ValidationMessage.CurrentCompanyEmpty);
            }

            else if (employee.Education == 0)
            {
                isValid = false;
                employee.ValidationMessage = StaticResources.GetValidationMessageAsByte(ValidationMessage.QualificationEmpty);
            }

            //-----------Validating fields length-------------\\

            else if (employee.FirstName.Length > 50)
            {
                isValid = false;
                employee.ValidationMessage = StaticResources.GetValidationMessageAsByte(ValidationMessage.FirstNameTooLong);
            }

            else if (employee.LastName.Length > 50)
            {
                isValid = false;
                employee.ValidationMessage = StaticResources.GetValidationMessageAsByte(ValidationMessage.LastNameTooLong);
            }

            else if (employee.MiddleName.Length > 25)
            {
                isValid = false;
                employee.ValidationMessage = StaticResources.GetValidationMessageAsByte(ValidationMessage.MiddleNameTooLong);
            }

            else if (employee.CurrentAddress.Length > 500)
            {
                isValid = false;
                employee.ValidationMessage = StaticResources.GetValidationMessageAsByte(ValidationMessage.CurrentAddressTooLong);

            }

            else if (employee.CurrentCompany.Length > 255)
            {
                isValid = false;
                employee.ValidationMessage = StaticResources.GetValidationMessageAsByte(ValidationMessage.CurrentCompanyTooLong);

            }

            return isValid;


        }
    }
}
