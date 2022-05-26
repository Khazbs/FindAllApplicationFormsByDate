using System.Collections.Generic;
using System;

interface IChronologicalRepo {
	IEnumerable<IFact> FindAllByDate(DateTime date);
	void Add(IFact fact);
}

interface IChronologicalRepo<T> : IChronologicalRepo where T : IFact {
	new IEnumerable<T> FindAllByDate(DateTime date);
	void Add(T fact);
}
