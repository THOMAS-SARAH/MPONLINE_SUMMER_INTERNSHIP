using System;
using System.Runtime.Serialization;

namespace CustomSerializationEg
{
    [Serializable]
    public class Employee : ISerializable
    {
        public int EmpId;
        public string EmpName;

        public int nSal;
        public int gSal;

        public Employee()
        {
            EmpId = 0;
            EmpName = null;
        }

        public Employee(SerializationInfo info, StreamingContext context)
        {
            EmpId = (int)info.GetValue("EmployeeId", typeof(int));
            EmpName = (string)info.GetValue("EmployeeName", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("EmployeeId", EmpId);
            info.AddValue("EmployeeName", EmpName);
        }
    }
}
