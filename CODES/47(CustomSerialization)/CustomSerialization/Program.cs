using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CustomSerializationEg
{
    class ObjSerial
    {
        static void Main(string[] args)
        {
            // Create Employee object
            Employee emp = new Employee();
            emp.EmpId = 10;
            emp.EmpName = "Omkumar";

            Stream stream = File.Open("EmployeeInfo.osl", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            Console.WriteLine("Writing Employee Information");

            formatter.Serialize(stream, emp);

            stream.Close();

            // Deserialization

            emp = null;

            stream = File.Open("EmployeeInfo.osl", FileMode.Open);

            formatter = new BinaryFormatter();

            Console.WriteLine("Reading Employee Information");

            emp = (Employee)formatter.Deserialize(stream);

            stream.Close();

            Console.WriteLine("Employee Id : " + emp.EmpId);
            Console.WriteLine("Employee Name : " + emp.EmpName);

            Console.ReadKey();
        }
    }
}
