// 1 Яким чином можна вибрати всіх студентів віком страрше за 20 років
// 2 Якби не було методу LINQ - Where, яким чином ми могли б його реаліувати.
// 3 Що таке метод розришерння, та в якому классі він має розміщуватися

List<Employee> employees = new List<Employee>()
{
    new Employee(){ Id = 1, Name = "Alex", Age = 20 },
    new Employee(){ Id = 2, Name = "Vasa", Age = 18 },
    new Employee(){ Id = 3, Name = "Peta", Age = 22 }
};

#region Answer

var res = employees.Where(emp => emp.Age > 20);
var myRes = employees.MyWhere(emp => emp.Age > 20);

static class MyEnumerable
{
    public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        foreach (var item in source)
        {
            if (predicate.Invoke(item))
            {
                yield return item;
            }
        }
    }
}

#endregion

class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Age { get; set; }
}