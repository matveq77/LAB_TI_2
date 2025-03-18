using System.Collections;

namespace TI_LAB_2;

public class CipherDecipher
{
    public BitArray ShiftRegister { get; private set; }
    public BitArray EncryptionKey { get; private set; }
    public BitArray InputData { get; set; }
    public BitArray EncryptedData { get; private set; }
    
    public void MakeShiftRegister(string parsingString)
    {
        ShiftRegister = new BitArray(parsingString.Length);
        for (int i = 0; i < parsingString.Length; i++)
            ShiftRegister[i] = parsingString[i] == '1';
    }

    public void MakeEncryptionKey(int length)
    {
        EncryptionKey = new(length);
        for (int i = 0; i < length; i++)
        {
            EncryptionKey[i] = ShiftRegister[0];
            
            int len = ShiftRegister.Length;
            bool nextValue = ShiftRegister[len - 30] ^ ShiftRegister[len - 16] ^ ShiftRegister[len - 15] ^ ShiftRegister[len - 1];

            for (int index = 0; index < ShiftRegister.Length - 1; index++)
            {
                ShiftRegister[index] = ShiftRegister[index + 1];
            }
            
            ShiftRegister[ShiftRegister.Length - 1] = nextValue;
        }
    }

    public void Cipher() => EncryptedData = EncryptionKey.Xor(InputData);
}
