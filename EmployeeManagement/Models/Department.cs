using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models{

public class Department{
    public int Id { get;set;}
    [Required(ErrorMessage="Department Name is required")]
    public string Name { get;set;}
    public int Code { get; set;}
    
    [Required(ErrorMessage="Branch is required")]
    public string Branch { get; set;}
    
         public static List<Department> GetDepartment()
         {
              Department department1 = new Department()

            {
                Id =1,
                Name = "Abc",
                Code =5464, 
                Branch = "Ktm",

            };
            Department department2 = new Department()
            {
                Id = 2,
                Name = "Eda",
                Code =5464, 
                Branch = "Ktm",


            };
            List<Department> departments =new List<Department>(){department1,department2};
            return (departments);
}
}
}
