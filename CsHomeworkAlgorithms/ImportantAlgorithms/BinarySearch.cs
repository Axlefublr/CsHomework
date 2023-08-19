namespace ImportantAlgorithms;

public class BinarySearch {

   private static int Recursive(int value, int[] array, int left, int right) {
      int middle = (left + right) / 2;
      int midElement = array[middle];

      if (midElement == value) {
         return midElement;
      }

      if (left >= right) {
         return -1;
      }

      if (value > midElement) {
         return Recursive(value, array, middle + 1, right);
      } else {
         return Recursive(value, array, left, middle -1);
      }
   }

   private static int NonRecursive(int[] array, int value) {
      int left = 0;
      int right = array.Length;
      int middle;
      while (left <= right) {
         middle = (left + right) / 2;

         if (array[middle] == value) return middle;

         else if (array[middle] > value) {
            right = middle - 1;
         } else {
            left = middle + 1;
         }
      }
      return -1;
   }

}