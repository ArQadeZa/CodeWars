package fundamentals;

public class VowelCount {
    /**
     * Return the number (count) of vowels in the given string.
     * We will consider a, e, i, o, u as vowels for this Kata (but not y).
     * The input string will only consist of lower case letters and/or spaces.
     */
    public static int getCount(String str) {
        char[] vowels = new char[]{'a', 'e', 'i', 'o', 'u'};
        int count = 0;

        for (char c : str.toCharArray()) {
            for (char d : vowels) {
                if (c == d)
                    count++;
            }
        }

        return count;
    }
}
