// 1. Що буде виведено в результаті роботи методу UpdatePersonName ?
// 2. Чому буде такий результат ?
// 3. Який результат буде виведено на консоль, якщо замінити class Person на struct Person
// 3. Що буде виведено в результаті роботи методу UpdatePerson ?
// 4. Чому буде такий результат ?

Person person1 = new Person() { 
    Id = 1,
    Name = "Peta", 
    Age = 20
};

UpdatePersonName(person1);
Console.WriteLine($"{person1.Id} - {person1.Name} - {person1.Age}");

//UpdatePerson(person1);
//Console.WriteLine($"{person1.Id} - {person1.Name} - {person1.Age}");

static void UpdatePersonName(Person person)
{
    person.Name = "Alex";
}

static void UpdatePerson(Person person)
{
    person = new Person() {
        Id = 2,
        Name = "vova", 
        Age = 30
    };
}

class Person
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Age { get; set; }
}