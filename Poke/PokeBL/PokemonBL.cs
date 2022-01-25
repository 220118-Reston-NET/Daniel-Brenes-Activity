﻿using PokeDL;
using PokeModel;

namespace PokeBL
{
public class PokemonBL : IPokemonBL
{
    //Dependency Injection
    //======================
    //This is the main reason why we created interface first before the class
    //This will save you time on re-writing code that breaks if you updated a completely separate class
    //Main reason is to prevent us from re-writing code that already existed on (potentially) 50 files or more
    // without the compiler telling us

    private IRepository _repo;
    public PokemonBL(IRepository p_repo)
    {
        _repo = p_repo;

    }
    public Pokemon AddPokemon(Pokemon p_poke)
    {
        Random rand = new Random();

        //Processing data to meet conditions
        //It will either subtract or add a range from -5 to 5
        //p_poke.Attack += rand.Next(-5, 5); 


        p_poke.Attack = p_poke.Attack + rand.Next(-5, 5);
        p_poke.Defense += rand.Next(-5,5);
        p_poke.Health += rand.Next(-5,5);


        return _repo.AddPokemon(p_poke);
    }

}
}