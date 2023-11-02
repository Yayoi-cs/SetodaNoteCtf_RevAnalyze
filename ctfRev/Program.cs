using System.Text;

public class ctrfRev {
    private static void Main() {
        byte[] numArray = new byte[15]
    {
      (byte) 65,
      (byte) 127,
      (byte) 89,
      (byte) 80,
      (byte) 182,
      (byte) 160,
      (byte) 183,
      (byte) 182,
      (byte) 89,
      (byte) 118,
      (byte) 119,
      (byte) 116,
      (byte) 177,
      (byte) 189,
      (byte) 177
    };
        for (int index = 0; index < numArray.Length; ++index) {
            numArray[index] ^= (byte)35;
            if (a(numArray[index], 119))
                numArray[index] += (byte)3;
            numArray[index] ^= (byte)21;
            numArray[index] -= (byte)32;
            numArray[index] = b(numArray[index], 39);
        }
        //Console.WriteLine(Encoding.ASCII.GetString(numArray));
        result(numArray);
    }

    private static void result(byte[] A_1) {
        Console.WriteLine("Yes, that's the right answer.");
        byte[] bytes = new byte[27]
        {
        (byte) 9,
        (byte) 37,
        (byte) 48,
        (byte) 34,
        (byte) 41,
        (byte) 61,
        (byte) 199,
        (byte) 49,
        (byte) 220,
        (byte) 63,
        (byte) 115,
        (byte) 59,
        (byte) 220,
        (byte) 200,
        (byte) 46,
        (byte) 115,
        (byte) 57,
        (byte) 220,
        (byte) 214,
        (byte) 50,
        (byte) 53,
        (byte) 46,
        (byte) 47,
        (byte) 37,
        (byte) 124,
        (byte) 62,
        (byte) 9
        };
        for (int index = 0; index < bytes.Length; ++index) {
            bytes[index] ^= A_1[12];
            bytes[index] ^= A_1[8];
            bytes[index] ^= A_1[3];
            bytes[index] ^= (byte)35;
            if (a(bytes[index], 113))
                bytes[index] += (byte)3;
            bytes[index] ^= (byte)21;
            bytes[index] -= (byte)32;
            bytes[index] = b(bytes[index], 114);
        }
        Console.WriteLine(Encoding.ASCII.GetString(bytes));
    }

    private static byte b(byte A_0, int A_1) {
        switch (A_1) {
            case 39:
                A_0 ^= (byte)19;
                break;
            case 114:
                A_0 ^= (byte)40;
                break;
        }
        return A_0;
    }
    private static bool a(byte A_0, int A_1) {
        if (A_1 == 119) {
            if (A_0 == (byte)107 || A_0 == (byte)117 || A_0 == (byte)108 || A_0 == (byte)102 || A_0 == (byte)98)
                return true;
        }
        else if (A_0 == (byte)110 || A_0 == (byte)119 || A_0 == (byte)99 || A_0 == (byte)111 || A_0 == (byte)97 || A_0 == (byte)101 || A_0 == (byte)112 || A_0 == (byte)103 || A_0 == (byte)108 || A_0 == (byte)107 || A_0 == (byte)112 || A_0 == (byte)113)
            return true;
        return false;
    }
}