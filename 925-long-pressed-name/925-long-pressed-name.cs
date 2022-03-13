public class Solution {
    public bool IsLongPressedName(string name, string typed) {
            
           int j = 0;
            int i = 0;
            for (  i = 0; i < name.Length; i++)
            {

                if (i == name.Length - 1 || name[i] != name[i + 1])
                {
                    int tt = 0;
                    while (j <= typed.Length - 1 && name[i] == typed[j])
                    {
                        j++;
                        tt++;
                    }
                    if (tt == 0 )
                    {
                        return false;
                    }
                }
                else
                {
                    j++;

                }

            }

            if(j<=typed.Length - 1)
            {
                if (typed[j] != name[name.Length - 1])
                {
                    return false;
                }
            }
            return true;
    }
}