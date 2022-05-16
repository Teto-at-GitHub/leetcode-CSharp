namespace Stack.Main.MinStack
{
   // All operations in this class are O(1) in time, 
   // thanks to the Stack capabilities.
   // That's why we add a second one for the minima
   public class MinStack
   {
      private Stack<int> _stack ;

      private Stack<int> _minStack;
      public MinStack()
      {
         _stack = new();
         _minStack = new();
      }

      public void Push(int val)
      {
         _stack.Push(val);
         val = _minStack.TryPeek(out int currentMin) ? Math.Min(val,currentMin) : val;
         _minStack.Push(val);
      }

      public void Pop()
      {
         _stack.Pop();
         _minStack.Pop();
      }

      public int Top()
      {
         return _stack.Peek();
      }

      public int GetMin()
      {
         return _minStack.Peek();
      }
   }

   /**
    * Your MinStack object will be instantiated and called as such:
    * MinStack obj = new MinStack();
    * obj.Push(val);
    * obj.Pop();
    * int param_3 = obj.Top();
    * int param_4 = obj.GetMin();
    */
}