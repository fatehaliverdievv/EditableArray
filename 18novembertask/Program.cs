namespace _18novembertask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("size of array : ");
            int.TryParse(Console.ReadLine(), out int size);
            Console.WriteLine("input the elements of array : ");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            InsertArray(ref arr,3,32,3,4);
            Console.WriteLine("modified array : ");
            foreach (int i in arr) { Console.WriteLine(i);}
        }
        static void InsertArray(ref int[] arr, params int[] array)
        {
            int[] newArr = new int[arr.Length + array.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            int indeks = arr.Length;
            for (int i = 0; i <array.Length; i++)
            {
                newArr[indeks] = array[i];
                indeks++;
            }
            arr = newArr;
        }
    }
}