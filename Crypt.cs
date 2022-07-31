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
            
            for (int i = 0; i < ToEncrypt.Length; i++)
            {
                
            }

            return EncryptedString;
        }
    }
}