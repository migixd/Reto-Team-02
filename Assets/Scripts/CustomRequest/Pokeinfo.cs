using System;
using System.Collections.Generic;
[Serializable]
public class Pokeinfo 
{
public int count=0;
public string next ="" ;
public string previous ="";
public List<PokemonInfo> results = new List<PokemonInfo>();
[Serializable]
public class PokemonInfo
{
    public string name="";
    public string url="";
}
}
