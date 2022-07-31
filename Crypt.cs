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
                String _char = ToEncrypt[i].ToString();

                for (int x = 0; x < Key.FullArray.Length; x++)
                {
                    
                }

                // switch (_char)
                // {
                //     case "a":
                //         EncryptedString += CryptKey[0];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                //     case "b":
                //         EncryptedString += CryptKey[1];
                //         break;
                // }
            }

            return EncryptedString;
        }
    }
}