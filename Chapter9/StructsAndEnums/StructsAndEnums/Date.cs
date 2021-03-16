using System;

namespace StructsAndEnums
{
    class Date
    {
        private int year;
        private Month month;
        private int day;

        public Date(int ccyy, Month mm, int dd)
        {
            this.year = ccyy - 1900;
            this.month = mm;
            this.day = dd - 1;
        }
        public override string ToString()
        {
            string date = $"{this.month} {this.day + 1} {this.year + 1900}";
            return date;
        }
        public void addMonth()
        {
            if (this.month.Equals(Month.December))
            {
                this.month = Month.January;
                this.year++;
            }
            else
            {
                this.month++;
            }
            
        }

        public void AdvanceMonth()
        {
            this.month++;
            if (this.month == Month.December + 1)
            {
                this.month = Month.January;
                this.year++;
            }
        }
    }
}
