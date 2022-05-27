using System.Collections.Generic;
using System;

interface IChronologicalRepo {
	void Add(ITemporal item);
	IEnumerable<ITemporal> All { get; }
	IEnumerable<ITemporal> FindAllByDate(DateTime date);
}

interface IChronologicalRepo<T> where T : ITemporal {
	void Add(T item);
	IEnumerable<T> All { get; }
	IEnumerable<T> FindAllByDate(DateTime date);
}
