package fundamentals;

import java.util.Arrays;

public class SimpleMathTest {
    /**
     * Create a function which checks a number for three different properties.
     * <p>
     * is the number prime?
     * is the number even?
     * is the number a multiple of 10?
     * Each should return either true or false, which should be given as an array. Remark: The Haskell variant uses data Property.
     * <p>
     * Examples
     * SimpleMath.numberProperty(7)  => new boolean[] {true, false, false}
     * SimpleMath.numberProperty(10) => new boolean[] {false, true, true}
     * The number will always be an integer, either positive or negative. Note that negative numbers cannot be primes, but they can be multiples of 10
     **/

    public static boolean[] numberProperty(int n) {
        boolean[] numberPropertyRelations = new boolean[3];

        if (n < 0) {
            isEvenOrDivisableBy10(n, numberPropertyRelations);
        } else {
            //checks if range between 2 and n-1 are divisible or not
            if (!(n <= 1)) {
                int count =0;
                for (int i = 2; i <= Math.sqrt(n); i++) {
                    if (n % i == 0) {
                        count++;
                    }
                }
                if(count ==0){
                    numberPropertyRelations[0]= true;
                }
            }


            isEvenOrDivisableBy10(n, numberPropertyRelations);
        }

        return numberPropertyRelations;
    }

    private static void isEvenOrDivisableBy10(int n, boolean[] numberPropertyRelations) {
        if (n % 2 == 0) {
            numberPropertyRelations[1] = true;
        }
        if (n % 10 == 0) {
            numberPropertyRelations[2] = true;
        }
    }

}
