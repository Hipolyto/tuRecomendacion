using System.ComponentModel;

namespace tuRecomendacion.Model
{
    public class Question : BaseModel, IConvertible
    {
        public string Id { get; set; }               // The question's unique identifier
        public string Text { get; set; }             // The question text
        public List<QuestionOption> Choices { get; set; }    // The possible choices for this question
                                                             // ... add more properties as needed ...

        QuestionOption _answer;
        public QuestionOption Answer
        {
            get => _answer;
            set => SetProperty(ref _answer, value);
        }

        public Question(string text, List<QuestionOption> options)
        {
            Text = text;
            Choices = options;
        }
        public Question()
        {
        }

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
    }

    public class QuestionOption : BaseModel
    {
        public string Text { get; set; }
        public int Value { get; set; }
        int _answersCount = 0;
        public int AnswerCount
        {
            get => _answersCount;
            set => SetProperty(ref _answersCount, value);
        }

        bool _isSelected = false;
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }

        public QuestionOption(string text, int value = 0)
        {
            Text = text;
            Value = value;
        }
    }

}

