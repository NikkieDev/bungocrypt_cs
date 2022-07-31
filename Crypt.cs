namespace bungocrypt
{
    public class Crypt
    {
        public static String Encrypt(String ToEncrypt, String Key)
        {
            String EncryptedString = "";

            if (Key.Length != 68)
            {
                EncryptedString = "KeyError [1]: Key was not 68 characters long!";
            } 

            for (int i = 0; i < ToEncrypt.Length; i++)
            {
                String _char = ToEncrypt[i].ToString();

                // New Approach
                for (var x = 0; x < Key.Length; x++)
                {
                    
                }

                // Original Approach
                // switch (_char)
                // {
                //     case "a":
                //         EncryptedString += Key[0];
                //         break;
                //     case "b":
                //         EncryptedString += Key[1];
                //         break;
                // }
            }

            return EncryptedString;
        }
    }
}