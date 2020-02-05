using System.Collections.Generic;
using System;
namespace Q
{

    public class Node
    {
        public Node(int data){
            Data = data;
        }

        public int Data;
        public Node next;

        
    }
    public class Q
    {
        public int count;
        public Node rear;

        public void MakeEmpty()
        {rear =  null;
        count = 0;



        }



        public void Enqueue(int n){
            if (rear == null){
                Node last = new Node(n);
                rear = last;
            }
            else{
               Node last = new Node(n);
               last.next = rear; 
                
            
            }
                count++;
        }
        public void Dequeue(){
           Node MyNode = GetSeondLast(rear);
           if(MyNode != null){
            MyNode.next = null;
            count--;
            if(rear == MyNode){
                rear=null;
                
                
            }
           else{
               MyNode.next = null;
               
           }
           }
           
        }

        private Node GetSeondLast(Node startspot){
            if (startspot == null){
                return null;
            }
            if (startspot.next==null){
                return startspot;
            }
            else if (startspot.next.next ==null){
                return startspot;
            }
            else {
                return GetSeondLast(startspot.next);
            }
        }
        
        public Node Front(Node startspot){
            if(startspot == null){
                return startspot;
            }
            if (startspot.next==null){
                return startspot;
            }
           
            else {
                return Front(startspot.next);
            }
        }

        public Node Rear(){
            return rear;
        }
        public int Peek(int input){
            int rearcount = count - input;
            return rearcount;
        }

        private int GetNodeFromRear(int n, Node start){
            if(n ==1){
                return start.Data;
            }
            else{
                return GetNodeFromRear(n-1, start.next);
            }
        }
        public bool IsFull(){
            
            try{
                Node full = new Node(1);
                return false;
            }
            catch{
                return true;
            }
        }

        public void printQ(){
            List<int> values =new List<int>();
            GetQValues(rear,values);

            string output = "Front{ ";
            for(int i = values.Count - 1;i > -1;i--){
                 output += values[i] + " ";
            }
            output += "} Rear";
            Console.WriteLine(output);

        }

        public void GetQValues(Node startspot, List<int> values){
            if(startspot == null){
                return;
            }
            values.Add(startspot.Data);
            if (startspot.next==null){
                return ;
            }
           
            else {
             GetQValues(startspot.next, values);
            }
        }
    }


}






