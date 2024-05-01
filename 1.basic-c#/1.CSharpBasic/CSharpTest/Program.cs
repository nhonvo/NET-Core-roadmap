using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 5, 5, 5,6};
        int number = GetSecondLargestIndex(numbers);
        System.Console.WriteLine(number);
    }
    /// <summary>
    /// ```IndexOfSecondLargestElementInArray```
    /// tham số đầu vào hàm là mảng số nguyên X
    /// kết quả hàm sau khi thực thi là vị trí(index) của SỐ-LỚN-THỨ-2-TRONG-MẢNG
    /// trong trường hợp tồn tại 2 số có cùng giá trị lớn nhất thì trả về -1:
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int GetSecondLargestIndex(int[] arr)
    {
        //if array has 1 element or null return -1
        if (arr == null || arr.Length <= 1)
            return -1;

        int[] maxValues = arr.OrderByDescending(x => x).Distinct().Take(2).ToArray();
        
        // if arr has 2 greatest element return -1
        if (maxValues.Length < 2)
            return -1;

        // return the index
        return Array.IndexOf(arr, maxValues[1]);
    }
}