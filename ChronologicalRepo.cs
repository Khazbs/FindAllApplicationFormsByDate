using System.Collections.Generic;
using System;

class ChronologicalRepo<T> : IChronologicalRepo<T> where T : ITemporal {
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

class ChronologicalRepo : IChronologicalRepo {
	ChronologicalRepo<ITemporal> _repo = new ChronologicalRepo<ITemporal>();

	public void Add(ITemporal item) {
		_repo.Add(item);
	}
	
	public IEnumerable<ITemporal> All => (IEnumerable<ITemporal>) _repo.All;
	
	public IEnumerable<ITemporal> FindAllByDate(DateTime date) {
		return (IEnumerable<ITemporal>) _repo.FindAllByDate(date);
	}
}
