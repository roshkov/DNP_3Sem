namespace _9summarizedtext
{
    class StringUtility
    {
         public static string summarizeText(string s){
            if (s.Length>20){
                var snew = s.Substring(0,20);
                snew=snew+"...";
                return snew;
            }
            else return s;

        }
    
    }
}