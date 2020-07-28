using System.Collections;
using System.Collections.Generic;

namespace myProgramTips 
{

    public class ProgramingTips {

        public Dictionary<string,int> dic = new Dictionary<string,int>();
        public bool ifExists = false; 
        string testData = "Test";
        ifExists =  dic.ContainsKey(testData);
        int count = dic.Count;
        dic.Add(testData,5);
        bool ifRemoved = dic.Remove(testData);
        dic[testData] = 1;
        dic.Clear();

        int max = 100;
        foreach(KeyValuePair<int,int> p in dic) {
            if(p.Value == max) {
                Console.WriteLine(p.Key);
            }
        }

        Dictionary<int,int> count = new Dictionary<int,int>();
        // sorting Dictionary by value
        var tempoutput = (from num in count
                    orderby num.Value descending
                    select num.Key).ToList().Take(k);
        
        // this will return top k keys order by their value 
        Dictionary<string,int> map = new Dictionary<string,int>();        
        List<string> candidates = new List<string>(map.Keys);
        candidates.Sort( (w1,w2) => map[w1] == map[w2] ? w1.CompareTo(w2) : map[w2] - map[w1] );
        candidates.GetRange(0, k);
        
        
        Stack<string> stackNum = new Stack<string>();
        numbers.Push("one");
        string s = numbers.Peek();
        string pop = numbers.Pop();

        List<string> dinosaurs = new List<string>();
        dinosaurs.IndexOf("Tyrannosaurus");

        HashSet<int> map = new HashSet<int>();
        map.Contains(5)

        char[] str = new char[10];
        string input =  new String(str);
        char[] input = input.ToCharArray();
        input.Substring(1,4); // 4 is length
        input.Split( new char[] {' '});

        String.Join (separator, value, startIndex, count);


        var inputString = new string(input.OrderBy(c => c).ToArray());

        char ch = 'A';
        Char.ToLower(ch)    // a

        Console.WriteLine(Char.IsLetter('8'));					// False
        Console.WriteLine(Char.IsLetter(ch));					// true
        Console.WriteLine(Char.IsLetter("sample string", 7));	// True

        int i = 40;
        String.IsNullOrEmpty(input);
        int[] intArray = Enumerable.Repeat(100, 5).ToArray();

        int[] output = {1, 2, 3};
        Array.Fill(output,0);
        Array.Sort(nums);
        Array.Sort(nums, (i,j) => nums[i].CompareTo(nums[j]) );
        Array.Sort(input, (i,j) => nums[i].CompareTo(nums[j]) );
        
        int min = int.MaxValue;
        int max = int.MinValue;

        int i = 12345;
        char[] char = i.ToString().ToCharArray();

        char c = '5'
        int i = c -'49' ; // 4 
       
        //List
        List<int> parts = new List<int>();
        parts.Add(1234);

        IList<int> output = new List<int>();
        foreach( int a in tempoutput) {
            output.Add(a);
        }

        int level = 0;
        IList<IList<int>> output = new List<IList<int>>();
        output.Add(new List<int>());
        output[level].Add(20);
        output.Count

        int caseSwitch = 1;
        
        switch (caseSwitch)
        {
            case 1:
                Console.WriteLine("Case 1");
                break;
            case 2:
                Console.WriteLine("Case 2");
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }

        public ListNode ReverseList(ListNode head) {    
            ListNode current = head;
            ListNode prev = null;
            ListNode next = null;
            
            while(current!= null) {
                
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;            
            }
            
            return prev;
        }


    // 2D array
    int[,] codes = new int[,]
    {
        {200, 400},
        {2000, 4176},
        {20000, 40000}
    };

        // Get all bounds before looping.
        int bound0 = codes.GetUpperBound(0); // row 
        int bound1 = codes.GetUpperBound(1); // column

         int[][] costs;
         Array.Sort(costs, (x,y) => ( (x[0] - x[1]).CompareTo(y[0] - y[1])  ));
         foreach(int[] a in costs) {
            Console.WriteLine(String.Join(" ", a));
        }
    } 
}
