namespace bungocrypt
{
    class Crypt
    {
        public static String Encrypt(String ToEncrypt, String Key)
        {
            String EncryptedString = "";

            if (Key.Length != 68)
            {
                EncryptedString = "KeyError [1]: Key was not 68 characters long!";
            } 

            

            return EncryptedString;
        }
    }
}