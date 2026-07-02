# Custom Serialization in C# (.NET Framework 4.6)

## Description

This project demonstrates **Custom Serialization** and **Deserialization** using the `ISerializable` interface and `BinaryFormatter` in C#.

## Features

- Create an Employee object
- Serialize object to a binary file
- Deserialize object from the binary file
- Display employee details

## Technologies Used

- C#
- .NET Framework 4.6
- BinaryFormatter
- ISerializable

## Project Structure

```
CustomSerializationEg
│── Program.cs
│── Employee.cs
│── App.config
│── CustomSerializationEg.csproj
│── README.md
```

## Sample Output

```
Writing Employee Information
Reading Employee Information
Employee Id : 10
Employee Name : Omkumar
```

## Note

This project uses **BinaryFormatter**, which is obsolete and insecure in modern .NET versions. It is intended only for learning purposes in .NET Framework 4.6.
