public class ListasEnlazadas {
    private node head;
    private node tail;
    private String name;

    public createList (string listname){
        name = listname;
        head = tail = null;
    }

    public bool isListEmpty(){
        if(head==null){
            return true
        }
        return false;
    }

    public void insertHeadNode(int data){
        node newHead = new node();
        
        if(isListEmpty){
            newHead.setData(data)
            head = tail = newHead;
        }
        else{
            newHead.setData(data);
            newHead.setNext(head);
            head = newHead;
        }
    }

    public voide insertTailNode(int data){
        if(isListEmpty){
            head = tail = new node(data);
        }
        else{
            node n = new node (data);
            tail.next = n;
            tail = n;
        }
    }

    public int deleteHead{
        if(isListEmpty){
            throw new emptyListException(name);
        }
        int deletedNode = head.getData;
        if (head == tail){
            head = tail = null;
        }
        else{
            head = head.getNext;
        }
        return deletedNode;

    }
    public void Print(){
        if(isListEmpty){
            Console.WriteLine("La lista vacía")
        }
    }
}