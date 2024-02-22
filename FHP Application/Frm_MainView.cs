using FHP_Application.Properties;
using FHP_BL;
using FHP_DL;
using FHP_ValueObject;
using Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHP_Application
{

    public partial class Frm_MainView : Form
    {
        DataGridViewRow selectedRow;                            //--------Represents the selected Row
        Employee employee;                                     //---------Represents an employee data ---[VO]----
        DataProcessing dataProcess;                           //--------- Object of  Business Layer where my data is going to be process ---[BL]---
        List<Employee> employees;                            //---------- List of Employees(Value Object) which will hold data for multiple employees

        public Frm_MainView()
        {
            InitializeComponent();


            dataProcess = new DataProcessing();                 //-------Creating object of dataProcessing(Business Layer) it will read if there is any data in file     
            this.employees = dataProcess.employeesList;         //-------- Getting employees list
            if (employees != null && employees.Count>0)
            {
                RenderEmployees(employees);
            }
            lbl_Status.Text = $"Total Records -> {employees.Count}";


        }
        private void menu_New_Click(object sender, EventArgs e)
        {
            employee = new Employee();       //-----Creating instance of new employee
            if (selectedRow != null)
            {
                int lastSecondRowIndex = dgv_EmployeeData.Rows.Count - 2;

                if (lastSecondRowIndex < 0)
                {
                    employee.SerialNo = 1;

                } // Means there are no records

                else
                {
                    int serialNoColumnIndex = dgv_EmployeeData.Columns["SerialNo"].Index;
                    if (serialNoColumnIndex != -1)
                    {
                        object serialNoValue = dgv_EmployeeData.Rows[lastSecondRowIndex].Cells[serialNoColumnIndex].Value;

                        if (serialNoValue != null)
                        {
                            
                            int serialNo = Convert.ToInt32(serialNoValue);
                            employee.SerialNo = serialNo + 1;
                            Console.WriteLine($"SerialNo of last second row: {serialNo}");
                        }

                    }
                } // means there are some records


                //--------------Passing control to EditAdd Model form For adding employee ------------------\\

                Frm_EditAdd editAddModel = new Frm_EditAdd(employee);
                editAddModel.ShowDialog();


                //-------------Refreshing the Grid View After Add---------------\\

                DataProcessing passingEmployee = new DataProcessing(employee);   // Passing object to business layer which will  pass object for record to add in file 
                employees = passingEmployee.employeesList;                       // Getting list of employees
                RenderEmployees(employees);                                      // rendering employees in DGV
                lbl_Status.Text = $"Total Records -> {employees.Count}";
            }
        }

        private void menu_Update_Click(object sender, EventArgs e)
        {
            
            int employeeCountInList = selectedRow.Index;                            // index of that row [starting from 0]
            Employee empDataToBeUpdate = employees[employeeCountInList];
            empDataToBeUpdate.editMode = 2;                                          // Setting the edit mode to 2 [Update]

            //--------------Passing control to EditAdd Model form For adding employee ------------------\\
            Frm_EditAdd editAddModel = new Frm_EditAdd(empDataToBeUpdate);
            editAddModel.ShowDialog();

            //-------------Refreshing the Grid View After Add---------------\\

            DataProcessing passingEmployee = new DataProcessing(employee);   // Passing object to business layer which will  pass object for record to Update in file 
            employees = passingEmployee.employeesList;                       // Getting list of employees
            RenderEmployees(employees);                                      // rendering employees in DGV
            lbl_Status.Text = $"Total Records -> {employees.Count}";

        }

        

        private void menu_Delete_Click(object sender, EventArgs e)
        {
            int employeeCountInList = selectedRow.Index;                            // index of that row [starting from 0]
            Employee empDataToBeUpdate = employees[employeeCountInList];
            empDataToBeUpdate.isDeleted = true;                                     // Setting the isDeleted Property=true




        }

        private void menu_View_Click(object sender, EventArgs e)
        {

        }
        private void dgv_EmployeeData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = dgv_EmployeeData.Rows[e.RowIndex]; // here selectRow is intialized with the row that user selects

            if (e.RowIndex == dgv_EmployeeData.RowCount - 1)
            {
                menu_New.Enabled = true;

                menu_View.Enabled = false;
                menu_Update.Enabled = false;
                menu_Delete.Enabled = false;
            } // this checks that whether this is the last row of employee table or not

            else if(e.RowIndex!=-1)
            {
                menu_View.Enabled = true;
                menu_Update.Enabled = true;
                menu_Delete.Enabled = true;

            }


           
        }

        public void RenderEmployees(List<Employee> employees)
        {
            dgv_EmployeeData.Rows.Clear();

            for (int employeeNumber = 0; employeeNumber < employees.Count; employeeNumber++)
            {
                dgv_EmployeeData.Rows.Add();
                dgv_EmployeeData.Rows[employeeNumber].Cells[0].Value = employees[employeeNumber].SerialNo;
                dgv_EmployeeData.Rows[employeeNumber].Cells[1].Value = employees[employeeNumber].Prefix;
                dgv_EmployeeData.Rows[employeeNumber].Cells[2].Value = employees[employeeNumber].FirstName;
                dgv_EmployeeData.Rows[employeeNumber].Cells[3].Value = employees[employeeNumber].MiddleName;
                dgv_EmployeeData.Rows[employeeNumber].Cells[4].Value = employees[employeeNumber].LastName;
                dgv_EmployeeData.Rows[employeeNumber].Cells[5].Value = StaticResources.GetQualificationDescriptionAtIndex(Convert.ToByte(employees[employeeNumber].Education - 1));
                dgv_EmployeeData.Rows[employeeNumber].Cells[6].Value = employees[employeeNumber].JoiningDate.ToString("dd-MM-yyyy");
                dgv_EmployeeData.Rows[employeeNumber].Cells[7].Value = employees[employeeNumber].CurrentCompany;
                dgv_EmployeeData.Rows[employeeNumber].Cells[8].Value = employees[employeeNumber].CurrentAddress;
                dgv_EmployeeData.Rows[employeeNumber].Cells[9].Value = employees[employeeNumber].DOB.ToString("dd-MM-yyyy");
            }

        }

        private void dgv_EmployeeData_SelectionChanged(object sender, EventArgs e)
        {
            bool anyCellSelected = dgv_EmployeeData.SelectedCells.Count > 0 &&
                         dgv_EmployeeData.SelectedCells[0].ColumnIndex != -1;

            if (dgv_EmployeeData.SelectedRows.Count > 1)
            {
                menu_Delete.Enabled = true;

            } // if user selects multiple row 
            else
            {
                menu_Delete.Enabled = false;
                menu_New.Enabled = false;
                menu_View.Enabled = false;
                menu_Update.Enabled = false;

            }  
        }
    }

}
