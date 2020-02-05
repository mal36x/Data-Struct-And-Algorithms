using System;



namespace Q
{
     class lfsr
    {
        public lfsr(string seed, int tap1, int tap2){
            t1 = tap1;
            t2 = tap2;

            foreach(char line in seed){
                queue.Enqueue(Convert.ToInt32(line));
            }
        }

        public int t1, t2;

        Q queue;

        bool XOR(int a, int b)
        { return a ==1 ^ b==1;

           
        }

        public void NextState(){
            int temp = XOR(queue.Peek(t1), queue.Peek(t2))?1:0; //ternary if true do first part(1)...if false do second(0)
            queue.Dequeue();
            queue.Enqueue(temp);
        }

        public void print(){
            queue.printQ();
        }


    }

}