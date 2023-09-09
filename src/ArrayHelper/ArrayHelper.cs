namespace ArrayHelper;

public static class ArrayHelper
{
    public static int[] Add(int[] root, int element)
    {
        int newArrayLength = root.Length + 1;
        int newElementIdx = newArrayLength - 1; 

        int[] resultArray = new int[newArrayLength];
        root.CopyTo(resultArray, index: 0)
        resultArray[newElementIdx] = element;
        return resultArray;
    }

    public static int[] RemoveLast(int[] array)
    {
        if (array.Length == 0)
        {
            // If array is empty, we return an empty array
            return new int[0];
        }

        int newArrayLength = array.Length - 1;
        int[] resultArray = new int[newArrayLength];

        for (int i = 0; i < newArrayLength; i++)
        {
            resultArray[i] = array[i];
        }

        return resultArray;
    }

    public static int[] RemoveLastByIndex(int[] array, int index)
    {
        if (index < 0 && index >= array.length)
        {
            // If index is greater then array length, we return array
            return array;
        }

        int newArrayLength = array.Length - 1;
        int[] resultArray = new int[newArrayLength];

        int resultIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i == index)
            {
                continue; 
            }
            else
            {
                resultArray[resultIndex] = array[i];
                resultIndex++;
            }
        }

        return resultArray;
    }

    public static int GetByIndex(int[] array, int index)
    {
        if (index < 0 && index >= array.length)
        {
            // If index is greater then array length, we return array
            return 0;
        }

        return array[index];
    }

    public static int GetFirstElement(int[] array)
    {
        if (array.Length == 0)
        {
            throw new InvalidOperationException("Array is empty!");
        }

        return array[0];
    }

    public static int GetLastElement(int[] array)
    {
        if (array.Length == 0)
        {
            throw new InvalidOperationException("Array is empty!");
        }

        int lastElementIndex = array.Length - 1;

        return array[lastElementIndex];
    }

    public static int GetMiddleElement(int[] array)
    {
        if (array.Length == 0)
        {
            throw new InvalidOperationException("Array is empty!");
        }

        int middleIndex = array.Length / 2;

        if (array.Length % 2 == 0)
        {
            int middleElement1 = array[middleIndex - 1];
            int middleElement2 = array[middleIndex];
            return (middleElement1 + middleElement2)/2;
        }
        else 
        {
            return array[middleIndex];
        }
    }
}
