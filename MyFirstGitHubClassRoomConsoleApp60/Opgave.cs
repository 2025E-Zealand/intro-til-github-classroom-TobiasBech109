using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Opgave
{
	public string Navn { get; set; }
	public int Tid { get; set; }
	public string Beskrivelse { get; set; }

	public Opgave(string navn, int tid, string beskrivelse)
	{
		Navn = navn;
		Tid = tid;
		Beskrivelse = beskrivelse;
	}

	public Opgave()
	{
	}

	public override string ToString()
	{
		return $"Navn: {Navn}, Tid: {Tid}, Beskrivelse: {Beskrivelse}";
	}

}

