int [] array = {1,12,118,4,15,16,17,118};

int n = array.Length;
int find = 118;

int index = 0;

while (index<n)
{
if(array[index] == find)
{
    Console.WriteLine(index);
    break;
}
    index++;
}