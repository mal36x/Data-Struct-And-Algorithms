using System;



namespace Q
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Malcolm\testprojects\p02input1.txt");
            Console.WriteLine("############################################################################");
            Q queue = null;
            lfsr lfsr = null;
            foreach (string line in lines)
            {
                string[] sep = line.Split(" ");

                switch (sep[0])
                {
                    case "#":
                        Console.WriteLine(line);
                        break;

                    case "~":
                        Console.WriteLine("############################################################################");
                        break;

                    case "c":
                        if (sep[1] == "Q")
                        {
                            Console.WriteLine("Queue.Queue() -- Status = Complete");

                            queue = new Q();
                        }
                        else if (sep[1] == "L")
                        {
                            Console.WriteLine("LFSR::LFSR" + " " + "--Status = ");


                        }
                        break;
                    case "+":
                        if (queue != null)
                        {
                            queue.Enqueue(Convert.ToInt32(sep[1]));

                        }
                        break;
                    case "-":
                        if (queue != null)
                        {
                            queue.Dequeue();

                        }
                        break;
                    case "f":

                        if (queue != null)
                        {

                            Node front = queue.Front(queue.rear);
                            if (front == null)
                            {
                                Console.WriteLine("Queue.Front() -- Status = Failed");
                            }
                            else
                            {
                                Console.WriteLine("Queue.Front() -- Status = Completed Value =" + front.Data);
                            }
                        }
                        break;
                    case "r":

                        if (queue != null)
                        {

                            Node rear = queue.Rear();
                            if (rear == null)
                            {
                                Console.WriteLine("Queue.Front() -- Status = Failed");
                            }
                            else
                            {
                                Console.WriteLine("Queue.Front() -- Status = Completed Value =" + rear.Data);
                            }
                        }
                        break;
                    case "e":

                        if (queue != null)
                        {
                            Console.WriteLine("Queue.IsEmpty() ---Status = " + (queue.IsFull() ? "NotEmpty" : "Empty"));

                        }
                        else
                        {
                            Console.WriteLine("LFSR.IsEmpty() --- Status = Failed");
                        }

                        break;
                    case "m":

                        if (queue != null)
                        {
                            queue.MakeEmpty();

                            Console.WriteLine("Queue.MakeEmpty() --- Status = Complete");

                        }
                        else
                        {
                            Console.WriteLine("LFSR.MakeEmpty() --- Status = Failed");
                        }

                        break;
                    case "l":

                        if (queue != null)
                        {
                            Console.WriteLine("Queue.Size() --- Status = " + (queue.count));

                        }

                        break;
                    case "n":

                        if (lfsr != null)
                        {
                            try
                            {
                                lfsr.NextState();
                                   Console.WriteLine("LFSR.NextState ---  Complete"); 

                            }
                            catch{
                                 Console.WriteLine("LFSR.NextState ---  Failed");
                            }
                           

                            }
               

                            break;
                        case "?":

                        if (queue != null)
                        {
                        
                            int peek =queue.Peek(Convert.ToInt32(sep[1]));

                            if(peek>-1){
                            Console.WriteLine("Queue.peek("+ sep[1] + ") ---" +peek);


                            }
                            else
                        {
                            Console.WriteLine("Queue.peek(" +sep[1] + ")--" + "Failed");
                        }

                        }
                        
                            break;
                            case "p":

                        if (queue != null)
                        {
                            Console.WriteLine("Queue.PrintQ()");
                            queue.printQ();
                        }
                        else
                        {
                            Console.WriteLine("LFSR.PrintQ()");
                            lfsr.print();
                        }

                        break;

                        case "d":
                         queue = null;
                         lfsr = null;

                         break;
                        }

                }
            }
        }
    }
