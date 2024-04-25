// Яки не було циклу форич яким чином можна було б його замінити.
// Розкажіть про інтерфейс IEnumerable та IEnumerator

using System.Collections;

List<Employee> employees = new List<Employee>()
{
    new Employee(){ Name = "Alex" },
    new Employee(){ Name = "Vasa" },
    new Employee(){ Name = "Peta" }
};

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.Name);
}

#region Answer
IEnumerable enumerable = employees;
IEnumerator enumerator = enumerable.GetEnumerator();

while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}

#endregion

class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }
}