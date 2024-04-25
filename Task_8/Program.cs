// Чи правильно в данному прикладі проходить обробка помилок.
// Що таке стек трейс 
// Що таке блок finaly та коли він вкористовуєтся

int x = 10;
//int indexer = 1;
int indexer = 3;
int[] array = new int[3] { 1, 0, 3 };

try
{
    int res = x / array[indexer];
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}
