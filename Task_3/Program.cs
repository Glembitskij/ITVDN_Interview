// 1. Які парадими ООП ви знаете ?
// 2. Що таке наслідування ?
// 3. Що таке абстракція ?
// 4. Чи можна було б в данному випадку класс Employee зробити абстрактим, чи були б в цьому переваги?
// 5  Чи може абстрактний класс містити конструктор классу?, навіщо він потрібний?
// 5. Що таке поліморфізм, модифікатори virtual, ovveride
// 7. Що буде виведено в результаті роботи данного коду?

Manager manager = new Manager() { Name = "Peta", PayForHour = 20 };
Developer developer = new Developer() { Name = "Vova", PayForHour = 30 };

// manager 20*40+100 = 900
// developer 30*40=1200
// total 900 + 1200 = 2100 
int budget = CalculateBudget(manager, developer);
Console.WriteLine(budget);

static int CalculateBudget(params Employee[] employees)
{
    int workingHour = 40;
    int res = 0;

    foreach (Employee employee in employees)
    {
        res += employee.CaclulateSalary(workingHour);
    }

    return res;
}

class Employee
{
    public string Name { get; set; }

    public int PayForHour { get; set; }

    public int CaclulateSalary(int Hour)
    {
        return PayForHour * Hour;
    }
}

class Manager: Employee
{
    private int _bonus = 100;

    public int CaclulateSalary(int Hour)
    {
        return PayForHour * Hour + _bonus;
    }
}

class Developer: Employee
{

}