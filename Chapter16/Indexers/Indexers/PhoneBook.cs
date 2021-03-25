using System;

namespace Indexers
{
	sealed class PhoneBook
	{
        private int used;
        private Name[] names;
        private PhoneNumber[] phoneNumbers;

		public PhoneBook()
		{
			int initialSize = 0;
			this.used = 0;
			this.names = new Name[initialSize];
			this.phoneNumbers = new PhoneNumber[initialSize];
		}
		
		public void Add(Name name, PhoneNumber number)
		{
			enlargeIfFull();
			this.names[used] = name;
			this.phoneNumbers[used] = number;
			this.used++;
		}
		public Name this[PhoneNumber number]
        {
			get 
			{
				//if (names != null)
				//{
				//	return names[Array.IndexOf(phoneNumbers, number)];
				//}
				//return;
				int index = Array.IndexOf(this.phoneNumbers, number);
				if(index != -1)
                {
					return this.names[index];
                }
				else
                {
					return new Name();
                }
			}
        }
		public PhoneNumber  this[Name name]
		{
			get 
			{
				int index = Array.IndexOf(this.names, name);
				if(index != -1)
                {
					return this.phoneNumbers[index];
                }
				else
                {
					return new PhoneNumber();
                }
			}
		}
		
		private void enlargeIfFull()
		{
			if (this.used == this.names.Length)
			{
				int bigger = used + 16;
				
				Name[] moreNames = new Name[bigger];
				this.names.CopyTo(moreNames, 0);
				
				PhoneNumber[] morePhoneNumbers = new PhoneNumber[bigger];
				this.phoneNumbers.CopyTo(morePhoneNumbers, 0);
						
				this.names = moreNames;
				this.phoneNumbers = morePhoneNumbers;
			}
		}
	}
}