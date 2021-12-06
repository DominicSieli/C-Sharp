using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq
{
	public class Entry
	{
		public string tag {get; set;}
		public int data {get; set;}
	}

	public class Repository
	{
		public IEnumerable<Entry> Entries()
		{
			return new List<Entry>
			{
				new Entry() {tag = "Tag4", data = 4},
				new Entry() {tag = "Tag5", data = 5},
				new Entry() {tag = "Tag6", data = 6},
				new Entry() {tag = "Tag7", data = 7},
				new Entry() {tag = "Tag8", data = 8},
				new Entry() {tag = "Tag2", data = 2},
				new Entry() {tag = "Tag3", data = 3},
				new Entry() {tag = "Tag1", data = 1}
			};
		}
	}

	class Program
	{
		static void Main()
		{
			var entries = new Repository().Entries();
			var entry1 = entries.SingleOrDefault(e1 => e1.tag == "Tag1");
			var entriesLessThan5 = entries.Where(entry => entry.data < 5).OrderBy(entry => entry.data);

			foreach(var entry in entriesLessThan5)
			{
				Console.WriteLine("Tag: {0}, Data: {1}", entry.tag, entry.data);
			}

			Console.WriteLine("\nTag: {0}, Data: {1}", entry1?.tag, entry1?.data);
		}
	}
}