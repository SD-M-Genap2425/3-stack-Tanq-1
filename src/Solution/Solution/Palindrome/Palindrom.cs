namespace Solution.Palindrome{
    public static class PalindromeChecker{
        public static bool CekPalindrom(string input){
            var nI = new string(input.Where(c => Char.IsLetter(c)).Select(c => Char.ToLower(c)).ToArray());
            var stack = new Stack<char>();
            foreach (var ch in nI) stack.Push(ch);
            foreach (var ch in nI) if (stack.Pop() != ch) return false;
            return true;
        }
    }
}
