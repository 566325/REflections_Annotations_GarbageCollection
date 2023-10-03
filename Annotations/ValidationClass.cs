using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Annotations
{
    public class ValidationClass
    {
        public static void Test()
        {
            Employee employee = new Employee();
            employee.Name = "Sireesha";
            employee.Age = 19;
            employee.Phone = " 63764899754";
            employee.Email = "Siri@gmail.com";

            ValidationContext contect = new ValidationContext(employee, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool vaild =Validator.TryValidateObject(employee, contect,validationResults,true);

            if (!vaild)
            {
                foreach(ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine(validationResult);
                }
            }
            else
            {
                Console.WriteLine("Name :"+ employee.Name +" Age:" + employee.Age +" Phone: " + employee.Phone +  " Email Address: "+ employee.Email);
            }


        }
    }
}
