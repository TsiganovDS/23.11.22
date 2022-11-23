Console.WriteLine("Введите число "); 
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(P(Number));        
Console.ReadKey(true);        

static bool P(int Number)      
{
    if (Number >= 0 && Number <10)        
    return true;
    int NumberLength = GetLength(Number);
    int[] digits = new int[NumberLength];
        for (int i = NumberLength - 1; i >= 0; i--) 
        {
            digits[i] = Number % 10;
            Number /= 10;
        }
             for (int i = 0; i < NumberLength/2; i++)
             {
                if (digits[i] != digits[NumberLength - i - 1])
                return false;
             }
            return true;            
}        
               
static int GetLength(int Number)        
{
    int N = 0;
    while (Number > 0)
    {
        Number /= 10;
        N++;
    }
    return N;
 }
