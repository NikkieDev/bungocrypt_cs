namespace bungocrypt
{
    public class Key
    {
        private static String[] AlphabetUpper = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        private static List<String> LowerList = new List<String>();
        private static String[] Numbers = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
        private static String[] Symbols = {@"!", @"@", @"#", @"$", @"%", @"^", @"&", @"*", @"(", @")", @"-", @"_", @"+", @"=", @"~", @"`", @";", @":", "\"", @"'", @"{", @"}", @"[", @"]", @"|", @"\", @"<", @">", @",", @".", @"/", @"?", @" "};
        private static List<String> FullList = new List<String>();
        protected internal static String[]? FullArray;
        protected internal static void Initialize()
        {
            for (int i = 0; i < AlphabetUpper.Length; i++)
            {
                List<String> LowerList = new List<String>();
                LowerList.Add(AlphabetUpper[i].ToLower());
            }

            String[] AlphabetLower = LowerList.ToArray<String>();

            foreach (String AlHigh in AlphabetUpper)
            {
                FullList.Add(AlHigh);
            }
            
            foreach (String AlLow in AlphabetLower)
            {
                FullList.Add(AlLow);
            }

            foreach (String symbol in Symbols)
            {
                FullList.Add(symbol);
            }

            foreach (String number in Numbers)
            {
                FullList.Add(number);
            }
            FullArray = FullList.ToArray<String>();
        }

        public static String CreateKey()
        {
            Initialize();
            List<String> Key = new List<String>();
            Random rd = new Random();
            String? ToAdd;

            for (int i = 0; i < FullArray.Length; i++)
            {
                ToAdd = FullList[rd.Next(0, FullList.Count())];
                Key.Add(ToAdd);
                FullList.Remove(ToAdd);
            }

            String[] KeyArray = Key.ToArray();
            String KeyString = "";

            foreach (var _char in KeyArray)
            {
                KeyString += _char;
            }
            
            return KeyString;
        }
    }
}