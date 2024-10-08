using System;

namespace __lab14
{
    internal class SearchMethods
    {
        public short SearchNumber(short[] lineArray, short target)
        {
            for (short i = 0; i < lineArray.Length; i++)
            {
                if (lineArray[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        public short BinarySearch(short[] array, short target, short low, short high)
        {
            while (low <= high)
            {
                short middle = (short)((low + high) / 2); // Вычисляем средний индекс

                if (array[middle] == target)
                {
                    return middle; // Элемент найден
                }
                else if (array[middle] < target)
                {
                    low = (short)(middle + 1); // Поиск в правой половине
                }
                else
                {
                    high = (short)(middle - 1); // Поиск в левой половине
                }
            }

            return -1; // Элемент не найден
        }
        public short[] BubbleSearch(short[] array)
        {
            // Создаем новый массив той же длины
            short[] sortedArray = new short[array.Length];
            Array.Copy(array, sortedArray, array.Length); // Копируем исходный массив в новый

            int n = sortedArray.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        // Меняем местами sortedArray[j] и sortedArray[j + 1]
                        short temp = sortedArray[j];
                        sortedArray[j] = sortedArray[j + 1];
                        sortedArray[j + 1] = temp;
                        swapped = true; // Отметим, что произошло изменение
                    }
                }

                // Если за проход не было произведено ни одной замены, массив отсортирован
                if (!swapped)
                    break;
            }

            return sortedArray; // Возвращаем отсортированный массив
        }
        public short[] InsertionSort(short[] array)
        {
            // Создаем новый массив той же длины
            short[] sortedArray = new short[array.Length];
            Array.Copy(array, sortedArray, array.Length); // Копируем исходный массив в новый

            int n = sortedArray.Length;

            for (int i = 1; i < n; i++)
            {
                short key = sortedArray[i];
                int j = i - 1;

                // Перемещаем элементы sortedArray[0..i-1], которые больше key,
                // на одну позицию вперед от их текущей позиции
                while (j >= 0 && sortedArray[j] > key)
                {
                    sortedArray[j + 1] = sortedArray[j];
                    j--;
                }
                sortedArray[j + 1] = key;
            }

            return sortedArray; // Возвращаем отсортированный массив
        }
        public short[] SelectionSort(short[] array)
        {
            // Создаем новый массив той же длины
            short[] sortedArray = new short[array.Length];
            Array.Copy(array, sortedArray, array.Length); // Копируем исходный массив в новый

            int n = sortedArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Находим индекс минимального элемента в неотсортированной части массива
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (sortedArray[j] < sortedArray[minIndex])
                    {
                        minIndex = j; // Обновляем индекс минимального элемента
                    }
                }

                // Меняем местами найденный минимальный элемент с первым элементом неотсортированной части
                short temp = sortedArray[minIndex];
                sortedArray[minIndex] = sortedArray[i];
                sortedArray[i] = temp;
            }

            return sortedArray; // Возвращаем отсортированный массив
        }
    }
}