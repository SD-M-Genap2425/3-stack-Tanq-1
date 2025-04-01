namespace Solution.BrowserHistory{
    public class Halaman{
        public string URL{get;set;}
        public Halaman(string url) => URL = url;
    }
    public class HistoryManager{
        private class Node{
            public Halaman Data{get;set;}
            public Node Next {get;set;}
            public Node(Halaman data){Data=data;Next=null;}
        }
        private Node top;
        public HistoryManager() => top = null;
        public void KunjungiHalaman(string url){
            var newPage = new Halaman(url);
            var newNode = new Node(newPage);
            newNode.Next = top;
            top = newNode;
        }
        public string Kembali(){
            if (top == null || top.Next == null) return "Tidak ada halaman sebelumnya.";
            top = top.Next;
            return top.Data.URL;
        }
        public string LihatHalamanSaatIni() => top == null ? null : top.Data.URL;
        public void TampilkanHistory(){
            var historyList = new System.Collections.Generic.List<string>();
            var current = top;
            while (current != null){
                historyList.Add(current.Data.URL);
                current = current.Next;
            }
            historyList.Reverse();
            foreach (var url in historyList) System.Console.WriteLine(url);
        }
    }
}
