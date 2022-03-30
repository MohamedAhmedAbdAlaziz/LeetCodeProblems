  public class MapSum
    {
        Dictionary<string, int> dic;
        public MapSum()
        {
            dic = new Dictionary<string, int>();
        }

        public void Insert(string key, int val)
        {
            dic[key] = val;
        }

        public int Sum(string prefix)
        {
            int t = 0;
            foreach (var item in dic)
            {
                  if (prefix.Length > item.Key.Length)
                    continue;
                string s = item.Key.Substring(0, prefix.Length);
                if (s==prefix)
                {
                    t += item.Value;
                }
            }
            return t;
        }
    }

/**
 * Your MapSum object will be instantiated and called as such:
 * MapSum obj = new MapSum();
 * obj.Insert(key,val);
 * int param_2 = obj.Sum(prefix);
 */