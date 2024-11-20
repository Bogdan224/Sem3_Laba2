using System.Collections;

namespace Sem3_Laba2
{

    public class MyString : ICloneable, IComparable, IComparable<MyString>, IEquatable<MyString>
    {
        //Fields
        public static readonly MyString Empty = "";
        private char[] _characters;

        //Properties
        public char this[int index]
        {
            get
            {
                if (index < 0 || index >= _characters.Length) throw new ArgumentOutOfRangeException();
                return _characters[index];
            }
        }
        public int Length
        {
            get
            {
                return _characters.Length;
            }
        }

        //Constructors
        public MyString(char characters)
        {
            if (characters == null)
                throw new ArgumentNullException();
            _characters = [characters];
        }
        public MyString(char[] characters)
        {
            if (characters == null)
                throw new ArgumentNullException();
            _characters = characters;
        }
        public MyString(string str)
        {
            _characters = str.ToCharArray();
        }
        public MyString(MyString str)
        {
            _characters = str.ToCharArray();
        }



        //Methods:
        public IEnumerator GetEnumerator() => _characters.GetEnumerator();

        public int IndexOf(char value)
        {
            int index = 0;
            foreach (var item in _characters)
            {
                if (item == value) return index;
                index++;
            }
            return -1;
        }

        public int IndexOf(MyString value)
        {
            if (value is null) throw new ArgumentNullException();
            if (value == Empty) return 0;
            if (value.Length > Length) return -1;
            if (Equals(value)) return 0;

            int beginIndex = 0;
            int currentIndex = 0;
            foreach (char item in _characters)
            {
                if (beginIndex + value.Length <= Length)
                {
                    foreach (char item1 in value)
                    {
                        if (_characters[beginIndex + currentIndex] == value[currentIndex])
                        {
                            currentIndex++;
                            if (currentIndex == value.Length)
                            {
                                return beginIndex;
                            }
                        }
                        else
                        {
                            beginIndex += currentIndex;
                            currentIndex = 0;
                            break;
                        }
                    }
                    beginIndex++;
                }
                else
                    break;
            }
            return -1;
        }

        public MyString Substring(int beginIndex, int length = -2121354)
        {
            if (length == -2121354)
                length = Length - beginIndex;
            if (beginIndex < 0 || beginIndex > Length) throw new ArgumentOutOfRangeException();
            if (beginIndex == Length) return new MyString(Empty);
            if (beginIndex + length > Length) throw new ArgumentOutOfRangeException();

            MyString result = "";
            for (int i = beginIndex; i < beginIndex + length; i++)
            {
                result += _characters.ElementAt(i);
            }
            return result;
        }

        public char[] ToCharArray()
        {
            return _characters;
        }
        public override string ToString()
        {
            return new string(_characters);
        }

        //Operators
        public static implicit operator MyString(string characters)
        {
            MyString strinf = "agfdh";
            if (characters == null)
                throw new ArgumentNullException();
            return new MyString(characters);
        }

        public static bool operator <(MyString left, MyString right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(MyString left, MyString right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(MyString left, MyString right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(MyString left, MyString right)
        {
            return left.CompareTo(right) >= 0;
        }

        public static MyString operator +(MyString left, MyString right)
        {
            char[] chars = new char[left.Length + right.Length];
            for (int i = 0; i < left.Length + right.Length; i++)
            {
                if (i < left.Length)
                    chars[i] = left._characters[i];
                else
                    chars[i] = right._characters[i - left.Length];
            }
            return new MyString(chars);
        }
        public static MyString operator +(MyString left, int right)
        {
            return new MyString(left.ToString() + right);
        }

        public static MyString operator -(MyString left, int right)
        {
            return left.Substring(0, left.Length - right);
        }

        public static MyString operator *(MyString left, char right)
        {
            char[] chars = new char[left.Length];
            for (int i = 0; i < left.Length; i++)
            {
                chars[i] = right;
            }
            return new MyString(chars);
        }

        //Interface's methods
        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(object? value)
        {
            if (value is null) throw new ArgumentNullException();
            return new string(_characters).CompareTo(value.ToString());
        }

        public int CompareTo(MyString? value)
        {
            if (value is null) throw new ArgumentNullException();
            return new string(_characters).CompareTo(value.ToString());
        }

        public bool Equals(MyString other)
        {
            if (other is null)
            {
                return false;
            }
            if (this.Length != other.Length)
            {
                return false;
            }
            for (int i = 0; i < Length; i++)
            {
                if (this[i] != other[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
