namespace Solution.BracketValidation{
    public class BracketValidator{
        private class Node{
            public char Data{get;set;}
            public Node Next {get;set;}
            public Node(char data) => Data = data;
        }
        private Node top;
        private void Push(char bracket){
            var newNode = new Node(bracket){Next=top};
            top = newNode;
        }
        private char? Pop(){
            if(top==null){return null;}
            var popped = top.Data;
            top = top.Next;
            return popped;
        }
        public bool ValidasiEkspresi(string ekspresi){
            foreach (var ch in ekspresi){
                if(ch == '(' || ch == '{' || ch == '['){Push(ch);}
                else if (ch == ')' || ch == '}' || ch == ']'){
                    var popped = Pop();
                    if(!popped.HasValue || (ch == ')' && popped != '(') || (ch == '}' && popped != '{') || (ch == ']' && popped != '[')) 
                        return false;
                }
            }
            return top == null;
        }
    }
}
