public class node{
    private int data;
    private node next;

    public void createNode (int data){
        this.data = data;
        this.next = null;
    }
    public void newNode(int data){
        this.data = data;
        this.next = null;
    }
    public int getData(){
        return data;
    }
    public int setData(int data){
        this.data = data;
    }
    public node getNext(){
        return next;
    }
    public void node setNext(int data, node next){
        this.data = data;
        this.next = next;
    }

}