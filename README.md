# "Ideal Code"
This repository contains my "Ideal Code" that efficiently solves a certain problem. _~Arthur Khazbulatov_

## The problem
Every few minutes a company is receiving application forms from their customers. An application form contains the information about the applicant (including their first name, middle name and last name), the main body text and a creation timestamp. The company wants you to design an application forms service. The service must allow to create application forms and add them to a repository. You must implement retrieval of all application forms and finding all application forms created on a specific date, preserving the chronological order and with respect to time efficiency.

## The solution
The main part of the solution is located in the file named `ChronologicalRepo.cs`. The data structure used is: a list that contains all application forms in the order of their creation, plus a dictionary of lists with creation date as the key and lists of application forms as the values:

```CSharp
class ChronologicalRepo<T> : IChronologicalRepo<T>
				   where T : ITemporal {

	IList<T> _items = new List<T>();
	Dictionary<DateTime, IList<T>> _dateIndex =
		new Dictionary<DateTime, IList<T>>();

	public void Add(T item) {
		_items.Add(item);
		if (!_dateIndex.ContainsKey(item.DateTime.Date)) {
			_dateIndex.Add(item.DateTime.Date, new List<T>());
		}
		_dateIndex[item.DateTime.Date].Add(item);
	}
	
	public IEnumerable<T> All => _items;
	
	public IEnumerable<T> FindAllByDate(DateTime date) {
		return _dateIndex.GetValueOrDefault(date.Date);
	}
}
```

## The efficiency
Retrieving applications in chronological order is made possible by storing them in lists, appending each in the order of their creation. Finding all application forms only takes O(1) thanks to the hashtable used in the dictionary to index the application forms by date.

## The everything else
If you are interested, other files might be worth a peek too! Look inside `Program.cs`, hit the **Run** button, wait for everything to compile and see this code in action!
