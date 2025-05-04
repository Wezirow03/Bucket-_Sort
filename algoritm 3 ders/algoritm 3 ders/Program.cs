using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm_3_ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Stack
    {
        private char[] _a;
        private int size;
        private int last;

        public bool add(char x)
        {
            if (isFully())
            {
                /*  _a[last] = x; 
                  last = last + 1;*/
                _a[++last] = x;
                return true;
            }
        return false;
        }
        public char delete()
        {
            if (!isEmpty())
            {
                return _a[last--];
            }
            return '!';
        }
        public Stack(int size)

        {
            last = -1;
            size = size;
            _a = new char[size];
        }
        public bool isEmpty()
        {
            return last == -1;
        }
        public bool isFully() {  return last == size-1; }
        public bool Parse(string s)
        {
            Stack stack = new Stack(100);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{')
                {
                    stack.add(s[i]);
                    if (s[i] == ')')
                    {
                        if (stack.delete() != '(')  return false; 
                        if (s[i] == '}')
                        {
                            if (stack.delete() != '{')  return false; 
                        }
                        return isEmpty();
                    }
                }
            }
        } 
    }
}
