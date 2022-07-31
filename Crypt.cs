namespace bungocrypt
{
    public class Crypt
    {
        public static String Encrypt(String ToEncrypt, String CryptKey)
        {
            String EncryptedString = "";

            if (CryptKey.Length != Key.FullArray.Length)
            {
                EncryptedString = "KeyError [1]: Key was not 68 characters long!";
            } 
            
            // for every character that needs to be encrypted
            for (int i = 0; i < ToEncrypt.Length; i++)
            {
                // Compare to the string in fullarray
                for (int j = 0; j < Key.FullArray.Length; j++) {
                    if (ToEncrypt[i].ToString() == Key.FullArray[j])
                    {
                        // Testing to check the string to the parseable array Console.WriteLine($"ToEncrypt: {ToEncrypt[i].ToString()} compares to FullArray: {Key.FullArray[j]}");
                        EncryptedString += CryptKey[j];
                    }
                }
            }

            return EncryptedString;
        }

        public static String Decrypt(String ToDecrypt, String CryptKey)
        {
            String DecryptedString = "";

            if (CryptKey.Length != Key.FullArray.Length)
            {
                DecryptedString = "KeyError [1]: Key was not 68 characters long!";
            }

            for (int i = 0; i < ToDecrypt.Length; i++)
            {
                for (int x = 0; x < CryptKey.Length; x++)
                {
                    if (ToDecrypt[i].ToString() == CryptKey[x].ToString())
                    {
                        DecryptedString += Key.FullArray[x];
                    }
                }
            }

            return DecryptedString;
        }
    }
}